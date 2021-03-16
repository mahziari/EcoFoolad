using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class EducationLang
    {
        public int EducationLangId { get; set; }
        public int EducationId { get; set; }
        public int LanguageId { get; set; }
        public string Education { get; set; }

        public virtual Education EducationNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
