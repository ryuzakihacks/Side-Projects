using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Builder
{
    public partial class Main : Form
    {
        Tool tools = new Tool();
        StructBuilderFunctions func = new StructBuilderFunctions();

        public Main()
        {
            InitializeComponent();
        }


        private void Add_Click(object sender, EventArgs e)
        {
            new Offset_Manager(this).Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit here");
        }

        private void Remove_Selected_Click(object sender, EventArgs e)
        {
            tools.RemoveSelected(Struct_List_View);
        }

        private void Clear_All_Click(object sender, EventArgs e)
        {
            tools.ClearAll(Struct_List_View);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save_Dialog.FileName = "Offsets.txt";
            tools.SaveData(tools.Serialize(Struct_List_View),Save_Dialog);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            tools.LoadData(Struct_List_View,Open_Dialog);
        }

        private void btn_BUILD_Click(object sender, EventArgs e)
        {
            new Build_Settings(this).Show();
        }

       


        

       


        
    }
}
