using DVLD_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DVLD.Global
{
    public class clsGlobal
    {
        public static clsUsers currentUser;

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(currentDirectory, "DVLD_Credentials.txt");

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    string dataToSave = username + "#//#" + password;
                    File.WriteAllText(filePath, dataToSave);
                    return true;
                }
                else
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(currentDirectory, "DVLD_Credentials.txt");

                if (File.Exists(filePath))
                {
                    string line = File.ReadAllText(filePath);

                    string[] parts = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        Username = parts[0];
                        Password = parts[1];
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}