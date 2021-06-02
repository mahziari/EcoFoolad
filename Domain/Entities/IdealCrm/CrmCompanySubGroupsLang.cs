using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCompanySubGroupsLang
    {
        public int CrmCompanySubGroupsLangId { get; set; }
        public int CompanySubGroupId { get; set; }
        public int LanguageId { get; set; }
        public string SubGroupName { get; set; }
        public string SubGroupDesc { get; set; }

        public virtual CrmCompanySubGroups CompanySubGroup { get; set; }
        public virtual Languages Language { get; set; }
    }
}
