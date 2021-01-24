using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmConversationLang
    {
        public int CrmConversationLangId { get; set; }
        public int ConversationId { get; set; }
        public int LanguageId { get; set; }
        public string CnvsSubject { get; set; }
        public string CnvsDesc { get; set; }
        public string CnvsReferDesc { get; set; }

        public virtual CrmConversation Conversation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
