using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace Iron.Global_Classes
{
    internal class clsGlobalUser
    {
        public static clsUsers CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                string CurrentDirection = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentDirection + "\\data.txt";

                if (Username == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }

                string DataToSave = Username + "#//#" + Password;

                using (StreamWriter Write = new StreamWriter(FilePath))
                {
                    Write.WriteLine(DataToSave);
                    return true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                string CurrentDirection = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentDirection + "\\data.txt";

                if (File.Exists(FilePath))
                {
                    string Line;
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        while ((Line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(Line);
                            string[] Result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                            Username = Result[0];
                            Password = Result[1];
                        }
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;

            }


        }


        public static string GetPasswordBeforeHashing(string Password)
        {
            using (SHA256 Sha = SHA256.Create())
            {
                byte[] Pas = Sha.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return BitConverter.ToString(Pas).Replace("-", "").ToLower();
            }
        }





        //------
        public static bool RememberUsernameAndPasswordInRegistry(string Username, string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\IronSteal";

            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey Key = BaseKey.OpenSubKey(@"SOFTWARE\\IronSteal", true))
                    {
                        if (Key != null)
                        {
                            string[] valueNames = Key.GetValueNames();

                            foreach (string value in valueNames)
                            {
                                // حذف القيم الموجودة
                                Key.DeleteValue(value, false);
                            }
                        }
                        Registry.SetValue(keyPath, Username, Password, RegistryValueKind.String);
                        return true;

                        
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }


        }

        public static bool GetStoredCredentialInRegistry(ref string Username, ref string Password)
        {

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\IronSteal";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\IronSteal"))
                {
                    if (key == null)
                    {
                        MessageBox.Show("Registry key not found.");
                        return false;
                    }

                    // الحصول على جميع الأسماء المخزنة
                    string[] valueNames = key.GetValueNames();

                    if (valueNames.Length == 0)
                    {
                        MessageBox.Show("No user credentials found.");
                        return false;
                    }

                    // استخدام أول اسم مستخدم في القائمة
                    string username = valueNames[0];
                    string password = key.GetValue(username, null) as string;

                    if (!string.IsNullOrEmpty(password))
                    {
                        Username = username;

                        Password = password;

                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from registry: {ex.Message}");
                return false;
            }
            return false;
        }
    }
}
       
