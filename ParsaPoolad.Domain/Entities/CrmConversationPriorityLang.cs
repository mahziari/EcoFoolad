﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmConversationPriorityLang
    {
        public int CrmConversationPriorityLangId { get; set; }
        public int ConversationPriorityId { get; set; }
        public int LanguageId { get; set; }
        public string Priority { get; set; }
        public string PriorityDesc { get; set; }

        public virtual CrmConversationPriority ConversationPriority { get; set; }
        public virtual Languages Language { get; set; }
    }
}
