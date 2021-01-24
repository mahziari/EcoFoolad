using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmProjectGroupsLang
    {
        public int ProjectGroupsLangId { get; set; }
        public int ProjectGroupId { get; set; }
        public int LanguageId { get; set; }
        public string ProjectGroup { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectGroups ProjectGroupNavigation { get; set; }
    }
}
