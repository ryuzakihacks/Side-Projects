using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ZFS_Loader
{
    internal class Functions : MetroForm
    {
        private readonly Main _main;

        public Functions(Main th)
        {
            _main = th;
        }

        private static string Writevalues(string featureName, CheckBox box)
        {
            if (box.Checked)
            {
                return featureName + " = 1" + Environment.NewLine;
            }
            return featureName + " = 0" + Environment.NewLine;
        }

        public string WriteSettings()
        {
            var settings = (";-------------------------;" + Environment.NewLine);
            settings += (";   GEPOPULSE SOFTWARE    ;" + Environment.NewLine);
            settings += (";       ZFS SETTINGS      ;" + Environment.NewLine);
            settings += (";-------------------------;" + Environment.NewLine);
            settings += (Environment.NewLine);
            settings += ("[SETTINGS]" + Environment.NewLine);
            settings += Writevalues("FAST_AMMO", _main.checkbox_FastAmmo);
            settings += Writevalues("FAST_HEALTH", _main.checkbox_FastHealth);
            settings += Writevalues("FAST_REPAIR", _main.checkbox_FastRepair);
            settings += Writevalues("BONE_SHOT", _main.checkbox_BoneShot);
            settings += Writevalues("NO_SCREEN_SHAKE", _main.checkbox_NoScreenShake);
            settings += Writevalues("SUPER_NO_SPREAD", _main.checkbox_SuperNoSpread);
            settings += Writevalues("NO_RECOIL", _main.checkbox_NoRecoil);
            settings += Writevalues("NO_RELOAD", _main.checkbox_NoReload);
            settings += Writevalues("UNLIMITED_AMMO", _main.checkbox_UnlimitedAmmo);
            settings += Writevalues("EXTRA_CLIP_A", _main.checkbox_ExtraClipA);
            settings += Writevalues("EXTRA_CLIP_S", _main.checkbox_ExtraClipS);
            settings += Writevalues("GM_WARNING", _main.checkbox_GMWarning);
            settings += Writevalues("GM_WARNING_CLOSE", _main.checkbox_ExitGame);
            settings += Environment.NewLine;
            return settings;
        }

        public void Load_Config(string Feature, CheckBox Box)
        {
            var config = Path.GetTempPath() + "\\Settings.ini";

            if (!File.Exists(config)) return;
            var file = new StreamReader(config);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(Feature + " = 1"))
                {
                    Box.Checked = true;
                }
            }
        }
    }

    internal class Variables
    {
        public static bool IsInjected = false;
    }
}