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
    public class EventDAL
    {
        private static SqlCommand sqlCommand;
        private static EventDOL.QueryStatus queryStatus;

        public EventDAL(EventDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public EventDAL(EventDOL.QueryStatus QueryStatusField, EventBOL _EventBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_EventBOL);
        }
        public EventBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EventBOL[] EventBOLs = new EventBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    string Description = DataConvertor.ConvertToString(row["Description"]);
                    string EstateIds = DataConvertor.ConvertToString(row["EstateIds"]);

                    EventBOLs[index] = new EventBOL(Id, Title,Description,EstateIds);
                }
                return EventBOLs;
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
                case EventDOL.QueryStatus.Select:
                    return EventDOL.Select;
                case EventDOL.QueryStatus.SelectComboBox:
                    return EventDOL.SelectComboBox;
                case EventDOL.QueryStatus.Delete:
                    return EventDOL.Delete;
                case EventDOL.QueryStatus.Update:
                    return EventDOL.Update;
                case EventDOL.QueryStatus.Insert:
                    return EventDOL.Insert;
                case EventDOL.QueryStatus.SelectMaxId:
                    return EventDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(EventBOL _EventBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _EventBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _EventBOL.Title, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _EventBOL.Description, true);
            sqlCommand.Parameters.Add("@EstateIds", SqlDbType.NVarChar).Value = ValidateParameter("@EstateIds", _EventBOL.EstateIds, true);

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
        public EventBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EventBOL[] EventBOLs = new EventBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    EventBOLs[index] = new EventBOL{Id=Id, Title=Title};
                }
                return EventBOLs;
            }
            return null;
        }
    }
}
