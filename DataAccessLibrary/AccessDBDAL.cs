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
    using System.Data.OleDb;
    public class AccessDBDAL
    {
        private static SqlCommand sqlCommand;
        private static AccessDBDOL.QueryStatus queryStatus;
        static string Path;
        public AccessDBDAL(AccessDBDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public AccessDBDAL(AccessDBDOL.QueryStatus QueryStatusField, AccessDBBOL _AccessDBBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_AccessDBBOL);
        }
        public AccessDBBOL[] Select(string path)
        {
            
            DataTable table = ExecuteReader(path);
            DataRow row;
            if (table.Rows.Count > 0)
            {
                AccessDBBOL[] AccessDBBOLs = new AccessDBBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Code = DataConvertor.ConvertToInt(row["n_parvandeh"]);
                    bool? IsMale= DataConvertor.ConvertToBoolean(row["jensiat"]);
                    DateTime? FormationDate = DataConvertor.ConvertToDateTime(row["tar_tashkil_par"]);
                    string FirstName = DataConvertor.ConvertToString(row["name"]);
                    string LastName = DataConvertor.ConvertToString(row["shohrat"]);
                    string FatherName = DataConvertor.ConvertToString(row["nampedar"]);
                    DateTime? BirthDate = DataConvertor.ConvertToDateTime(row["tar_tavalod"]);
                    string Certificate = DataConvertor.ConvertToString(row["n_shenasnameh"]);
                    string IssuancePlace = DataConvertor.ConvertToString(row["mahal_s"]);
                    byte? SectId = DataConvertor.ConvertToByte(row["cod_Mazhab"]);
                    byte? MilitaryStatusId = DataConvertor.ConvertToByte(row["nezam"]);
                    byte? Ostan = DataConvertor.ConvertToByte(row["cod_ostan_s"]);
                    byte? CityCode=DataConvertor.ConvertToByte(row["cod_shar_s"]);
                    string Address=DataConvertor.ConvertToString(row["addres_s"]);
                    byte? DegreeId = DataConvertor.ConvertToByte(row["DegreeTitle"]);
                    string Field=DataConvertor.ConvertToString(row["reshte_t"]);
                    string DegreeAddress=DataConvertor.ConvertToString(row["addres_t"]);
                    bool? StatusId=DataConvertor.ConvertToBoolean(row["vazeiyat_f"]);
                    string AliasesFirstName = DataConvertor.ConvertToString(row["name_m"]);
                    string AliasesLastName = DataConvertor.ConvertToString(row["shohrat_m"]);
                    bool? IsAlive = DataConvertor.ConvertToBoolean(row["Life"]);
                    string Serial = DataConvertor.ConvertToString(row["n_serial"]);
                    bool? Isforeigner=DataConvertor.ConvertToBoolean(row["atbaebigane"]);

                    AccessDBBOLs[index] = new AccessDBBOL(null, Code, IsMale, FormationDate, FirstName, LastName, FatherName, BirthDate, Certificate, IssuancePlace, SectId, MilitaryStatusId,
                    Ostan, CityCode, Address, DegreeId, Field, DegreeAddress, StatusId, AliasesFirstName, AliasesLastName, IsAlive, Isforeigner, Serial);//, ReligionId);
        
                }
                return AccessDBBOLs;
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
                case AccessDBDOL.QueryStatus.Select:
                    return AccessDBDOL.Select;
                //case AccessDBDOL.QueryStatus.SelectComboBox:
                //    return AccessDBDOL.SelectComboBox;
                case AccessDBDOL.QueryStatus.Delete:
                    return AccessDBDOL.Delete;
                case AccessDBDOL.QueryStatus.Update:
                    return AccessDBDOL.Update;
                case AccessDBDOL.QueryStatus.Insert:
                    return AccessDBDOL.Insert;
                case AccessDBDOL.QueryStatus.SelectMaxId:
                    return AccessDBDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(AccessDBBOL _AccessDBBOL)
        {
            sqlCommand.Parameters.Add("@n_parvandeh", SqlDbType.Int).Value = ValidateParameter("@n_parvandeh", _AccessDBBOL.Code, true);
            sqlCommand.Parameters.Add("@jensiat", SqlDbType.Bit).Value = ValidateParameter("@jensiat", _AccessDBBOL.IsMale, true);
            sqlCommand.Parameters.Add("@tar_tashkil_par", SqlDbType.DateTime).Value = ValidateParameter("@tar_tashkil_par", _AccessDBBOL.FormationDate, true);
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = ValidateParameter("@name", _AccessDBBOL.FirstName, true);
            sqlCommand.Parameters.Add("@shohrat", SqlDbType.NVarChar).Value = ValidateParameter("@shohrat", _AccessDBBOL.LastName, true);
            sqlCommand.Parameters.Add("@nampedar", SqlDbType.NVarChar).Value = ValidateParameter("@Price", _AccessDBBOL.FatherName, true);
            sqlCommand.Parameters.Add("@tar_tavalod", SqlDbType.DateTime).Value = ValidateParameter("@tar_tavalod", _AccessDBBOL.BirthDate, true);
            sqlCommand.Parameters.Add("@seri_shenasnameh", SqlDbType.NVarChar).Value = ValidateParameter("@seri_shenasnameh", _AccessDBBOL.Serial, true);
            sqlCommand.Parameters.Add("@n_shenasnameh", SqlDbType.NVarChar).Value = ValidateParameter("@n_shenasnameh", _AccessDBBOL.Certificate, true);
            sqlCommand.Parameters.Add("@mahal_s", SqlDbType.NVarChar).Value = ValidateParameter("@mahal_s", _AccessDBBOL.IssuancePlace, true);
            sqlCommand.Parameters.Add("@cod_Din", SqlDbType.NVarChar).Value = ValidateParameter("@cod_Din", _AccessDBBOL.ReligionId, true);
            sqlCommand.Parameters.Add("@cod_Mazhab", SqlDbType.NVarChar).Value = ValidateParameter("@cod_Mazhab", _AccessDBBOL.SectId, true);
            sqlCommand.Parameters.Add("@cod_Mazhab", SqlDbType.NVarChar).Value = ValidateParameter("@cod_Mazhab", _AccessDBBOL.SectId, true);
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
        private static DataTable ExecuteReader(string path)
        {
            Path = path;
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0;data source="+path;
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
           // myOleDbCommand.CommandText = AccessDBDOL.QueryStatus.Select.ToString();
            AccessDBBOL _AccessBOL = new AccessDBBOL();
            
            //_AccessBLL.Select(_AccessBOL,connectionString);
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
        //public AccessDBBOL[] SelectComboBox()
        //{
        //    DataTable table = ExecuteReader();
        //    DataRow row;
        //    if (table.Rows.Count > 0)
        //    {
        //        AccessDBBOL[] AccessDBBOLs = new AccessDBBOL[table.Rows.Count];
        //        for (int index = 0; index < table.Rows.Count; index++)
        //        {
        //            row = table.Rows[index];
        //            int? Code = DataConvertor.ConvertToInt(row["n_parvandeh"]);
        //            bool? IsMale = DataConvertor.ConvertToBoolean(row["jensiat"]);
        //            DateTime? FormationDate = DataConvertor.ConvertToDateTime(row["tar_tashkil_par"]);
        //            string FirstName = DataConvertor.ConvertToString(row["name"]);
        //            string LastName = DataConvertor.ConvertToString(row["shohrat"]);
        //            string FatherName = DataConvertor.ConvertToString(row["nampedar"]);
        //            DateTime? BirthDate = DataConvertor.ConvertToDateTime(row["tar_tavalod"]);
        //            string Certificate = DataConvertor.ConvertToString(row["n_shenasnameh"]);
        //            string IssuancePlace = DataConvertor.ConvertToString(row["mahal_s"]);
        //            byte? SectId = DataConvertor.ConvertToByte(row["cod_Mazhab"]);
        //            byte? MilitaryStatusId = DataConvertor.ConvertToByte(row["nezam"]);
        //            byte? Ostan = DataConvertor.ConvertToByte(row["cod_ostan_s"]);
        //            byte? CityCode = DataConvertor.ConvertToByte(row["cod_shar_s"]);
        //            string Address = DataConvertor.ConvertToString(row["addres_s"]);
        //            byte? DegreeId = DataConvertor.ConvertToByte(row["DegreeTitle"]);
        //            string Field = DataConvertor.ConvertToString(row["reshte_t"]);
        //            string DegreeAddress = DataConvertor.ConvertToString(row["addres_t"]);
        //            bool? StatusId = DataConvertor.ConvertToBoolean(row["vazeiyat_f"]);
        //            string AliasesFirstName = DataConvertor.ConvertToString(row["name_m"]);
        //            string AliasesLastName = DataConvertor.ConvertToString(row["shohrat_m"]);
        //            bool? IsAlive = DataConvertor.ConvertToBoolean(row["Life"]);
        //            string Serial = DataConvertor.ConvertToString(row["n_serial"]);
        //            bool? Isforeigner = DataConvertor.ConvertToBoolean(row["atbaebigane"]);

        //            AccessDBBOLs[index] = new AccessDBBOL(null, Code, IsMale, FormationDate, FirstName, LastName, FatherName, BirthDate, Certificate, IssuancePlace, SectId, MilitaryStatusId,
        //            Ostan, CityCode, Address, DegreeId, Field, DegreeAddress, StatusId, AliasesFirstName, AliasesLastName, IsAlive, Isforeigner, Serial);//, ReligionId);
        //        }
        //        return AccessDBBOLs;
        //    }
        //    return null;
        //}
    }
}
