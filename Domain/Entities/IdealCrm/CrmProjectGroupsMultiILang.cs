using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectGroupsMultiILang
    {
        public int ProjectGroupsMultiIlangId { get; set; }
        public int ProjectGroupsMultiIid { get; set; }
        public int LanguageId { get; set; }
        public string ProjectGroupsMultiIname { get; set; }
        public string ProjectGroupsMultiIdesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectGroupsMultiI ProjectGroupsMultiI { get; set; }
    }
}
