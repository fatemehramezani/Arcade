using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using DataAccessLayer;
using System.Configuration;

namespace DataAccessLibrary
{
    public class DatabaseDAL : System.ComponentModel.Component
    {
        private static Server _Server;
        public bool BackUp(string Path, string Name)
        {
            string _ConnectionString = new ConnectionDAL().ConnectionString();
            string _DataBaseName = GetDataBaseName(_ConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(_ConnectionString);
            _SqlConnection.Open();
            ServerConnection _ServerConnection = new ServerConnection(_SqlConnection);
            _Server = new Server(_ServerConnection);
            if (_Server != null)
                return BackupDataBase(Path, Name, _DataBaseName);
            else
                return false;
        }
        private string GetDataBaseName(string ConnectionString)
        {
            string[] items = ConnectionString.Split(';');
            foreach (string item in items)
                if (item.Contains("Initial Catalog="))
                {
                    return item.Replace("Initial Catalog=", "");
                }
            return "Election";
        }
        private bool BackupDataBase(string Path, string Name, string DataBaseName)
        {
            string databasePath = string.Format("{0}\\{1}{2}", Path, Name, ".bak");
            Backup _Backup = new Backup();
            _Backup.Action = BackupActionType.Database;
            _Backup.BackupSetDescription = string.Format("Full backup of {0} Database on {1}", DataBaseName, DateTime.Now);
            _Backup.BackupSetName = DataBaseName;
            _Backup.Database = DataBaseName;
            BackupDeviceItem deviceItem = new BackupDeviceItem(databasePath, DeviceType.File);
            _Backup.Initialize = true;
            _Backup.Checksum = true;
            _Backup.ContinueAfterError = true;
            _Backup.Devices.Add(deviceItem);
            _Backup.Incremental = false;
            _Backup.LogTruncation = BackupTruncateLogType.Truncate;
            _Backup.FormatMedia = false;
            _Backup.SqlBackup(_Server);
            _Server.Refresh();
            return true;
        }
        public bool RestoreBackUp(string Path, string Name)
        {
            string _ConnectionString = new ConnectionDAL().ConnectionString();
            string _DataBaseName = GetDataBaseName(_ConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(_ConnectionString);
            _SqlConnection.Open();
            _SqlConnection.ChangeDatabase("master");
            ServerConnection _ServerConnection = new ServerConnection(_SqlConnection);
            _Server = new Server(_ServerConnection);
            if (_Server != null)
            {
                string backUpPath = string.Format("{0}\\{1}{2}", Path, Name, ".bak");
                BackupDeviceItem _BackupDeviceItem = new BackupDeviceItem(backUpPath, DeviceType.File);
                Restore _Restore = new Restore();
                _Restore.PercentCompleteNotification = 1;
                _Restore.Devices.Add(_BackupDeviceItem);
                _Restore.NoRecovery = false;
                _Restore.ReplaceDatabase = true;
                _Restore.Database = _DataBaseName;
                _Restore.Action = RestoreActionType.Database;
                _Restore.SqlRestore(_Server);
                return true;
            }
            else
            {


                return false;
            }
        }
        public static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            //ServiceController service = new ServiceController(serviceName);
            //try
            //{
            //    int millisec1 = Environment.TickCount;
            //    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

            //    service.Stop();
            //    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

            //    // count the rest of the timeout
            //    int millisec2 = Environment.TickCount;
            //    timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

            //    service.Start();
            //    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            //}
            //catch
            //{
            //    // ...
            //}
        }
        public DataTable Select(string ConnectionString)
        {
            SqlConnection _SqlConnection = new SqlConnection(ConnectionString);
            _SqlConnection.Open();
            try
            {
                return _SqlConnection.GetSchema("Databases");
            }
            catch (Exception e)
            {
                _SqlConnection.Close();
                throw new Exception(e.Message);
            }
        }
    }
}