using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

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
            try
            {
                var files = Directory.GetFiles(Application.StartupPath + @"\Assemblies", "*.dll");
                foreach (var filepath in files)
                {
                    try
                    {
                        var info = FileVersionInfo.GetVersionInfo(filepath);
                        if (info.OriginalFilename != null)
                        {
                            Grid_Assembly.Rows.Add(false, info.ProductName, info.FileVersion, info.CompanyName,
                                info.FileName);
                        }
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }
            catch
            {
                // ignored
            }
            
            Grid_Assembly.Columns[4].Visible = false;
        }

        private void Injection_Timer_Tick(object sender, EventArgs e)
        {
            var p = Process.GetProcessesByName("warrock");
            GC.Collect();
            if (p.Length == 0) return;
            Injection_Timer.Enabled = false;
            WindowState = FormWindowState.Minimized;
            ManagedInject.ProcessName = "warrock";
            Grid_Assembly.EndEdit();
            foreach (DataGridViewRow row in Grid_Assembly.Rows)
            {
                if (Convert.ToBoolean(row.Cells["column_Checked"].Value))
                {
                    ManagedInject.InjectCLR(row.Cells[4].Value.ToString());
                }
            }
            Application.Exit();
        }
    }
}