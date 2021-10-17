using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class PurchaseLetterDOL 
    {
        public const string Select = @"SELECT System.PurchaseLetter.DeliveryDate, System.PurchaseLetter.Transmiter, System.PurchaseLetter.ContarctDate, System.PurchaseLetter.Id, 
                      System.PurchaseLetter.SellerId, System.PurchaseLetter.CostumerId, System.PurchaseLetter.Price, System.PurchaseLetter.CouncilId, 
                      System.PurchaseLetter.Prepayment, System.PurchaseLetter.TransforRedress, System.PurchaseLetter.CommitmentRedress, System.PurchaseLetter.WitnessName1, 
                      System.PurchaseLetter.WitnessName2, System.PurchaseLetter.Code, System.PurchaseLetter.CheckNumbers, System.PurchaseLetter.AmountInWords, 
                      System.PersonalInfo.FirstName AS CostumerFirstName, System.PersonalInfo.LastName AS CostumerLastName, PersonalInfo_1.FirstName AS SellerFirstName, 
                      PersonalInfo_1.LastName AS SellerLastName, System.CoordinatingCouncil.FirstName AS CouncilFirstName, 
                      System.CoordinatingCouncil.LastName AS CouncilLastName
                      FROM System.PurchaseLetter INNER JOIN
                      System.PersonalInfo ON System.PurchaseLetter.CostumerId = System.PersonalInfo.Id INNER JOIN
                      System.LandLord ON System.PurchaseLetter.SellerId = System.LandLord.Id INNER JOIN
                      System.PersonalInfo AS PersonalInfo_1 ON System.LandLord.PersonalInfoId = PersonalInfo_1.Id INNER JOIN
                      System.CoordinatingCouncil ON System.PurchaseLetter.CouncilId = System.CoordinatingCouncil.Id
                      WHERE (System.PurchaseLetter.Id = @Id OR
                      @Id IS NULL) AND (System.PurchaseLetter.SellerId = @SellerId OR
                      @SellerId IS NULL) AND (System.PurchaseLetter.CostumerId = @CostumerId OR
                      @CostumerId IS NULL) AND (System.PurchaseLetter.CouncilId = @CouncilId OR
                      @CouncilId IS NULL) AND (System.PurchaseLetter.Code = @Code OR
                      @Code IS NULL)";
 public const string Insert = @"INSERT    
INTO            System.PurchaseLetter(Id, DeliveryDate , Transmiter, ContarctDate, SellerId, CostumerId, Price, CouncilId, Prepayment, TransforRedress, 
                      CommitmentRedress, WitnessName1, WitnessName2,Code,AmountInWords,CheckNumbers)
VALUES     (@Id,@DeliveryDate,@Transmiter,@ContarctDate,@SellerId,@CostumerId,@Price,@CouncilId,@Prepayment,@TransforRedress,@CommitmentRedress,@WitnessName1,@WitnessName2,@Code,@AmountInWords,@CheckNumbers)";
        public const string Delete = "DELETE   FROM         System.PurchaseLetter  WHERE     (Id = @Id)";
        public const string Update = "UPDATE    System.PurchaseLetter  SET              DeliveryDate = @DeliveryDate, Transmiter = @Transmiter, ContarctDate = @ContarctDate, SellerId = @SellerId, CostumerId = @CostumerId,              Price = @Price, CouncilId = @CouncilId, Prepayment = @Prepayment, TransforRedress = @TransforRedress, CommitmentRedress = @CommitmentRedress,                    WitnessName1 = @WitnessName1, WitnessName2 = @WitnessName2, Code=@Code,AmountInWords=@AmountInWords, CheckNumbers=@CheckNumbers  WHERE     (Id = @Id)";
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.PurchaseLetter";
        public enum QueryStatus { Select,Insert, Delete, Update, SelectMaxId };
    }
}
