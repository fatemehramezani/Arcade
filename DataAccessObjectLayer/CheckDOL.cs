using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class CheckDOL
    {
        public const string Select = @"SELECT     Id, Number, AccountNumber, Date, AccountName, Price, BankName, ForWhom FROM         System.[Check]
WHERE     (Id = @Id OR
                      @Id IS NULL) AND (Number = @Number OR
                      @Number IS NULL) AND (AccountName = @AccountName OR
                      @AccountName IS NULL) AND (ForWhom = @ForWhom OR
                      @ForWhom IS NULL)";
        public const string Insert = @"INSERT INTO System.[Check](Id, Number, AccountNumber, Date, AccountName, Price, BankName, ForWhom) VALUES     (@Id,@Number,@AccountNumber,@Date,@AccountName,@Price,@BankName,@ForWhom)";
        //public const string SelectComboBox = @"SELECT Id, Title FROM Basic.MilitaryStatus UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string Delete = "DELETE FROM System.[Check] WHERE(Id = @Id)";
        public const string Update = "UPDATE    System.[Check] SET Id = @Id, Number = @Number, AccountNumber = @AccountNumber, Date = @Date, AccountName = @AccountName, Price = @Price, BankName = @BankName, ForWhom = @ForWhom WHERE(Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.[Check]";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
