using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectsTmpLang
    {
        public int CrmProjectsLangId { get; set; }
        public int ProjectId { get; set; }
        public int LanguageId { get; set; }
        public string PrjTitle { get; set; }
        public string PrjDesc { get; set; }
        public string PrjPostFix { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectsTmp Project { get; set; }
    }
}
