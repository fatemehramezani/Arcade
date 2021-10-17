using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class LeaseDOL
    {
        public const string Select = @"SELECT     System.Lease.LandLordId, System.Lease.Leasehold, System.Lease.LeaseMounth, System.Lease.FromDate, System.Lease.ToDate, System.Lease.Charge, 
                      System.Lease.LateCharge, System.Lease.CouncilId, System.Lease.JobId, System.Lease.PaymentType, System.Lease.Prepayment, System.Lease.Witness, 
                      System.Lease.Code, System.Lease.AmountInWords, System.Lease.TanentPersonalInfo, System.Lease.Id, System.PersonalInfo.FirstName AS LandLordFirstName, 
                      System.PersonalInfo.LastName AS LandLordLastName, PersonalInfo_1.FirstName AS TanentFirstName, PersonalInfo_1.LastName AS TanentLastName, 
                      CoordinatingCouncil_1.FirstName AS CouncilFirstName, CoordinatingCouncil_1.LastName AS CouncilLastName, Basic.Job.Title AS JobTitle
FROM         System.Lease INNER JOIN
                      System.LandLord ON System.Lease.LandLordId = System.LandLord.Id INNER JOIN
                      System.PersonalInfo ON System.LandLord.PersonalInfoId = System.PersonalInfo.Id INNER JOIN
                      System.PersonalInfo AS PersonalInfo_1 ON System.Lease.TanentPersonalInfo = PersonalInfo_1.Id INNER JOIN
                      System.CoordinatingCouncil ON System.Lease.CouncilId = System.CoordinatingCouncil.Id INNER JOIN
                      System.CoordinatingCouncil AS CoordinatingCouncil_1 ON System.Lease.CouncilId = CoordinatingCouncil_1.Id INNER JOIN
                      Basic.Job ON System.Lease.JobId = Basic.Job.Id
WHERE     (System.Lease.LandLordId = @LandLordId OR
                      @LandLordId IS NULL) AND (System.Lease.CouncilId = @CouncilId OR
                      @CouncilId IS NULL) AND (System.Lease.JobId = @JobId OR
                      @JobId IS NULL) AND (System.Lease.TanentPersonalInfo = @TanentPersonalInfo OR
                      @TanentPersonalInfo IS NULL) AND (System.Lease.Id = @Id OR
                      @Id IS NULL)";
        public const string Insert = @"INSERT   
INTO            System.Lease(Id, LandLordId, TanentPersonalInfo, Leasehold, LeaseMounth, FromDate, ToDate, Charge, LateCharge, CouncilId, JobId, PaymentType, Prepayment, 
                       Witness, Code,AmountInWords)
VALUES     (@Id,@LandLordId,@TanentPersonalInfo,@Leasehold,@LeaseMounth,@FromDate,@ToDate,@Charge,@LateCharge,@CouncilId,@JobId,@PaymentType,@Prepayment,@Witness,@Code,@AmountInWords)";
        public const string Update = "UPDATE     System.Lease  SET              LandLordId = @LandLordId, TanentPersonalInfo = @TanentPersonalInfo, Leasehold = @Leasehold, LeaseMounth = @LeaseMounth, FromDate = @FromDate,          ToDate = @ToDate, Charge = @Charge, LateCharge = @LateCharge, CouncilId = @CouncilId, JobId = @JobId, PaymentType = @PaymentType,                 Prepayment = @Prepayment, Witness = @Witness, Code = @Code,AmountInWords=@AmountInWords WHERE     (Id = @Id)";
        public const string Delete = "DELETE   FROM         System.Lease  WHERE     (Id = @Id)";        
        public const string SelectMaxId = "SELECT ISNULL(MAX(Id),0)+1 AS MAX_ID FROM System.Lease";
        public enum QueryStatus { Select,Insert, Delete, Update, SelectMaxId };
    }
}
