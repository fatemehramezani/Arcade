using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class InsuranceStatusDOL
    {
        public const string Select = @"SELECT Id, Title FROM InsuranceStatus WHERE (Id = @Id OR @Id IS NULL) AND (Title = @Title OR @Title IS NULL)";
        public const string Insert = @"INSERT INTO InsuranceStatus (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM InsuranceStatus UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM InsuranceStatus WHERE Id =@Id";
        public const string Update = "UPDATE InsuranceStatus SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM InsuranceStatus";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
