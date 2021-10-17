using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class OutPutDOL
    {
        public const string Select = @"SELECT   Accounting.OutPut.Id, Accounting.OutPut.EventId, Accounting.OutPut.Price, Accounting.OutPut.Date, Accounting.OutPut.Description, 
                      Accounting.Event.Title AS EventTitle
FROM         Accounting.OutPut INNER JOIN
                      Accounting.Event ON Accounting.OutPut.EventId = Accounting.Event.Id
WHERE     (Accounting.OutPut.Id = @Id) AND (Accounting.OutPut.EventId = @EventId) OR
                      (Accounting.OutPut.Id = @Id) AND (@EventId IS NULL) OR
                      (Accounting.OutPut.EventId = @EventId) AND (@Id IS NULL) OR
                      (@EventId IS NULL) AND (@Id IS NULL)";
        public const string Insert = @"INSERT   
INTO            Accounting.OutPut(Id, EventId, Price, Date, Description)
VALUES     (@Id,@EventId,@Price,@Date,@Description)";

        public const string Delete = "DELETE FROM  Accounting.OutPut WHERE Id = @Id";
        public const string Update = "UPDATE    Accounting.OutPut   SET   EventId = @EventId, Price = @Price, Date = @Date, Description = @Description WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Accounting.OutPut";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
