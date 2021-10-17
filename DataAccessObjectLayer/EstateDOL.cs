using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjectLayer
{
    public class EstateDOL
    {
        public const string Select = @"SELECT     System.Estate.Id, System.Estate.ZipCode, System.Estate.Area, System.Estate.Facilities, System.Estate.Floor, System.Estate.Address, System.Estate.Phone, 
                      System.Estate.EstateTypeId, System.Estate.Name, Basic.EstateType.Title AS EstateTypeTitle
FROM         System.Estate INNER JOIN
                      Basic.EstateType ON System.Estate.EstateTypeId = Basic.EstateType.Id
WHERE     (System.Estate.Id = @Id) AND (System.Estate.ZipCode = @ZipCode) AND (System.Estate.EstateTypeId = @EstateTypeId) OR
                      (System.Estate.Id = @Id) AND (System.Estate.EstateTypeId = @EstateTypeId) AND (@ZipCode IS NULL) OR
                      (System.Estate.ZipCode = @ZipCode) AND (System.Estate.EstateTypeId = @EstateTypeId) AND (@Id IS NULL) OR
                      (System.Estate.EstateTypeId = @EstateTypeId) AND (@Id IS NULL) AND (@ZipCode IS NULL) OR
                      (System.Estate.Id = @Id) AND (System.Estate.ZipCode = @ZipCode) AND (@EstateTypeId IS NULL) OR
                      (System.Estate.Id = @Id) AND (@ZipCode IS NULL) AND (@EstateTypeId IS NULL) OR
                      (System.Estate.ZipCode = @ZipCode) AND (@Id IS NULL) AND (@EstateTypeId IS NULL) OR
                      (@Id IS NULL) AND (@ZipCode IS NULL) AND (@EstateTypeId IS NULL)";
        public const string Insert = @"INSERT 
INTO            System.Estate(Id, ZipCode, Area, Facilities, Floor, Address, Phone, EstateTypeId, Name)
VALUES     (@Id,@ZipCode,@Area,@Facilities,@Floor,@Address,@Phone,@EstateTypeId,@Name)";
        public const string Delete = "DELETE FROM System.Estate WHERE(Id = @Id)";
        public const string SelectComboBox = "SELECT     Id,'کد ملک:'  +System.Estate.Name +' ' + Address+'   '  + 'کدپستی' + ZipCode+'   '  + 'تلفن'  + Phone+'   '  +'طبقه' + CAST(Floor As NVARCHAR(3)) AS Title FROM         System.Estate   UNION (SELECT ID AS Id, TEXT AS Title FROM NOSELECTION)";
        public const string SelectComboBoxLandLord = " SELECT     System.Estate.Id,  System.Estate.Address + '   ' + 'کدپستی' + System.Estate.ZipCode + '   ' + 'تلفن' + System.Estate.Phone + '   ' + 'طبقه' + CAST(System.Estate.Floor AS NVARCHAR(3)) + '  ' + ' کد ملک'  +System.Estate.Name  AS Title FROM         System.Estate INNER JOIN  System.LandLord ON System.Estate.Id = System.LandLord.EstateId WHERE     (System.LandLord.PersonalInfoId = @PersonalInfoId) UNION SELECT     ID AS Id, TEXT AS Title FROM         NoSelection ";        
        public const string Update = "UPDATE  System.Estate  SET              ZipCode = @ZipCode, Area = @Area, Facilities = @Facilities, Floor = @Floor, Address = @Address, Phone = @Phone, EstateTypeId = @EstateTypeId, Name = @Name WHERE (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.Estate";
        public enum QueryStatus { Select, Insert, Delete, SelectComboBox, SelectComboBoxLandLord, Update, SelectMaxId };
    }
}
