using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmProjectFieldTitleLang
    {
        public int CrmProjectFieldTitleLangId { get; set; }
        public int ProjectFieldTitleId { get; set; }
        public int LanguageId { get; set; }
        public string FieldTitle { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectFieldTitle ProjectFieldTitle { get; set; }
    }
}
