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
    
    public class InputDAL
    {
        private static SqlCommand sqlCommand;
        private static InputDOL.QueryStatus queryStatus;

        public InputDAL(InputDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public InputDAL(InputDOL.QueryStatus QueryStatusField, InputBOL _InputBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_InputBOL);
        }
        public InputBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InputBOL[] InputBOLs = new InputBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? EstateId = DataConvertor.ConvertToInt(row["EstateId"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    int? EventId = DataConvertor.ConvertToInt(row["EventId"]);
                    string EventTitle = DataConvertor.ConvertToString(row["EventTitle"]);
                    decimal? Price = DataConvertor.ConvertToDecimal(row["Price"]);
                    DateTime? Date = DataConvertor.ConvertToDateTime(row["Date"]);
                    string Description = DataConvertor.ConvertToString(row["Description"]);
                    InputBOLs[index] = new InputBOL(Id,EstateId,Title,EventId,EventTitle,Price,Date,Description);
                }
                return InputBOLs;
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
                case InputDOL.QueryStatus.Select:
                    return InputDOL.Select;
                case InputDOL.QueryStatus.Delete:
                    return InputDOL.Delete;
                case InputDOL.QueryStatus.Update:
                    return InputDOL.Update;
                case InputDOL.QueryStatus.Insert:
                    return InputDOL.Insert;
                case InputDOL.QueryStatus.SelectMaxId:
                    return InputDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(InputBOL _InputBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _InputBOL.Id, true);
            sqlCommand.Parameters.Add("@EstateId", SqlDbType.Int).Value = ValidateParameter("@EstateId", _InputBOL.EstateId, true);
            sqlCommand.Parameters.Add("@EventId", SqlDbType.Int).Value = ValidateParameter("@EventId", _InputBOL.EventId, true);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = ValidateParameter("@Price", _InputBOL.Price, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _InputBOL.Date, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _InputBOL.Description, true);
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
