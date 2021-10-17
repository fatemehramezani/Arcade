using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class PersonalInfoDOL
    {
        public const string Select = @"SELECT     System.PersonalInfo.Id, System.PersonalInfo.FirstName, System.PersonalInfo.LastName, System.PersonalInfo.FatherName, 
                      System.PersonalInfo.NationalCode, System.PersonalInfo.Cetificate, System.PersonalInfo.IssuancePlace, System.PersonalInfo.BirthPlace, 
                      System.PersonalInfo.Birthday, System.PersonalInfo.IsMale, System.PersonalInfo.MaritalStatuseId, System.PersonalInfo.Phone, System.PersonalInfo.Mobile, 
                      System.PersonalInfo.Image, System.PersonalInfo.MilitaryStatuseId, System.PersonalInfo.Address, System.PersonalInfo.JobId, System.PersonalInfo.CompanyName, 
                      System.PersonalInfo.CompanyAddress, System.PersonalInfo.CompanyPhone, System.PersonalInfo.IsLegal, System.PersonalInfo.ZipeCode, Basic.Job.Title AS JobTitle, 
                      Basic.MaritalStatus.Title AS MaritalStatuseTitle, Basic.MilitaryStatus.Title AS MIlitaryStatuseTitle
FROM         System.PersonalInfo LEFT OUTER JOIN
                      Basic.MilitaryStatus ON System.PersonalInfo.MilitaryStatuseId = Basic.MilitaryStatus.Id LEFT OUTER JOIN
                      Basic.MaritalStatus ON System.PersonalInfo.MaritalStatuseId = Basic.MaritalStatus.Id LEFT OUTER JOIN
                      Basic.Job ON System.PersonalInfo.JobId = Basic.Job.Id
WHERE     (System.PersonalInfo.Id = @Id) AND (System.PersonalInfo.NationalCode = @NationalCode) AND (System.PersonalInfo.Cetificate = @Cetificate) AND 
                      (System.PersonalInfo.MaritalStatuseId = @MaritalStatuseId) AND (System.PersonalInfo.MilitaryStatuseId = @MilitaryStatuseId) AND 
                      (System.PersonalInfo.JobId = @JobId) OR
                      (@Id IS NULL) OR
                      (@NationalCode IS NULL) OR
                      (@Cetificate IS NULL) OR
                      (@MaritalStatuseId IS NULL) OR
                      (@MilitaryStatuseId IS NULL)";

        public const string Insert = @"INSERT   
INTO            System.PersonalInfo(Id, FirstName, LastName, FatherName, NationalCode, Cetificate, IssuancePlace, BirthPlace, Birthday, IsMale, MaritalStatuseId, Phone, Mobile, 
                      Image, MilitaryStatuseId, Address, JobId, CompanyName, CompanyAddress, CompanyPhone, IsLegal,ZipeCode)
VALUES     (@Id,@FirstName,@LastName,@FatherName,@NationalCode,@Cetificate,@IssuancePlace,@BirthPlace,@Birthday,@IsMale,@MaritalStatuseId,@Phone,@Mobile,@Image,@MilitaryStatuseId,@Address,@JobId,@CompanyName,@CompanyAddress,@CompanyPhone,@IsLegal,@ZipeCode)";

        public const string Delete = "DELETE FROM System.PersonalInfo WHERE Id = @Id";
        public const string SelectLandlord = "SELECT DISTINCT   System.PersonalInfo.Id, System.PersonalInfo.FirstName, System.PersonalInfo.LastName, System.PersonalInfo.FatherName, System.PersonalInfo.NationalCode,    System.PersonalInfo.Cetificate, System.PersonalInfo.IssuancePlace, System.PersonalInfo.BirthPlace, System.PersonalInfo.Birthday, System.PersonalInfo.IsMale,      System.PersonalInfo.MaritalStatuseId, System.PersonalInfo.Phone, System.PersonalInfo.Mobile, System.PersonalInfo.MilitaryStatuseId,     System.PersonalInfo.Address, System.PersonalInfo.JobId, System.PersonalInfo.CompanyName, System.PersonalInfo.CompanyAddress,     System.PersonalInfo.CompanyPhone, System.PersonalInfo.IsLegal, System.PersonalInfo.ZipeCode, System.LandLord.PersonalInfoId,       Basic.MilitaryStatus.Title AS MilitaryStatuseTitle, Basic.Job.Title AS JobTitle, Basic.MaritalStatus.Title AS MaritalStatuseTitle  FROM         System.PersonalInfo INNER JOIN      System.LandLord ON System.PersonalInfo.Id = System.LandLord.PersonalInfoId INNER JOIN   Basic.Job ON System.PersonalInfo.JobId = Basic.Job.Id INNER JOIN   Basic.MaritalStatus ON System.PersonalInfo.MaritalStatuseId = Basic.MaritalStatus.Id INNER JOIN  Basic.MilitaryStatus ON System.PersonalInfo.MilitaryStatuseId = Basic.MilitaryStatus.Id WHERE     (System.PersonalInfo.Id = @Id) OR      (@Id IS NULL)";
        public const string Update  = "UPDATE   System.PersonalInfo  SET              FirstName = @FirstName, LastName = @LastName, FatherName = @FatherName, NationalCode = @NationalCode, Cetificate = @Cetificate,  IssuancePlace = @IssuancePlace, BirthPlace = @BirthPlace, Birthday = @Birthday, IsMale = @IsMale, MaritalStatuseId = @MaritalStatuseId, Phone = @Phone,  Mobile = @Mobile, Image = @Image, MilitaryStatuseId = @MilitaryStatuseId, Address = @Address, JobId = @JobId, CompanyName = @CompanyName,    CompanyAddress = @CompanyAddress, CompanyPhone = @CompanyPhone, IsLegal = @IsLegal, ZipeCode=@ZipeCode WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.PersonalInfo";
        public const string SelectReport = "Select * FROM ReportPersonalInfo";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId, SelectReport,SelectLandlord };
    }
}
