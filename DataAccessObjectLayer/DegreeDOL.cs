using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class DegreeDOL
    {
        public const string Select = @"SELECT Id, Title FROM Degree WHERE (Id = @Id OR @Id IS NULL) AND (Title = @Title OR @Title IS NULL)";
        public const string Insert = @"INSERT INTO Degree (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Degree UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Degree WHERE Id =@Id";
        public const string Update = "UPDATE Degree SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Degree";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
