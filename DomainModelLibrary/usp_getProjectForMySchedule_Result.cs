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
    
    public partial class usp_getProjectForMySchedule_Result
    
    {
        public int ProjectID { get; set; }
        public string ProjectCode { get; set; }
        public int ProjectLeader { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public Nullable<int> ClientAssetID { get; set; }
        public string ClientAssetName { get; set; }
        public string ProjectStartDate { get; set; }
        public Nullable<System.DateTime> ProjectSDate { get; set; }
        public string ProjectEndDate { get; set; }
        public string ProjectStatus { get; set; }
    }
}