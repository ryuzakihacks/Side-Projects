namespace Struct_Builder
{
    partial class Offset_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offset_Manager));
            this.nsTheme1 = new NSTheme();
            this.txtbox_SIZE = new System.Windows.Forms.TextBox();
            this.txtbox_VALUE = new System.Windows.Forms.TextBox();
            this.txtbox_NAME = new System.Windows.Forms.TextBox();
            this.btn_ADD = new NSButton();
            this.cmbbox_DATA_TYPE = new NSComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nsControlButton1 = new NSControlButton();
            this.Settings = new System.Windows.Forms.Timer(this.components);
            this.nsTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.txtbox_SIZE);
            this.nsTheme1.Controls.Add(this.txtbox_VALUE);
            this.nsTheme1.Controls.Add(this.txtbox_NAME);
            this.nsTheme1.Controls.Add(this.btn_ADD);
            this.nsTheme1.Controls.Add(this.cmbbox_DATA_TYPE);
            this.nsTheme1.Controls.Add(this.label4);
            this.nsTheme1.Controls.Add(this.label3);
            this.nsTheme1.Controls.Add(this.label2);
            this.nsTheme1.Controls.Add(this.label1);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(257, 193);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Offset Manager";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // txtbox_SIZE
            // 
            this.txtbox_SIZE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtbox_SIZE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_SIZE.ForeColor = System.Drawing.Color.White;
            this.txtbox_SIZE.Location = new System.Drawing.Point(78, 101);
            this.txtbox_SIZE.Name = "txtbox_SIZE";
            this.txtbox_SIZE.Size = new System.Drawing.Size(147, 20);
            this.txtbox_SIZE.TabIndex = 5;
            this.txtbox_SIZE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_SIZE_KeyPress);
            // 
            // txtbox_VALUE
            // 
            this.txtbox_VALUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtbox_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_VALUE.ForeColor = System.Drawing.Color.White;
            this.txtbox_VALUE.Location = new System.Drawing.Point(78, 72);
            this.txtbox_VALUE.Name = "txtbox_VALUE";
            this.txtbox_VALUE.Size = new System.Drawing.Size(147, 20);
            this.txtbox_VALUE.TabIndex = 5;
            this.txtbox_VALUE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_VALUE_KeyPress);
            // 
            // txtbox_NAME
            // 
            this.txtbox_NAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtbox_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_NAME.ForeColor = System.Drawing.Color.White;
            this.txtbox_NAME.Location = new System.Drawing.Point(78, 43);
            this.txtbox_NAME.Name = "txtbox_NAME";
            this.txtbox_NAME.Size = new System.Drawing.Size(147, 20);
            this.txtbox_NAME.TabIndex = 5;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ADD.Location = new System.Drawing.Point(78, 161);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(75, 23);
            this.btn_ADD.TabIndex = 4;
            this.btn_ADD.Text = "Add";
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // cmbbox_DATA_TYPE
            // 
            this.cmbbox_DATA_TYPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbbox_DATA_TYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbox_DATA_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_DATA_TYPE.ForeColor = System.Drawing.Color.White;
            this.cmbbox_DATA_TYPE.FormattingEnabled = true;
            this.cmbbox_DATA_TYPE.Items.AddRange(new object[] {
            "float",
            "WORD",
            "DWORD",
            "BYTE",
            "int",
            "CHAR"});
            this.cmbbox_DATA_TYPE.Location = new System.Drawing.Point(106, 129);
            this.cmbbox_DATA_TYPE.Name = "cmbbox_DATA_TYPE";
            this.cmbbox_DATA_TYPE.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_DATA_TYPE.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(237, 2);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 0;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // Settings
            // 
            this.Settings.Enabled = true;
            this.Settings.Interval = 200;
            this.Settings.Tick += new System.EventHandler(this.Settings_Tick);
            // 
            // Offset_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 193);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Offset_Manager";
            this.Text = "Offset Manager";
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSControlButton nsControlButton1;
        private NSComboBox cmbbox_DATA_TYPE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NSButton btn_ADD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Settings;
        private System.Windows.Forms.TextBox txtbox_SIZE;
        private System.Windows.Forms.TextBox txtbox_VALUE;
        private System.Windows.Forms.TextBox txtbox_NAME;
    }
}