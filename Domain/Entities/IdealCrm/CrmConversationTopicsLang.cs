using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmConversationTopicsLang
    {
        public int CrmConversationTopicsLangId { get; set; }
        public int ConversationTopicsId { get; set; }
        public int LanguageId { get; set; }
        public string Topic { get; set; }
        public string TopicDesc { get; set; }

        public virtual CrmConversationTopics ConversationTopics { get; set; }
        public virtual Languages Language { get; set; }
    }
}
