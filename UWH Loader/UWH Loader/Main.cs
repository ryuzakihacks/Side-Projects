using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using InjectionLibrary;
using JLibrary.PortableExecutable;
using MetroFramework;
using MetroFramework.Forms;
using UWH_Loader.Properties;

namespace UWH_Loader
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            LoadGridView();
            LoadSettings();
            Browser.Navigate("http://adf.ly/vgzP6");
        }

        private void LoadSettings()
        {
            var functions = new Functions(this);
            functions.Load_Config("KNUCKLES", 0);
            functions.Load_Config("COLT", 1);
            functions.Load_Config("MP5", 2);
            functions.Load_Config("K2", 3);
            functions.Load_Config("SNIPER", 4);
            functions.Load_Config("HEAVY", 5);
            functions.Load_Config("MEDICKIT", 6);
            functions.Load_Config("SPANNER", 7);
            functions.Load_Config("GRENADE", 8);
            functions.Load_Config("TMA_1A", 9);
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
            var functions = new Functions(this);
            File.WriteAllText(Path.GetTempPath() + "\\Config.ini", functions.WriteSettings());
            if (File.Exists(Path.GetTempPath() + "\\Config.ini"))
            {
                MetroMessageBox.Show(this, "The Config File has been successfully saved!", "Loaded!");
            }
            else
            {
                MetroMessageBox.Show(this, "Error on saving the file!", "Error");
            }
        }

        private void Tile_FBPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/geopulse.softwares");
        }

        private void Timer_Injection_Tick(object sender, EventArgs e)
        {
            var standardInjector = InjectionMethod.Create(InjectionMethodType.Standard);
            var targetProcess = Process.GetProcessesByName("warrock");
            if (targetProcess.Length == 0) return;
            if (Variables.IsInjected) return;
            var processId = Process.GetProcessesByName("warrock")[0].Id;
            var img = new PortableExecutable(Resources.Empty);
            var hModule = standardInjector.Inject(img, processId);
            lbl_Status.Text = @"Status: Injecting...";
            Variables.IsInjected = true;

            if (hModule != IntPtr.Zero)
            {
                MetroMessageBox.Show(this, "The hack has been Injected Successfully", "Injected");
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Something went wrong, can't inject the hack", "Error");
                Close();
            }
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (Browser.Url.ToString() == "http://adf.ly/vgzP6") return;
            Browser.Visible = false;
            lbl_Status.ForeColor = Color.Green;
            lbl_Status.BackColor = Color.Green;
            lbl_Status.Text = @"Status: Waiting for Warrock";
            Timer_Injection.Start();
        }

        private void Tile_Credits_Click(object sender, EventArgs e)
        {
            var fuck = "Special Thanks To:" + Environment.NewLine;
            fuck += "@V3n0x" + Environment.NewLine;
            fuck += "@MJCreado" + Environment.NewLine;
            fuck += "@[W]eb[C]ombat" + Environment.NewLine;
            fuck += "@viperneo" + Environment.NewLine;
            fuck += "@Jason" + Environment.NewLine;
            MetroMessageBox.Show(this, fuck, "Credits");
        }

        private void Tile_Weaponcodes_Click(object sender, EventArgs e)
        {
            Process.Start("http://adf.ly/vgeiW");
        }
    }
}