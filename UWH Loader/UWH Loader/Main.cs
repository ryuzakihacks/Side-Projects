using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;
using InjectionLibrary;
using JLibrary.PortableExecutable;
using System.Diagnostics;

namespace UWH_Loader
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            LoadGridView();
            LoadSettings();
            //Browser.Navigate("http://adf.ly/vgzP6");
     
        }


        private void LoadSettings()
        {
            Functions Function = new Functions(this);
            Function.Load_Config("KNUCKLES", 0);
            Function.Load_Config("COLT", 1);
            Function.Load_Config("MP5",2);
            Function.Load_Config("K2",3);
            Function.Load_Config("SNIPER",4);
            Function.Load_Config("HEAVY",5);
            Function.Load_Config("MEDICKIT",6);
            Function.Load_Config("SPANNER",7);
            Function.Load_Config("GRENADE",8);
            Function.Load_Config("TMA_1A",9);
        }

        private void LoadGridView()
        {
            Grid_Weapons.Rows.Add("KNUCKLES");
            Grid_Weapons.Rows.Add("COLT");
            Grid_Weapons.Rows.Add("MP5");
            Grid_Weapons.Rows.Add("K2");
            Grid_Weapons.Rows.Add("SNIPER");
            Grid_Weapons.Rows.Add("HEAVY");
            Grid_Weapons.Rows.Add("MEDICKIT");
            Grid_Weapons.Rows.Add("SPANNER");
            Grid_Weapons.Rows.Add("GRENADE");
            Grid_Weapons.Rows.Add("TMA_1A");
            Grid_Weapons.Columns[0].ReadOnly = true;
        }

        
        private void btn_LoadSettings_Click(object sender, EventArgs e)
        {
            Functions Function = new Functions(this);
            File.WriteAllText(Path.GetTempPath() + "\\Config.ini", Function.WriteSettings());
            if (File.Exists(Path.GetTempPath() + "\\Config.ini"))
            { MetroMessageBox.Show(this, "The Config File has been successfully saved!", "Loaded!"); }
            else { MetroMessageBox.Show(this, "Error on saving the file!", "Error"); }
        }

        private void Tile_FBPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/geopulse.softwares");
        }

        private void Timer_Injection_Tick(object sender, EventArgs e)
        {
            var StandardInjector = InjectionMethod.Create(InjectionMethodType.Standard);
            Process[] TargetProcess = Process.GetProcessesByName("warrock");
            if (TargetProcess.Length != 0)
            {
                if (VARIABLES.isInjected) return;
                var processId = Process.GetProcessesByName("warrock")[0].Id;
                var hModule = IntPtr.Zero;
                var img = new PortableExecutable(Properties.Resources.Empty);
                    hModule = StandardInjector.Inject(img, processId);
                    lbl_Status.Text = "Status: Injecting...";
                    VARIABLES.isInjected = true;
                
                if(hModule != IntPtr.Zero)
                {
                    MetroMessageBox.Show(this, "The hack has been Injected Successfully", "Injected");
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "Something went wrong, can't inject the hack", "Error");
                    this.Close();
                }
            }
        }


        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (Browser.Url.ToString() != "http://adf.ly/vgzP6")
            {
                Browser.Visible = false;
                lbl_Status.ForeColor = Color.Green;
                lbl_Status.BackColor = Color.Green;
                lbl_Status.Text = "Status: Waiting for Warrock";
                Timer_Injection.Start();
            }
        }

        private void Tile_Credits_Click(object sender, EventArgs e)
        {
            string Fuck;
            Fuck = "Special Thanks To:" + Environment.NewLine;
            Fuck += "@V3n0x" + Environment.NewLine;
            Fuck += "@MJCreado" + Environment.NewLine;
            Fuck += "@[W]eb[C]ombat" + Environment.NewLine;
            Fuck += "@viperneo" + Environment.NewLine;
            Fuck += "@Jason" + Environment.NewLine;
            MetroMessageBox.Show(this, Fuck, "Credits");
        }

        private void Tile_Weaponcodes_Click(object sender, EventArgs e)
        {
            Process.Start("http://adf.ly/vgeiW");
        }
    }
}
