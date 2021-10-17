using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class PersonalRoleDOL
    {
        public const string Select = @"SELECT     System.PersonRole.Id, System.PersonRole.RoleTypeId, System.PersonRole.PersonalInfoId, System.PersonalInfo.FirstName, System.PersonalInfo.LastName, 
                      Basic.RoleType.Title AS RoleTypeTitle
FROM         System.PersonRole LEFT OUTER JOIN
                      Basic.RoleType ON System.PersonRole.RoleTypeId = Basic.RoleType.Id LEFT OUTER JOIN
                      System.PersonalInfo ON System.PersonRole.PersonalInfoId = System.PersonalInfo.Id
WHERE     (System.PersonRole.Id = @Id) AND (System.PersonRole.RoleTypeId = @RoleTypeId) AND (System.PersonRole.PersonalInfoId = @PersonalInfoId) OR
                      (@Id IS NULL) OR
                      (@RoleTypeId IS NULL) OR
                      (@PersonalInfoId IS NULL)";
        public const string Insert = @"INSERT   
INTO            System.PersonRole(Id, RoleTypeId, PersonalInfoId)
VALUES     (@Id,@RoleTypeId,@PersonalInfoId)";
        public const string Delete = "DELETE FROM System.PersonRole WHERE Id =@Id";
        public const string Update = "UPDATE   System.PersonRole    SET              RoleTypeId = @RoleTypeId, PersonalInfoId = @PersonalInfoId  WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.PersonRole";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
