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
    
    public class InsuranceStatusDAL
    {
        private static SqlCommand sqlCommand;
        private static InsuranceStatusDOL.QueryStatus queryStatus;

        public InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public InsuranceStatusDAL(InsuranceStatusDOL.QueryStatus QueryStatusField, InsuranceStatusBOL _InsuranceStatusBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_InsuranceStatusBOL);
        }
        public InsuranceStatusBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InsuranceStatusBOL[] InsuranceStatusBOLs = new InsuranceStatusBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    InsuranceStatusBOLs[index] = new InsuranceStatusBOL(Id,Title);
                }
                return InsuranceStatusBOLs;
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
                case InsuranceStatusDOL.QueryStatus.Select:
                    return InsuranceStatusDOL.Select;
                case InsuranceStatusDOL.QueryStatus.SelectComboBox:
                    return InsuranceStatusDOL.SelectComboBox;
                case InsuranceStatusDOL.QueryStatus.Delete:
                    return InsuranceStatusDOL.Delete;
                case InsuranceStatusDOL.QueryStatus.Update:
                    return InsuranceStatusDOL.Update;
                case InsuranceStatusDOL.QueryStatus.Insert:
                    return InsuranceStatusDOL.Insert;
                case InsuranceStatusDOL.QueryStatus.SelectMaxId:
                    return InsuranceStatusDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(InsuranceStatusBOL _InsuranceStatusBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _InsuranceStatusBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _InsuranceStatusBOL.Title, true);
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
        public InsuranceStatusBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InsuranceStatusBOL[] InsuranceStatusBOLs = new InsuranceStatusBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    InsuranceStatusBOLs[index] = new InsuranceStatusBOL(Id,Title);
                }
                return InsuranceStatusBOLs;
            }
            return null;
        }
    }
}
