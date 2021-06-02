using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectsForbiddenForUserLang
    {
        public int CrmProjectsForbiddenForUserLangId { get; set; }
        public int ProjectsForbiddenForUserId { get; set; }
        public int LanguageId { get; set; }
        public string ForbiddenProjectTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectsForbiddenForUser ProjectsForbiddenForUser { get; set; }
    }
}
