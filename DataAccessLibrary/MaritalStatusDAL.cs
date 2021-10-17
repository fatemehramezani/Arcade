using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using DataObjectLayer;
    using BusinessObjectLayer;
    using DataConvertor;
    using System.Data;
    public class MaritalStatusDAL
    {
        private static SqlCommand sqlCommand;
        private static MaritalStatusDOL.QueryStatus queryStatus;

        public MaritalStatusDAL(MaritalStatusDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public MaritalStatusDAL(MaritalStatusDOL.QueryStatus QueryStatusField, MaritalStatusBOL _MaritalStatusBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_MaritalStatusBOL);
        }
        public MaritalStatusBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                MaritalStatusBOL[] MaritalStatusBOLs = new MaritalStatusBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    MaritalStatusBOLs[index] = new MaritalStatusBOL(Id, Title);
                }
                return MaritalStatusBOLs;
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
        public byte? SelectMaxId()
        {
            return DataConvertor.ConvertToByte(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case MaritalStatusDOL.QueryStatus.Select:
                    return MaritalStatusDOL.Select;
                case MaritalStatusDOL.QueryStatus.SelectComboBox:
                    return MaritalStatusDOL.SelectComboBox;
                case MaritalStatusDOL.QueryStatus.Delete:
                    return MaritalStatusDOL.Delete;
                case MaritalStatusDOL.QueryStatus.Update:
                    return MaritalStatusDOL.Update;
                case MaritalStatusDOL.QueryStatus.Insert:
                    return MaritalStatusDOL.Insert;
                case MaritalStatusDOL.QueryStatus.SelectMaxId:
                    return MaritalStatusDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(MaritalStatusBOL _MaritalStatusBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _MaritalStatusBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _MaritalStatusBOL.Title, true);
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
        public MaritalStatusBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                MaritalStatusBOL[] MaritalStatusBOLs = new MaritalStatusBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    MaritalStatusBOLs[index] = new MaritalStatusBOL(Id, Title);
                }
                return MaritalStatusBOLs;
            }
            return null;
        }
    }
}
