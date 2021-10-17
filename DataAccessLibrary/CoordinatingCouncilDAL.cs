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
    public class CoordinatingCouncilDAL
    {
        private static SqlCommand sqlCommand;
        private static CoordinatingCouncilDOL.QueryStatus queryStatus;

        public CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public CoordinatingCouncilDAL(CoordinatingCouncilDOL.QueryStatus QueryStatusField, CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_CoordinatingCouncilBOL);
        }
        public CoordinatingCouncilBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                CoordinatingCouncilBOL[] CoordinatingCouncilBOLs = new CoordinatingCouncilBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string FirstName = DataConvertor.ConvertToString(row["FirstName"]);
                    string LastName = DataConvertor.ConvertToString(row["LastName"]);
                    string FatherName = DataConvertor.ConvertToString(row["FatherName"]);
                    DateTime? Membershipdate = DataConvertor.ConvertToDateTime(row["Membershipdate"]);
                    string NationalCode = DataConvertor.ConvertToString(row["NationalCode"]);
                    DateTime? QuitDate = DataConvertor.ConvertToDateTime(row["QuitDate"]);
                    CoordinatingCouncilBOLs[index] = new CoordinatingCouncilBOL(Id, FirstName, LastName, FatherName, Membershipdate, NationalCode, QuitDate);
                }
                return CoordinatingCouncilBOLs;
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
                case CoordinatingCouncilDOL.QueryStatus.Select:
                    return CoordinatingCouncilDOL.Select;
                //case CoordinatingCouncilDOL.QueryStatus.SelectComboBox:
                //    return CoordinatingCouncilDOL.SelectComboBox;
                case CoordinatingCouncilDOL.QueryStatus.Delete:
                    return CoordinatingCouncilDOL.Delete;
                case CoordinatingCouncilDOL.QueryStatus.Update:
                    return CoordinatingCouncilDOL.Update;
                case CoordinatingCouncilDOL.QueryStatus.Insert:
                    return CoordinatingCouncilDOL.Insert;
                case CoordinatingCouncilDOL.QueryStatus.SelectMaxId:
                    return CoordinatingCouncilDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(CoordinatingCouncilBOL _CoordinatingCouncilBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _CoordinatingCouncilBOL.Id, true);
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ValidateParameter("@FirstName", _CoordinatingCouncilBOL.FirstName, true);
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ValidateParameter("@LastName", _CoordinatingCouncilBOL.LastName, true);
            sqlCommand.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = ValidateParameter("@FatherName", _CoordinatingCouncilBOL.FatherName, true);
            sqlCommand.Parameters.Add("@MembershipDate", SqlDbType.DateTime).Value = ValidateParameter("@MembershipDate", _CoordinatingCouncilBOL.MembershipDate, true);
            sqlCommand.Parameters.Add("@NationalCode", SqlDbType.NVarChar).Value = ValidateParameter("@NationalCode", _CoordinatingCouncilBOL.NationalCode, true);
            sqlCommand.Parameters.Add("@QuitDate", SqlDbType.DateTime).Value = ValidateParameter("@QuitDate", _CoordinatingCouncilBOL.QuitDate, true);
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
        //public CoordinatingCouncilBOL[] SelectComboBox()
        //{
        //    DataTable table = ExecuteReader();
        //    DataRow row;
        //    if (table.Rows.Count > 0)
        //    {
        //        CoordinatingCouncilBOL[] CoordinatingCouncilBOLs = new CoordinatingCouncilBOL[table.Rows.Count];
        //        for (int index = 0; index < table.Rows.Count; index++)
        //        {
        //            row = table.Rows[index];
        //            byte? Id = DataConvertor.ConvertToByte(row["Id"]);
        //            string Title = DataConvertor.ConvertToString(row["Title"]);
        //            CoordinatingCouncilBOLs[index] = new CoordinatingCouncilBOL(Id, Title);
        //        }
        //        return CoordinatingCouncilBOLs;
        //    }
        //    return null;
        //}
    }
}
