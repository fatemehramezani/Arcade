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
    public class RoleTypeDAL
    {
        private static SqlCommand sqlCommand;
        private static RoleTypeDOL.QueryStatus queryStatus;

        public RoleTypeDAL(RoleTypeDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public RoleTypeDAL(RoleTypeDOL.QueryStatus QueryStatusField, RoleTypeBOL _RoleTypeBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_RoleTypeBOL);
        }
        public RoleTypeBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                RoleTypeBOL[] RoleTypeBOLs = new RoleTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    RoleTypeBOLs[index] = new RoleTypeBOL(Id, Title);
                }
                return RoleTypeBOLs;
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
                case RoleTypeDOL.QueryStatus.Select:
                    return RoleTypeDOL.Select;
                case RoleTypeDOL.QueryStatus.SelectComboBox:
                    return RoleTypeDOL.SelectComboBox;
                case RoleTypeDOL.QueryStatus.Delete:
                    return RoleTypeDOL.Delete;
                case RoleTypeDOL.QueryStatus.Update:
                    return RoleTypeDOL.Update;
                case RoleTypeDOL.QueryStatus.Insert:
                    return RoleTypeDOL.Insert;
                case RoleTypeDOL.QueryStatus.SelectMaxId:
                    return RoleTypeDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(RoleTypeBOL _RoleTypeBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _RoleTypeBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _RoleTypeBOL.Title, true);
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
        public RoleTypeBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                RoleTypeBOL[] RoleTypeBOLs = new RoleTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    RoleTypeBOLs[index] = new RoleTypeBOL(Id, Title);
                }
                return RoleTypeBOLs;
            }
            return null;
        }
    }
}
