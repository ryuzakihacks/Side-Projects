using System;
using System.Windows.Forms;

namespace Struct_Builder
{
    public partial class BuildSettings : Form
    {
        private readonly StructBuilderFunctions _func = new StructBuilderFunctions();
        private readonly Main _main;
        private readonly Tool _tools = new Tool();

        public BuildSettings(Main th)
        {
            InitializeComponent();
            _main = th;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            if (txtbox_NAME.Text != "")
            {
                _main.Save_Dialog.FileName = "Struct.txt";
                _tools.SaveData(
                    _func.Buildstruct(txtbox_NAME.Text, _main.Struct_List_View, checkbox_HEX.Checked,
                        checkbox_COMMENTS.Checked), _main.Save_Dialog);
                Close();
            }
            else
            {
                MessageBox.Show(@"Please enter a struct name!");
            }
        }
    }
}