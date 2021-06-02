using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmConversationPriority
    {
        public CrmConversationPriority()
        {
            CrmConversation = new HashSet<CrmConversation>();
            CrmConversationPriorityLang = new HashSet<CrmConversationPriorityLang>();
            CrmConversationReferUsers = new HashSet<CrmConversationReferUsers>();
            CrmConversationTmp = new HashSet<CrmConversationTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int ConversationPriorityId { get; set; }
        public string Priority { get; set; }
        public string Color { get; set; }
        public string PriorityDesc { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? OrderView { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmConversationPriorityLang> CrmConversationPriorityLang { get; set; }
        public virtual ICollection<CrmConversationReferUsers> CrmConversationReferUsers { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
