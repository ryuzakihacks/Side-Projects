using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Struct_Builder
{
    public partial class Build_Settings : Form
    {
        Main main;
        public Build_Settings(Main th)
        {
            InitializeComponent();
            main = th;
        }

        StructBuilderFunctions func = new StructBuilderFunctions();
        Tool tools = new Tool();
        

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            if(txtbox_NAME.Text != "")
            {
                main.Save_Dialog.FileName = "Struct.txt";
                tools.SaveData(func.buildstruct(txtbox_NAME.Text, main.Struct_List_View, checkbox_HEX.Checked, checkbox_COMMENTS.Checked), main.Save_Dialog);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a struct name!");
            }
            
        }

       
    }
}
