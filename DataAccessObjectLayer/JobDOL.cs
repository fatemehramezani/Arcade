using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class JobDOL
    {
        public const string Select = @"SELECT Id,Title FROM Basic.Job WHERE (Id = @Id OR @Id IS NULL) AND (Title = @Title  OR @Title IS NULL)";
        public const string Insert = @"INSERT INTO Basic.Job (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Basic.Job UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Basic.Job WHERE(Id = @Id)";
        public const string Update = "UPDATE Basic.Job SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Basic.Job";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
