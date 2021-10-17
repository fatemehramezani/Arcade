using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class EventDOL
    {
        public const string Select = @"SELECT    Id, Title, Description, EstateIds   FROM         Accounting.Event  WHERE     (Id = @Id OR @Id IS NULL)";
        public const string Insert = @"INSERT   INTO            Accounting.Event(Id, Title, Description, EstateIds)  VALUES     (@Id,@Title,@Description,@EstateIds)";
        public const string SelectComboBox = @"SELECT Id, Title FROM Accounting.Event UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM Accounting.Event  WHERE(Id = @Id)";
        public const string Update = "UPDATE  Accounting.Event  SET  Title = @Title, Description = @Description, EstateIds = @EstateIds  WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Accounting.Event";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
