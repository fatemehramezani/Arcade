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
    public class JobDAL
    {
        private static SqlCommand sqlCommand;
        private static JobDOL.QueryStatus queryStatus;

        public JobDAL(JobDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public JobDAL(JobDOL.QueryStatus QueryStatusField, JobBOL _JobBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_JobBOL);
        }
        public JobBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                JobBOL[] JobBOLs = new JobBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    JobBOLs[index] = new JobBOL(Id, Title);
                }
                return JobBOLs;
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
                case JobDOL.QueryStatus.Select:
                    return JobDOL.Select;
                case JobDOL.QueryStatus.SelectComboBox:
                    return JobDOL.SelectComboBox;
                case JobDOL.QueryStatus.Delete:
                    return JobDOL.Delete;
                case JobDOL.QueryStatus.Update:
                    return JobDOL.Update;
                case JobDOL.QueryStatus.Insert:
                    return JobDOL.Insert;
                case JobDOL.QueryStatus.SelectMaxId:
                    return JobDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(JobBOL _JobBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _JobBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _JobBOL.Title, true);
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
        public JobBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                JobBOL[] JobBOLs = new JobBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    JobBOLs[index] = new JobBOL(Id, Title);
                }
                return JobBOLs;
            }
            return null;
        }
    }
}
