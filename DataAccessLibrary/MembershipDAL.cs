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
    
    public class MembershipDAL
    {
        private static SqlCommand sqlCommand;
        private static MembershipDOL.QueryStatus queryStatus;

        public MembershipDAL(MembershipDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public MembershipDAL(MembershipDOL.QueryStatus QueryStatusField, MembershipBOL _MembershipBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_MembershipBOL);
        }
        public MembershipBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                MembershipBOL[] MembershipBOLs = new MembershipBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? PersonalInfoId = DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    string RegistrationNumber = DataConvertor.ConvertToString(row["RegistrationNumber"]);
                    decimal? Dues = DataConvertor.ConvertToDecimal(row["Dues"]);
                    DateTime? RegistrationDate = DataConvertor.ConvertToDateTime(row["RegistrationDate"]);
                    MembershipBOLs[index] = new MembershipBOL(Id, PersonalInfoId, RegistrationNumber, Dues, RegistrationDate);
                }
                return MembershipBOLs;
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
                case MembershipDOL.QueryStatus.Select:
                    return MembershipDOL.Select;
                case MembershipDOL.QueryStatus.Delete:
                    return MembershipDOL.Delete;
                case MembershipDOL.QueryStatus.Update:
                    return MembershipDOL.Update;
                case MembershipDOL.QueryStatus.Insert:
                    return MembershipDOL.Insert;
                case MembershipDOL.QueryStatus.SelectMaxId:
                    return MembershipDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(MembershipBOL _MembershipBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _MembershipBOL.Id, true);
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.Int).Value = ValidateParameter("@PersonalInfoId", _MembershipBOL.PersonalInfoId, true);
            sqlCommand.Parameters.Add("@RegistrationNumber", SqlDbType.NVarChar).Value = ValidateParameter("@RegistrationNumber", _MembershipBOL.RegistrationNumber, true);
            sqlCommand.Parameters.Add("@Dues", SqlDbType.Money).Value = ValidateParameter("@Dues", _MembershipBOL.Dues, true);
            sqlCommand.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = ValidateParameter("@RegistrationDate", _MembershipBOL.RegistrationDate, true);
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
