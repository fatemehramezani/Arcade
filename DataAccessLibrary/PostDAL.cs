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
    public class PostDAL
    {
        private static SqlCommand sqlCommand;
        private static PostDOL.QueryStatus queryStatus;

        public PostDAL(PostDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public PostDAL(PostDOL.QueryStatus QueryStatusField, PostBOL _PostBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PostBOL);
        }
        public PostBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PostBOL[] PostBOLs = new PostBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? PostTypeId= DataConvertor.ConvertToInt(row["PostTypeId"]);
                    int? PersonalInfoId=DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    PostBOLs[index] = new PostBOL(Id,PostTypeId, PersonalInfoId);
                }
                return PostBOLs;
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
                case PostDOL.QueryStatus.Select:
                    return PostDOL.Select;
                case PostDOL.QueryStatus.SelectComboBox:
                    return PostDOL.SelectComboBox;
                case PostDOL.QueryStatus.Delete:
                    return PostDOL.Delete;
                case PostDOL.QueryStatus.Update:
                    return PostDOL.Update;
                case PostDOL.QueryStatus.Insert:
                    return PostDOL.Insert;
                case PostDOL.QueryStatus.SelectMaxId:
                    return PostDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(PostBOL _PostBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _PostBOL.Id, true);
            sqlCommand.Parameters.Add("@PostTypeId", SqlDbType.NVarChar).Value = ValidateParameter("@PostTypeId", _PostBOL.PersonalInfoId, true);
            sqlCommand.Parameters.Add("@PersonalInfoId", SqlDbType.NVarChar).Value = ValidateParameter("@PersonalInfoId", _PostBOL.PersonalInfoId, true);
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
        public PostBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PostBOL[] PostBOLs = new PostBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    int? PersonalInfoId = DataConvertor.ConvertToInt(row["PersonalInfoId"]);
                    int? PostTypeId= DataConvertor.ConvertToInt(row["PostTypeId"]);
                    PostBOLs[index] = new PostBOL(Id, PersonalInfoId,PostTypeId);
                }
                return PostBOLs;
            }
            return null;
        }
    }
}
