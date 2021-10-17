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
    public class LeaseDAL 
    {
        private static SqlCommand sqlCommand;
        private static LeaseDOL.QueryStatus queryStatus;

        public LeaseDAL(LeaseDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LeaseDAL(LeaseDOL.QueryStatus QueryStatusField, LeaseBOL _LeaseBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LeaseBOL);
        }
        public LeaseBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LeaseBOL[] LeaseBOLs = new LeaseBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToByte(row["Id"]);
                    int? LandLordId = DataConvertor.ConvertToInt(row["LandLordId"]);
                    string LandLordFirstName = DataConvertor.ConvertToString(row["LandLordFirstName"]);
                    string LandLordLastName = DataConvertor.ConvertToString(row["LandLordLastName"]);
                    int? TanentPersonalInfo = DataConvertor.ConvertToInt(row["TanentPersonalInfo"]);
                    string TanentFirstName = DataConvertor.ConvertToString(row["TanentFirstName"]);
                    string TanentLastName = DataConvertor.ConvertToString(row["TanentLastName"]);
                    decimal? Leasehold = DataConvertor.ConvertToDecimal(row["Leasehold"]);
                    byte? LeaseMounth = DataConvertor.ConvertToByte(row["LeaseMounth"]);
                    DateTime? FromDate = DataConvertor.ConvertToDateTime(row["FromDate"]);
                    DateTime? ToDate = DataConvertor.ConvertToDateTime(row["ToDate"]);
                    decimal? Charge = DataConvertor.ConvertToDecimal(row["Charge"]);
                    decimal? LateCharge = DataConvertor.ConvertToDecimal(row["LateCharge"]);
                    int? CouncilId = DataConvertor.ConvertToInt(row["CouncilId"]);
                    string CouncilFirstName = DataConvertor.ConvertToString(row["CouncilFirstName"]);
                    string CouncilLastName = DataConvertor.ConvertToString(row["CouncilLastName"]);
                    byte? JobId = DataConvertor.ConvertToByte(row["JobId"]);
                    string JobTitle = DataConvertor.ConvertToString(row["JobTitle"]);
                    string PaymentType = DataConvertor.ConvertToString(row["PaymentType"]);
                    decimal? Prepayment = DataConvertor.ConvertToDecimal(row["Prepayment"]);
                    string Witness = DataConvertor.ConvertToString(row["Witness"]);
                    string Code = DataConvertor.ConvertToString(row["Code"]);
                    string AmountInWords = DataConvertor.ConvertToString(row["AmountInWords"]);

                    
                    LeaseBOLs[index] = new LeaseBOL(Id,LandLordId, LandLordFirstName, LandLordLastName,TanentPersonalInfo, TanentFirstName,
                        TanentLastName, Leasehold, LeaseMounth, FromDate, ToDate, Charge, LateCharge, CouncilId, CouncilFirstName ,CouncilLastName, JobId,JobTitle, PaymentType,
                        Prepayment, Witness, Code,AmountInWords);
                }
                return LeaseBOLs;
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
                case LeaseDOL.QueryStatus.Select:
                    return LeaseDOL.Select;
                //case LeaseDOL.QueryStatus.SelectComboBox:
                //    return LeaseDOL.SelectComboBox;
                case LeaseDOL.QueryStatus.Delete:
                    return LeaseDOL.Delete;
                case LeaseDOL.QueryStatus.Update:
                    return LeaseDOL.Update;
                case LeaseDOL.QueryStatus.Insert:
                    return LeaseDOL.Insert;
                case LeaseDOL.QueryStatus.SelectMaxId:
                    return LeaseDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(LeaseBOL _LeaseBOL)
        {
           
                   
                   
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _LeaseBOL.Id, true);
            sqlCommand.Parameters.Add("@Leasehold", SqlDbType.Money).Value = ValidateParameter("@Leasehold", _LeaseBOL.Leasehold, true);
            sqlCommand.Parameters.Add("@LeaseMounth", SqlDbType.TinyInt).Value = ValidateParameter("@LeaseMounth", _LeaseBOL.LeaseMounth, true);
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = ValidateParameter("@FromDate", _LeaseBOL.FromDate, true);
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ValidateParameter("@ToDate", _LeaseBOL.ToDate, true);
            sqlCommand.Parameters.Add("@Charge", SqlDbType.Money).Value = ValidateParameter("@Charge", _LeaseBOL.Charge, true);
            sqlCommand.Parameters.Add("@LateCharge", SqlDbType.Money).Value = ValidateParameter("@LateCharge", _LeaseBOL.LateCharge, true);
            sqlCommand.Parameters.Add("@CouncilId", SqlDbType.Int).Value = ValidateParameter("@CouncilId", _LeaseBOL.CouncilId, true);
            sqlCommand.Parameters.Add("@JobId", SqlDbType.TinyInt).Value = ValidateParameter("@JobId", _LeaseBOL.JobId, true);
            sqlCommand.Parameters.Add("@PaymentType", SqlDbType.NVarChar).Value = ValidateParameter("@PaymentType", _LeaseBOL.PaymentType, true);
            sqlCommand.Parameters.Add("@Prepayment", SqlDbType.Money).Value = ValidateParameter("@Prepayment", _LeaseBOL.Prepayment, true);
            sqlCommand.Parameters.Add("@LandLordId", SqlDbType.Int).Value = ValidateParameter("@LandLordId", _LeaseBOL.LandLordId, true);
            sqlCommand.Parameters.Add("@TanentPersonalInfo", SqlDbType.Int).Value = ValidateParameter("@TanentPersonalInfo", _LeaseBOL.TanentPersonalInfo, true);
            sqlCommand.Parameters.Add("@LandLordFirstName", SqlDbType.NVarChar).Value = ValidateParameter("@LandLordFirstName", _LeaseBOL.LandLordFirstName, true);
            sqlCommand.Parameters.Add("@LandLordLastName", SqlDbType.NVarChar).Value = ValidateParameter("@LandLordLastName", _LeaseBOL.LandLordLastName, true);
            sqlCommand.Parameters.Add("@TanentFirstName", SqlDbType.NVarChar).Value = ValidateParameter("@TanentFirstName", _LeaseBOL.TanentFirstName, true);
            sqlCommand.Parameters.Add("@CouncilFirstName", SqlDbType.NVarChar).Value = ValidateParameter("@CouncilFirstName", _LeaseBOL.CouncilFirstName, true);
            sqlCommand.Parameters.Add("@CouncilLastName", SqlDbType.NVarChar).Value = ValidateParameter("@CouncilLastName", _LeaseBOL.CouncilLastName, true);
            sqlCommand.Parameters.Add("@Witness", SqlDbType.NVarChar).Value = ValidateParameter("@Witness", _LeaseBOL.Witness, true);
            sqlCommand.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = ValidateParameter("@JobTitle", _LeaseBOL.JobTitle, true);
            sqlCommand.Parameters.Add("@Code", SqlDbType.NVarChar).Value = ValidateParameter("@Code", _LeaseBOL.Code, true);
            sqlCommand.Parameters.Add("@AmountInWords", SqlDbType.NVarChar).Value = ValidateParameter("@AmountInWords", _LeaseBOL.AmountInWords, true);   

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
