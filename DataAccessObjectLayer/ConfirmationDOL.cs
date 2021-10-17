using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class ConfirmationDOL
    {
        public const string Select = @"SELECT Id, Title FROM Confirmation WHERE (Id = @Id OR @Id IS NULL) AND (Title = @Title OR @Title IS NULL)";
        public const string Insert = @"INSERT INTO Confirmation (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Confirmation UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Confirmation WHERE Id =@Id";
        public const string Update = "UPDATE Confirmation SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Confirmation";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
