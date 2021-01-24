using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmConversationTopics
    {
        public CrmConversationTopics()
        {
            CrmConversation = new HashSet<CrmConversation>();
            CrmConversationTmp = new HashSet<CrmConversationTmp>();
            CrmConversationTopicsLang = new HashSet<CrmConversationTopicsLang>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int ConversationTopicsId { get; set; }
        public short? TopicOrder { get; set; }
        public string Topic { get; set; }
        public string TopicDesc { get; set; }
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
        public bool? Fodefault { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmp { get; set; }
        public virtual ICollection<CrmConversationTopicsLang> CrmConversationTopicsLang { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
