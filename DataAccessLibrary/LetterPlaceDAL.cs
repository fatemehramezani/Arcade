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
    
    public class LetterPlaceDAL
    {
        private static SqlCommand sqlCommand;
        private static LetterPlaceDOL.QueryStatus queryStatus;

        public LetterPlaceDAL(LetterPlaceDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LetterPlaceDAL(LetterPlaceDOL.QueryStatus QueryStatusField, LetterPlaceBOL _LetterPlaceBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LetterPlaceBOL);
        }
        public LetterPlaceBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LetterPlaceBOL[] LetterPlaceBOLs = new LetterPlaceBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    LetterPlaceBOLs[index] = new LetterPlaceBOL(Id,Title);
                }
                return LetterPlaceBOLs;
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
        public long? SelectMaxId()
        {
            return DataConvertor.ConvertToLong(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case LetterPlaceDOL.QueryStatus.Select:
                    return LetterPlaceDOL.Select;
                case LetterPlaceDOL.QueryStatus.SelectComboBox:
                    return LetterPlaceDOL.SelectComboBox;
                case LetterPlaceDOL.QueryStatus.Delete:
                    return LetterPlaceDOL.Delete;
                case LetterPlaceDOL.QueryStatus.Update:
                    return LetterPlaceDOL.Update;
                case LetterPlaceDOL.QueryStatus.Insert:
                    return LetterPlaceDOL.Insert;
                case LetterPlaceDOL.QueryStatus.SelectMaxId:
                    return LetterPlaceDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(LetterPlaceBOL _LetterPlaceBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.TinyInt).Value = ValidateParameter("@Id", _LetterPlaceBOL.Id, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _LetterPlaceBOL.Title, true);
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
        public LetterPlaceBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LetterPlaceBOL[] LetterPlaceBOLs = new LetterPlaceBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    byte? Id = DataConvertor.ConvertToByte(row["Id"]);
                    string Title = DataConvertor.ConvertToString(row["Title"]);
                    LetterPlaceBOLs[index] = new LetterPlaceBOL(Id,Title);
                }
                return LetterPlaceBOLs;
            }
            return null;
        }
    }
}
