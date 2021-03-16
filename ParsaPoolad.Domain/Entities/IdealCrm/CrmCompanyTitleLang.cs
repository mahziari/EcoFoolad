using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyTitleLang
    {
        public int CrmCompanyTitleLangId { get; set; }
        public int CompanyTitleId { get; set; }
        public int LanguageId { get; set; }
        public string CompanyTitle { get; set; }

        public virtual CrmCompanyTitle CompanyTitleNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
