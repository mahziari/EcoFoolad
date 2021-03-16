using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmProjectPriorityLang
    {
        public int CrmProjectPriorityLangId { get; set; }
        public int ProjectPriorityId { get; set; }
        public int LanguageId { get; set; }
        public string Priority { get; set; }
        public string PriorityDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectPriority ProjectPriority { get; set; }
    }
}
