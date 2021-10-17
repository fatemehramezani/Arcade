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
    
    public class AddressDAL
    {
        private static SqlCommand sqlCommand;
        private static AddressDOL.QueryStatus queryStatus;

        public AddressDAL(AddressDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public AddressDAL(AddressDOL.QueryStatus QueryStatusField, AddressBOL _AddressBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_AddressBOL);
        }
        public AddressBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                AddressBOL[] AddressBOLs = new AddressBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? PersonalInfoId = DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    string Address = DataConvertor.ConvertToString(row["Address"]);
                    DateTime? StartDate = DataConvertor.ConvertToDateTime(row["StartDate"]);
                    DateTime? EndDate = DataConvertor.ConvertToDateTime(row["EndDate"]);
                    byte? HabitationId = DataConvertor.ConvertToByte(row["HabitationId"]);
                    string HabitationTitle = DataConvertor.ConvertToString(row["HabitationTitle"]);
                    string PostalCode = DataConvertor.ConvertToString(row["PostalCode"]);
                    AddressBOLs[index] = new AddressBOL(Id, PersonalInfoId, Address, StartDate, EndDate, HabitationId, HabitationTitle, PostalCode);
                }
                return AddressBOLs;
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
                case AddressDOL.QueryStatus.Select:
                    return AddressDOL.Select;
                case AddressDOL.QueryStatus.Delete:
                    return AddressDOL.Delete;
                case AddressDOL.QueryStatus.Update:
                    return AddressDOL.Update;
                case AddressDOL.QueryStatus.Insert:
                    return AddressDOL.Insert;
                case AddressDOL.QueryStatus.SelectMaxId:
                    return AddressDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(AddressBOL _AddressBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _AddressBOL.Id, true);
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.Int).Value = ValidateParameter("@PersonalInfoId", _AddressBOL.PersonalInfoId, true);
            sqlCommand.Parameters.Add("@HabitationId", SqlDbType.TinyInt).Value = ValidateParameter("@HabitationId", _AddressBOL.HabitationId, true);
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = ValidateParameter("@Address", _AddressBOL.Address, true);
            sqlCommand.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = ValidateParameter("@PostalCode", _AddressBOL.PostalCode, true);
            sqlCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = ValidateParameter("@StartDate", _AddressBOL.StartDate, true);
            sqlCommand.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = ValidateParameter("@EndDate", _AddressBOL.EndDate, true);
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
