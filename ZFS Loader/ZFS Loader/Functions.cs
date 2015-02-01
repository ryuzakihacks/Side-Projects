using System;
using System.Collections.Generic;
using System.Text;
using MetroFramework.Forms;
using MetroFramework;
using System.Windows.Forms;
using System.IO;

namespace ZFS_Loader
{
    class Functions:MetroForm
    {
        Main main;
        public Functions(Main th)
        {
            main = th;
        }


        private string writevalues(string FeatureName,CheckBox Box)
        {
            if(Box.Checked)
            {
                return FeatureName + " = 1" + Environment.NewLine;
            }
            return FeatureName+" = 0" + Environment.NewLine;
        }
        public string WriteSettings()
        {
            string settings;
            settings = (";-------------------------;" + Environment.NewLine);
            settings += (";   GEPOPULSE SOFTWARE    ;" + Environment.NewLine);
            settings += (";       ZFS SETTINGS      ;" + Environment.NewLine);
            settings += (";-------------------------;" + Environment.NewLine);
            settings += (Environment.NewLine);
            settings += ("[SETTINGS]" + Environment.NewLine);
            settings += writevalues("FAST_AMMO", main.checkbox_FastAmmo);
            settings += writevalues("FAST_HEALTH", main.checkbox_FastHealth);
            settings += writevalues("FAST_REPAIR", main.checkbox_FastRepair);
            settings += writevalues("BONE_SHOT", main.checkbox_BoneShot);
            settings += writevalues("NO_SCREEN_SHAKE", main.checkbox_NoScreenShake);
            settings += writevalues("SUPER_NO_SPREAD", main.checkbox_SuperNoSpread);
            settings += writevalues("NO_RECOIL", main.checkbox_NoRecoil);
            settings += writevalues("NO_RELOAD", main.checkbox_NoReload);
            settings += writevalues("UNLIMITED_AMMO", main.checkbox_UnlimitedAmmo);
            settings += writevalues("EXTRA_CLIP_A", main.checkbox_ExtraClipA);
            settings += writevalues("EXTRA_CLIP_S", main.checkbox_ExtraClipS);
            settings += writevalues("GM_WARNING", main.checkbox_GMWarning);
            settings += writevalues("GM_WARNING_CLOSE", main.checkbox_ExitGame);
            settings += Environment.NewLine;
            return settings;
        }

        public void Load_Config(string Feature, CheckBox Box)
        {
            string Config = Path.GetTempPath() + "\\Settings.ini";
            string line;

            if(File.Exists(Config))
            {
                StreamReader file = new StreamReader(Config);
                while((line = file.ReadLine()) != null)
                {
                    if(line.Contains(Feature + " = 1"))
                    {
                        Box.Checked = true;
                    }
                }
            }
        }

    }

    class VARIABLES
    {
        public static bool isInjected = false;
    }
 
}
