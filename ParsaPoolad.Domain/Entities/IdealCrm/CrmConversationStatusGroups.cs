using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmConversationStatusGroups
    {
        public CrmConversationStatusGroups()
        {
            CrmConversationStatus = new HashSet<CrmConversationStatus>();
            CrmConversationStatusGroupsLang = new HashSet<CrmConversationStatusGroupsLang>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
            CrmProjectTitles = new HashSet<CrmProjectTitles>();
            CrmProjects = new HashSet<CrmProjects>();
            CrmProjectsTmp = new HashSet<CrmProjectsTmp>();
        }

        public int ConversationStatusGroupId { get; set; }
        public string ConversationStatusGroup { get; set; }
        public string ConversationStatusGroupDesc { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? FocnvsReferUserId { get; set; }
        public string FocnvsReferMultiUser { get; set; }

        public virtual Users FocnvsReferUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversationStatus> CrmConversationStatus { get; set; }
        public virtual ICollection<CrmConversationStatusGroupsLang> CrmConversationStatusGroupsLang { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
        public virtual ICollection<CrmProjectTitles> CrmProjectTitles { get; set; }
        public virtual ICollection<CrmProjects> CrmProjects { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmp { get; set; }
    }
}
