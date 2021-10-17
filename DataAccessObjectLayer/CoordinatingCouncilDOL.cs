using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class CoordinatingCouncilDOL
    {
        public const string Select = @"SELECT  Id, FirstName, LastName, FatherName, MembershipDate, NationalCode, QuitDate  FROM         System.CoordinatingCouncil  WHERE     (Id = @Id) OR        (@Id IS NULL)";
        public const string Insert = @"INSERT   INTO      System.CoordinatingCouncil(Id, FirstName, LastName, FatherName, MembershipDate, NationalCode, QuitDate) VALUES     (@Id,@FirstName,@LastName,@FatherName,@MembershipDate,@NationalCode,@QuitDate)";
        public const string Delete = "DELETE FROM System.CoordinatingCouncil WHERE Id =@Id";
        public const string Update = "UPDATE    System.CoordinatingCouncil   SET              FirstName = @FirstName, LastName = @LastName, FatherName = @FatherName, MembershipDate = @MembershipDate, NationalCode = @NationalCode,     QuitDate = @QuitDate WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.CoordinatingCouncil ";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
