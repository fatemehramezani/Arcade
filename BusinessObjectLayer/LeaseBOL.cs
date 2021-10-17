using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LeaseBOL
    {

        private int? id;
        private decimal? leasehold;
        private byte? leaseMounth;
        private DateTime? fromDate;
        private DateTime? toDate;
        private decimal? charge;
        private decimal? lateCharge;
        private int? councilId;
        private byte? jobId;
        private string paymentType;
        private decimal? prepayment;
        private int? landLordId;
        private int? tanentPersonalInfo;
        private string landLordFirstName;
        private string landLordLastName;
        private string tanentFirstName;
        private string tanentLastName;
        private string councilFirstName;
        private string councilLastName;
        private string witness;
        private string jobTitle;
        private string code;
        private string amountInWords;
        
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public decimal? Leasehold
        {
            get { return this.leasehold; }
            set { this.leasehold = value; }
        }
        public byte? LeaseMounth
        {
            get { return this.leaseMounth; }
            set { this.leaseMounth = value; }
        }
        public DateTime? FromDate
        {
            get { return this.fromDate; }
            set { this.fromDate = value; }
        }

        public DateTime? ToDate
        {
            get { return this.toDate; }
            set { this.toDate = value; }
        }

        public decimal? Charge
        {
            get { return this.charge; }
            set { this.charge = value; }
        }

        public decimal? LateCharge
        {
            get { return this.lateCharge; }
            set { this.lateCharge = value; }
        }

        public int? CouncilId
        {
            get { return this.councilId; }
            set { this.councilId = value; }
        }

        public byte? JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }
        public string PaymentType
        {
            get { return this.paymentType; }
            set { this.paymentType = value; }
        }

        public decimal? Prepayment
        {
            get { return this.prepayment; }
            set { this.prepayment = value; }
        }

        

        public int? LandLordId
        {
            get { return this.landLordId; }
            set { this.landLordId = value; }
        }
        public int? TanentPersonalInfo
        {
            get { return this.tanentPersonalInfo; }
            set { this.tanentPersonalInfo = value; }
        }

   
        public string LandLordFirstName
        {
            get { return this.landLordFirstName; }
            set { this.landLordFirstName = value; }
        }
        public string LandLordLastName
        {
            get { return this.landLordLastName; }
            set { this.landLordLastName = value; }
        }

        public string TanentFirstName
        {
            get { return this.tanentFirstName; }
            set { this.tanentFirstName = value; }
        }
        public string TanentLastName
        {
            get { return this.tanentLastName; }
            set { this.tanentLastName = value; }
        }
        public string CouncilFirstName
        {
            get { return this.councilFirstName; }
            set { this.councilFirstName = value; }
        }
        public string CouncilLastName
        {
            get { return this.councilLastName; }
            set { this.councilLastName = value; }
        }

        public string Witness
        {
            get { return this.witness; }
            set { this.witness = value; }
        }

        public string JobTitle
        {
            get { return this.jobTitle; }
            set { this.jobTitle = value; }
        }
        

        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }


        public string AmountInWords
        {
            get { return this.amountInWords; }
            set { this.amountInWords = value; }
        }
       
        public LeaseBOL() { }
        public LeaseBOL(int? Id,int? LandLordId,string LandLordFirstName,string LandLordLastName,int? TanentPersonalInfo,string TanentFirstName,string TanentLastName,decimal? Leasehold,byte? LeaseMounth,DateTime? FromDate,DateTime? ToDate,decimal? Charge,decimal? LateCharge,int? CouncilId ,string CouncilFirstName,string CouncilLastName, byte? JobId,string JobTitle,string PaymentType,decimal? Prepayment, string Witness,string Code,string AmountInWords)
        {
            this.Id = Id;
            this.Leasehold=Leasehold;
            this.LeaseMounth=LeaseMounth;
            this.FromDate=FromDate;
            this.ToDate=ToDate;
            this.Charge=Charge;
            this.LateCharge=LateCharge;
            this.CouncilId=CouncilId;
            this.JobId=JobId;
            this.PaymentType=PaymentType;
            this.Prepayment=Prepayment ;
            this.LandLordId =LandLordId;
            this.TanentPersonalInfo=TanentPersonalInfo;
            this.LandLordFirstName =LandLordFirstName;
            this.LandLordLastName=LandLordLastName ;
            this.TanentFirstName =TanentFirstName ;
            this.TanentLastName = TanentLastName;
            this.CouncilFirstName = CouncilFirstName;
            this.CouncilLastName = CouncilLastName;
            this.Witness = Witness;
            this.JobTitle = JobTitle;
            this.Code = Code;
            this.AmountInWords = AmountInWords;
           
        }
    }
}
