using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class LandLordDOL
    {
        public const string Select = @"SELECT     System.LandLord.Id, System.LandLord.PersonalInfoId, System.LandLord.Share, System.LandLord.EstateId, System.LandLord.Type, System.LandLord.IsLandLord, 
                      System.Estate.Address + '   ' + 'کدپستی' + System.Estate.ZipCode + '   ' + 'تلفن' + System.Estate.Phone + '   ' + 'طبقه' + CAST(System.Estate.Floor AS NVARCHAR(3)) 
                      AS Title, System.PersonalInfo.FirstName, System.PersonalInfo.LastName
FROM         System.LandLord LEFT OUTER JOIN
                      System.PersonalInfo ON System.LandLord.PersonalInfoId = System.PersonalInfo.Id LEFT OUTER JOIN
                      System.Estate ON System.LandLord.EstateId = System.Estate.Id
WHERE     (System.LandLord.Id = @Id OR
                      @Id IS NULL) AND (System.LandLord.PersonalInfoId = @PersonalInfoId OR
                      @PersonalInfoId IS NULL) AND (System.LandLord.EstateId = @EstateId OR
                      @EstateId IS NULL) AND (System.LandLord.IsLandLord = @IsLandLord OR
                      @IsLandLord IS NULL)";
        public const string Insert = @"INSERT   
INTO            System.LandLord(Id, PersonalInfoId, Share, EstateId,Type,IsLandLord)
VALUES     (@Id,@PersonalInfoId,@Share,@EstateId,@Type,@IsLandLord)";
        public const string Delete = "DELETE FROM System.LandLord WHERE(Id = @Id)";
        public const string Update = "UPDATE  System.LandLord  SET              PersonalInfoId = @PersonalInfoId, Share = @Share, EstateId = @EstateId,  Type=@Type,IsLandLord=@IsLandLord WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.LandLord";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
