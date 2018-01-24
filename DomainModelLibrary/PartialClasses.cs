using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelLibrary
{

    public partial class NotifiMessage
    {
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public int MessageID { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        public string Content { get; set; }
        public string RedirectURL { get; set; }
        public string QueryString { get; set; }
        public string MessageFor { get; set; }
        public string Active { get; set; }
        public string MessageType { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime VisitDate { get; set; }
    }
    public partial class User_Message
    {
        public int MessageID { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        public string Message { get; set; }
        public string RedirectURL { get; set; }
        public string QueryString { get; set; }
        public string MessageFor { get; set; }
        public string Active { get; set; }
        public string MessageType { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public string IsProgressAlert { get; set; }
    }


    public partial class UploadFileData
    {
        public int fileID { get; set; }

    }



    public partial class TimeSheet
    {
        public int TimeSheetWeeklyID { get; set; }
        public System.DateTime TimeSheetFromDate { get; set; }
        public System.DateTime TimeSheetToDate { get; set; }
        public int UserID { get; set; }
        public string Justifydeviation { get; set; }
        public decimal AvailableHours { get; set; }
        public decimal ConsumedHours { get; set; }
        public string Remarks { get; set; }
        public decimal JustifydeviationHrs { get; set; }
    }
   
    public partial class usp_ResourceDistributionChart_Result
    {
        public usp_ResourceDistributionChart_Result() { }
        public usp_ResourceDistributionChart_Result(decimal absolute_Numbers, string resources_Distributed_Across_ID, string resources_Distributed_Across_Name, string resources_Distributed_Across_Code, decimal percentage_Value)
        {
            this.Absolute_Numbers = absolute_Numbers;
            this.Resources_Distributed_Across_ID = resources_Distributed_Across_ID;
            this.Resources_Distributed_Across_Name = resources_Distributed_Across_Name;
            this.Resources_Distributed_Across_Code = resources_Distributed_Across_Code;
            this.Percentage_Value = percentage_Value;
        }
        public decimal Percentage_Value { get; set; }
    }
   
    public partial class TaskTypeWiseProgress : IEntity
    {
        public EntityState EntityState { get; set; }

    }




   
    public partial class TranType : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class Store : IEntity
    {
        public EntityState EntityState { get; set; }

    }



   
    public partial class ApprovalAttachmentFile : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ApprovalAttachmentFileTemp : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class CustomReportFilterMaster : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class TimeSheetRejection : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class ActivityLog : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class CompanyType : IEntity
    {
        public EntityState EntityState { get; set; }

    }




   
    public partial class MaterialNorm : IEntity
    {
        public EntityState EntityState { get; set; }

    }
    
   
    public partial class ContactType : IEntity
    {
        public EntityState EntityState { get; set; }

    }

    

   
    public partial class RelatedTask : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class CustomReport : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class MaterialUnit : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class FileCheckerEmailDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }



   
    public partial class ProjectlevelTaskDependency : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class TaxCode : IEntity
    {

        public EntityState EntityState { get; set; }

    }


   
    public partial class EstimationColSettingTemplateDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class ProjectleveltasksStakeholder : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class Projectleveltask : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCommentHistory : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class Department_Test : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskCostDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class DocumentFilter : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class IndividualRecipient : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class RecipientFilter : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class MilestonesStakeHolder : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class ProgressLevelTemplateDocDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class UsedProgressLevelTemplateNPA : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class DocStage : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class TaskMilestoneBookedQty : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaskMilestoneBookedQtyFile : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class DeliverableMessage : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class Company : IEntity
    {
        public EntityState EntityState { get; set; }

    }



   
    public partial class commentedAttachFile : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ProjectMilestonesDocDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskProgressHistory : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class TaskListColorCell : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class IndexDataTable : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class RemindMeProgressLevel : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class FileStatu : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class ResourceLevelChart : IEntity
    {
        public EntityState EntityState { get; set; }

    }
    //[Serializable]
    //public partial class NotifiMessage
    //{
    //    public string FromUserID { get; set; }
    //    public string ToUserID { get; set; }
    //}
    //
    //public partial class User_Message
    //{
    //    public string FromUserID { get; set; }
    //    public string ToUserID { get; set; }
    //}
   
    public partial class LevelOverloading : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class LastRuningNumber : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class RevisionFile : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProgressSheet : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class PageTextDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProjectContract : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class MessageTemplate : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class AssentUniqueNumber : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class UploadDeliverableFile : IEntity
    {
        public EntityState EntityState { get; set; }
        public string flag { get; set; }



    }
   
    public partial class PageCommentDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class AttachTransmitalFile : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class Transmittal : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TransmittalDelList : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TransmittalUser : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class FileChecker : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCircleDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageLineDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCloud : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCloudDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageRecDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class AttachmentFile : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class CompanyProfile : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class CheckerAttachmentFile : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class MaterialdetailsColumn : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceAllocation : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class HideColumnSetting : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceCategory : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceCostSetting : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NextStepMessageUser : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceCostSettingDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDetail_Contract : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TopManagementUser : IEntity
    {
        public EntityState EntityState { get; set; }

    }


   
    public partial class ProjectsAdmin : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ExtProjectsMember : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskColumnsMasterTemp : IEntity
    {
        public EntityState EntityState { get; set; }
        public virtual ICollection<EstimationTaskColumnsMasterTemp> EstimationTaskColumnsMasterTemps { get; set; }
    }

   
    public partial class EstimationColSettingTemplate : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class NormSetType : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class MileStoneTaskType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectMilestone : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class WeeklyTaskList : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ContractNormDistribution : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Message : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsMapping : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormSet : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ContractNormColMaster : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceRequestDesignation : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskCreationNormDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDesignation : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDesignation_Contract : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceRequest : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class IntroPage : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class AssignResourceForEstimation : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class ProjectTempDocument : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskColumnsMaster : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskList : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskDependency : IEntity
    {
        public EntityState EntityState { get; set; }

    }
    [NotMapped]

    public partial class Currency : IEntity
    {
       
        public EntityState EntityState { get; set; }

    }
   
    public partial class Norm : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsColumnsMaster : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsManageTable : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsManageTableColumn : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NewActivity : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NewActivityDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class NewActivityMaster : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class AcceptanceClass : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class AlertsSetting : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TimeSheetWeeklyDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TimeSheetWeekly : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TimeSheetDeviation : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskStartEndJustification : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskHandoverDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Client : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ClientAsset : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class Location : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class DesignType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectWB : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ExUser : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ClientFocalPoint : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Comment : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ConfigFile : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class DailyWorkingHr : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Department : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class DependencyType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Designation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class EmailTemplate : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class HolidayCalendar : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class LeaveType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Priority : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskMilestoneTargetDate : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskMilestoneTargetDates_Contract : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProgressLevelTemplateDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Project : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectPipeline : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectPipelineDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class WBSTemplateDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class WBSTemplate : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class VW_MYTASK
    {
    }
   
    public partial class ProjectProgressLevelTemplate : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectProgressLevelTemplateTaskType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectStage : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Confidential : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Role : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class RoleRight : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ScheduleHealth : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ScopeChangeType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Skill : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskType : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class Technology : IEntity
    {
        public EntityState EntityState { get; set; }
    }

    public partial class User : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

    public partial class UserActivityTracker : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectTaskList : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectTaskList_Contract : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_getProjectWiseHrsForLoadingDetails_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_getDrillDownProjectByProjectId_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_ProjectProgressSummary_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_getViewTransmittalDetails_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_getTaskDetailsByProjectID_Result
    {

    }
   
    public partial class usp_getTaskTypeWiseProgressByTaskID_Result
    {

    }
   
    public partial class usp_GetPageCommentDetailsForApprov_Result
    {

    }
   
    public partial class usp_getTransmittalDetails_Result
    {

    }
   
    public partial class usp_GetTransmittalUser_Result
    {

    }

   
    public partial class UserEmployerHistory
    {
    }
   
    public partial class TaskDependency : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskDependency_Contract : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ScopeChange : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class GanntChartSetting : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_getMilestoneDetailsAndTask_Result : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_getUserList_Result
    {
    }

   
    public partial class usp_GetPageCommentDetails_Result
    {
    }
   
    public partial class usp_getTaskMilestoneTargetDates_Result
    {
    }
   
    public partial class usp_ChangeProjectTaskList_Result
    {
    }
   
    public partial class usp_ChangeMilestoneTargetDates_Result
    {
    }
   
    public partial class usp_getDeliverableTaskByUserID_Result
    {
    }
   
    public partial class usp_getViewTargetMilestone_Result
    {
    }
   
    public partial class usp_getTaskStatusReportByProjectID_Result
    {
    }
   
    public partial class usp_getTaskRecordByID_Result
    {
    }
   
    public partial class Leave : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class OverTimeRequest : IEntity
    {
        public EntityState EntityState { get; set; }
        public int ProjectID { get; set; }


    }
   
    public partial class ProjectDocument : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectsDepartment : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    
    
    public partial class InventoryColumnsMaster : IEntity
    {
        public EntityState EntityState { get; set; }
    }
    
   
    public partial class SimilarProject : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectStatu : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_TaskMilestoneTargetDatesByProjectTaskID_Result : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_GetAllNewActivityUsersByActvityID_Result : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class UserComment : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaskProgressReminder : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class TransmitalTemplate : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class PageComment_images : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProgressLevelNotification : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProgressLevelNotificationRole : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class BufferField : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown4 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class Dropdown5 : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown6 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class Dropdown7 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class Dropdown8 : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown9 : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown10 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class SharedProjectTaskList : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProcurementDocumentColumnsMaster : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProcurementDocumentData : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaxCodesDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaxType : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ApprovalRelatedTask : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class SelfApprovalComment : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class MaterialInventory : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class MaterialInventoryDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class ProgressUpdateNotificationSetting : IEntity
    {
        public EntityState EntityState { get; set; }

    }
    


   
    public partial class usp_GetEstimationDetailsNotTransferedByProjectID_Result
    {
        public int Priority { get; set; }
        public string PreReqInfo { get; set; }
        public string Del { get; set; }
        public string Remarks { get; set; }

    }




    //Classes for Mapping
    public class Client_FocalPoint
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int FocalPointID { get; set; }
        public string FocalPointName { get; set; }
        public string FocalPointCode { get; set; }
    }
    public class Int_ListItem
    {
        public int itemField1 { get; set; }
        public Nullable<int> itemField2 { get; set; }
    }





}
