using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanyGroupsLang
    {
        public int CrmCompanyGroupsLangId { get; set; }
        public int CompanyGroupId { get; set; }
        public int LanguageId { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }

        public virtual CrmCompanyGroups CompanyGroup { get; set; }
        public virtual Languages Language { get; set; }
    }
}
