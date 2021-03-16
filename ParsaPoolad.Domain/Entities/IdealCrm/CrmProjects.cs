using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmProjects
    {
        public CrmProjects()
        {
            CrmConversation = new HashSet<CrmConversation>();
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
            CrmFilesDirectory = new HashSet<CrmFilesDirectory>();
            CrmProjectFieldTitle = new HashSet<CrmProjectFieldTitle>();
            CrmProjectInformations = new HashSet<CrmProjectInformations>();
            CrmProjectsLang = new HashSet<CrmProjectsLang>();
            EmailReceive = new HashSet<EmailReceive>();
            EmailReceiveAttachments = new HashSet<EmailReceiveAttachments>();
            EmailSendDetail = new HashSet<EmailSendDetail>();
            EmailUserTempTank = new HashSet<EmailUserTempTank>();
            SecLetters = new HashSet<SecLetters>();
            WsbuyOrder = new HashSet<WsbuyOrder>();
            Wsdoc = new HashSet<Wsdoc>();
            Wsorder = new HashSet<Wsorder>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
        }

        public int ProjectId { get; set; }
        public int PrjCompanyId { get; set; }
        public string PrjTitle { get; set; }
        public string PrjDesc { get; set; }
        public string PrjStartDate { get; set; }
        public string PrjStartDay { get; set; }
        public string PrjStartTime { get; set; }
        public DateTime? PrjStartDateTime { get; set; }
        public int? PrjStarterUserId { get; set; }
        public int? PrjFinishedStatusId { get; set; }
        public bool? PrjIsFinished { get; set; }
        public string PrjFinishedDate { get; set; }
        public string PrjFinishedDay { get; set; }
        public string PrjFinishedTime { get; set; }
        public DateTime? PrjFinishedDateTime { get; set; }
        public int? PrjFinishedUserId { get; set; }
        public int? PrjGradeId { get; set; }
        public int? PrjPriorityId { get; set; }
        public string PrjFirstRegisterDate { get; set; }
        public int PrjFirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public int? PrjGroupId { get; set; }
        public int? PrjcnvsStatusGroupId { get; set; }
        public int? PrjOrderView { get; set; }
        public string AppType { get; set; }
        public string PrjPostFix { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public DateTime? FirstRegisterDateTime { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? PrjFirstRegisterDateTime { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public string PrjRemindDate { get; set; }
        public DateTime? PrjRemindDateTime { get; set; }
        public bool? PrjFocmpCanSee { get; set; }
        public bool? PrjIsTicket { get; set; }
        public int? PrjUserDepartmentId { get; set; }
        public bool? PrjHaveSms { get; set; }
        public string PrjSmsPrsIds { get; set; }
        public string PrjSmsText { get; set; }
        public DateTime? PrjSmsSendDate { get; set; }
        public string PrjSmsSendDatePersian { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCompany PrjCompany { get; set; }
        public virtual CrmConversationStatus PrjFinishedStatus { get; set; }
        public virtual Users PrjFinishedUser { get; set; }
        public virtual Users PrjFirstRegisterUser { get; set; }
        public virtual CrmProjectGrade PrjGrade { get; set; }
        public virtual CrmProjectGroups PrjGroup { get; set; }
        public virtual CrmProjectPriority PrjPriority { get; set; }
        public virtual Users PrjStarterUser { get; set; }
        public virtual UserDepartments PrjUserDepartment { get; set; }
        public virtual CrmConversationStatusGroups PrjcnvsStatusGroup { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
        public virtual ICollection<CrmFilesDirectory> CrmFilesDirectory { get; set; }
        public virtual ICollection<CrmProjectFieldTitle> CrmProjectFieldTitle { get; set; }
        public virtual ICollection<CrmProjectInformations> CrmProjectInformations { get; set; }
        public virtual ICollection<CrmProjectsLang> CrmProjectsLang { get; set; }
        public virtual ICollection<EmailReceive> EmailReceive { get; set; }
        public virtual ICollection<EmailReceiveAttachments> EmailReceiveAttachments { get; set; }
        public virtual ICollection<EmailSendDetail> EmailSendDetail { get; set; }
        public virtual ICollection<EmailUserTempTank> EmailUserTempTank { get; set; }
        public virtual ICollection<SecLetters> SecLetters { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
    }
}
