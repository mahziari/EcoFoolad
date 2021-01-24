using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmUserTaskPrioritiesLang
    {
        public int CrmUserTaskPrioritiesLangId { get; set; }
        public int UserTaskPriorityId { get; set; }
        public int LanguageId { get; set; }
        public string Priority { get; set; }
        public string PriorityDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmUserTaskPriorities UserTaskPriority { get; set; }
    }
}
