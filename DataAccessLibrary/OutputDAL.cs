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
    
    public class OutPutDAL
    {
        private static SqlCommand sqlCommand;
        private static OutPutDOL.QueryStatus queryStatus;

        public OutPutDAL(OutPutDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public OutPutDAL(OutPutDOL.QueryStatus QueryStatusField, OutPutBOL _OutPutBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_OutPutBOL);
        }
        public OutPutBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                OutPutBOL[] OutPutBOLs = new OutPutBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? EventId = DataConvertor.ConvertToInt(row["EventId"]);
                    string EventTitle = DataConvertor.ConvertToString(row["EventTitle"]);
                    decimal? Price = DataConvertor.ConvertToDecimal(row["Price"]);
                    DateTime? Date = DataConvertor.ConvertToDateTime(row["Date"]);
                    string Description = DataConvertor.ConvertToString(row["Description"]);
                    OutPutBOLs[index] = new OutPutBOL(Id,EventId,EventTitle,Price,Date,Description);
                }
                return OutPutBOLs;
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
        public int? SelectMaxId()
        {
            return DataConvertor.ConvertToInt(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case OutPutDOL.QueryStatus.Select:
                    return OutPutDOL.Select;
                case OutPutDOL.QueryStatus.Delete:
                    return OutPutDOL.Delete;
                case OutPutDOL.QueryStatus.Update:
                    return OutPutDOL.Update;
                case OutPutDOL.QueryStatus.Insert:
                    return OutPutDOL.Insert;
                case OutPutDOL.QueryStatus.SelectMaxId:
                    return OutPutDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(OutPutBOL _OutPutBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _OutPutBOL.Id, true);
            sqlCommand.Parameters.Add("@EventId", SqlDbType.Int).Value = ValidateParameter("@EventId", _OutPutBOL.EventId, true);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = ValidateParameter("@Price", _OutPutBOL.Price, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _OutPutBOL.Date, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _OutPutBOL.Description, true);
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
    }
}
