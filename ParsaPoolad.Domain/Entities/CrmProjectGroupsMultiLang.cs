using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmProjectGroupsMultiLang
    {
        public int ProjectGroupsMultiLangId { get; set; }
        public int ProjectGroupsMultiId { get; set; }
        public int LanguageId { get; set; }
        public string ProjectGroupsMultiName { get; set; }
        public string ProjectGroupsMultiDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectGroupsMulti ProjectGroupsMulti { get; set; }
    }
}
