using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_System.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGuid()
        {
            Guid NewGuid = Guid.NewGuid();
            return NewGuid.ToString();
        }
        public static bool CreateFolderIfNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Creating Folder " + ex.Message);

                    return false;
                }
            }
            return true;
        }
        public static string ReplaceFileNameWithGuid(string SourceFile)
        {
            FileInfo fi  =  new FileInfo(SourceFile);
            string extn=  fi.Extension;



            return GenerateGuid() + extn;
        }
        public static bool CopyImageToProjectImageFolder(ref string SourceFile)
        {

            string DestinationFolder = @"E:\DVLD-People-Images\";
            if (!CreateFolderIfNotExist(DestinationFolder))
            {
                return false;
            }

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGuid(SourceFile);

            try
            {
                File.Copy(SourceFile, DestinationFile,true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            SourceFile = DestinationFile;
            return true;
        }
    }
}
