//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveType
    {
        public LeaveType()
        {
            this.Leaves = new HashSet<Leave>();
        }
    
        public int LeaveTypeID { get; set; }
        public string LeaveType1 { get; set; }
    
        public virtual ICollection<Leave> Leaves { get; set; }
    }
}
