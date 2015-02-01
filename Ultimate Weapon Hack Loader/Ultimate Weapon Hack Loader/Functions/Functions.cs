using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Windows;


namespace Ultimate_Weapon_Hack_Loader
{
    class Functions : Form
    {
        Main main;
        public Functions(Main th)
        {
            main = th;
        }

        public Variables vars = new Variables();
        private string hasherino = "d312e33468967755b3300a4dec929458";
 
       private string RandomString(int size)
       {
        StringBuilder builder = new StringBuilder();
        Random random = new Random();
        char ch;
        for (int i = 0; i < size; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }
        return builder.ToString();
     }
        private bool isValidCode(string code)
       {
            foreach (string x in vars.ValidCodes)
            {
                if (x.Contains(code.ToUpper()))
                {
                    return true;
                }
            }
            return false;
       }

        private string writevalues(string weapon, string code)
        {
           if(code != string.Empty)
           { 
            if (isValidCode(code)) return weapon + " = " + '"' + code.ToUpper() + '"' + Environment.NewLine;
            else MessageBox.Show(code.ToUpper() + " is not a valid code");
           }
            return null;
        }

        public string hashmd5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        public string getdll()
        {
            string[] files = Directory.GetFiles(Application.StartupPath, "*.dll");
            foreach (string filepath in files)
            {
                if (hashmd5(filepath) == hasherino)
                {
                    return (filepath);
                }
            }
            return null;
        }

        public void cleandirectory()
        {
            string[] files = Directory.GetFiles(Application.StartupPath, "*.dll");
            foreach (string filepath in files)
            {
                if (hashmd5(filepath) == hasherino)
                {
                    if (File.Exists(filepath)) File.Delete(filepath);
                }
            }
          
        }

        int checkboxval(bool isChecked)
        {
        if (isChecked) return 1;
        else return 0;
        }

        
       private string WriteSettings()
       {
           string settings;
           settings = (";-------------------------;" + Environment.NewLine);
           settings += (";   WEAPONHACK SETTINGS   ;" + Environment.NewLine);
           settings += (";   Created By: Ryuzaki™  ;" + Environment.NewLine);
           settings += (";-------------------------;" + Environment.NewLine);
           settings += (Environment.NewLine);
           settings += ("[WEAPONS]" + Environment.NewLine);
           settings += writevalues("KNUCKLES", main.txtbox_knuckles.Text);
           settings += writevalues("COLT", main.txtbox_colt.Text);
           settings += writevalues("MP5", main.txtbox_mp5.Text);
           settings += writevalues("K2", main.txtbox_k2.Text);
           settings += writevalues("SNIPER", main.txtbox_sniper.Text);
           settings += writevalues("HEAVY", main.txtbox_heavy.Text);
           settings += writevalues("MEDICKIT", main.txtbox_medickit.Text);
           settings += writevalues("SPANNER", main.txtbox_spanner.Text);
           settings += writevalues("GRENADE", main.txtbox_grenade.Text);
           settings += writevalues("TMA_1A", main.txtbox_tma.Text);
           settings += Environment.NewLine;
           return settings;
       }

        public void Load_Hack()
        {
            //Process[] TargetProcess = Process.GetProcessesByName("warrock");
            string dllname = RandomString(5);
            if (!File.Exists(Application.StartupPath + "\\Config.ini"))
            { File.WriteAllText(Application.StartupPath + "\\Config.ini", WriteSettings()); }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Overwrite the old config?", "Overwrite?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.WriteAllText(Application.StartupPath + "\\Config.ini", WriteSettings());
                }
            }
           // File.WriteAllBytes(Application.StartupPath + "\\" + dllname + ".dll", Properties.Resources.Empty);


           //main.Timer_Injection.Start();
        }

        public void Load_Config(string weapon, NSTextBox txtbox)
        {
            string config = Application.StartupPath + "\\Config.ini";
            string line;

            if(File.Exists(config))
            {
                StreamReader file = new StreamReader(config);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(weapon))
                    {
                        string code = line.Replace(weapon + " = " + '"', "");
                        code = code.TrimEnd('"');
                        txtbox.Text = code;
                    }
                }
            }
        }

      


    }
}
