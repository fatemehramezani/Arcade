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
    public class ConstractionDAL
    {
        private static SqlCommand sqlCommand;
        private static ConstractionDOL.QueryStatus queryStatus;

        public ConstractionDAL(ConstractionDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ConstractionDAL(ConstractionDOL.QueryStatus QueryStatusField, ConstractionBOL _ConstractionBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ConstractionBOL);
        }
        public ConstractionBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ConstractionBOL[] ConstractionBOLs = new ConstractionBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    DateTime? StartDate = DataConvertor.ConvertToDateTime(row["StartDate"]);
                    DateTime? DeliveryDate = DataConvertor.ConvertToDateTime(row["DeliveryDate"]);
                    int? UnitNumber = DataConvertor.ConvertToInt(row["UnitNumber"]);
                    int? EstateId = DataConvertor.ConvertToInt(row["EstateId"]);
                    byte? EstateTypeId= DataConvertor.ConvertToByte(row["EstateTypeId"]);
                    int? Floor= DataConvertor.ConvertToInt(row["EstateFloor"]);
                    string ConstractorName = DataConvertor.ConvertToString(row["ConstractorName"]);
                    string EstateTypeTitle = DataConvertor.ConvertToString(row["EstateTypeTitle"]);
                    ConstractionBOLs[index] = new ConstractionBOL(Id, StartDate, DeliveryDate, UnitNumber, EstateId, EstateTypeId, Floor, ConstractorName, EstateTypeTitle);
                }
                return ConstractionBOLs;
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
                case ConstractionDOL.QueryStatus.Select:
                    return ConstractionDOL.Select;
                case ConstractionDOL.QueryStatus.SelectComboBox:
                    return ConstractionDOL.SelectComboBox;
                case ConstractionDOL.QueryStatus.Delete:
                    return ConstractionDOL.Delete;
                case ConstractionDOL.QueryStatus.Update:
                    return ConstractionDOL.Update;
                case ConstractionDOL.QueryStatus.Insert:
                    return ConstractionDOL.Insert;
                case ConstractionDOL.QueryStatus.SelectMaxId:
                    return ConstractionDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(ConstractionBOL _ConstractionBOL)
        {
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ValidateParameter("@Id", _ConstractionBOL.Id, true);
            sqlCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = ValidateParameter("@StartDate", _ConstractionBOL.StartDate, true);
            sqlCommand.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = ValidateParameter("@DeliveryDate", _ConstractionBOL.DeliveryDate, true);
            sqlCommand.Parameters.Add("@UnitNumber", SqlDbType.TinyInt).Value = ValidateParameter("@UnitNumber", _ConstractionBOL.UnitNumber, true);
            sqlCommand.Parameters.Add("@EstateId", SqlDbType.Int).Value = ValidateParameter("@EstateId", _ConstractionBOL.EstateId, true);
            sqlCommand.Parameters.Add("@EstateTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@EstateTypeId", _ConstractionBOL.EstateTypeId, true);
            sqlCommand.Parameters.Add("@EstateFloor", SqlDbType.TinyInt).Value = ValidateParameter("@EstateFloor", _ConstractionBOL.EstateFloor, true);
            sqlCommand.Parameters.Add("@ConstractorName", SqlDbType.NVarChar).Value = ValidateParameter("@ConstractorName", _ConstractionBOL.ConstractorName, true);
            sqlCommand.Parameters.Add("@EstateTypeTitle", SqlDbType.NVarChar).Value = ValidateParameter("@EstateTypeTitle", _ConstractionBOL.EstateTypeTitle, true);
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
        public ConstractionBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ConstractionBOL[] ConstractionBOLs = new ConstractionBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];

                    int? Id = DataConvertor.ConvertToInt(row["Id"]);
                    DateTime? StartDate = DataConvertor.ConvertToDateTime(row["StartDate"]);
                    DateTime? DeliveryDate = DataConvertor.ConvertToDateTime(row["DeliveryDate"]);
                    int? UnitNumber = DataConvertor.ConvertToInt(row["UnitNumber"]);
                    int? EstateId = DataConvertor.ConvertToInt(row["EstateId"]);
                    byte? EstateTypeId = DataConvertor.ConvertToByte(row["EstateTypeId"]);
                    int? Floor = DataConvertor.ConvertToInt(row["Floor"]);
                    string ConstractorName = DataConvertor.ConvertToString(row["ConstractorName"]);
                    string EstateTypeTitle = DataConvertor.ConvertToString(row["EstateTypeTitle"]);
                    ConstractionBOLs[index] = new ConstractionBOL(Id, StartDate, DeliveryDate, UnitNumber, EstateId, EstateTypeId, Floor, ConstractorName, EstateTypeTitle);
                }
                return ConstractionBOLs;
            }
            return null;
        }
    }
}
