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
    
    public partial class Job
    {
        public Job()
        {
            this.Leases = new HashSet<Lease>();
            this.PersonalInfoes = new HashSet<PersonalInfo>();
        }
    
        public byte Id { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Lease> Leases { get; set; }
        public virtual ICollection<PersonalInfo> PersonalInfoes { get; set; }
    }
}
