using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class InputDOL
    {
        public const string Select = @"SELECT   Accounting.InPut.Id, Accounting.InPut.EstateId, Accounting.InPut.EventId, Accounting.InPut.Price, Accounting.InPut.Date, Accounting.InPut.Description, 
                      Accounting.Event.Title AS EventTitle, 
                      System.Estate.Address + '  --- ' + 'کدپستی' + System.Estate.ZipCode + ' ---  ' + 'تلفن' + System.Estate.Phone + ' ---  ' + 'طبقه' + CAST(System.Estate.Floor AS NVARCHAR(3)) + ' --- ' + 'کد ملک' + System.Estate.Name
                      AS Title
FROM         Accounting.InPut LEFT OUTER JOIN
                      System.Estate ON Accounting.InPut.EstateId = System.Estate.Id LEFT OUTER JOIN
                      Accounting.Event ON Accounting.InPut.EventId = Accounting.Event.Id
WHERE     (Accounting.InPut.Id = @Id) AND (Accounting.InPut.EstateId = @EstateId) AND (Accounting.InPut.EventId = @EventId) OR
                      (Accounting.InPut.Id = @Id) AND (Accounting.InPut.EventId = @EventId) AND (@EstateId IS NULL) OR
                      (Accounting.InPut.EstateId = @EstateId) AND (Accounting.InPut.EventId = @EventId) AND (@Id IS NULL) OR
                      (Accounting.InPut.EventId = @EventId) AND (@EstateId IS NULL) AND (@Id IS NULL) OR
                      (Accounting.InPut.Id = @Id) AND (Accounting.InPut.EstateId = @EstateId) AND (@EventId IS NULL) OR
                      (Accounting.InPut.Id = @Id) AND (@EstateId IS NULL) AND (@EventId IS NULL) OR
                      (Accounting.InPut.EstateId = @EstateId) AND (@Id IS NULL) AND (@EventId IS NULL) OR
                      (@EstateId IS NULL) AND (@Id IS NULL) AND (@EventId IS NULL)";
        public const string Insert = @"INSERT     
INTO            Accounting.InPut(Id, EstateId, EventId, Price, Date, Description)
VALUES     (@Id,@EstateId,@EventId,@Price,@Date,@Description)";

        public const string Delete = "DELETE FROM  Accounting.InPut WHERE Id = @Id";
        public const string Update = "UPDATE    Accounting.InPut   SET  EstateId = @EstateId, EventId = @EventId, Price = @Price, Date = @Date, Description = @Description WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Accounting.InPut";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
