using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyGroupsIiiLang
    {
        public int CrmCompanyGroupsIiilangId { get; set; }
        public int CompanyGroupIiiid { get; set; }
        public int LanguageId { get; set; }
        public string GroupIiiname { get; set; }
        public string GroupIiidesc { get; set; }

        public virtual CrmCompanyGroupsIii CompanyGroupIii { get; set; }
        public virtual Languages Language { get; set; }
    }
}
