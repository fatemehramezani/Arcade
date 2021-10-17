using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class PurchaseLetterBOL
    {
        private int? id;
        private DateTime? deliveryDate;
       
        private string transmiter;
        private DateTime? contarctDate;
        private int? sellerId;
        private string sellerFirstName;
        private string sellerLastName;
        private int? costumerId;
        private string costumerFirstName;
        private string costumerLastName;
        private decimal? price;
        private int? councilId;
        private string councilFirstName;
        private string councilLastName;
        private decimal? commitmentRedress;
        private decimal? prepayment;
        private decimal? transforRedress;
        private string witnessName1;
        private string witnessName2;
        //private int? estateId;
        //private string title;
        private string code;
        private string amountInWords;
        private string checkNumbers;
      
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime? DeliveryDate
        {
            get { return this.deliveryDate; }
            set { this.deliveryDate = value; }
        }
 
        public string Transmiter
        {
            get { return this.transmiter; }
            set { this.transmiter = value; }
        }
        public DateTime? ContarctDate
        {
            get { return this.contarctDate; }
            set { this.contarctDate = value; }
        }
        public int? SellerId
        {
            get { return this.sellerId; }
            set { this.sellerId = value; }
        }
         public string SellerFirstName
        {
            get { return this.sellerFirstName; }
            set { this.sellerFirstName = value; }
        }
        public string SellerLastName
        {
            get { return this.sellerLastName; }
            set { this.sellerLastName = value; }
        }
        public int? CostumerId
        {
            get { return this.costumerId; }
            set { this.costumerId = value; }
        }
        public string CostumerFirstName
        {
            get { return this.costumerFirstName; }
            set { this.costumerFirstName = value; }
        }
        public string CostumerLastName
        {
            get { return this.costumerLastName; }
            set { this.costumerLastName = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int? CouncilId
        {
            get { return this.councilId; }
            set { this.councilId= value; }
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
        public decimal? Prepayment
        {
            get { return this.prepayment; }
            set { this.prepayment = value; }
        }
        public decimal? CommitmentRedress
        {
            get { return this.commitmentRedress; }
            set { this.commitmentRedress = value; }
        }
        public decimal? TransforRedress
        {
            get { return this.transforRedress; }
            set { this.transforRedress = value; }
        }
        public string WitnessName1
        {
            get { return this.witnessName1; }
            set { this.witnessName1 = value; }
        }
        public string WitnessName2
        {
            get { return this.witnessName2; }
            set { this.witnessName2 = value; }
        }
        //public int? EstateId
        //{
        //    get { return this.estateId; }
        //    set { this.estateId = value; }
        //}
        //public string Title
        //{
        //    get { return this.title; }
        //    set { this.title = value; }
        //}
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
        public string CheckNumbers
        {
            get { return this.checkNumbers; }
            set { this.checkNumbers = value; }
        }
        public PurchaseLetterBOL() { }
        public PurchaseLetterBOL(int? Id,DateTime? DeliveryDate,string Transmiter,DateTime? ContarctDate,int? SellerId,string SellerFirstName,string SellerLastName,int? CostumerId,string CostumerFirstName,string CostumerLastName,decimal? Price,int? CouncilId,string CouncilFirstName,string CouncilLastName,decimal? Prepayment,decimal? TransforRedress,decimal? CommitmentRedress,string WitnessName1, string WitnessName2,string Code,string AmountInWords,string CheckNumbers)
        {
            this.Id = Id;
            this.AmountInWords = AmountInWords;
            this.Code = Code;
            this.DeliveryDate=DeliveryDate;
            this.Transmiter=Transmiter;
            this.ContarctDate=ContarctDate;
            this.SellerId=SellerId;
            this.SellerFirstName=SellerFirstName;
            this.SellerLastName=SellerLastName;
            this.CostumerId=CostumerId;
            this.CostumerFirstName = CostumerFirstName;
            this.CostumerLastName = CostumerLastName;
            this.CouncilId = CouncilId;
            this.CouncilFirstName=CouncilFirstName;
            this.CouncilLastName=CouncilLastName;
            this.Prepayment=Prepayment;
            this.TransforRedress=TransforRedress;
            this.WitnessName1=WitnessName1;
            this.WitnessName2=WitnessName2;
            this.Price = Price;
            this.CommitmentRedress=CommitmentRedress;
            this.CheckNumbers = CheckNumbers;
        }
    }
}
