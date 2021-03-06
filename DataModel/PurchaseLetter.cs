//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseLetter
    {
        public System.DateTime DeliveryDate { get; set; }
        public string Transmiter { get; set; }
        public Nullable<System.DateTime> ContarctDate { get; set; }
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int CostumerId { get; set; }
        public decimal Price { get; set; }
        public int CouncilId { get; set; }
        public Nullable<decimal> Prepayment { get; set; }
        public Nullable<decimal> TransforRedress { get; set; }
        public Nullable<decimal> CommitmentRedress { get; set; }
        public string WitnessName1 { get; set; }
        public string WitnessName2 { get; set; }
        public string Code { get; set; }
        public string CheckNumbers { get; set; }
        public string AmountInWords { get; set; }
    
        public virtual CoordinatingCouncil CoordinatingCouncil { get; set; }
        public virtual LandLord LandLord { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
