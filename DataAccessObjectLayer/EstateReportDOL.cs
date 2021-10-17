using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class EstateReportDOL
    {
        public const string Select = @"SELECT * FROM         arcadeAdmin.reportEstate";
        public const string Insert = @"INSERT INTO Basic.EstateReport (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Basic.EstateReport UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Basic.EstateReport WHERE(Id = @Id)";
        public const string Update = "UPDATE Basic.EstateReport SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Basic.EstateReport";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
