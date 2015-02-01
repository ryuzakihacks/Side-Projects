namespace UWH_Loader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btn_LoadSettings = new MetroFramework.Controls.MetroButton();
            this.Grid_Weapons = new MetroFramework.Controls.MetroGrid();
            this.Column_DefaultWeapon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_WeaponCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Status = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Tile_Credits = new MetroFramework.Controls.MetroTile();
            this.Tile_FBPage = new MetroFramework.Controls.MetroTile();
            this.Tile_Weaponcodes = new MetroFramework.Controls.MetroTile();
            this.Timer_Injection = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Weapons)).BeginInit();
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
            this.metroTabControl1.Size = new System.Drawing.Size(362, 316);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn_LoadSettings);
            this.metroTabPage1.Controls.Add(this.Grid_Weapons);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(354, 274);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Weapon Settings";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btn_LoadSettings
            // 
            this.btn_LoadSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_LoadSettings.Location = new System.Drawing.Point(0, 251);
            this.btn_LoadSettings.Name = "btn_LoadSettings";
            this.btn_LoadSettings.Size = new System.Drawing.Size(354, 23);
            this.btn_LoadSettings.TabIndex = 3;
            this.btn_LoadSettings.Text = "Load Config";
            this.btn_LoadSettings.UseSelectable = true;
            this.btn_LoadSettings.Click += new System.EventHandler(this.btn_LoadSettings_Click);
            // 
            // Grid_Weapons
            // 
            this.Grid_Weapons.AllowUserToAddRows = false;
            this.Grid_Weapons.AllowUserToDeleteRows = false;
            this.Grid_Weapons.AllowUserToOrderColumns = true;
            this.Grid_Weapons.AllowUserToResizeRows = false;
            this.Grid_Weapons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Weapons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_Weapons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Weapons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Weapons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Weapons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Weapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Weapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_DefaultWeapon,
            this.Column_WeaponCode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Weapons.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Weapons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Grid_Weapons.EnableHeadersVisualStyles = false;
            this.Grid_Weapons.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Weapons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_Weapons.Location = new System.Drawing.Point(0, 3);
            this.Grid_Weapons.Name = "Grid_Weapons";
            this.Grid_Weapons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Weapons.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Weapons.RowHeadersVisible = false;
            this.Grid_Weapons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Weapons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Weapons.Size = new System.Drawing.Size(354, 239);
            this.Grid_Weapons.TabIndex = 2;
            // 
            // Column_DefaultWeapon
            // 
            this.Column_DefaultWeapon.HeaderText = "Weapon";
            this.Column_DefaultWeapon.Name = "Column_DefaultWeapon";
            this.Column_DefaultWeapon.Width = 175;
            // 
            // Column_WeaponCode
            // 
            this.Column_WeaponCode.HeaderText = "Weapon Code";
            this.Column_WeaponCode.Name = "Column_WeaponCode";
            this.Column_WeaponCode.Width = 150;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lbl_Status);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.Browser);
            this.metroTabPage3.Controls.Add(this.Tile_Credits);
            this.metroTabPage3.Controls.Add(this.Tile_FBPage);
            this.metroTabPage3.Controls.Add(this.Tile_Weaponcodes);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(354, 274);
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
            this.lbl_Status.Location = new System.Drawing.Point(78, 101);
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
            this.Browser.Size = new System.Drawing.Size(354, 60);
            this.Browser.TabIndex = 6;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // Tile_Credits
            // 
            this.Tile_Credits.ActiveControl = null;
            this.Tile_Credits.AutoSize = true;
            this.Tile_Credits.Location = new System.Drawing.Point(7, 215);
            this.Tile_Credits.Name = "Tile_Credits";
            this.Tile_Credits.Size = new System.Drawing.Size(180, 56);
            this.Tile_Credits.TabIndex = 4;
            this.Tile_Credits.Text = "Credits";
            this.Tile_Credits.UseSelectable = true;
            this.Tile_Credits.Click += new System.EventHandler(this.Tile_Credits_Click);
            // 
            // Tile_FBPage
            // 
            this.Tile_FBPage.ActiveControl = null;
            this.Tile_FBPage.AutoSize = true;
            this.Tile_FBPage.Location = new System.Drawing.Point(6, 156);
            this.Tile_FBPage.Name = "Tile_FBPage";
            this.Tile_FBPage.Size = new System.Drawing.Size(181, 56);
            this.Tile_FBPage.TabIndex = 3;
            this.Tile_FBPage.Text = "Facebook Page";
            this.Tile_FBPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tile_FBPage.UseSelectable = true;
            this.Tile_FBPage.Click += new System.EventHandler(this.Tile_FBPage_Click);
            // 
            // Tile_Weaponcodes
            // 
            this.Tile_Weaponcodes.ActiveControl = null;
            this.Tile_Weaponcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tile_Weaponcodes.Location = new System.Drawing.Point(193, 156);
            this.Tile_Weaponcodes.Name = "Tile_Weaponcodes";
            this.Tile_Weaponcodes.Size = new System.Drawing.Size(158, 115);
            this.Tile_Weaponcodes.TabIndex = 2;
            this.Tile_Weaponcodes.Text = "Weapon Codes";
            this.Tile_Weaponcodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_Weaponcodes.TileImage = ((System.Drawing.Image)(resources.GetObject("Tile_Weaponcodes.TileImage")));
            this.Tile_Weaponcodes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_Weaponcodes.UseSelectable = true;
            this.Tile_Weaponcodes.Click += new System.EventHandler(this.Tile_Weaponcodes_Click);
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
            this.ClientSize = new System.Drawing.Size(402, 396);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 240);
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "     Ultimate Weapon Loader";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Weapons)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        public MetroFramework.Controls.MetroGrid Grid_Weapons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DefaultWeapon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_WeaponCode;
        private MetroFramework.Controls.MetroButton btn_LoadSettings;
        private MetroFramework.Controls.MetroTile Tile_Weaponcodes;
        private MetroFramework.Controls.MetroTile Tile_FBPage;
        private MetroFramework.Controls.MetroTile Tile_Credits;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.WebBrowser Browser;
        private MetroFramework.Controls.MetroLabel lbl_Status;
        private System.Windows.Forms.Timer Timer_Injection;

    }
}

