using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.Global_Classes
{
    public class clsUtil
    {
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            try
            {
                if (!Directory.Exists(FolderPath))
                  {
                Directory.CreateDirectory(FolderPath);
                return true;
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Create Folder " + ex.Message);
                return false;
            }
          return true;
            
        }

        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {

            string FileName = sourceFile;
            FileInfo fileInfo = new FileInfo(FileName);
            string extn = fileInfo.Extension;

            return GenerateGUID() + extn;

        }
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder  = @"G:\Visul\Iron - Project\";

            if (!CreateFolderIfDoesNotExist (DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
              
            }
            catch (Exception iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }


            sourceFile = destinationFile;
            return true;
        }
    }
}
