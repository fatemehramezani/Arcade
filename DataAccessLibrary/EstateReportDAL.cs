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
    public class EstateReportDAL
    {
        private static SqlCommand sqlCommand;
        private static EstateReportDOL.QueryStatus queryStatus;

        public EstateReportDAL(EstateReportDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public EstateReportDAL(EstateReportDOL.QueryStatus QueryStatusField, EstateReportBOL _EstateReportBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_EstateReportBOL);
        }
        public DataTable Select()
        {
            DataTable table = ExecuteReader();
            //DataRow row;
            //if (table.Rows.Count > 0)
            //{
            //    EstateReportBOL[] EstateReportBOLs = new EstateReportBOL[table.Rows.Count];
            //    for (int index = 0; index < table.Rows.Count; index++)
            //    {
            //        row = table.Rows[index];
            //        decimal? Price = DataConvertor.ConvertToDecimal(row["Price"]);
            //        string Title = DataConvertor.ConvertToString(row["Title"]);
            //        DateTime? Date = DataConvertor.ConvertToDateTime(row["InputDate"]);
            //        string FirstName = DataConvertor.ConvertToString(row["FirstName"]);
            //        string LastName = DataConvertor.ConvertToString(row["LastName"]);
            //        string Name = DataConvertor.ConvertToString(row["Name"]);
            //        string Description = DataConvertor.ConvertToString(row["Description"]);
            //        EstateReportBOLs[index] = new EstateReportBOL(Price, Title, Date, FirstName, LastName, Name, Description);
            //    }
                return table;
            //}eturn null;
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
                case EstateReportDOL.QueryStatus.Select:
                    return EstateReportDOL.Select;
                case EstateReportDOL.QueryStatus.SelectComboBox:
                    return EstateReportDOL.SelectComboBox;
                case EstateReportDOL.QueryStatus.Delete:
                    return EstateReportDOL.Delete;
                case EstateReportDOL.QueryStatus.Update:
                    return EstateReportDOL.Update;
                case EstateReportDOL.QueryStatus.Insert:
                    return EstateReportDOL.Insert;
                case EstateReportDOL.QueryStatus.SelectMaxId:
                    return EstateReportDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(EstateReportBOL _EstateReportBOL)
        {
 //           EstateReportBOLs[index] = new EstateReportBOL(Price, Title, Date, FirstName, LastName, Name, Description);

            sqlCommand.Parameters.Add("@Price", SqlDbType.Money).Value = ValidateParameter("@Price", _EstateReportBOL.Price, true);
            sqlCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ValidateParameter("@Title", _EstateReportBOL.Title, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _EstateReportBOL.Date, true);
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ValidateParameter("@FirstName", _EstateReportBOL.FitsName, true);
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ValidateParameter("@LastName", _EstateReportBOL.LastName, true);
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = ValidateParameter("@Name", _EstateReportBOL.Name, true);
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
        //public EstateReportBOL[] SelectComboBox()
        //{
        //    DataTable table = ExecuteReader();
        //    DataRow row;
        //    if (table.Rows.Count > 0)
        //    {
        //        EstateReportBOL[] EstateReportBOLs = new EstateReportBOL[table.Rows.Count];
        //        for (int index = 0; index < table.Rows.Count; index++)
        //        {
        //            row = table.Rows[index];
        //            byte? Id = DataConvertor.ConvertToByte(row["Id"]);
        //            string Title = DataConvertor.ConvertToString(row["Title"]);
        //            EstateReportBOLs[index] = new EstateReportBOL(Id, Title);
        //        }
        //        return EstateReportBOLs;
        //    }
        //    return null;
        //}
    }
}
