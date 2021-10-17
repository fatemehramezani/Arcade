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
    public class EstateDAL
    {
        private static SqlCommand sqlCommand;
        private static EstateDOL.QueryStatus queryStatus;

        public EstateDAL(EstateDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public EstateDAL(EstateDOL.QueryStatus QueryStatusField, EstateBOL _EstateBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_EstateBOL);
        }
        public EstateBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EstateBOL[] EstateBOLs = new EstateBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string ZipCode = DataConvertor.ConvertToString(row["ZipCode"]);
                    int? Area = DataConvertor.ConvertToInt(row["Area"]);
                    string Facilities = DataConvertor.ConvertToString(row["Facilities"]);
                    byte? Floor = DataConvertor.ConvertToByte(row["Floor"]);
                    string Address = DataConvertor.ConvertToString(row["Address"]);
                    string Phone = DataConvertor.ConvertToString(row["Phone"]);
                    byte? EstateTypeId = DataConvertor.ConvertToByte(row["EstateTypeId"]);
                    string EstateTypeTitle = DataConvertor.ConvertToString(row["EstateTypeTitle"]);

                    string Name = DataConvertor.ConvertToString(row["Name"]);
                  
                    EstateBOLs[index] = new EstateBOL(Id,ZipCode,Area,Facilities,Floor,Address,Phone,EstateTypeId,EstateTypeTitle,Name);
                }
                return EstateBOLs;
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
                case EstateDOL.QueryStatus.Select:
                    return EstateDOL.Select;
                case EstateDOL.QueryStatus.SelectComboBox:
                    return EstateDOL.SelectComboBox;
                case EstateDOL.QueryStatus.SelectComboBoxLandLord:
                    return EstateDOL.SelectComboBoxLandLord;
                case EstateDOL.QueryStatus.Delete:
                    return EstateDOL.Delete;
                case EstateDOL.QueryStatus.Update:
                    return EstateDOL.Update;
                case EstateDOL.QueryStatus.Insert:
                    return EstateDOL.Insert;
                case EstateDOL.QueryStatus.SelectMaxId:
                    return EstateDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(EstateBOL _EstateBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _EstateBOL.Id, true);
            sqlCommand.Parameters.Add("@ZipCode", SqlDbType.NVarChar).Value = ValidateParameter("@ZipCode", _EstateBOL.ZipCode, true);
            sqlCommand.Parameters.Add("@Area", SqlDbType.Int).Value = ValidateParameter("@Area", _EstateBOL.Area, true);
            sqlCommand.Parameters.Add("@Floor", SqlDbType.TinyInt).Value = ValidateParameter("@Floor", _EstateBOL.Floor, true);
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = ValidateParameter("@Adress", _EstateBOL.Address, true);

            sqlCommand.Parameters.Add("@Facilities", SqlDbType.NVarChar).Value = ValidateParameter("@Facilities", _EstateBOL.Facilities, true);
            sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = ValidateParameter("@Phone", _EstateBOL.Phone, true);
            sqlCommand.Parameters.Add("@EstateTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@EstateTypeId", _EstateBOL.EstateTypeId, true);
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = ValidateParameter("@Name", _EstateBOL.Name, true);
      
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
        public EstateBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EstateBOL[] EstateBOLs = new EstateBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    EstateBOLs[index] = new EstateBOL { Id = Id, Title = Title };
                }
                return EstateBOLs;
            }
            return null;
        }
    
      public EstateBOL[] SelectComboBoxLandLord(int? PersonalInfoId)
        {
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.Int).Value = ValidateParameter("@PersonalInfoId", PersonalInfoId, true);
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EstateBOL[] EstateBOLs = new EstateBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    EstateBOLs[index] = new EstateBOL { Id = Id, Title = Title };
                }
                return EstateBOLs;
            }
            return null;
        }
    }
}
