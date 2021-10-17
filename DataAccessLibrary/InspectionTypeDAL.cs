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
    
    public class InspectionTypeDAL
    {
        private static SqlCommand sqlCommand;
        private static InspectionTypeDOL.QueryStatus queryStatus;

        public InspectionTypeDAL(InspectionTypeDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public InspectionTypeDAL(InspectionTypeDOL.QueryStatus QueryStatusField, InspectionTypeBOL _InspectionTypeBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_InspectionTypeBOL);
        }
        public InspectionTypeBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InspectionTypeBOL[] InspectionTypeBOLs = new InspectionTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    InspectionTypeBOLs[index] = new InspectionTypeBOL(Id,Title);
                }
                return InspectionTypeBOLs;
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
                case InspectionTypeDOL.QueryStatus.Select:
                    return InspectionTypeDOL.Select;
                case InspectionTypeDOL.QueryStatus.SelectComboBox:
                    return InspectionTypeDOL.SelectComboBox;
                case InspectionTypeDOL.QueryStatus.Delete:
                    return InspectionTypeDOL.Delete;
                case InspectionTypeDOL.QueryStatus.Update:
                    return InspectionTypeDOL.Update;
                case InspectionTypeDOL.QueryStatus.Insert:
                    return InspectionTypeDOL.Insert;
                case InspectionTypeDOL.QueryStatus.SelectMaxId:
                    return InspectionTypeDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(InspectionTypeBOL _InspectionTypeBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _InspectionTypeBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _InspectionTypeBOL.Title, true);
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
        public InspectionTypeBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InspectionTypeBOL[] InspectionTypeBOLs = new InspectionTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    InspectionTypeBOLs[index] = new InspectionTypeBOL(Id,Title);
                }
                return InspectionTypeBOLs;
            }
            return null;
        }
    }
}
