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
    
    public class PersonalInfoDAL
    {
        private static SqlCommand sqlCommand;
        private static PersonalInfoDOL.QueryStatus queryStatus;

        public PersonalInfoDAL(PersonalInfoDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public PersonalInfoDAL(PersonalInfoDOL.QueryStatus QueryStatusField, PersonalInfoBOL _PersonalInfoBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PersonalInfoBOL);
        }
        public PersonalInfoBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PersonalInfoBOL[] PersonalInfoBOLs = new PersonalInfoBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string FirstName = DataConvertor.ConvertToString(row["FirstName"]);
                    string LastName = DataConvertor.ConvertToString(row["LastName"]);
                    string FatherName = DataConvertor.ConvertToString(row["FatherName"]);
                    string NationalCode = DataConvertor.ConvertToString(row["NationalCode"]);
                    string Cetificate = DataConvertor.ConvertToString(row["Cetificate"]);
                    string IssuancePlace = DataConvertor.ConvertToString(row["IssuancePlace"]);
                    string BirthPlace = DataConvertor.ConvertToString(row["BirthPlace"]);
                    DateTime? Birthday = DataConvertor.ConvertToDateTime(row["Birthday"]);
                    bool? IsMale = DataConvertor.ConvertToBoolean(row["IsMale"]);
                    bool? IsLegal = DataConvertor.ConvertToBoolean(row["IsLegal"]);
                    byte? MaritalStatuseId = DataConvertor.ConvertToByte(row["MaritalStatuseId"]);
                    string MaritalStatuseTitle = DataConvertor.ConvertToString(row["MaritalStatuseTitle"]);
                    string Phone = DataConvertor.ConvertToString(row["Phone"]);
                    string Mobile = DataConvertor.ConvertToString(row["Mobile"]);
                    byte? JobId = DataConvertor.ConvertToByte(row["JobId"]);
                    string JobTitle = DataConvertor.ConvertToString(row["JobTitle"]);
                    byte[] Image = DataConvertor.ConvertToByteArray(row["Image"]);
                    byte? MilitaryStatuseId = DataConvertor.ConvertToByte(row["MilitaryStatuseId"]);
                    string MilitaryStatuseTitle = DataConvertor.ConvertToString(row["MilitaryStatuseTitle"]);
                    string Address = DataConvertor.ConvertToString(row["Address"]);
                    string CompanyAddress = DataConvertor.ConvertToString(row["CompanyAddress"]);
                    string CompanyName = DataConvertor.ConvertToString(row["CompanyName"]);
                    string CompanyPhone = DataConvertor.ConvertToString(row["CompanyPhone"]);
                    string ZipeCode = DataConvertor.ConvertToString(row["ZipeCode"]);


                    PersonalInfoBOLs[index] = new PersonalInfoBOL(Id, FirstName, LastName, FatherName, NationalCode, Cetificate, IssuancePlace, BirthPlace, Birthday, IsMale, MaritalStatuseId, MaritalStatuseTitle,Phone, Mobile, Image, MilitaryStatuseId, MilitaryStatuseTitle, Address, JobId, JobTitle, CompanyName, CompanyAddress, CompanyPhone, IsLegal,ZipeCode);
                }
                return PersonalInfoBOLs;
            }
            return null;
        }



        public PersonalInfoBOL[] SelectLandlord()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PersonalInfoBOL[] PersonalInfoBOLs = new PersonalInfoBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string FirstName = DataConvertor.ConvertToString(row["FirstName"]);
                    string LastName = DataConvertor.ConvertToString(row["LastName"]);
                    string FatherName = DataConvertor.ConvertToString(row["FatherName"]);
                    string NationalCode = DataConvertor.ConvertToString(row["NationalCode"]);
                    string Cetificate = DataConvertor.ConvertToString(row["Cetificate"]);
                    string IssuancePlace = DataConvertor.ConvertToString(row["IssuancePlace"]);
                    string BirthPlace = DataConvertor.ConvertToString(row["BirthPlace"]);
                    DateTime? Birthday = DataConvertor.ConvertToDateTime(row["Birthday"]);
                    bool? IsMale = DataConvertor.ConvertToBoolean(row["IsMale"]);
                    bool? IsLegal = DataConvertor.ConvertToBoolean(row["IsLegal"]);
                    byte? MaritalStatuseId = DataConvertor.ConvertToByte(row["MaritalStatuseId"]);
                    string MaritalStatuseTitle = DataConvertor.ConvertToString(row["MaritalStatuseTitle"]);
                    string Phone = DataConvertor.ConvertToString(row["Phone"]);
                    string Mobile = DataConvertor.ConvertToString(row["Mobile"]);
                    byte? JobId = DataConvertor.ConvertToByte(row["JobId"]);
                    string JobTitle = DataConvertor.ConvertToString(row["JobTitle"]);
                    byte? MilitaryStatuseId = DataConvertor.ConvertToByte(row["MilitaryStatuseId"]);
                    string MilitaryStatuseTitle = DataConvertor.ConvertToString(row["MilitaryStatuseTitle"]);
                    string Address = DataConvertor.ConvertToString(row["Address"]);
                    string CompanyAddress = DataConvertor.ConvertToString(row["CompanyAddress"]);
                    string CompanyName = DataConvertor.ConvertToString(row["CompanyName"]);
                    string CompanyPhone = DataConvertor.ConvertToString(row["CompanyPhone"]);
                    string ZipeCode = DataConvertor.ConvertToString(row["ZipeCode"]);
                    


                    PersonalInfoBOLs[index] = new PersonalInfoBOL(Id, FirstName, LastName, FatherName, NationalCode, Cetificate, IssuancePlace, BirthPlace, Birthday, IsMale, MaritalStatuseId, MaritalStatuseTitle, Phone, Mobile, MilitaryStatuseId, MilitaryStatuseTitle, Address, JobId, JobTitle, CompanyName, CompanyAddress, CompanyPhone, IsLegal, ZipeCode);
                }
                return PersonalInfoBOLs;
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
        public DataTable SelectReport()
        {
            return ExecuteReader();
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case PersonalInfoDOL.QueryStatus.Select:
                    return PersonalInfoDOL.Select;
                case PersonalInfoDOL.QueryStatus.SelectLandlord:
                    return PersonalInfoDOL.SelectLandlord;
                case PersonalInfoDOL.QueryStatus.Delete:
                    return PersonalInfoDOL.Delete;
                case PersonalInfoDOL.QueryStatus.Update:
                    return PersonalInfoDOL.Update;
                case PersonalInfoDOL.QueryStatus.Insert:
                    return PersonalInfoDOL.Insert;
                case PersonalInfoDOL.QueryStatus.SelectMaxId:
                    return PersonalInfoDOL.SelectMaxId;
                case PersonalInfoDOL.QueryStatus.SelectReport:
                    return PersonalInfoDOL.SelectReport;
            }
            return string.Empty;
        }
        private void SetParameter(PersonalInfoBOL _PersonalInfoBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _PersonalInfoBOL.Id, true);
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ValidateParameter("@FirstName", _PersonalInfoBOL.FirstName, true);
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ValidateParameter("@LastName", _PersonalInfoBOL.LastName, true);
            sqlCommand.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = ValidateParameter("@FatherName", _PersonalInfoBOL.FatherName, true);
            sqlCommand.Parameters.Add("@NationalCode", SqlDbType.NVarChar).Value = ValidateParameter("@NationalCode", _PersonalInfoBOL.NationalCode, true);
            sqlCommand.Parameters.Add("@Cetificate", SqlDbType.NVarChar).Value = ValidateParameter("@Cetificate", _PersonalInfoBOL.Cetificate, true);
            sqlCommand.Parameters.Add("@IssuancePlace", SqlDbType.NVarChar).Value = ValidateParameter("@IssuancePlace", _PersonalInfoBOL.IssuancePlace, true);
            sqlCommand.Parameters.Add("@BirthPlace", SqlDbType.NVarChar).Value = ValidateParameter("@BirthPlace", _PersonalInfoBOL.BirthPlace, true);
            sqlCommand.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = ValidateParameter("@Birthday", _PersonalInfoBOL.Birthday, true);
            sqlCommand.Parameters.Add("@IsMale", SqlDbType.Bit).Value = ValidateParameter("@IsMale", _PersonalInfoBOL.IsMale, true);
            sqlCommand.Parameters.Add("@IsLegal", SqlDbType.Bit).Value = ValidateParameter("@IsLegal", _PersonalInfoBOL.IsLegal, true);
            sqlCommand.Parameters.Add("@MaritalStatuseId", SqlDbType.TinyInt).Value = ValidateParameter("@MaritalStatuseId", _PersonalInfoBOL.MaritalStatuseId, true);
            sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = ValidateParameter("@Phone", _PersonalInfoBOL.Phone, true);
            sqlCommand.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = ValidateParameter("@Mobile", _PersonalInfoBOL.Mobile, true);
            sqlCommand.Parameters.Add("@JobId", SqlDbType.TinyInt).Value = ValidateParameter("@JobId", _PersonalInfoBOL.JobId, true);
            sqlCommand.Parameters.Add("@Image", SqlDbType.Image).Value = ValidateParameter("@Image", _PersonalInfoBOL.Image, true);
            sqlCommand.Parameters.Add("@MilitaryStatuseId", SqlDbType.TinyInt).Value = ValidateParameter("@MilitaryStatuseId", _PersonalInfoBOL.MilitaryStatuseId, true);
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = ValidateParameter("@Address", _PersonalInfoBOL.Address, true);
            sqlCommand.Parameters.Add("@CompanyAddress", SqlDbType.NVarChar).Value = ValidateParameter("@CompanyAddress", _PersonalInfoBOL.CompanyAddress, true);
            sqlCommand.Parameters.Add("@CompanyPhone", SqlDbType.NVarChar).Value = ValidateParameter("@CompanyPhone", _PersonalInfoBOL.CompanyPhone, true);
            sqlCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = ValidateParameter("@CompanyName", _PersonalInfoBOL.CompanyName, true);
            sqlCommand.Parameters.Add("@ZipeCode", SqlDbType.NVarChar).Value = ValidateParameter("@ZipeCode", _PersonalInfoBOL.ZipeCode, true);

          
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
