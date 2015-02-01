namespace ZFS_Loader
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.checkbox_ExitGame = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_NoReload = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_SuperNoSpread = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_GMWarning = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_NoRecoil = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_ExtraClipS = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_ExtraClipA = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_BoneShot = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_UnlimitedAmmo = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_FastRepair = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_NoScreenShake = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_FastHealth = new MetroFramework.Controls.MetroCheckBox();
            this.checkbox_FastAmmo = new MetroFramework.Controls.MetroCheckBox();
            this.btn_LoadSettings = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Status = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Tile_Credits = new MetroFramework.Controls.MetroTile();
            this.Tile_FBPage = new MetroFramework.Controls.MetroTile();
            this.Timer_Injection = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(354, 239);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.checkbox_ExitGame);
            this.metroTabPage1.Controls.Add(this.checkbox_NoReload);
            this.metroTabPage1.Controls.Add(this.checkbox_SuperNoSpread);
            this.metroTabPage1.Controls.Add(this.checkbox_GMWarning);
            this.metroTabPage1.Controls.Add(this.checkbox_NoRecoil);
            this.metroTabPage1.Controls.Add(this.checkbox_ExtraClipS);
            this.metroTabPage1.Controls.Add(this.checkbox_ExtraClipA);
            this.metroTabPage1.Controls.Add(this.checkbox_BoneShot);
            this.metroTabPage1.Controls.Add(this.checkbox_UnlimitedAmmo);
            this.metroTabPage1.Controls.Add(this.checkbox_FastRepair);
            this.metroTabPage1.Controls.Add(this.checkbox_NoScreenShake);
            this.metroTabPage1.Controls.Add(this.checkbox_FastHealth);
            this.metroTabPage1.Controls.Add(this.checkbox_FastAmmo);
            this.metroTabPage1.Controls.Add(this.btn_LoadSettings);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(346, 197);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Hack Settings";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // checkbox_ExitGame
            // 
            this.checkbox_ExitGame.AutoSize = true;
            this.checkbox_ExitGame.Location = new System.Drawing.Point(186, 119);
            this.checkbox_ExitGame.Name = "checkbox_ExitGame";
            this.checkbox_ExitGame.Size = new System.Drawing.Size(153, 15);
            this.checkbox_ExitGame.TabIndex = 4;
            this.checkbox_ExitGame.Text = "Exit Game (GM Warning)";
            this.checkbox_ExitGame.UseSelectable = true;
            // 
            // checkbox_NoReload
            // 
            this.checkbox_NoReload.AutoSize = true;
            this.checkbox_NoReload.Location = new System.Drawing.Point(13, 119);
            this.checkbox_NoReload.Name = "checkbox_NoReload";
            this.checkbox_NoReload.Size = new System.Drawing.Size(78, 15);
            this.checkbox_NoReload.TabIndex = 4;
            this.checkbox_NoReload.Text = "No Reload";
            this.checkbox_NoReload.UseSelectable = true;
            // 
            // checkbox_SuperNoSpread
            // 
            this.checkbox_SuperNoSpread.AutoSize = true;
            this.checkbox_SuperNoSpread.Location = new System.Drawing.Point(13, 140);
            this.checkbox_SuperNoSpread.Name = "checkbox_SuperNoSpread";
            this.checkbox_SuperNoSpread.Size = new System.Drawing.Size(111, 15);
            this.checkbox_SuperNoSpread.TabIndex = 4;
            this.checkbox_SuperNoSpread.Text = "Super No Spread";
            this.checkbox_SuperNoSpread.UseSelectable = true;
            // 
            // checkbox_GMWarning
            // 
            this.checkbox_GMWarning.AutoSize = true;
            this.checkbox_GMWarning.Location = new System.Drawing.Point(186, 98);
            this.checkbox_GMWarning.Name = "checkbox_GMWarning";
            this.checkbox_GMWarning.Size = new System.Drawing.Size(90, 15);
            this.checkbox_GMWarning.TabIndex = 4;
            this.checkbox_GMWarning.Text = "GM Warning";
            this.checkbox_GMWarning.UseSelectable = true;
            // 
            // checkbox_NoRecoil
            // 
            this.checkbox_NoRecoil.AutoSize = true;
            this.checkbox_NoRecoil.Location = new System.Drawing.Point(13, 98);
            this.checkbox_NoRecoil.Name = "checkbox_NoRecoil";
            this.checkbox_NoRecoil.Size = new System.Drawing.Size(74, 15);
            this.checkbox_NoRecoil.TabIndex = 4;
            this.checkbox_NoRecoil.Text = "No Recoil";
            this.checkbox_NoRecoil.UseSelectable = true;
            // 
            // checkbox_ExtraClipS
            // 
            this.checkbox_ExtraClipS.AutoSize = true;
            this.checkbox_ExtraClipS.Location = new System.Drawing.Point(186, 77);
            this.checkbox_ExtraClipS.Name = "checkbox_ExtraClipS";
            this.checkbox_ExtraClipS.Size = new System.Drawing.Size(81, 15);
            this.checkbox_ExtraClipS.TabIndex = 4;
            this.checkbox_ExtraClipS.Text = "Extra Clip S";
            this.checkbox_ExtraClipS.UseSelectable = true;
            // 
            // checkbox_ExtraClipA
            // 
            this.checkbox_ExtraClipA.AutoSize = true;
            this.checkbox_ExtraClipA.Location = new System.Drawing.Point(186, 56);
            this.checkbox_ExtraClipA.Name = "checkbox_ExtraClipA";
            this.checkbox_ExtraClipA.Size = new System.Drawing.Size(83, 15);
            this.checkbox_ExtraClipA.TabIndex = 4;
            this.checkbox_ExtraClipA.Text = "Extra Clip A";
            this.checkbox_ExtraClipA.UseSelectable = true;
            // 
            // checkbox_BoneShot
            // 
            this.checkbox_BoneShot.AutoSize = true;
            this.checkbox_BoneShot.Location = new System.Drawing.Point(13, 77);
            this.checkbox_BoneShot.Name = "checkbox_BoneShot";
            this.checkbox_BoneShot.Size = new System.Drawing.Size(77, 15);
            this.checkbox_BoneShot.TabIndex = 4;
            this.checkbox_BoneShot.Text = "Bone Shot";
            this.checkbox_BoneShot.UseSelectable = true;
            // 
            // checkbox_UnlimitedAmmo
            // 
            this.checkbox_UnlimitedAmmo.AutoSize = true;
            this.checkbox_UnlimitedAmmo.Location = new System.Drawing.Point(186, 35);
            this.checkbox_UnlimitedAmmo.Name = "checkbox_UnlimitedAmmo";
            this.checkbox_UnlimitedAmmo.Size = new System.Drawing.Size(115, 15);
            this.checkbox_UnlimitedAmmo.TabIndex = 4;
            this.checkbox_UnlimitedAmmo.Text = "Unlimited Ammo";
            this.checkbox_UnlimitedAmmo.UseSelectable = true;
            // 
            // checkbox_FastRepair
            // 
            this.checkbox_FastRepair.AutoSize = true;
            this.checkbox_FastRepair.Location = new System.Drawing.Point(13, 56);
            this.checkbox_FastRepair.Name = "checkbox_FastRepair";
            this.checkbox_FastRepair.Size = new System.Drawing.Size(80, 15);
            this.checkbox_FastRepair.TabIndex = 4;
            this.checkbox_FastRepair.Text = "Fast Repair";
            this.checkbox_FastRepair.UseSelectable = true;
            // 
            // checkbox_NoScreenShake
            // 
            this.checkbox_NoScreenShake.AutoSize = true;
            this.checkbox_NoScreenShake.Location = new System.Drawing.Point(186, 14);
            this.checkbox_NoScreenShake.Name = "checkbox_NoScreenShake";
            this.checkbox_NoScreenShake.Size = new System.Drawing.Size(111, 15);
            this.checkbox_NoScreenShake.TabIndex = 4;
            this.checkbox_NoScreenShake.Text = "No Screen Shake";
            this.checkbox_NoScreenShake.UseSelectable = true;
            // 
            // checkbox_FastHealth
            // 
            this.checkbox_FastHealth.AutoSize = true;
            this.checkbox_FastHealth.Location = new System.Drawing.Point(13, 35);
            this.checkbox_FastHealth.Name = "checkbox_FastHealth";
            this.checkbox_FastHealth.Size = new System.Drawing.Size(82, 15);
            this.checkbox_FastHealth.TabIndex = 4;
            this.checkbox_FastHealth.Text = "Fast Health";
            this.checkbox_FastHealth.UseSelectable = true;
            // 
            // checkbox_FastAmmo
            // 
            this.checkbox_FastAmmo.AutoSize = true;
            this.checkbox_FastAmmo.Location = new System.Drawing.Point(13, 14);
            this.checkbox_FastAmmo.Name = "checkbox_FastAmmo";
            this.checkbox_FastAmmo.Size = new System.Drawing.Size(84, 15);
            this.checkbox_FastAmmo.TabIndex = 4;
            this.checkbox_FastAmmo.Text = "Fast Ammo";
            this.checkbox_FastAmmo.UseSelectable = true;
            // 
            // btn_LoadSettings
            // 
            this.btn_LoadSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_LoadSettings.Location = new System.Drawing.Point(0, 174);
            this.btn_LoadSettings.Name = "btn_LoadSettings";
            this.btn_LoadSettings.Size = new System.Drawing.Size(346, 23);
            this.btn_LoadSettings.TabIndex = 3;
            this.btn_LoadSettings.Text = "Load Settings";
            this.btn_LoadSettings.UseSelectable = true;
            this.btn_LoadSettings.Click += new System.EventHandler(this.btn_LoadSettings_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lbl_Status);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.Browser);
            this.metroTabPage3.Controls.Add(this.Tile_Credits);
            this.metroTabPage3.Controls.Add(this.Tile_FBPage);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(346, 197);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Loader";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Status.Location = new System.Drawing.Point(77, 95);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(193, 19);
            this.lbl_Status.TabIndex = 9;
            this.lbl_Status.Text = "Status: Waiting to load the hack";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Press \"Skip Ad\" to Load";
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScrollBarsEnabled = false;
            this.Browser.Size = new System.Drawing.Size(346, 60);
            this.Browser.TabIndex = 6;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // Tile_Credits
            // 
            this.Tile_Credits.ActiveControl = null;
            this.Tile_Credits.AutoSize = true;
            this.Tile_Credits.Location = new System.Drawing.Point(190, 143);
            this.Tile_Credits.Name = "Tile_Credits";
            this.Tile_Credits.Size = new System.Drawing.Size(156, 54);
            this.Tile_Credits.TabIndex = 4;
            this.Tile_Credits.Text = "Credits";
            this.Tile_Credits.UseSelectable = true;
            this.Tile_Credits.Click += new System.EventHandler(this.Tile_Credits_Click);
            // 
            // Tile_FBPage
            // 
            this.Tile_FBPage.ActiveControl = null;
            this.Tile_FBPage.AutoSize = true;
            this.Tile_FBPage.Location = new System.Drawing.Point(0, 143);
            this.Tile_FBPage.Name = "Tile_FBPage";
            this.Tile_FBPage.Size = new System.Drawing.Size(184, 58);
            this.Tile_FBPage.TabIndex = 3;
            this.Tile_FBPage.Text = "Facebook Page";
            this.Tile_FBPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tile_FBPage.UseSelectable = true;
            this.Tile_FBPage.Click += new System.EventHandler(this.Tile_FBPage_Click);
            // 
            // Timer_Injection
            // 
            this.Timer_Injection.Interval = 20;
            this.Timer_Injection.Tick += new System.EventHandler(this.Timer_Injection_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(18, 20, 10, 10);
            this.BackMaxSize = 35;
            this.ClientSize = new System.Drawing.Size(394, 319);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "    Zombie Farming Simulator";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btn_LoadSettings;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel lbl_Status;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.WebBrowser Browser;
        private MetroFramework.Controls.MetroTile Tile_Credits;
        private MetroFramework.Controls.MetroTile Tile_FBPage;
        private System.Windows.Forms.Timer Timer_Injection;
        public MetroFramework.Controls.MetroCheckBox checkbox_NoReload;
        public MetroFramework.Controls.MetroCheckBox checkbox_SuperNoSpread;
        public MetroFramework.Controls.MetroCheckBox checkbox_NoRecoil;
        public MetroFramework.Controls.MetroCheckBox checkbox_BoneShot;
        public MetroFramework.Controls.MetroCheckBox checkbox_UnlimitedAmmo;
        public MetroFramework.Controls.MetroCheckBox checkbox_FastRepair;
        public MetroFramework.Controls.MetroCheckBox checkbox_NoScreenShake;
        public MetroFramework.Controls.MetroCheckBox checkbox_FastHealth;
        public MetroFramework.Controls.MetroCheckBox checkbox_FastAmmo;
        public MetroFramework.Controls.MetroCheckBox checkbox_ExitGame;
        public MetroFramework.Controls.MetroCheckBox checkbox_GMWarning;
        public MetroFramework.Controls.MetroCheckBox checkbox_ExtraClipS;
        public MetroFramework.Controls.MetroCheckBox checkbox_ExtraClipA;
    }
}

