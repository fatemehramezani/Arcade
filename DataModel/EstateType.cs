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
    
    public partial class EstateType
    {
        public EstateType()
        {
            this.Estates = new HashSet<Estate>();
        }
    
        public byte Id { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Estate> Estates { get; set; }
    }
}
