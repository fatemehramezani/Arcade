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
    
    public partial class Event
    {
        public Event()
        {
            this.Bases = new HashSet<Basis>();
            this.InPuts = new HashSet<InPut>();
            this.OutPuts = new HashSet<OutPut>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EstateIds { get; set; }
    
        public virtual ICollection<Basis> Bases { get; set; }
        public virtual ICollection<InPut> InPuts { get; set; }
        public virtual ICollection<OutPut> OutPuts { get; set; }
    }
}
