using System;
using System.Windows.Forms;

namespace Struct_Builder
{
    public partial class OffsetManager : Form
    {
        private readonly Main _main;
        private readonly Tool _tool = new Tool();

        public OffsetManager(Main th)
        {
            InitializeComponent();
            _main = th;
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            if (cmbbox_DATA_TYPE.Text != string.Empty && txtbox_VALUE.Text != string.Empty &&
                txtbox_NAME.Text != string.Empty && txtbox_SIZE.Text != string.Empty)
            {
                if (!_tool.IsNameExists(txtbox_NAME.Text, _main.Struct_List_View))
                {
                    if (!_tool.IsOffsetExists(txtbox_VALUE.Text, _main.Struct_List_View))
                    {
                        if (_tool.OnlyHexInString(txtbox_VALUE.Text))
                        {
                            if (!cmbbox_DATA_TYPE.Text.Contains("CHAR"))
                            {
                                _main.Struct_List_View.AddItem(cmbbox_DATA_TYPE.Text, txtbox_NAME.Text,
                                    txtbox_VALUE.Text.ToUpper());
                                _tool.Cleartextboxes(txtbox_NAME, txtbox_VALUE, txtbox_SIZE);
                            }
                            else
                            {
                                _main.Struct_List_View.AddItem(cmbbox_DATA_TYPE.Text,
                                    txtbox_NAME.Text + "[" + txtbox_SIZE.Text + "]", txtbox_VALUE.Text.ToUpper());
                                _tool.Cleartextboxes(txtbox_NAME, txtbox_VALUE, txtbox_SIZE);
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"The offset must contain hex digits only!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(txtbox_VALUE.Text + @" already exists");
                    }
                }
                else
                {
                    MessageBox.Show(txtbox_NAME.Text + @" already exists");
                }
            }
            else
            {
                MessageBox.Show(@"Please fill up all of the informations");
            }
        }

        private void Settings_Tick(object sender, EventArgs e)
        {
            switch (cmbbox_DATA_TYPE.Text)
            {
                default:
                    txtbox_SIZE.Enabled = false;
                    break;
                case "CHAR":
                    txtbox_SIZE.Enabled = true;
                    break;
                case "float":
                    txtbox_SIZE.Text = sizeof (float).ToString();
                    break;
                case "WORD":
                    txtbox_SIZE.Text = sizeof (ushort).ToString();
                    break;
                case "DWORD":
                    txtbox_SIZE.Text = sizeof (uint).ToString();
                    break;
                case "BYTE":
                    txtbox_SIZE.Text = sizeof (byte).ToString();
                    break;
                case "int":
                    txtbox_SIZE.Text = sizeof (int).ToString();
                    break;
            }
        }

        private void txtbox_SIZE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                e.Handled = !Uri.IsHexDigit(e.KeyChar);
        }

        private void txtbox_VALUE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                e.Handled = !Uri.IsHexDigit(e.KeyChar);
        }
    }
}