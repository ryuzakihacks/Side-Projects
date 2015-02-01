namespace Struct_Builder
{
    partial class Build_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Build_Settings));
            this.theme = new NSTheme();
            this.nsGroupBox1 = new NSGroupBox();
            this.checkbox_COMMENTS = new NSCheckBox();
            this.checkbox_HEX = new NSCheckBox();
            this.btn_SAVE = new NSButton();
            this.txtbox_NAME = new NSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nsControlButton1 = new NSControlButton();
            this.theme.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.AccentOffset = 0;
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.theme.Colors = new Bloom[0];
            this.theme.Controls.Add(this.nsGroupBox1);
            this.theme.Controls.Add(this.btn_SAVE);
            this.theme.Controls.Add(this.txtbox_NAME);
            this.theme.Controls.Add(this.label1);
            this.theme.Controls.Add(this.nsControlButton1);
            this.theme.Customization = "";
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.theme.Image = null;
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Movable = true;
            this.theme.Name = "theme";
            this.theme.NoRounding = false;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(232, 207);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Build Settings";
            this.theme.TransparencyKey = System.Drawing.Color.Empty;
            this.theme.Transparent = false;
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.checkbox_COMMENTS);
            this.nsGroupBox1.Controls.Add(this.checkbox_HEX);
            this.nsGroupBox1.DrawSeperator = false;
            this.nsGroupBox1.Location = new System.Drawing.Point(16, 73);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(201, 100);
            this.nsGroupBox1.SubTitle = "Configure what fits in your style!";
            this.nsGroupBox1.TabIndex = 5;
            this.nsGroupBox1.Text = "nsGroupBox1";
            this.nsGroupBox1.Title = "Struct Settings";
            // 
            // checkbox_COMMENTS
            // 
            this.checkbox_COMMENTS.Checked = false;
            this.checkbox_COMMENTS.Location = new System.Drawing.Point(27, 61);
            this.checkbox_COMMENTS.Name = "checkbox_COMMENTS";
            this.checkbox_COMMENTS.Size = new System.Drawing.Size(146, 23);
            this.checkbox_COMMENTS.TabIndex = 3;
            this.checkbox_COMMENTS.Text = "Write Comments";
            // 
            // checkbox_HEX
            // 
            this.checkbox_HEX.Checked = false;
            this.checkbox_HEX.Location = new System.Drawing.Point(27, 38);
            this.checkbox_HEX.Name = "checkbox_HEX";
            this.checkbox_HEX.Size = new System.Drawing.Size(138, 23);
            this.checkbox_HEX.TabIndex = 3;
            this.checkbox_HEX.Text = "UnknownData in Int";
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SAVE.Location = new System.Drawing.Point(79, 179);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(75, 23);
            this.btn_SAVE.TabIndex = 4;
            this.btn_SAVE.Text = "Save";
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            // 
            // txtbox_NAME
            // 
            this.txtbox_NAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_NAME.Location = new System.Drawing.Point(102, 44);
            this.txtbox_NAME.MaxLength = 32767;
            this.txtbox_NAME.Multiline = false;
            this.txtbox_NAME.Name = "txtbox_NAME";
            this.txtbox_NAME.ReadOnly = false;
            this.txtbox_NAME.Size = new System.Drawing.Size(116, 23);
            this.txtbox_NAME.TabIndex = 2;
            this.txtbox_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_NAME.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Struct name:";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(212, 2);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 0;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // Build_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 207);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Build_Settings";
            this.Text = "Build_Settings";
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            this.nsGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme theme;
        private NSControlButton nsControlButton1;
        private NSTextBox txtbox_NAME;
        private System.Windows.Forms.Label label1;
        private NSButton btn_SAVE;
        private NSGroupBox nsGroupBox1;
        private NSCheckBox checkbox_COMMENTS;
        private NSCheckBox checkbox_HEX;
    }
}