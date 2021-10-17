using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class MilitaryStatusDOL
    {
        public const string Select = @"SELECT Id,Title FROM Basic.MilitaryStatus WHERE (Id = @Id) AND (Title = @Title) OR (@Id IS NULL) AND (@Title IS NULL)";
        public const string Insert = @"INSERT INTO Basic.MilitaryStatus (Id, Title) VALUES (@Id,@Title)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Basic.MilitaryStatus UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Basic.MilitaryStatus WHERE(Id = @Id)";
        public const string Update = "UPDATE Basic.MilitaryStatus SET Title = @Title WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Basic.MilitaryStatus";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
