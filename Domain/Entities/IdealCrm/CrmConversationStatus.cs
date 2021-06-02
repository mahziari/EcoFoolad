using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmConversationStatus
    {
        public CrmConversationStatus()
        {
            CrmConversation = new HashSet<CrmConversation>();
            CrmConversationStatusLang = new HashSet<CrmConversationStatusLang>();
            CrmConversationTmp = new HashSet<CrmConversationTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
            CrmProjects = new HashSet<CrmProjects>();
            CrmProjectsTmp = new HashSet<CrmProjectsTmp>();
        }

        public int ConversationStatusId { get; set; }
        public short? StatusOrder { get; set; }
        public string Status { get; set; }
        public string StatusDesc { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? ProgressPercent { get; set; }
        public Guid? Guid { get; set; }
        public int? GroupId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? EventPolicyIsActive { get; set; }
        public string SmsbodyPatternFormula { get; set; }
        public bool? SendSmsweb { get; set; }
        public bool? SendSmsgsm { get; set; }
        public string EmailSubjectPatternFormula { get; set; }
        public string EmailBodyPatternFormula { get; set; }
        public bool? SendEmail { get; set; }
        public bool? SendImmediately { get; set; }
        public int? SendDelayDays { get; set; }
        public bool? SendForAllCmpPersons { get; set; }
        public bool? UserCanCheckBeforeSend { get; set; }
        public bool? ForcedStatus { get; set; }
        public bool? Fodefault { get; set; }

        public virtual CrmConversationStatusGroups Group { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmConversationStatusLang> CrmConversationStatusLang { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
        public virtual ICollection<CrmProjects> CrmProjects { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmp { get; set; }
    }
}
