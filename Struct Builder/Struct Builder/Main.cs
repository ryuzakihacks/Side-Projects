using System;
using System.Windows.Forms;


namespace Struct_Builder
{
    public partial class Main : Form
    {
        private readonly Tool _tools = new Tool();
        private StructBuilderFunctions _func = new StructBuilderFunctions();

        public Main()
        {
            InitializeComponent();
        }

        public StructBuilderFunctions Func
        {
            get { return _func; }
            set { _func = value; }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new OffsetManager(this).Show();
        }

        private void Remove_Selected_Click(object sender, EventArgs e)
        {
            _tools.RemoveSelected(Struct_List_View);
        }

        private void Clear_All_Click(object sender, EventArgs e)
        {
            _tools.ClearAll(Struct_List_View);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save_Dialog.FileName = "Offsets.txt";
            _tools.SaveData(_tools.Serialize(Struct_List_View), Save_Dialog);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            _tools.LoadData(Struct_List_View, Open_Dialog);
        }

        private void btn_BUILD_Click(object sender, EventArgs e)
        {
            new BuildSettings(this).Show();
        }
    }
}