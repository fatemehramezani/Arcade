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
    
    public partial class PersonalInfo
    {
        public PersonalInfo()
        {
            this.LandLords = new HashSet<LandLord>();
            this.Leases = new HashSet<Lease>();
            this.PurchaseLetters = new HashSet<PurchaseLetter>();
            this.Roles = new HashSet<Role>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string Cetificate { get; set; }
        public string IssuancePlace { get; set; }
        public string BirthPlace { get; set; }
        public System.DateTime Birthday { get; set; }
        public bool IsMale { get; set; }
        public byte MaritalStatuseId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public byte[] Image { get; set; }
        public byte MilitaryStatuseId { get; set; }
        public string JobAddress { get; set; }
        public string JobPhone { get; set; }
        public string Address { get; set; }
        public Nullable<byte> JobId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public bool IsLegal { get; set; }
        public string ZipeCode { get; set; }
    
        public virtual Job Job { get; set; }
        public virtual MaritalStatu MaritalStatu { get; set; }
        public virtual MilitaryStatu MilitaryStatu { get; set; }
        public virtual ICollection<LandLord> LandLords { get; set; }
        public virtual ICollection<Lease> Leases { get; set; }
        public virtual ICollection<PurchaseLetter> PurchaseLetters { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
