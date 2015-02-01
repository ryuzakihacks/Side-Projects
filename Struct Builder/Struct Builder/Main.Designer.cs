namespace Struct_Builder
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
            NSListView.NSListViewColumnHeader nsListViewColumnHeader1 = new NSListView.NSListViewColumnHeader();
            NSListView.NSListViewColumnHeader nsListViewColumnHeader2 = new NSListView.NSListViewColumnHeader();
            NSListView.NSListViewColumnHeader nsListViewColumnHeader3 = new NSListView.NSListViewColumnHeader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Open_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Save_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.Theme = new NSTheme();
            this.nsLabel1 = new NSLabel();
            this.btn_BUILD = new NSButton();
            this.Struct_List_View = new NSListView();
            this.Menu = new NSContextMenu();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Remove_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_All = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.nsControlButton1 = new NSControlButton();
            this.Theme.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open_Dialog
            // 
            this.Open_Dialog.FileName = "Offsets.txt";
            // 
            // Save_Dialog
            // 
            this.Save_Dialog.FileName = "Offsets.txt";
            this.Save_Dialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // Theme
            // 
            this.Theme.AccentOffset = 0;
            this.Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Theme.Colors = new Bloom[0];
            this.Theme.Controls.Add(this.nsLabel1);
            this.Theme.Controls.Add(this.btn_BUILD);
            this.Theme.Controls.Add(this.Struct_List_View);
            this.Theme.Controls.Add(this.nsControlButton1);
            this.Theme.Customization = "";
            this.Theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.Theme.Image = null;
            this.Theme.Location = new System.Drawing.Point(0, 0);
            this.Theme.Movable = true;
            this.Theme.Name = "Theme";
            this.Theme.NoRounding = false;
            this.Theme.Sizable = false;
            this.Theme.Size = new System.Drawing.Size(460, 224);
            this.Theme.SmartBounds = true;
            this.Theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Theme.TabIndex = 0;
            this.Theme.Text = "Struct Builder by Ryuzaki™";
            this.Theme.TransparencyKey = System.Drawing.Color.Empty;
            this.Theme.Transparent = false;
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(143, 34);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(174, 23);
            this.nsLabel1.TabIndex = 3;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "GEOPULSE";
            this.nsLabel1.Value2 = "SOFTWARES";
            // 
            // btn_BUILD
            // 
            this.btn_BUILD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BUILD.Location = new System.Drawing.Point(193, 194);
            this.btn_BUILD.Name = "btn_BUILD";
            this.btn_BUILD.Size = new System.Drawing.Size(75, 23);
            this.btn_BUILD.TabIndex = 2;
            this.btn_BUILD.Text = "Build";
            this.btn_BUILD.Click += new System.EventHandler(this.btn_BUILD_Click);
            // 
            // Struct_List_View
            // 
            nsListViewColumnHeader1.Text = "Type";
            nsListViewColumnHeader1.Width = 100;
            nsListViewColumnHeader2.Text = "NAME";
            nsListViewColumnHeader2.Width = 200;
            nsListViewColumnHeader3.Text = "OFFSET";
            nsListViewColumnHeader3.Width = 200;
            this.Struct_List_View.Columns = new NSListView.NSListViewColumnHeader[] {
        nsListViewColumnHeader1,
        nsListViewColumnHeader2,
        nsListViewColumnHeader3};
            this.Struct_List_View.ContextMenuStrip = this.Menu;
            this.Struct_List_View.Items = new NSListView.NSListViewItem[0];
            this.Struct_List_View.Location = new System.Drawing.Point(8, 58);
            this.Struct_List_View.MultiSelect = false;
            this.Struct_List_View.Name = "Struct_List_View";
            this.Struct_List_View.Size = new System.Drawing.Size(445, 132);
            this.Struct_List_View.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.DropShadowEnabled = false;
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.toolStripSeparator1,
            this.Remove_Selected,
            this.Clear_All,
            this.toolStripSeparator2,
            this.Save,
            this.Load});
            this.Menu.Name = "Menu";
            this.Menu.ShowImageMargin = false;
            this.Menu.Size = new System.Drawing.Size(140, 126);
            // 
            // Add
            // 
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 22);
            this.Add.Text = "Add";
            this.Add.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // Remove_Selected
            // 
            this.Remove_Selected.Name = "Remove_Selected";
            this.Remove_Selected.Size = new System.Drawing.Size(139, 22);
            this.Remove_Selected.Text = "Remove Selected";
            this.Remove_Selected.Click += new System.EventHandler(this.Remove_Selected_Click);
            // 
            // Clear_All
            // 
            this.Clear_All.Name = "Clear_All";
            this.Clear_All.Size = new System.Drawing.Size(139, 22);
            this.Clear_All.Text = "Clear All";
            this.Clear_All.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(139, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(139, 22);
            this.Load.Text = "Load";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nsControlButton1.Location = new System.Drawing.Point(440, 2);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 0;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 224);
            this.Controls.Add(this.Theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = " ";
            this.Theme.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme Theme;
        private NSControlButton nsControlButton1;
        private NSContextMenu Menu;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Remove_Selected;
        private System.Windows.Forms.ToolStripMenuItem Clear_All;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.OpenFileDialog Open_Dialog;
        private NSButton btn_BUILD;
        public NSListView Struct_List_View;
        public System.Windows.Forms.SaveFileDialog Save_Dialog;
        private NSLabel nsLabel1;
    }
}

