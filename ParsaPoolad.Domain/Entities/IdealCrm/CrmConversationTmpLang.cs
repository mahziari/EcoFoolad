using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmConversationTmpLang
    {
        public int CrmConversationLangId { get; set; }
        public int ConversationId { get; set; }
        public int LanguageId { get; set; }
        public string CnvsSubject { get; set; }
        public string CnvsDesc { get; set; }
        public string CnvsReferDesc { get; set; }

        public virtual CrmConversationTmp Conversation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
