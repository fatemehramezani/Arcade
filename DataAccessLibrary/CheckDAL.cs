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
    public class CheckDAL
    {
        private static SqlCommand sqlCommand;
        private static CheckDOL.QueryStatus queryStatus;

        public CheckDAL(CheckDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public CheckDAL(CheckDOL.QueryStatus QueryStatusField, CheckBOL _CheckBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_CheckBOL);
        }
        public CheckBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                CheckBOL[] CheckBOLs = new CheckBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string Number = DataConvertor.ConvertToString(row["Number"]);
                    string AccountNumber = DataConvertor.ConvertToString(row["AccountNumber"]);
                    DateTime? Date = DataConvertor.ConvertToDateTime(row["Date"]);
                    string AccountName = DataConvertor.ConvertToString(row["AccountName"]);
                    decimal? Price = DataConvertor.ConvertToDecimal(row["Price"]);
                    string BankName = DataConvertor.ConvertToString(row["BankName"]);
                    string ForWhom = DataConvertor.ConvertToString(row["ForWhom"]);
                    CheckBOLs[index] = new CheckBOL(Id, Number,AccountNumber,Date,AccountName,Price,BankName,ForWhom);
                }
                return CheckBOLs;
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
                case CheckDOL.QueryStatus.Select:
                    return CheckDOL.Select;
                //case CheckDOL.QueryStatus.SelectComboBox:
                //    return CheckDOL.SelectComboBox;
                case CheckDOL.QueryStatus.Delete:
                    return CheckDOL.Delete;
                case CheckDOL.QueryStatus.Update:
                    return CheckDOL.Update;
                case CheckDOL.QueryStatus.Insert:
                    return CheckDOL.Insert;
                case CheckDOL.QueryStatus.SelectMaxId:
                    return CheckDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(CheckBOL _CheckBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _CheckBOL.Id, true);
            sqlCommand.Parameters.Add("@Number", SqlDbType.NVarChar).Value = ValidateParameter("@Number", _CheckBOL.Number, true);
            sqlCommand.Parameters.Add("@AccountNumber",SqlDbType.NVarChar).Value=ValidateParameter("@AccountNumber",_CheckBOL.AccountNumber,true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _CheckBOL.Date, true);
            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar).Value = ValidateParameter("@AccountName", _CheckBOL.AccountName, true);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Money).Value = ValidateParameter("@Price", _CheckBOL.Price, true);
            sqlCommand.Parameters.Add("@BankName", SqlDbType.NVarChar).Value = ValidateParameter("@BankName", _CheckBOL.BankName, true);
            sqlCommand.Parameters.Add("@ForWhom", SqlDbType.NVarChar).Value = ValidateParameter("@ForWhom", _CheckBOL.ForWhom, true);
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
        public CheckBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                CheckBOL[] CheckBOLs = new CheckBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string Number = DataConvertor.ConvertToString(row["Number"]);
                    string AccountNumber = DataConvertor.ConvertToString(row["AccountNumber"]);
                    DateTime? Date= DataConvertor.ConvertToDateTime(row["Date"]);
                    string AccountName = DataConvertor.ConvertToString(row["AccountName"]);
                    decimal? Price= DataConvertor.ConvertToDecimal(row["Price"]);
                    string BankName = DataConvertor.ConvertToString(row["BankName"]);
                    string ForWho = DataConvertor.ConvertToString(row["ForWhom"]);
                    CheckBOLs[index] = new CheckBOL(Id, Number,AccountNumber,Date,AccountName,Price,BankName,ForWho);
                }
                return CheckBOLs;
            }
            return null;
        }
    }
}
