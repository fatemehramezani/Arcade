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
    
    public class LetterDAL
    {
        private static SqlCommand sqlCommand;
        private static LetterDOL.QueryStatus queryStatus;

        public LetterDAL(LetterDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LetterDAL(LetterDOL.QueryStatus QueryStatusField, LetterBOL _LetterBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LetterBOL);
        }
        public LetterBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LetterBOL[] LetterBOLs = new LetterBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? PersonalInfoId = DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    string LetterNumber = DataConvertor.ConvertToString(row["LetterNumber"]);
                    DateTime? LetterDate = DataConvertor.ConvertToDateTime(row["LetterDate"]);
                    byte? LetterPlaceId = DataConvertor.ConvertToByte(row["LetterPlaceId"]);
                    string LetterPlaceTitle = DataConvertor.ConvertToString(row["LetterPlaceTitle"]);
                    LetterBOLs[index] = new LetterBOL(Id, PersonalInfoId, LetterNumber, LetterDate, LetterPlaceId, LetterPlaceTitle);
                }
                return LetterBOLs;
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
                case LetterDOL.QueryStatus.Select:
                    return LetterDOL.Select;
                case LetterDOL.QueryStatus.Delete:
                    return LetterDOL.Delete;
                case LetterDOL.QueryStatus.Update:
                    return LetterDOL.Update;
                case LetterDOL.QueryStatus.Insert:
                    return LetterDOL.Insert;
                case LetterDOL.QueryStatus.SelectMaxId:
                    return LetterDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(LetterBOL _LetterBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _LetterBOL.Id, true);
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.Int).Value = ValidateParameter("@PersonalInfoId", _LetterBOL.PersonalInfoId, true);
            sqlCommand.Parameters.Add("@LetterNumber", SqlDbType.NVarChar).Value = ValidateParameter("@LetterNumber", _LetterBOL.LetterNumber, true);
            sqlCommand.Parameters.Add("@LetterDate", SqlDbType.DateTime).Value = ValidateParameter("@LetterDate", _LetterBOL.LetterDate, true);
            sqlCommand.Parameters.Add("@LetterPlaceId", SqlDbType.TinyInt).Value = ValidateParameter("@LetterPlaceId", _LetterBOL.LetterPlaceId, true);
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
