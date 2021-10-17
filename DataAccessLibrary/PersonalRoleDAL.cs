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
    
    public class PersonalRoleDAL
    {
        private static SqlCommand sqlCommand;
        private static PersonalRoleDOL.QueryStatus queryStatus;

        public PersonalRoleDAL(PersonalRoleDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public PersonalRoleDAL(PersonalRoleDOL.QueryStatus QueryStatusField, PersonalRoleBOL _PersonalRoleBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PersonalRoleBOL);
        }
        public PersonalRoleBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PersonalRoleBOL[] PersonalRoleBOLs = new PersonalRoleBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    byte? RoleTypeId = DataConvertor.ConvertToByte(row["RoleTypeId"]);
                    string RoleTypeTitle = DataConvertor.ConvertToString(row["RoleTypeTitle"]);
                    int? PersonalInfoId = DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    string FirstName = DataConvertor.ConvertToString(row["FirstName"]);
                    string LastName = DataConvertor.ConvertToString(row["LastName"]);


                    PersonalRoleBOLs[index] = new PersonalRoleBOL(Id,RoleTypeId,RoleTypeTitle,PersonalInfoId,FirstName,LastName);
                }
                return PersonalRoleBOLs;
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
                case PersonalRoleDOL.QueryStatus.Select:
                    return PersonalRoleDOL.Select;
                //case PersonalRoleDOL.QueryStatus.SelectComboBox:
                //    return PersonalRoleDOL.SelectComboBox;
                case PersonalRoleDOL.QueryStatus.Delete:
                    return PersonalRoleDOL.Delete;
                case PersonalRoleDOL.QueryStatus.Update:
                    return PersonalRoleDOL.Update;
                case PersonalRoleDOL.QueryStatus.Insert:
                    return PersonalRoleDOL.Insert;
                case PersonalRoleDOL.QueryStatus.SelectMaxId:
                    return PersonalRoleDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(PersonalRoleBOL _PersonalRoleBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _PersonalRoleBOL.Id, true);
            sqlCommand.Parameters.Add("@RoleTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@RoleTypeId", _PersonalRoleBOL.RoleTypeId, true);
            sqlCommand.Parameters.Add("@RoleTypeTitle", SqlDbType.NVarChar).Value = ValidateParameter("@RoleTypeTitle", _PersonalRoleBOL.RoleTypeTitle, true);
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.Int).Value = ValidateParameter("@PersonalInfoId", _PersonalRoleBOL.PersonalInfoId, true);
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ValidateParameter("@FirstName", _PersonalRoleBOL.FirstName, true);
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ValidateParameter("@LastName", _PersonalRoleBOL.LastName, true);

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
