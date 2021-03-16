using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmConversationStatusLang
    {
        public int CrmConversationStatusLangId { get; set; }
        public int ConversationStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Status { get; set; }
        public string StatusDesc { get; set; }

        public virtual CrmConversationStatus ConversationStatus { get; set; }
        public virtual Languages Language { get; set; }
    }
}
