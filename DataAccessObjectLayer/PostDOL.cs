using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class PostDOL
    {
        public const string Select = @"SELECT Id,Title FROM Basic.Post WHERE (Id = @Id) AND (Title = @Title) OR (@Id IS NULL) AND (@Title IS NULL)";
        public const string Insert = @"INSERT INTO Basic.Post (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Basic.Post UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Basic.Post WHERE(Id = @Id)";
        public const string Update = "UPDATE Basic.Post SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Basic.Post";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
