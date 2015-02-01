﻿using System;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;

namespace UWH_Loader
{
    internal class Functions : MetroForm
    {
        private readonly Main _main;

        public Functions(Main th)
        {
            _main = th;
        }

        private static bool IsValidCode(string code)
        {
            foreach (var x in Variables.ValidCodes)
            {
                if (x.Contains(code.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        private string Writevalues(string weapon, int row)
        {
            if (_main.Grid_Weapons.Rows[row].Cells[1].Value == null) return null;
            if (_main.Grid_Weapons.Rows[row].Cells[1].Value.ToString() == string.Empty) return null;
            if (IsValidCode(_main.Grid_Weapons.Rows[row].Cells[1].Value.ToString()))
                return weapon + " = " + '"' + _main.Grid_Weapons.Rows[row].Cells[1].Value.ToString().ToUpper() +
                       '"' + Environment.NewLine;
            MetroMessageBox.Show(_main,
                _main.Grid_Weapons.Rows[row].Cells[1].Value.ToString().ToUpper() + " is not a valid code");
            return null;
        }

        public string WriteSettings()
        {
            var settings = (";-------------------------;" + Environment.NewLine);
            settings += (";   GEPOPULSE SOFTWARE    ;" + Environment.NewLine);
            settings += (";   WEAPONHACK SETTINGS   ;" + Environment.NewLine);
            settings += (";-------------------------;" + Environment.NewLine);
            settings += (Environment.NewLine);
            settings += ("[WEAPONS]" + Environment.NewLine);
            settings += Writevalues("KNUCKLES", 0);
            settings += Writevalues("COLT", 1);
            settings += Writevalues("MP5", 2);
            settings += Writevalues("K2", 3);
            settings += Writevalues("SNIPER", 4);
            settings += Writevalues("HEAVY", 5);
            settings += Writevalues("MEDICKIT", 6);
            settings += Writevalues("SPANNER", 7);
            settings += Writevalues("GRENADE", 8);
            settings += Writevalues("TMA_1A", 9);
            settings += Environment.NewLine;
            return settings;
        }

        public void Load_Config(string weapon, int row)
        {
            var config = Path.GetTempPath() + "\\Config.ini";

            if (!File.Exists(config)) return;
            var file = new StreamReader(config);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                if (!line.Contains(weapon)) continue;
                var code = line.Replace(weapon + " = " + '"', "");
                code = code.TrimEnd('"');
                _main.Grid_Weapons.Rows[row].Cells[1].Value = code;
            }
        }
    }

    internal class Variables
    {
        public static string[] ValidCodes =
        {
            "AA01", "AB01", "AC01", "AD01", "AE01", "BA01", "BA02", "BA03", "BA04",
            "BA05", "BA06", "BA07", "BA08", "BA0E", "BA0F", "BA10", "BA11", "BA12", "BA13", "BA14", "BA15", "BA16",
            "BA17", "BA18", "BA19", "BA1A", "BA1B", "BA1C", "BA1D", "BA1E", "BA20", "BA21", "BA22", "BA23", "BA24",
            "BA25", "BA27", "BA29", "BA40", "BAA0", "BAA1", "BAA2", "BAA3", "BAA4", "BAA5", "BAA6", "BAA7", "BAA8",
            "BAA9", "BAAA", "BAAB", "BAAC", "BAAD", "BAAF", "BAB0", "BAB1", "BAB2", "BAB3", "BAB4", "BAB5", "BAB6",
            "BAB7", "BAB8", "BAB9", "BABA", "BABB", "BB01", "BB02", "BB03", "BB04", "BB05", "BB06", "BB07", "BB10",
            "BB14", "BC01", "BC02", "BD01", "BD02", "BD03", "BD05", "BE01", "BE02", "BE03", "BE04", "BF49", "BF50",
            "BE05", "BF01", "BF02", "BF03", "BF04", "BF05", "BF06", "BF07", "BF08", "BF41", "BF42", "BF43", "BF44",
            "BF45", "BF52", "BF53", "BF40", "BF38", "BF39", "BF10", "BF11", "BF12", "BF13", "BF14", "BF15", "BF16",
            "BF17", "BF18", "BF19", "BF20", "BF21", "BF22", "BF23", "BF24", "BF25", "BF26", "BF27", "BF28", "BF29",
            "BF30", "BF31", "BF32", "BF58", "BF59", "BF33", "BF34", "BF35", "BF36", "BF37", "BG01", "BG04", "BH01",
            "BH02", "BH03", "BH04", "BH05", "BH06", "BH07", "BH08", "BI01", "BI02", "BI03", "BI04", "BI05", "BI07",
            "BI08", "BI10", "BI12", "BJ01", "BJ02", "BJ03", "BJ04", "BJ05", "BJ06", "BJ07", "BJ08", "BJ10", "BJ11",
            "BK01", "BM01", "BM02", "BM03", "BM04", "BM05", "BM06", "BM07", "BM08", "BO01", "BO02", "BO03", "BO04",
            "BO05", "BO06", "BP01", "BP02", "BP03", "BP04", "BP05", "BP06", "BP08", "BR01", "BR02", "BS01", "BS02",
            "BS03", "BS04", "BS05", "BS06", "BS07", "BS08", "BS10", "BS11", "BS12", "BS14", "BS0E", "BT01", "BT02",
            "BT03", "BT04", "BT05", "BU01", "BV01", "BV02", "BV03", "BV04", "BV05", "BV06", "BV10", "BX01", "BX02",
            "BX03", "BX04", "BX05", "BX06", "BX07", "BX08", "BX10", "BX11", "BX12", "BY01", "BZ51", "BZ52", "BZ53",
            "BZ54", "BZ55", "BZ06", "BZ07", "BZ08", "BZ09", "BZ10", "BZ56", "BZ11", "CA01", "CA02", "CA03", "CA04",
            "CB01", "CB02", "CB03", "CB08", "CB09", "CB13", "CB20", "CB27", "CB53", "CB54", "CB55", "CB60", "CB61",
            "CC01", "CC02", "CC03", "CC04", "CC05", "CC06", "CC07", "CC08", "CC09", "CC10", "CC11", "CC12", "CC13",
            "CC14", "CC15", "CC16", "CC17", "CC18", "CC19", "CC20", "CC21", "CC27", "CC31", "CC32", "CC33", "CC34",
            "CC35", "CC36", "CC39", "CC40", "CC38", "CC41", "CC51", "CD01", "CD02", "CD03", "CE01", "CE02", "CE03",
            "CF01", "CF02", "CG01", "CG02", "CP01", "CT01", "CT02", "CH01", "CH02", "CH03", "CH04", "CI01", "CJ01",
            "CJ02", "CK01", "CM01", "CM02", "CM03", "CM04", "CM05", "CM06", "CM07", "CM08", "CM09", "CM10", "CM11",
            "CM12", "CR01", "CR02", "CR03", "CR04", "CS01", "CS02", "CZ01", "CZ02", "CZ03", "CZ04", "CZ05", "CZ06",
            "CZ07", "CZ08", "CZ09", "CZ10", "CZ11", "CZ12", "CZ13", "CZ14", "CZ15", "CZ16", "CZ17", "CZ18", "CZ19",
            "CZ20", "CZ21", "CZ22", "CZ23", "CZ24", "CZ25", "CZ26", "CZ27", "CZ28", "CZ29", "CZ30", "CZ31", "CZ32",
            "CZ33", "CZ34", "CZ35", "CZ36", "CZ37", "CZ38", "CZ39", "CZ40", "CZ41", "CZ42", "CZ43", "CZ44", "CZ45",
            "CZ46", "CZ47", "CZ48", "CZ49", "CZ50", "CZ51", "CZ52", "CZ53", "CZ54", "CZ55", "CZ56", "CZ57", "CZ58",
            "CZ59", "CZ60", "CZ61", "CZ62", "CZ63", "CZ64", "CZ65", "CZ66", "CZ67", "CZ68", "CZ69", "CZ70", "CZ71",
            "CZ72", "CZ73", "CZ74", "CZ75", "CZ76", "CZ77", "CZ78", "CZ79", "CZ80", "CZ83", "CZ84", "CZ85", "CB99",
            "DA01", "DA02", "DA03", "DA04", "DA05", "DA06", "DA10", "DA20", "DB01", "DB02", "DB03", "DB04", "DB05",
            "DB06", "DB07", "DB08", "DB09", "DB10", "DB33", "DC01", "DC02", "DC03", "DC04", "DC05", "DC06", "DC07",
            "DC08", "DC09", "DC10", "DC11", "DC12", "DC13", "DC31", "DC33", "DD01", "DD02", "DD03", "DE01", "DE02",
            "DF01", "DF02", "DF03", "DF04", "DF05", "DF06", "DF07", "DF08", "DF09", "DF10", "DF11", "DF12", "DF35",
            "DF41", "DG01", "DG02", "DG03", "DG04", "DG05", "DG06", "DG07", "DG08", "DG09", "DG10", "DG11", "DG12",
            "DG13", "DG31", "DG44", "DH01", "DH02", "DI01", "DI02", "DJ01", "DJ02", "DJ03", "DJ04", "DJ33", "DJ63",
            "DK01", "DK02", "DL01", "DL02", "DM01", "DN01", "DN02", "DO01", "DO02", "DO03", "DU04", "DU05", "DP03",
            "DP04", "DP05", "DP06", "DQ01", "DQ02", "DQ03", "DR01", "DR02", "DS01", "DS02", "DS03", "DS10", "DX02",
            "DX01", "DS05", "DT01", "DT02", "DT03", "DT04", "DT05", "DU01", "DU02", "DU03", "DV01", "DW01", "DW02",
            "DW03", "DW04", "DZ01", "D001", "D101", "D201", "D501", "D502", "D601", "D602", "D701", "D702", "D801",
            "D802", "D901", "D902", "DC76", "DF71", "DT73", "DG32", "DT34", "DC61", "DA07", "DA50", "DA51", "DA52",
            "DA53", "DA54", "DN51", "DN52", "DC21", "DC22", "DC23", "DC24", "DC25", "DC26", "DC27", "DC28", "DC29",
            "DC30", "DC41", "DC42", "DC43", "DM02", "DN04", "DN03", "DU06", "DA55", "DB11", "DG14", "DG15", "DF13",
            "DG16", "D202", "D203", "DG17", "DJ05", "DC15", "DI03", "DG18", "DN05", "DM03", "DB12", "DG19", "DJ06",
            "DF43", "DJ50", "DJ51", "DA08", "DA09", "DJ52", "DJ53", "DJ54", "DN53", "DC44", "DC45", "DC46", "DC47",
            "DC48", "DC49", "DC50", "DC51", "DC52", "DC53", "DC54", "DC55", "DC56", "DC57", "DC58", "DC59", "DC60",
            "DC66", "DC62", "DC63", "DC64", "DC16", "DC17", "DF36", "DC34", "DU51", "DC14", "D204", "DC36", "DJ35",
            "DG40", "DC40", "DF14", "DJ07", "DG37", "DM04", "DN06", "DG20", "DG21", "DB13", "DA11", "DB14", "DA12",
            "DJ08", "DJ09", "DB15", "DI04", "DA13", "DA56", "DT06", "DM05", "DN07", "DF15", "DG22", "DC18", "DC19",
            "DB16", "DJ38", "DC20", "DF16", "DF46", "DA57", "DA58", "DN54", "DH99", "DU07", "DH03", "DH04", "DH05",
            "DT07", "DB17", "DB18", "DB19", "DA59", "DA60", "DF37", "DI05", "DH06", "DC65", "DC67", "DG23", "DF17",
            "DC68", "DG24", "DC32", "DF40", "DC39", "DC37", "DJ55", "DC38", "DC69", "DF65", "DG25", "DC93", "DC91",
            "DN55", "DA14", "D205", "DD32", "DI06", "DG26", "DK31", "DS11", "DJ56", "DJ10", "DG27", "DA61", "DA62",
            "DG57", "DA15", "DF18", "DF48", "DJ11", "DC70", "DD04", "DG28", "DE04", "DE05", "DE06", "DN08", "DA63",
            "DN56", "DG29", "DI07", "DA64", "DA16", "DA65", "DA66", "DA67", "DF19", "DF49", "DN09", "DJ12", "DI08",
            "DI09", "DT08", "DT09", "DG33", "DG34", "DF20", "DF21", "DB20", "DI10", "DM06", "DN10", "DD05", "DG30",
            "DJ93", "DC71", "DG35", "DA17", "D803", "D903", "D503", "D703", "D904", "D804", "DF95", "DE07", "DG63",
            "DB63", "DJ13", "DF22", "DB22", "DE08", "DE09", "DA21", "DA22", "DG38", "DG39", "DL03", "DB21", "DJ14",
            "DE10", "DF66", "DF67", "DG61", "DJ68", "DC94", "DG64", "DE11", "DE12", "DE13", "DF96", "DJ98", "DF68",
            "DJ69", "DN11", "DC73", "DF25", "DG49", "DJ20", "DF23", "DF24", "DI11", "DI12", "DA18", "DB23", "DE14",
            "DJ15", "DC95", "DF26", "DF27", "DG36", "DB24", "DG65", "DH07", "DH08", "DF44", "DF45", "DG66", "DG41",
            "DJ16", "DE15", "DE16", "DF72", "DF73", "DG67", "DG68", "DC72", "DB25", "DC74", "DG42", "DD06", "DD07",
            "DJ17", "DB26", "DC75", "DG43", "DU08", "DH09", "DF28", "DF29", "DJ18", "DJ19", "DC35", "DY01", "DF30",
            "D805", "D806", "D807", "D808", "D809", "DF31", "DC77", "D813", "D814", "D815", "D603", "D604", "D504",
            "D704", "D705", "D505", "D810", "D811", "D812", "DB27", "DA23", "DA24", "DA25", "DA26", "DA27", "DA28",
            "DA29", "DA30", "DA31", "DA32", "DA33", "DA34", "DA35", "DA36", "DA37", "DA38", "D816", "D817", "D818",
            "D819", "D820", "D821", "D506", "D507", "D905", "D906", "D605", "D606", "D706", "D707", "D822", "EA01",
            "FB01", "EA02", "FJ06", "EA03", "FB05", "EA04", "FB06", "EB01", "FD01", "EB02", "FI03", "EB03", "FI01",
            "EB04", "FI05", "EB05", "FD01", "EC01", "FA01", "EC02", "FA01", "ED01", "FA01", "FA01", "FB01", "ED02",
            "FA01", "FA01", "FJ01", "ED03", "FA01", "FA01", "FH01", "ED04", "FA01", "FA01", "FB01", "FI02", "ED05",
            "FC01", "FB01", "ED06", "FA01", "FH01", "FB01", "ED07", "FA01", "ED08", "FA01", "FA01", "FA01", "FA01",
            "FA01", "ED09", "FA01", "FA01", "FB01", "ED10", "FB02", "FA01", "ED11", "FA01", "FA01", "FA01", "FA01",
            "FA01", "ED12", "FA01", "FA01", "FB01", "EE01", "FF03", "FC03", "FB04", "EE02", "FF01", "FE01", "FB01",
            "EE03", "FF01", "FE01", "FB01", "EE04", "FF01", "FE01", "FB01", "FB02", "EE05", "FF01", "FE01", "FB01",
            "EE06", "FA01", "FF01", "FI07", "FB01", "FA01", "FA01", "EE07", "FF04", "FC03", "EE08", "FF03", "FC03",
            "FB04", "EE09", "FF01", "FE01", "FB01", "FB02", "EE10", "FF01", "FE01", "FB01", "EE11", "FF01", "FE01",
            "FB01", "EE12", "FB01", "FH01", "FA01", "FA01", "FA01", "FA01", "FA01", "EE14", "FF01", "FE01", "FB01",
            "EE16", "FF05", "FE02", "FD02", "EF01", "FF02", "FE01", "FB01", "FA01", "EF02", "FF02", "FE01", "FB01",
            "FA01", "EF03", "FJ01", "EF04", "FC01", "EF05", "FC01", "EG01", "FC01", "FJ01", "FA01", "FA01", "FA01",
            "FA01", "EG02", "FA01", "FB01", "FA01", "FA01", "FA01", "FA01", "EG03", "FA01", "FA01", "FA01", "EG04",
            "FA01", "FA01", "FA01", "EH01", "FG01", "FC03", "EH02", "FG01", "FB01", "EH03", "FG01", "FB01", "EH04",
            "FG01", "FB01", "EH05", "FA01", "FJ03", "EH06", "FG02", "EI01", "FD01", "EI02", "FI05", "EI03", "FA01",
            "FA01", "FA01", "EI04", "FA01", "FA01", "FA01", "EI05", "FI05", "EJ01", "FA01", "FA01", "FB03", "FB03",
            "EJ02", "FJ04", "FJ04", "FA01", "FA01", "FA01", "EJ03", "FI04", "FJ02", "FB02", "EJ04", "FJ03", "FB04",
            "FJ04", "EJ05", "FB04", "FJ03", "FA01", "EJ06", "FA01", "FA01", "FB03", "FB03", "EJ07", "FJ02", "FA01",
            "FA01", "FA01", "EJ08", "FA01", "FA01", "FB01", "FA01", "FA01", "FA01", "FA01", "FA01", "EJ09", "EJ11",
            "FJ02", "FA01", "FA01", "FA01", "EJ13", "FA01", "FA01", "FB01", "FA01", "FB01", "FA01", "FA01", "FA01",
            "EK01", "FC02", "FL01", "EK02", "FC03", "FI05", "EK03", "FA01", "FA01", "FA01", "EK04", "FI04", "FL02",
            "EK05", "FA01", "FA01", "FA01", "EK06", "FA01", "FA01", "FA01", "EK07", "FC03", "FI05", "EK08", "FI04",
            "FL02", "EL01", "FA01", "FB02", "EL02", "FA01", "FA01", "FA01", "EL03", "FA01", "FF02", "FI05", "FB04",
            "EM01", "FA01", "FH01", "FB01", "FB01", "EM02", "FA01", "EM03", "EN01", "EN02", "EN03", "EN04", "EN05",
            "EN06", "EN07", "EN08", "EN09", "EN10", "EN11", "EN12", "EN13", "EN14", "EN15", "EN16", "EN17", "EN18",
            "EN19", "EN20", "EN21", "EN22", "EN23", "EN24", "EN25", "EN26", "EN27", "EN28", "EN29", "EN30", "EN31",
            "EN32", "EN33", "EN34", "EN35", "EN36", "EN37", "EN38", "EN39", "EN40", "EN41", "EN42", "EN43", "EN44",
            "EN45", "EN46", "EN47", "EN48", "EN49", "EN50", "EN51", "EN52", "EN53", "EN54", "EN55", "EN56", "EN57",
            "FA01", "FB01", "FB02", "FB03", "FB04", "FB05", "FB06", "FC01", "FC02", "FC03", "FD01", "FD02", "FE01",
            "FE02", "FF01", "FF02", "FF03", "FF04", "FF05", "FG01", "FG02", "FH01", "FI01", "FI02", "FI03", "FI04",
            "FI05", "FI06", "FI07", "FJ01", "FJ02", "FJ03", "FJ04", "FJ05", "FJ06", "FK01", "FK02", "FL01", "FL02",
            "FI07"
        };

        public static bool IsInjected = false;
    }
}