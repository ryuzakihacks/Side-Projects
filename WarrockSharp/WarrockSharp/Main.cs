using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace WarrockSharp
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string[] Files = Directory.GetFiles(Application.StartupPath + @"\Assemblies", "*.dll");
            foreach (string filepath in Files)
            {
                try
                {
                    var info = FileVersionInfo.GetVersionInfo(filepath);
                    if(info.OriginalFilename != null)
                    { Grid_Assembly.Rows.Add(false, info.ProductName, info.FileVersion, info.CompanyName, info.FileName); }
                    
                }
                catch
                {

                }
            }
            Grid_Assembly.Columns[4].Visible = false;
        }

        private void Injection_Timer_Tick(object sender, EventArgs e)
        {
            Process[] P = Process.GetProcessesByName("warrock");
            GC.Collect();
            if (P.Length == 0) return;
            Injection_Timer.Enabled = false;
            WindowState = FormWindowState.Minimized;
            ManagedInject.ProcessName = "warrock";
            Grid_Assembly.EndEdit();
            foreach(DataGridViewRow row in Grid_Assembly.Rows)
            {
                if (Convert.ToBoolean(row.Cells["column_Checked"].Value) == true)
                {
                    ManagedInject.InjectCLR(row.Cells[4].Value.ToString());
                }
            }
            Application.Exit();
        } 

    }
}
