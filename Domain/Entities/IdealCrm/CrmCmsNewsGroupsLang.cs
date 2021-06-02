using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCmsNewsGroupsLang
    {
        public int CrmCmsNewsGroupLangId { get; set; }
        public int NewsGroupId { get; set; }
        public int LanguageId { get; set; }
        public string GroupName { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmCmsNewsGroups NewsGroup { get; set; }
    }
}
