using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD.General
{
    public static class clsUtil
    {
        public static string GenerateGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool CreateFolderIfNotExists(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating directory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string ReplaceFileNameWithGuid(string sourceFile)
        {
            string extension = Path.GetExtension(sourceFile);
            return GenerateGuid() + extension;
        }

        public static bool CopyImageToFolder(ref string sourceFilePath)
        {
            string targetFolderPath = @"C:\DVLD-People-Images";

            if (!CreateFolderIfNotExists(targetFolderPath))
                return false;

            string destinationFilePath = Path.Combine(targetFolderPath, ReplaceFileNameWithGuid(sourceFilePath));

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFilePath = destinationFilePath;
            return true;
        }
    }
}