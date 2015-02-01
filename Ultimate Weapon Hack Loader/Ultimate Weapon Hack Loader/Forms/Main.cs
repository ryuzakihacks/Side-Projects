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
using System.Windows;
using System.Diagnostics;


namespace Ultimate_Weapon_Hack_Loader
{
    public partial class Main : Form
    {
        Variables variables = new Variables();
        Injection injector = new Injection();


        public Main()
        {
            Functions Function = new Functions(this);
            InitializeComponent();
            Function.cleandirectory();
            Function.Load_Config("K2", txtbox_k2);
            Function.Load_Config("KNUCKLES", txtbox_knuckles);
            Function.Load_Config("COLT", txtbox_colt);
            Function.Load_Config("MP5", txtbox_mp5);
            Function.Load_Config("SNIPER", txtbox_sniper);
            Function.Load_Config("HEAVY", txtbox_heavy);
            Function.Load_Config("MEDICKIT", txtbox_medickit);
            Function.Load_Config("SPANNER", txtbox_spanner);
            Function.Load_Config("GRENADE", txtbox_grenade);
            Function.Load_Config("TMA_1A", txtbox_tma);
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            Functions Function = new Functions(this);
            Function.Load_Hack();

            //MessageBox.Show(Function.hashmd5(@"C:\Users\admin\Documents\Visual Studio 2013\Projects\Empty\Release\Empty.dll"));
            //Clipboard.SetText(Function.hashmd5(@"C:\Users\admin\Documents\Visual Studio 2013\Projects\Empty\Release\Empty.dll"));
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://pastebin.com/pr5XnGMz");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/geopulse.softwares");
        }

    
       
    }

}
