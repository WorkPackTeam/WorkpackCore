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
    
    public partial class PageCommentHistory
    {
        public int CommentHistoryID { get; set; }
        public Nullable<int> PageCommentDetailID { get; set; }
        public string CommentText { get; set; }
        public string ResponseText { get; set; }
        public string RejectionText { get; set; }
        public Nullable<int> CommentStatus { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CommentStatusDate { get; set; }
        public long CommentClientid { get; set; }
    }
}