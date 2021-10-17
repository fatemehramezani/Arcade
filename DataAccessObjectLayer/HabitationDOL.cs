using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class HabitationDOL
    {
        public const string Select = @"SELECT Id, Title FROM Habitation WHERE (Id = @Id OR @Id IS NULL) AND (Title = @Title OR @Title IS NULL)";
        public const string Insert = @"INSERT INTO Habitation (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Habitation UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Habitation WHERE Id =@Id";
        public const string Update = "UPDATE Habitation SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Habitation";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
