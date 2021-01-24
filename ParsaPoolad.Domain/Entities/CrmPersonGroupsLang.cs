using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmPersonGroupsLang
    {
        public int CrmPersonGroupsLangId { get; set; }
        public int PersonGroupId { get; set; }
        public int LanguageId { get; set; }
        public string PersonGroup { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmPersonGroups PersonGroupNavigation { get; set; }
    }
}
