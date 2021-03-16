using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyGroupsMultiLang
    {
        public int CrmCompanyGroupsMultiLangId { get; set; }
        public int CompanyGroupsMultiId { get; set; }
        public int LanguageId { get; set; }
        public string CompanyGroupsMultiName { get; set; }
        public string CompanyGroupsMultiDesc { get; set; }

        public virtual CrmCompanyGroupsMulti CompanyGroupsMulti { get; set; }
        public virtual Languages Language { get; set; }
    }
}
