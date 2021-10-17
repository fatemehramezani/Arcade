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
    public class EstateTypeDAL
    {
        private static SqlCommand sqlCommand;
        private static EstateTypeDOL.QueryStatus queryStatus;

        public EstateTypeDAL(EstateTypeDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public EstateTypeDAL(EstateTypeDOL.QueryStatus QueryStatusField, EstateTypeBOL _EstateTypeBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_EstateTypeBOL);
        }
        public EstateTypeBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EstateTypeBOL[] EstateTypeBOLs = new EstateTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    EstateTypeBOLs[index] = new EstateTypeBOL(Id, Title);
                }
                return EstateTypeBOLs;
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
                case EstateTypeDOL.QueryStatus.Select:
                    return EstateTypeDOL.Select;
                case EstateTypeDOL.QueryStatus.SelectComboBox:
                    return EstateTypeDOL.SelectComboBox;
                case EstateTypeDOL.QueryStatus.Delete:
                    return EstateTypeDOL.Delete;
                case EstateTypeDOL.QueryStatus.Update:
                    return EstateTypeDOL.Update;
                case EstateTypeDOL.QueryStatus.Insert:
                    return EstateTypeDOL.Insert;
                case EstateTypeDOL.QueryStatus.SelectMaxId:
                    return EstateTypeDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(EstateTypeBOL _EstateTypeBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _EstateTypeBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _EstateTypeBOL.Title, true);
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
        public EstateTypeBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EstateTypeBOL[] EstateTypeBOLs = new EstateTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    EstateTypeBOLs[index] = new EstateTypeBOL(Id, Title);
                }
                return EstateTypeBOLs;
            }
            return null;
        }
    }
}
