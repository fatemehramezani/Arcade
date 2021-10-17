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
    public class LandLordDAL
    {
        private static SqlCommand sqlCommand;
        private static LandLordDOL.QueryStatus queryStatus;

        public LandLordDAL(LandLordDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LandLordDAL(LandLordDOL.QueryStatus QueryStatusField, LandLordBOL _LandLordBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LandLordBOL);
        }
        public LandLordBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LandLordBOL[] LandLordBOLs = new LandLordBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToByte(row["Id"]);
                    int? PersonalInfoId = DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    string FirstName = DataConvertor.ConvertToString(row["FirstName"]);
                    string LastName = DataConvertor.ConvertToString(row["LastName"]);
                    byte? Share = DataConvertor.ConvertToByte(row["Share"]);
                    int? EstateId = DataConvertor.ConvertToByte(row["EstateId"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    bool? Type = DataConvertor.ConvertToBoolean(row["Type"]);
                    bool? IsLandLord = DataConvertor.ConvertToBoolean(row["IsLandLord"]);
                    LandLordBOLs[index] = new LandLordBOL(Id, PersonalInfoId, FirstName, LastName, Share, EstateId, Title, Type, IsLandLord);
                }
                return LandLordBOLs;
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
                case LandLordDOL.QueryStatus.Select:
                    return LandLordDOL.Select;
                case LandLordDOL.QueryStatus.Delete:
                    return LandLordDOL.Delete;
                case LandLordDOL.QueryStatus.Update:
                    return LandLordDOL.Update;
                case LandLordDOL.QueryStatus.Insert:
                    return LandLordDOL.Insert;
                case LandLordDOL.QueryStatus.SelectMaxId:
                    return LandLordDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(LandLordBOL _LandLordBOL)
        {
            
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _LandLordBOL.Id, true);
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.Int).Value = ValidateParameter("@PersonalInfoId", _LandLordBOL.PersonalInfoId, true);
            sqlCommand.Parameters.Add("@Share", SqlDbType.TinyInt).Value = ValidateParameter("@Share", _LandLordBOL.Share, true);
            sqlCommand.Parameters.Add("@EstateId", SqlDbType.Int).Value = ValidateParameter("@EstateId", _LandLordBOL.EstateId, true);
            sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = ValidateParameter("@Type", _LandLordBOL.Type, true);
            sqlCommand.Parameters.Add("@IsLandLord", SqlDbType.Bit).Value = ValidateParameter("@IsLandLord", _LandLordBOL.IsLandLord, true);

            
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
