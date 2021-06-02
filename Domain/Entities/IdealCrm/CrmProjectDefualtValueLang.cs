using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectDefualtValueLang
    {
        public int ProjectDefualtValueLangId { get; set; }
        public int ProjectDefualtValueId { get; set; }
        public int LanguageId { get; set; }
        public string DefualtValue { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectDefualtValue ProjectDefualtValue { get; set; }
    }
}
