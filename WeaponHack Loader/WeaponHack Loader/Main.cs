using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeaponHack_Loader
{
    public partial class Main : Form
    {
        Functions func = new Functions();

        

        public Main()
        {
            InitializeComponent();

        }

        private void btn_LOAD_Click(object sender, EventArgs e)
        {
            
            func.writeheadings();
            func.navi(opt_KNUCKLES, 1);
            func.navi(opt_COLT, 2);
            func.navi(opt_MP5, 3);
            func.navi(opt_K2, 4);
            func.navi(opt_SNIPER, 5);
            func.navi(opt_HEAVY, 6);
            func.navi(opt_MEDIC_KIT, 7);
            func.navi(opt_SPANNER, 8);
            func.log();
            MessageBox.Show("Successfully saved, Please inject the .dll now");
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/geopulse.softwares");
        }


        

    }
}
