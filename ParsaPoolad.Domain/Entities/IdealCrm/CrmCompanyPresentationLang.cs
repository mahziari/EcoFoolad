using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyPresentationLang
    {
        public int CrmCompanyPresentationLangId { get; set; }
        public int CompanyPresentationId { get; set; }
        public int LanguageId { get; set; }
        public string Presentation { get; set; }

        public virtual CrmCompanyPresentation CompanyPresentation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
