using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmKnowledgeTankPriorityLang
    {
        public int CrmKnowledgeTankPriorityLangId { get; set; }
        public int KnowledgeTankPriorityId { get; set; }
        public int LanguageId { get; set; }
        public string KnowledgeTankPriorityTitle { get; set; }
        public string KnowledgeTankPriorityDesc { get; set; }

        public virtual CrmKnowledgeTankPriority KnowledgeTankPriority { get; set; }
        public virtual Languages Language { get; set; }
    }
}
