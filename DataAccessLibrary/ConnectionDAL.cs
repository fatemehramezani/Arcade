using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class ConnectionDAL
    {
        private static SqlConnection sqlConnection;
        public ConnectionDAL()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString();
        }
        public ConnectionDAL(string ConnectionName)
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString(ConnectionName);
        }
        public string ConnectionString(string ConnectionName)
        {
            return ServerDAL.ConnectionStrings(ConnectionName);
        }
        public string ConnectionString()
        {
            return ServerDAL.ConnectionStrings();
        }
        public SqlConnection OpenConnection()
        {
            if (sqlConnection != null && sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();
            return sqlConnection;
        }
        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }
    }
}
