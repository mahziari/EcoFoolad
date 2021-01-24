using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanyGroupsIiLang
    {
        public int CrmCompanyGroupsIilangId { get; set; }
        public int CompanyGroupIiid { get; set; }
        public int LanguageId { get; set; }
        public string GroupIiname { get; set; }
        public string GroupIidesc { get; set; }

        public virtual CrmCompanyGroupsIi CompanyGroupIi { get; set; }
        public virtual Languages Language { get; set; }
    }
}
