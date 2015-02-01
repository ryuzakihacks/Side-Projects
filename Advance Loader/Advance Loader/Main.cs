using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
using System.Management;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Advance_Loader
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
     
        public Main()
        {
            InitializeComponent();
        }

        string serverstring = "Server=localhost;User Id=root;Password=123456789qwer;Database=geopulse_loader";
        string version = "1.0";
        string process = "warrock";
        MySqlConnection sqlconnection = new MySqlConnection();


        #region FUNCTIONS
        private bool check(string query)
        {
            //Variables

            MySqlCommand cmd = sqlconnection.CreateCommand();
            cmd.CommandText = query;
            cmd.Connection = sqlconnection;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
                reader.Close();
            return false;
        }

        private bool checkcurrentversion()
        {
            string query = "SELECT * FROM latest";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable TABLE = new DataTable();

            cmd.CommandText = query;
            cmd.Connection = sqlconnection;

            adapter.SelectCommand = cmd;
            adapter.Fill(TABLE);
            if (Convert.ToDouble(TABLE.Rows[0]["latestversion"]) > Convert.ToDouble(version))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getstatus()
        {
            string query = "SELECT * FROM info WHERE LOADER_VERSION="+version+"";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = sqlconnection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return reader["STATUS"].ToString();
            }
            return "error";
        }

        private void insert(string query)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlconnection;
            cmd.ExecuteNonQuery();
        }

        private string getHWID()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        public static string GetCompCode()  // Get Computer Name
        {
            string strHostName = "";
            strHostName = Dns.GetHostName();
            return strHostName;
        }

        public static string GetIpAddress()  // Get IP Address
        {
            string ip = "";
            IPHostEntry ipEntry = Dns.GetHostEntry(GetCompCode());
            IPAddress[] addr = ipEntry.AddressList;
            ip = addr[2].ToString();
            return ip;
        }


        #endregion

        #region Injection Code
        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32", EntryPoint = "LoadLibraryA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int LoadLibrary(string lpLibFileName);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int WriteProcessMemory(System.IntPtr hProcess, int lpBaseAddress, string lpBuffer, int nSize, int lpNumberOfBytesWritten);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int VirtualAllocEx(System.IntPtr hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetProcAddress(int hModule, string lpProcName);

        [DllImport("kernel32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int CreateRemoteThread(System.IntPtr hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, int lpThreadId);

        [DllImport("Kernel32", EntryPoint = "GetModuleHandleA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32", EntryPoint = "CloseHandle")]
        private static extern int CloseHandle(System.IntPtr hObject);

        [DllImport("user32", EntryPoint = "FindWindowA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        void Inject()
        {
            System.IntPtr TargetProcessHandle;
            int TargetBufferSize;
            String pszLibFileRemote;
            int pfnStartAddr;
            Process[] TargetProcess = Process.GetProcessesByName(process);
            TargetProcessHandle = OpenProcess(0x1F0FFF, false, TargetProcess[0].Id);
            //pszLibFileRemote = Application.StartupPath + ("C:\\Users\\admin\\Documents\\Visual Studio 2013\\Projects\\Geopulse Warrock\\Release\\Geopulse Warrock.dll");
            pszLibFileRemote = ("C:\\Users\\admin\\Documents\\Visual Studio 2013\\Projects\\Geopulse Warrock\\Release\\Geopulse Warrock.dll");
            pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32.dll"), "LoadLibraryA");
            TargetBufferSize = 1 + pszLibFileRemote.Length;
            int Rtn;
            int LoadLibParamAdr;
            LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, 4096, 4);
            Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0);
            CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0);
            CloseHandle(TargetProcessHandle);
        } 



        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            Cursor = Cursors.WaitCursor;
            lblloaderstatus.Text = "Retrieving data.....";
            retrievingdata.Start();
            
        }



        

    

        private void btnSUBMIT_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text;
                string checkquerycode = "SELECT * FROM users WHERE CODE='" + code + "'";
                string checkquerycode2 = "SELECT * FROM users WHERE CODE='" + code + "' AND NAME='' AND HWID='' AND IP=''";

                if (check(checkquerycode))
                {
                    if (check(checkquerycode2))
                    {
                        //string userinfo = "INSERT INTO users(NAME,HWID,IP,DATE) VALUES('TEST','TEST','TEST','TEST') WHERE CODE='" + code + "'";
                        string userinfo = "UPDATE users SET NAME='TEST',HWID='"+getHWID()+"',IP='"+GetIpAddress()+"',DATE='"+DateTime.Now+"' WHERE CODE='" + code + "'";
                        insert(userinfo);
                        injection.Start();

                    }
                    else
                    {
                        MessageBox.Show("The key has already been taken");
                    }
                }
                else
                {
                    MessageBox.Show("The Key has does not exists or has been deleted");
                }
            }
            catch
            {
                MessageBox.Show("FAILED SOMEHOW");
            }
        }

        private void injection_Tick(object sender, EventArgs e)
        {
            //string process = "d3d9";
            //string dllname = "C:\\Users\\admin\\Documents\\Visual Studio 2013\\Projects\\Geopulse Warrock\\Release\\Geopulse Warrock.dll";
            Process[] TargetProcess = Process.GetProcessesByName(process);
            if (TargetProcess.Length != 0)
            {
                
                Inject();
                Application.Exit();
            }
            else
            {
                lblloaderstatus.Text = "WAITING FOR WARROCK";
            }
            
                
            
        }

        private void retrievingdata_Tick(object sender, EventArgs e)
        {
            retrievingdata.Stop();
            sqlconnection.ConnectionString = serverstring;
            try
            {
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    Cursor = Cursors.WaitCursor;
                    sqlconnection.Open();
                    string ifregistered = "SELECT * FROM users WHERE HWID='" + getHWID() + "' AND IP='" + GetIpAddress() + "'";
                    if (checkcurrentversion())
                    {
                        if (check(ifregistered))
                        {
                            injection.Start();
                            MessageBox.Show("You are already registered, please open warrock");
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            btnSUBMIT.Enabled = false;
                        }
                        else
                        {
                            lblloaderstatus.Text = "WAITING FOR KEY";
                        }
                        lblstatus.Text = getstatus();
                        lblversion.Text = version;
                    }
                    else
                    {
                        MessageBox.Show("A new update is available, please download the latest version");
                    }
                }
                Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("FAILED TO CONNECT TO THE SERVER");
                Application.Exit();
            }
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/pages/Geopulse-Softwares/727296887299605?ref=hl");
        }

       

        
    }
}
