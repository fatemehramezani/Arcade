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
    public class PurchaseLetterDAL
    {
        private static SqlCommand sqlCommand;
        private static PurchaseLetterDOL.QueryStatus queryStatus;

        public PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public PurchaseLetterDAL(PurchaseLetterDOL.QueryStatus QueryStatusField, PurchaseLetterBOL _PurchaseLetterBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PurchaseLetterBOL);
        }
        public PurchaseLetterBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PurchaseLetterBOL[] PurchaseLetterBOLs = new PurchaseLetterBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToByte(row["Id"]);
                    DateTime? DeliveryDate = DataConvertor.ConvertToDateTime(row["DeliveryDate"]);
                    string Transmiter = DataConvertor.ConvertToString(row["Transmiter"]);
                    DateTime? ContarctDate = DataConvertor.ConvertToDateTime(row["ContarctDate"]);
                    int? SellerId = DataConvertor.ConvertToInt(row["SellerId"]);
                    string SellerFirstName = DataConvertor.ConvertToString(row["SellerFirstName"]);
                    string SellerLastName = DataConvertor.ConvertToString(row["SellerLastName"]);
                    int? CostumerId = DataConvertor.ConvertToInt(row["CostumerId"]);
                    string CostumerFirstName = DataConvertor.ConvertToString(row["CostumerFirstName"]);
                    string CostumerLastName = DataConvertor.ConvertToString(row["CostumerLastName"]);
                    decimal? Price = DataConvertor.ConvertToDecimal(row["Price"]);
                    int? CouncilId = DataConvertor.ConvertToInt(row["CouncilId"]);
                    string CouncilFirstName = DataConvertor.ConvertToString(row["CouncilFirstName"]);
                    string CouncilLastName = DataConvertor.ConvertToString(row["CouncilLastName"]);
                    decimal? Prepayment = DataConvertor.ConvertToDecimal(row["Prepayment"]);
                    decimal? TransforRedress = DataConvertor.ConvertToDecimal(row["TransforRedress"]);
                    decimal? CommitmentRedress = DataConvertor.ConvertToDecimal(row["CommitmentRedress"]);
                    string WitnessName1 = DataConvertor.ConvertToString(row["WitnessName1"]);
                    string WitnessName2 = DataConvertor.ConvertToString(row["WitnessName2"]);
                    string Code = DataConvertor.ConvertToString(row["Code"]);
                    string AmountInWords = DataConvertor.ConvertToString(row["AmountInWords"]);
                    string CheckNumbers = DataConvertor.ConvertToString(row["CheckNumbers"]);



                    PurchaseLetterBOLs[index] = new PurchaseLetterBOL(Id, DeliveryDate, Transmiter, ContarctDate, SellerId, SellerFirstName, SellerLastName, CostumerId, CostumerFirstName, CostumerLastName, Price, CouncilId, CouncilFirstName, CouncilLastName, Prepayment, TransforRedress, CommitmentRedress, WitnessName1, WitnessName2, Code, AmountInWords, CheckNumbers);
                }
                return PurchaseLetterBOLs;
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
                case PurchaseLetterDOL.QueryStatus.Select:
                    return PurchaseLetterDOL.Select;
                //case PurchaseLetterDOL.QueryStatus.SelectComboBox:
                //    return PurchaseLetterDOL.SelectComboBox;
                case PurchaseLetterDOL.QueryStatus.Delete:
                    return PurchaseLetterDOL.Delete;
                case PurchaseLetterDOL.QueryStatus.Update:
                    return PurchaseLetterDOL.Update;
                case PurchaseLetterDOL.QueryStatus.Insert:
                    return PurchaseLetterDOL.Insert;
                case PurchaseLetterDOL.QueryStatus.SelectMaxId:
                    return PurchaseLetterDOL.SelectMaxId;
            }
            return string.Empty; 
        }
        private void SetParameter(PurchaseLetterBOL _PurchaseLetterBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _PurchaseLetterBOL.Id, true);
            sqlCommand.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = ValidateParameter("@DeliveryDate", _PurchaseLetterBOL.DeliveryDate, true);
            sqlCommand.Parameters.Add("@ContarctDate", SqlDbType.DateTime).Value = ValidateParameter("@ContarctDate", _PurchaseLetterBOL.ContarctDate, true);
            sqlCommand.Parameters.Add("@Transmiter", SqlDbType.NVarChar).Value = ValidateParameter("@Transmiter", _PurchaseLetterBOL.Transmiter, true);
            sqlCommand.Parameters.Add("@SellerId", SqlDbType.Int).Value = ValidateParameter("@SellerId", _PurchaseLetterBOL.SellerId, true);
            sqlCommand.Parameters.Add("@CostumerId", SqlDbType.Int).Value = ValidateParameter("@CostumerId", _PurchaseLetterBOL.CostumerId, true);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Money).Value = ValidateParameter("@Price", _PurchaseLetterBOL.Price, true);
            sqlCommand.Parameters.Add("@CouncilId", SqlDbType.NVarChar).Value = ValidateParameter("@CouncilId", _PurchaseLetterBOL.CouncilId, true);
            sqlCommand.Parameters.Add("@Prepayment", SqlDbType.Money).Value = ValidateParameter("@Prepayment", _PurchaseLetterBOL.Prepayment, true);
            sqlCommand.Parameters.Add("@TransforRedress", SqlDbType.Money).Value = ValidateParameter("@TransforRedress", _PurchaseLetterBOL.TransforRedress, true);
            sqlCommand.Parameters.Add("@CommitmentRedress", SqlDbType.Money).Value = ValidateParameter("@CommitmentRedress", _PurchaseLetterBOL.CommitmentRedress, true);
            sqlCommand.Parameters.Add("@WitnessName1", SqlDbType.NVarChar).Value = ValidateParameter("@WitnessName1", _PurchaseLetterBOL.WitnessName1, true);
            sqlCommand.Parameters.Add("@WitnessName2", SqlDbType.NVarChar).Value = ValidateParameter("@WitnessName2", _PurchaseLetterBOL.WitnessName2, true);
            sqlCommand.Parameters.Add("@Code", SqlDbType.NVarChar).Value = ValidateParameter("@Code", _PurchaseLetterBOL.Code, true);
            sqlCommand.Parameters.Add("@CheckNumbers", SqlDbType.NVarChar).Value = ValidateParameter("@CheckNumbers", _PurchaseLetterBOL.CheckNumbers, true);
            sqlCommand.Parameters.Add("@AmountInWords", SqlDbType.NVarChar).Value = ValidateParameter("@AmountInWords", _PurchaseLetterBOL.AmountInWords, true);

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
