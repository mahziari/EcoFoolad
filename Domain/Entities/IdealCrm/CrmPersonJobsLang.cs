using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmPersonJobsLang
    {
        public int CrmPersonJobsLangId { get; set; }
        public int PersonJobId { get; set; }
        public int LanguageId { get; set; }
        public string Jobs { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmPersonJobs PersonJob { get; set; }
    }
}
