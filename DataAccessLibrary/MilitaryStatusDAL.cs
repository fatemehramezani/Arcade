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
    public class MilitaryStatusDAL
    {
        private static SqlCommand sqlCommand;
        private static MilitaryStatusDOL.QueryStatus queryStatus;

        public MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public MilitaryStatusDAL(MilitaryStatusDOL.QueryStatus QueryStatusField, MilitaryStatusBOL _MilitaryStatusBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_MilitaryStatusBOL);
        }
        public MilitaryStatusBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                MilitaryStatusBOL[] MilitaryStatusBOLs = new MilitaryStatusBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    MilitaryStatusBOLs[index] = new MilitaryStatusBOL(Id, Title);
                }
                return MilitaryStatusBOLs;
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
                case MilitaryStatusDOL.QueryStatus.Select:
                    return MilitaryStatusDOL.Select;
                case MilitaryStatusDOL.QueryStatus.SelectComboBox:
                    return MilitaryStatusDOL.SelectComboBox;
                case MilitaryStatusDOL.QueryStatus.Delete:
                    return MilitaryStatusDOL.Delete;
                case MilitaryStatusDOL.QueryStatus.Update:
                    return MilitaryStatusDOL.Update;
                case MilitaryStatusDOL.QueryStatus.Insert:
                    return MilitaryStatusDOL.Insert;
                case MilitaryStatusDOL.QueryStatus.SelectMaxId:
                    return MilitaryStatusDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(MilitaryStatusBOL _MilitaryStatusBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _MilitaryStatusBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _MilitaryStatusBOL.Title, true);
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
        public MilitaryStatusBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                MilitaryStatusBOL[] MilitaryStatusBOLs = new MilitaryStatusBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    MilitaryStatusBOLs[index] = new MilitaryStatusBOL(Id, Title);
                }
                return MilitaryStatusBOLs;
            }
            return null;
        }
    }
}
