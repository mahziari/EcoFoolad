using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmFundGroupsLang
    {
        public int CrmFundGroupLangId { get; set; }
        public int FundGroupId { get; set; }
        public int LanguageId { get; set; }
        public string GroupName { get; set; }

        public virtual CrmFundGroups FundGroup { get; set; }
        public virtual Languages Language { get; set; }
    }
}
