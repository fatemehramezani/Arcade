using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class LetterDOL
    {
        public const string Select = @"SELECT Letter.Id, Letter.PersonalInfoId, Letter.LetterNumber, Letter.LetterDate, Letter.LetterPlaceId, LetterPlace.Title AS LetterPlaceTitle FROM Letter INNER JOIN LetterPlace ON Letter.LetterPlaceId = LetterPlace.Id WHERE (Letter.Id = @Id OR @Id IS NULL) AND (Letter.PersonalInfoId = @PersonalInfoId OR @PersonalInfoId IS NULL) AND (Letter.LetterNumber = @LetterNumber OR @LetterNumber IS NULL) AND (Letter.LetterDate = @LetterDate OR @LetterDate IS NULL) AND (Letter.LetterPlaceId = @LetterPlaceId OR @LetterPlaceId IS NULL)";
        public const string Insert = @"INSERT INTO Letter (Id, PersonalInfoId, LetterNumber, LetterDate, LetterPlaceId) VALUES (@Id,@PersonalInfoId,@LetterNumber,@LetterDate,@LetterPlaceId)";
        public const string Delete = "DELETE FROM Letter WHERE Id = @Id";
        public const string Update = "UPDATE Letter SET PersonalInfoId = @PersonalInfoId, LetterNumber = @LetterNumber, LetterDate = @LetterDate, LetterPlaceId = @LetterPlaceId WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM Letter";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
