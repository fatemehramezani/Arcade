using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using DataObjectLayer;
    using BusinessObjectLayer;
    using DataConvertor;
    
    public class ConfirmationDAL
    {
        private static SqlCommand sqlCommand;
        private static ConfirmationDOL.QueryStatus queryStatus;

        public ConfirmationDAL(ConfirmationDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ConfirmationDAL(ConfirmationDOL.QueryStatus QueryStatusField, ConfirmationBOL _ConfirmationBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ConfirmationBOL);
        }
        public ConfirmationBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ConfirmationBOL[] ConfirmationBOLs = new ConfirmationBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    ConfirmationBOLs[index] = new ConfirmationBOL(Id,Title);
                }
                return ConfirmationBOLs;
            }
            return null;
        }
        public void Insert()
        {
            ExecuteNonQuery();
        }
        public void Update()
        {
            ExecuteNonQuery();
        }
        public void Delete()
        {
            ExecuteNonQuery();
        }
        public long? SelectMaxId()
        {
            return DataConvertor.ConvertToLong(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case ConfirmationDOL.QueryStatus.Select:
                    return ConfirmationDOL.Select;
                case ConfirmationDOL.QueryStatus.SelectComboBox:
                    return ConfirmationDOL.SelectComboBox;
                case ConfirmationDOL.QueryStatus.Delete:
                    return ConfirmationDOL.Delete;
                case ConfirmationDOL.QueryStatus.Update:
                    return ConfirmationDOL.Update;
                case ConfirmationDOL.QueryStatus.Insert:
                    return ConfirmationDOL.Insert;
                case ConfirmationDOL.QueryStatus.SelectMaxId:
                    return ConfirmationDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(ConfirmationBOL _ConfirmationBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _ConfirmationBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _ConfirmationBOL.Title, true);
        }
        private void ExecuteNonQuery()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            sqlCommand.ExecuteNonQuery();
            _ConnectionDAL.CloseConnection();
        }
        private object ExecuteScalar()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            object Object = sqlCommand.ExecuteScalar();
            _ConnectionDAL.CloseConnection();
            return Object;
        }
        private static DataTable ExecuteReader()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            _ConnectionDAL.CloseConnection();
            return dataTable;
        }
        private static object ValidateParameter(string ParameterName, object Value, bool IsNullable)
        {
            if (Value == null && !IsNullable)
                throw new ArgumentNullException(ParameterName);
            return (Value == null ? DBNull.Value : Value);
        }
        public ConfirmationBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ConfirmationBOL[] ConfirmationBOLs = new ConfirmationBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    ConfirmationBOLs[index] = new ConfirmationBOL(Id,Title);
                }
                return ConfirmationBOLs;
            }
            return null;
        }
    }
}
