using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using InjectionLibrary;
using JLibrary.PortableExecutable;
using MetroFramework;
using MetroFramework.Forms;
using ZFS_Loader.Properties;

namespace ZFS_Loader
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            LoadConfig();
            Browser.Navigate("http://adf.ly/vgzP6");
        }

        private void LoadConfig()
        {
            var function = new Functions(this);
            function.Load_Config("FAST_AMMO", checkbox_FastAmmo);
            function.Load_Config("FAST_HEALTH", checkbox_FastHealth);
            function.Load_Config("FAST_REPAIR", checkbox_FastRepair);
            function.Load_Config("BONE_SHOT", checkbox_BoneShot);
            function.Load_Config("NO_SCREEN_SHAKE", checkbox_NoScreenShake);
            function.Load_Config("SUPER_NO_SPREAD", checkbox_SuperNoSpread);
            function.Load_Config("NO_RECOIL", checkbox_NoRecoil);
            function.Load_Config("NO_RELOAD", checkbox_NoReload);
            function.Load_Config("UNLIMITED_AMMO", checkbox_UnlimitedAmmo);
            function.Load_Config("EXTRA_CLIP_A", checkbox_ExtraClipA);
            function.Load_Config("EXTRA_CLIP_S", checkbox_ExtraClipS);
            function.Load_Config("GM_WARNING", checkbox_GMWarning);
            function.Load_Config("GM_WARNING_CLOSE", checkbox_ExitGame);
        }

        private void btn_LoadSettings_Click(object sender, EventArgs e)
        {
            var function = new Functions(this);
            File.WriteAllText(Path.GetTempPath() + "\\Settings.ini", function.WriteSettings());
            if (File.Exists(Path.GetTempPath() + "\\Settings.ini"))
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

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (Browser.Url.ToString() == "http://adf.ly/vgzP6") return;
            Browser.Visible = false;
            lbl_Status.ForeColor = Color.Green;
            lbl_Status.BackColor = Color.Green;
            lbl_Status.Text = @"Status: Waiting for Warrock";
            Timer_Injection.Start();
        }

        private void Timer_Injection_Tick(object sender, EventArgs e)
        {
            var standardInjector = InjectionMethod.Create(InjectionMethodType.Standard);
            var targetProcess = Process.GetProcessesByName("warrock");
            if (targetProcess.Length == 0) return;
            if (Variables.IsInjected) return;
            var processId = Process.GetProcessesByName("warrock")[0].Id;
            var img = new PortableExecutable(Resources.Zombie_Farming_Simulator);
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
    }
}