using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmInternalMessagePriorityLang
    {
        public int CrmInternalMessagePriorityLangId { get; set; }
        public int InternalMessagePriorityId { get; set; }
        public int LanguageId { get; set; }
        public string InternalMessagePriority { get; set; }

        public virtual CrmInternalMessagePriority InternalMessagePriorityNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
