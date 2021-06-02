using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectsTmp
    {
        public CrmProjectsTmp()
        {
            CrmConversationTmp = new HashSet<CrmConversationTmp>();
            CrmProjectsTmpLang = new HashSet<CrmProjectsTmpLang>();
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
        public bool? PrjInsertForbidden { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCompanyTmp PrjCompany { get; set; }
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
        public virtual ICollection<CrmConversationTmp> CrmConversationTmp { get; set; }
        public virtual ICollection<CrmProjectsTmpLang> CrmProjectsTmpLang { get; set; }
    }
}
