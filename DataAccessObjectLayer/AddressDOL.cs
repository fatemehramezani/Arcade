using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class AddressDOL
    {
        public const string Select = @"SELECT Address.Id, Address.PersonalInfoId, Address.Address, Address.StartDate, Address.EndDate, Address.HabitationId, Address.PostalCode, Habitation.Title AS HabitationTitle FROM Address LEFT OUTER JOIN Habitation ON Address.HabitationId = Habitation.Id WHERE (Address.Id = @Id OR @Id IS NULL) AND (Address.PersonalInfoId = @PersonalInfoId OR @PersonalInfoId IS NULL) AND (Address.Address = @Address OR @Address IS NULL) AND (Address.StartDate = @StartDate OR @StartDate IS NULL) AND (Address.EndDate = @EndDate OR @EndDate IS NULL) AND (Address.HabitationId = @HabitationId OR @HabitationId IS NULL)";
        public const string Insert = @"INSERT INTO Address (Id, PersonalInfoId, Address, StartDate, EndDate, HabitationId, PostalCode) VALUES (@Id,@PersonalInfoId,@Address,@StartDate,@EndDate,@HabitationId,@PostalCode)";
        public const string Delete = "DELETE FROM Address WHERE Id =@Id";
        public const string Update = "UPDATE Address SET PersonalInfoId = @PersonalInfoId, Address = @Address, StartDate = @StartDate, EndDate = @EndDate, HabitationId = @HabitationId, PostalCode = @PostalCode WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Address";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
