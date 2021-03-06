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
    
    public partial class ProgressSheet
    {
        public int ProgressSheetid { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> TaskID { get; set; }
        public Nullable<int> TaskType { get; set; }
        public string Billing { get; set; }
        public Nullable<int> MilestoneID { get; set; }
        public string DeviationJustifcation { get; set; }
        public string Remarks { get; set; }
        public string ProgressSheetStatus { get; set; }
        public Nullable<int> AcceptanceClassID { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<int> DeviationJustificationID { get; set; }
    
        public virtual AcceptanceClass AcceptanceClass { get; set; }
        public virtual DeviationJustificationMaster DeviationJustificationMaster { get; set; }
        public virtual User User { get; set; }
        public virtual TaskType TaskType1 { get; set; }
    }
}
