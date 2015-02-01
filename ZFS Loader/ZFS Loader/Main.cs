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
using System.Diagnostics;
using InjectionLibrary;
using JLibrary.PortableExecutable;

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

        void LoadConfig()
        {
            Functions Function = new Functions(this);
            Function.Load_Config("FAST_AMMO", checkbox_FastAmmo);
            Function.Load_Config("FAST_HEALTH", checkbox_FastHealth);
            Function.Load_Config("FAST_REPAIR", checkbox_FastRepair);
            Function.Load_Config("BONE_SHOT", checkbox_BoneShot);
            Function.Load_Config("NO_SCREEN_SHAKE", checkbox_NoScreenShake);
            Function.Load_Config("SUPER_NO_SPREAD", checkbox_SuperNoSpread);
            Function.Load_Config("NO_RECOIL", checkbox_NoRecoil);
            Function.Load_Config("NO_RELOAD", checkbox_NoReload);
            Function.Load_Config("UNLIMITED_AMMO", checkbox_UnlimitedAmmo);
            Function.Load_Config("EXTRA_CLIP_A", checkbox_ExtraClipA);
            Function.Load_Config("EXTRA_CLIP_S", checkbox_ExtraClipS);
            Function.Load_Config("GM_WARNING", checkbox_GMWarning);
            Function.Load_Config("GM_WARNING_CLOSE", checkbox_ExitGame);
        }

        private void btn_LoadSettings_Click(object sender, EventArgs e)
        {
            Functions Function = new Functions(this);
            File.WriteAllText(Path.GetTempPath() + "\\Settings.ini", Function.WriteSettings());
            if (File.Exists(Path.GetTempPath() + "\\Settings.ini"))
            { MetroMessageBox.Show(this, "The Config File has been successfully saved!", "Loaded!"); }
            else { MetroMessageBox.Show(this, "Error on saving the file!", "Error"); }
        }

        private void Tile_FBPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/geopulse.softwares");
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

        private void Timer_Injection_Tick(object sender, EventArgs e)
        {
            var StandardInjector = InjectionMethod.Create(InjectionMethodType.Standard);
            Process[] TargetProcess = Process.GetProcessesByName("warrock");
            if (TargetProcess.Length != 0)
            {
                if (VARIABLES.isInjected) return;
                var processId = Process.GetProcessesByName("warrock")[0].Id;
                var hModule = IntPtr.Zero;
                var img = new PortableExecutable(Properties.Resources.Zombie_Farming_Simulator);
                hModule = StandardInjector.Inject(img, processId);
                lbl_Status.Text = "Status: Injecting...";
                VARIABLES.isInjected = true;

                if (hModule != IntPtr.Zero)
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
    }
}
