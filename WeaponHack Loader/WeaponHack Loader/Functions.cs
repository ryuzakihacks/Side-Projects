using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WeaponHack_Loader
{
    class Functions
    {
        //Declare our storage
        string text;

        //Log function
        public void log()
        {
            File.WriteAllText(Application.StartupPath + "\\Config.ini", text);
        }
       

        //Our function for headings
        public void writeheadings()
        {
            text = (";-------------------------;" + Environment.NewLine);
            text += (";   WEAPONHACK SETTINGS   ;" + Environment.NewLine);
            text += (";-------------------------;" + Environment.NewLine);
            text += (Environment.NewLine);
            text += ("[DEFAULT_WEAPONS]" + Environment.NewLine);
        }

        //Get data
        public void navi(NSComboBox option,int type)
        {
            //types:
            //1 = KNUCKLES
            //2 = COLT
            //3 = MP5
            //4 = K2
            //5 = SNIPER
            //6 = HEAVY

            //if the option is checked
            int val = option.SelectedIndex + 1;

            if (type == 1)
            {
                text += ("KNUCKLES = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 2)
            {
                text += ("COLT = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 3)
            {
                text += ("MP5 = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 4)
            {
                text += ("K2 = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 5)
            {
                text += ("SNIPER = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 6)
            {
                text += ("HEAVY = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 7)
            {
                text += ("MEDICKIT = " + val.ToString()) + Environment.NewLine;
            }
            if (type == 8)
            {
                text += ("SPANNER = " + val.ToString()) + Environment.NewLine;
            }

           
            
        }

        //public bool isGood (NSRadioButton option, int value, int type)
        //{
        //   if(navi(option,value,type) != null)
        //   {
        //       return true;
        //   }
        //   return false;
        //}

        //public void log(NSRadioButton option, int value, int type)
        //{
        //    if(isGood(option,value,type))
        //    {

        //    }
        //}

    }
}
