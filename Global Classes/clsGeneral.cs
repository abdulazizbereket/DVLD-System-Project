using DVDLBusinussLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_System.Global_Classes
{
    public class clsGeneral
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string UserName , string Password)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentDirectory + "\\data.txt";

                if (UserName == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string DataToSave = UserName + "#//#" + Password;
                
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine(DataToSave);
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error occured :{ex.Message}");
                return false;
            }
        }
        public static bool GetStoredUsernameAndPassword(ref string Username, ref string Password)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                string Filepath = CurrentDirectory + "\\data.txt";

                if (File.Exists(Filepath))
                {
                    using (StreamReader reader = new StreamReader(Filepath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];

                        }
                        return true;

                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An Error Occured : {ex.Message}");
                return false;

            }
        }
    }
}
