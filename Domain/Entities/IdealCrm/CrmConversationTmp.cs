using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmConversationTmp
    {
        public CrmConversationTmp()
        {
            CrmConversationTmpLang = new HashSet<CrmConversationTmpLang>();
        }

        public int ConversationId { get; set; }
        public int? CnvsProjectId { get; set; }
        public int CnvsCompanyId { get; set; }
        public string CnvsDate { get; set; }
        public string CnvsDay { get; set; }
        public string CnvsTime { get; set; }
        public DateTime? CnvsDateTime { get; set; }
        public int? CnvsTopicId { get; set; }
        public string CnvsSubject { get; set; }
        public string CnvsDesc { get; set; }
        public int? CnvsPersonId { get; set; }
        public int? CnvsUserId { get; set; }
        public int? CnvsReferUserId { get; set; }
        public string CnvsReferDesc { get; set; }
        public int? CnvsStatusId { get; set; }
        public int? CnvsPriorityId { get; set; }
        public string CnvsRemindDate { get; set; }
        public string CnvsRemindTime { get; set; }
        public DateTime? CnvsRemindDateTime { get; set; }
        public bool? CnvsRemindOk { get; set; }
        public bool? CnvsIsBookMark { get; set; }
        public int? CnvsFirstRegisterUserId { get; set; }
        public string CnvsFirstRegisterDate { get; set; }
        public DateTime? CnvsFirstRegisterDateTime { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public Guid? Guid { get; set; }
        public string CnvsRemindDateForAllarm { get; set; }
        public DateTime? CnvsRemindDateTimeForAllarm { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public string ApiId { get; set; }
        public bool? CnvsFocmpCanSee { get; set; }
        public bool? CnvsIsTicket { get; set; }
        public string CnvsCoordinateLatitude { get; set; }
        public string CnvsCoordinateLongitude { get; set; }
        public DateTime? CnvsCoordinateLastDate { get; set; }
        public string CnvsCoordinateLastDatePersian { get; set; }
        public bool? CnvsEventPolicyNeedCheck { get; set; }
        public string TmpUserMultiUserText { get; set; }

        public virtual CrmCompanyTmp CnvsCompany { get; set; }
        public virtual Users CnvsFirstRegisterUser { get; set; }
        public virtual CrmCompanyPersonsTmp CnvsPerson { get; set; }
        public virtual CrmConversationPriority CnvsPriority { get; set; }
        public virtual CrmProjectsTmp CnvsProject { get; set; }
        public virtual Users CnvsReferUser { get; set; }
        public virtual CrmConversationStatus CnvsStatus { get; set; }
        public virtual CrmConversationTopics CnvsTopic { get; set; }
        public virtual Users CnvsUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversationTmpLang> CrmConversationTmpLang { get; set; }
    }
}
