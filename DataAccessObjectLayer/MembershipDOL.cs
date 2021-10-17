using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class MembershipDOL
    {
        public const string Select = @"SELECT Id, PersonalInfoId, RegistrationNumber, Dues, RegistrationDate FROM MemberShip WHERE (Id = @Id OR @Id IS NULL) AND (PersonalInfoId = @PersonalInfoId OR @PersonalInfoId IS NULL) AND (RegistrationNumber = @RegistrationNumber OR @RegistrationNumber IS NULL) AND (Dues = @Dues OR @Dues IS NULL) AND (RegistrationDate = @RegistrationDate OR @RegistrationDate IS NULL)";
        public const string Insert = @"INSERT INTO Membership (Id, PersonalInfoId, RegistrationNumber, Dues, RegistrationDate) VALUES (@Id,@PersonalInfoId,@RegistrationNumber,@Dues,@RegistrationDate)";
        public const string Delete = "DELETE FROM Membership WHERE Id = @Id";
        public const string Update = "UPDATE Membership SET PersonalInfoId = @PersonalInfoId, RegistrationNumber = @RegistrationNumber, Dues = @Dues, RegistrationDate = @RegistrationDate WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Membership";
        public enum QueryStatus { Select,Insert, Delete, Update, SelectMaxId };
    }
}
