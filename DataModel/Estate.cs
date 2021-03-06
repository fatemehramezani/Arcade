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
    
    public partial class Estate
    {
        public Estate()
        {
            this.InPuts = new HashSet<InPut>();
            this.LandLords = new HashSet<LandLord>();
        }
    
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public int Area { get; set; }
        public string Facilities { get; set; }
        public int Floor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte EstateTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<InPut> InPuts { get; set; }
        public virtual EstateType EstateType { get; set; }
        public virtual ICollection<LandLord> LandLords { get; set; }
    }
}
