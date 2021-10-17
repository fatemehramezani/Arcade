using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using DataAccessLibrary;
using BusinessObjectLayer;
using System.Security.Cryptography;

namespace DataAccessLayer
{
    public static class ServerDAL
    {
        public static int GetIntValue(string Key)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings[Key]);
        }
        public static string GetStringValue(string Key)
        {
            return ConfigurationManager.AppSettings[Key];
        }
        public static long GetLongValue(string Key)
        {
            return Convert.ToInt64(ConfigurationManager.AppSettings[Key]);
        }
        public static bool GetBooleanValue(string Key)
        {
            return ConfigurationManager.AppSettings[Key].ToUpper() == "TRUE";
        }
        public static string ConnectionStrings()
        {
            return ConnectionStrings("ConnectionString");
        }
        public static string ConnectionStrings(string ConnectionName)
        {
            string connectionStringName = string.Format("UserInterface.Properties.Settings.{0}", ConnectionName);
            SettingBOL _SettingBOL = new SettingBOL(connectionStringName);
            SettingDAL _SettingDAL = new SettingDAL(DataAccessObjectLayer.SettingDOL.CommandStatus.ReadKey, _SettingBOL);
            return DecryptString(_SettingDAL.ReadConnectionString());
        }
        public static string GetServerPath()
        {//"\\185.4.28.202\C$\Program Files (x86)\Parallels\Plesk\Databases\MSSQL\MSSQL10_50.MSSQLSERVER\MSSQL\Backup";//
            return @AppDomain.CurrentDomain.BaseDirectory;
        }
        public static void SetConnectionString(string connectionName, string connectionString)
        {
            connectionString = EncryptData(connectionString);
            SettingBOL _SettingBOL = new SettingBOL(connectionName, connectionString, string.Empty);
            SettingDAL _SettingDAL = new SettingDAL(DataAccessObjectLayer.SettingDOL.CommandStatus.WriteKey, _SettingBOL);
            _SettingDAL.WriteConnectionString();
        }
        static string passphrase = "13931225";
        public static string EncryptData(string Message)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(passphrase));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }
        public static string DecryptString(string Message)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(passphrase));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToDecrypt = Convert.FromBase64String(Message);
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }

    }
}
