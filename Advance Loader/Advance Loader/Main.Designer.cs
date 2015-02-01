namespace Advance_Loader
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblloaderstatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnSUBMIT = new MetroFramework.Controls.MetroButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.lblENTERKEY = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.grpboxloaderinfo = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.lblstatus = new MetroFramework.Controls.MetroLabel();
            this.lblversion = new MetroFramework.Controls.MetroLabel();
            this.injection = new System.Windows.Forms.Timer(this.components);
            this.retrievingdata = new System.Windows.Forms.Timer(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpboxloaderinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 52);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(406, 133);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblloaderstatus);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.btnSUBMIT);
            this.metroTabPage1.Controls.Add(this.textBox3);
            this.metroTabPage1.Controls.Add(this.textBox2);
            this.metroTabPage1.Controls.Add(this.textBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.lbl1);
            this.metroTabPage1.Controls.Add(this.lblENTERKEY);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(398, 94);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Main Loader";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // lblloaderstatus
            // 
            this.lblloaderstatus.AutoSize = true;
            this.lblloaderstatus.Location = new System.Drawing.Point(163, 70);
            this.lblloaderstatus.Name = "lblloaderstatus";
            this.lblloaderstatus.Size = new System.Drawing.Size(119, 19);
            this.lblloaderstatus.TabIndex = 20;
            this.lblloaderstatus.Text = "WAITING FOR KEY";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(117, 69);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Status:";
            // 
            // btnSUBMIT
            // 
            this.btnSUBMIT.Location = new System.Drawing.Point(167, 38);
            this.btnSUBMIT.Name = "btnSUBMIT";
            this.btnSUBMIT.Size = new System.Drawing.Size(75, 23);
            this.btnSUBMIT.TabIndex = 18;
            this.btnSUBMIT.Text = "SUBMIT";
            this.btnSUBMIT.Click += new System.EventHandler(this.btnSUBMIT_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(266, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(15, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "-";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(200, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(15, 19);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "-";
            // 
            // lblENTERKEY
            // 
            this.lblENTERKEY.AutoSize = true;
            this.lblENTERKEY.Location = new System.Drawing.Point(74, 11);
            this.lblENTERKEY.Name = "lblENTERKEY";
            this.lblENTERKEY.Size = new System.Drawing.Size(77, 19);
            this.lblENTERKEY.TabIndex = 8;
            this.lblENTERKEY.Text = "ENTER KEY:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.grpboxloaderinfo);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(398, 94);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Info";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLink1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(195, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 86);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credits";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(132, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Special thanks: V3n0x";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Creator: Ryuzaki™";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "VERSION:";
            // 
            // grpboxloaderinfo
            // 
            this.grpboxloaderinfo.BackColor = System.Drawing.Color.Transparent;
            this.grpboxloaderinfo.Controls.Add(this.metroLabel6);
            this.grpboxloaderinfo.Controls.Add(this.lbl);
            this.grpboxloaderinfo.Controls.Add(this.lblstatus);
            this.grpboxloaderinfo.Controls.Add(this.lblversion);
            this.grpboxloaderinfo.Location = new System.Drawing.Point(12, 8);
            this.grpboxloaderinfo.Name = "grpboxloaderinfo";
            this.grpboxloaderinfo.Size = new System.Drawing.Size(177, 86);
            this.grpboxloaderinfo.TabIndex = 23;
            this.grpboxloaderinfo.TabStop = false;
            this.grpboxloaderinfo.Text = "About the loader";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 59);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(160, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "FEATURE:   WRPH Chams";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 19);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "STATUS:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(81, 41);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(90, 19);
            this.lblstatus.TabIndex = 20;
            this.lblstatus.Text = "UNDETECTED";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(81, 22);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(26, 19);
            this.lblversion.TabIndex = 22;
            this.lblversion.Text = "1.0";
            // 
            // injection
            // 
            this.injection.Tick += new System.EventHandler(this.injection_Tick);
            // 
            // retrievingdata
            // 
            this.retrievingdata.Tick += new System.EventHandler(this.retrievingdata_Tick);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(6, 55);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(165, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Like Geopulse on Facebook";
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 193);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Geopulse Loader";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxloaderinfo.ResumeLayout(false);
            this.grpboxloaderinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel lblENTERKEY;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel lblversion;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblstatus;
        private MetroFramework.Controls.MetroLabel lbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btnSUBMIT;
        private MetroFramework.Controls.MetroLabel lblloaderstatus;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Timer injection;
        private System.Windows.Forms.GroupBox grpboxloaderinfo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Timer retrievingdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;

    }
}

