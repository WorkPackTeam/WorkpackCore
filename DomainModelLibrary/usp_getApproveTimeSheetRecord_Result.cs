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
    
    public partial class usp_getApproveTimeSheetRecord_Result
    
    {
        public int TimeSheetDeviationID { get; set; }
        public Nullable<int> TimeSheetWeeklyID { get; set; }
        public string Deviation { get; set; }
        public string Week { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> JustifydeviationHrs { get; set; }
        public Nullable<int> TaskID { get; set; }
        public Nullable<int> AcceptanceClassID { get; set; }
        public string AcceptanceRemark { get; set; }
        public string TaskName { get; set; }
        public string UserName { get; set; }
        public string ProjectName { get; set; }
        public Nullable<decimal> AllottedHours { get; set; }
        public string Status { get; set; }
        public string AcceptanceClassCode { get; set; }
        public Nullable<decimal> ConsumedHours { get; set; }
    }
}