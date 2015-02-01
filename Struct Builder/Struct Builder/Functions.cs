using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Struct_Builder
{
    //The class that will help us in building the struct.
    class StructBuilderFunctions
    {
        //A function that gets the char's size
        private string getcharsize(string input)
        {
            return Regex.Match(input,@"\d+").Value;
        }

        //A function that gets all of the offsets from the list view
        public string[] getoffsets(NSListView listview)
        {
            string[] offsets = new string[listview.Items.Length];
            for (int i = 0; i < listview.Items.Length; i++)
            {
                offsets[i] = listview.Items[i].SubItems[1].Text;
            }
            return offsets;
        }

        //A function that gets all of the names from the listview
        public string[] getnames(NSListView listview)
        {
            string[] names = new string[listview.Items.Length];
            for (int i = 0; i < listview.Items.Length; i++)
            {
                names[i] = listview.Items[i].SubItems[0].Text;
            }
            return names;
        }

        //A function that finds the name of the offset from the listview
        private string findname(NSListView listview, string valuetosearch)
        {
            for(int i = 0; i < listview.Items.Length; i++)
            {
                if (listview.Items[i].SubItems[1].Text == valuetosearch)
                {
                    return listview.Items[i].SubItems[0].Text;
                }
            }
            return null;
        }

        //A function that finds the data type of the offset from the listview
        private string findtype(NSListView listview,string valuetosearch)
        {
            for(int i = 0; i < listview.Items.Length; i++)
            {
                if (listview.Items[i].SubItems[1].Text == valuetosearch)
                {
                    return listview.Items[i].Text;
                }
            }
            return null;
        }

        //The main function
       public string buildstruct(string name, NSListView listview, bool isInt, bool isComment)
        {
           //======== Declare our global Variables ============
           //The string that will hold our struct
            string generatedstruct = null;
           //The variable that will hold the last byte of the offset
            uint lastbyte = 0;
           //Just an add-on so we can have a unique name in unknownbytes. Even a random number/words will work
            int unknowndatacount = 0;
           //The variable that will hold the offsets
            uint[] offsets = new uint[listview.Items.Length];

           // ======= Where the magic begins ==========
            
           //Get the offsets from the list view then save it into our variable
            for (int i = 0; i < listview.Items.Length; i++)
            {
                offsets[i] = Convert.ToUInt32(getoffsets(listview)[i], 16);
            }

           //Sort our array of offset from least to greatest
            Array.Sort(offsets);

           //Write our headers
            generatedstruct += "struct " + name + Environment.NewLine;
            generatedstruct += "{" + Environment.NewLine;
           
           //Loop all the offsets
            for (int i = 0; i < offsets.Length; i++)
            {
                //Calculate the useless data that we have to skip
                uint unknowndata = offsets[i] - lastbyte;
                //Dont write if there are no useless data
                if(unknowndata != 0)
                {
                    //Write the useless bytes we have to skip
                    generatedstruct += "char UnknownData" + unknowndatacount.ToString() + "[";
                    
                    //If the user wants the unknowndata in integer format
                    if(isInt)
                        {
                            generatedstruct += unknowndata.ToString() + "];";
                        //If the user wants it to be commented    
                        if (isComment)
                                generatedstruct += "    //0x" + lastbyte.ToString("X");
                            
                        }
                    //If the user wants the unknowndata in hex format
                        else
                        {
                            generatedstruct += "0x" + unknowndata.ToString("X") + "];";
                            //If the user wants it to be commented
                            if (isComment)
                                generatedstruct += "  //0x" + lastbyte.ToString("X");
                        }
                        generatedstruct += Environment.NewLine;
                    //Add 1 to the count so we can have a unique name in the next loop
                        unknowndatacount++;
                }
                //Write the offsets
                generatedstruct += findtype(listview, offsets[i].ToString("X")) + " " + findname(listview, offsets[i].ToString("X")) + ";";
                //If the user wants it to be commented
                if (isComment)
                { generatedstruct += "    //0x" + offsets[i].ToString("X"); }
                generatedstruct += Environment.NewLine;
                   
                //In here, we assign the value for lastbyte of the offset
                switch (findtype(listview, offsets[i].ToString("X")))
                {
                    case "float":
                        lastbyte = offsets[i] + sizeof(float);
                        break;
                    case "WORD":
                        lastbyte = offsets[i] + sizeof(ushort);
                        break;
                    case "DWORD":
                        lastbyte = offsets[i] + sizeof(uint);
                        break;
                    case "BYTE":
                        lastbyte = offsets[i] + sizeof(byte);
                        break;
                    case "int":
                        lastbyte = offsets[i] + sizeof(int);
                        break;
                }
                
                // *Since the size of a char is not constant, getting it's size is different*
                // Let's find the datatype with "CHAR"
                if(findtype(listview, offsets[i].ToString("X")).Contains("CHAR"))
                {
                    //If found, get it's size then add it to the offset so we can have the last byte of it.
                    lastbyte = offsets[i] + (uint)(int)Convert.ToInt32(getcharsize(findname(listview, offsets[i].ToString("X")))); 
                }
            }

           //Write our footer :]
           generatedstruct += "};" + Environment.NewLine;

           //Extract the generated struct
            return generatedstruct;
        }
    }

    //The class that helps us in navigating the program.
    class Tool
    {
        //Check if the string is only in hex format
        public bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }
        
        //Writes down the "Format"
        public string Serialize(NSListView listview)
        {
           string value = null;
            for(int i = 0; i < listview.Items.Length; i++)
            {
                value += "--" + Environment.NewLine;
                value += listview.Items[i].Text + Environment.NewLine;
                value += listview.Items[i].SubItems[0].Text + Environment.NewLine;
                value += listview.Items[i].SubItems[1].Text + Environment.NewLine;
            }
            return value;
        }

        // Loads the txt file into the List view
        public void LoadData(NSListView listview, OpenFileDialog openfile)
        {
            openfile.InitialDirectory = GetFilePath();
            string[] Datatypes = { "CHAR", "float", "WORD", "DWORD", "BYTE", "int" };

          if(openfile.ShowDialog() == DialogResult.OK)
          { 
            RichTextBox rtb = new RichTextBox();
            rtb.Text = File.ReadAllText(openfile.FileName);
            int i= 0;
           foreach(string line in rtb.Lines)
           {
               if (line == "--")
               {
                   for (int index = 0; index < Datatypes.Length; index++)
                   {
                       if (Datatypes[index] == rtb.Lines[i + 1] && OnlyHexInString(rtb.Lines[i + 3]))
                       { listview.AddItem(rtb.Lines[i + 1], rtb.Lines[i + 2], rtb.Lines[i + 3].ToUpper()); }
                   }
                       
               }
               i++;
           }
          }
            
        }

        

        public bool isNameExists(string name, NSListView listview)
        {
            StructBuilderFunctions func = new StructBuilderFunctions();
            string[] names = new string[listview.Items.Length];
            for(int i = 0; i < listview.Items.Length; i++)
            {
                if (name == func.getnames(listview)[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool isOffsetExists(string offset, NSListView listview)
        {
            StructBuilderFunctions func = new StructBuilderFunctions();
            for (int i = 0; i < listview.Items.Length; i++ )
            {
                if (offset == func.getoffsets(listview)[i])
                {
                    return true;
                }
            }
                return false;
        }

        //Saves the data from the list view
        public void SaveData(string data, SaveFileDialog savefile)
        {
            savefile.InitialDirectory = GetFilePath();
            if(savefile.ShowDialog() == DialogResult.OK)
            { 
            File.WriteAllText(savefile.FileName, data);
            MessageBox.Show("Successfully Saved!");
            }
        }

        //Remove the selected item form the list view
        public void RemoveSelected(NSListView listview)
        {
            listview.RemoveItems(listview.SelectedItems);
        }

        //Clears all the items from the list view
        public void ClearAll(NSListView listview)
        {
            int length = listview.Items.Length;

            for (int i = 0; i < length; i++)
            {
                listview.RemoveItemAt(0);
            }
        }

        //Gets the application's directory
        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public void cleartextboxes(TextBox txtbox1, TextBox txtbox2,TextBox txtbox3)
        {
            txtbox1.Text = string.Empty;
            txtbox2.Text = string.Empty;
            txtbox3.Text = string.Empty;
        }

    }
}
