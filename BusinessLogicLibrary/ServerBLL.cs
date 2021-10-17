using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public static class ServerBLL
    {
        public static int GetIntValue(string Key)
        {
            return ServerDAL.GetIntValue(Key);
        }

        public static string GetStringValue(string Key)
        {
            return ServerDAL.GetStringValue(Key);
        }

        public static long GetLongValue(string Key)
        {
            return ServerDAL.GetLongValue(Key);
        }

        public static bool GetBooleanValue(string Key)
        {
            return ServerDAL.GetBooleanValue(Key);
        }

        public static string ConnectionStrings()
        {
            return ServerDAL.ConnectionStrings();
        }

        public static string ConnectionStrings(string ConnectionString)
        {
            return ServerDAL.ConnectionStrings(ConnectionString);
        }

        public static string GetServerPath()
        {
            return ServerDAL.GetServerPath();
        }

        public static bool BackUp(string Path, string Name)
        {
            return new DatabaseBLL().BackUp(Path, Name);
        }

        public static bool RestoreBackUp(string Path, string Name)
        {
            return new DatabaseBLL().RestoreBackUp(Path, Name);
        }

        public static DataTable Select(string ConnectionString)
        {
            return new DatabaseBLL().Select(ConnectionString);
        }

        public static void SetConnectionString(string connectionName, string connnectionString)
        {
            ServerDAL.SetConnectionString(connectionName, connnectionString);
        }
    }
}