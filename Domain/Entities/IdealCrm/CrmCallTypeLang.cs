using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCallTypeLang
    {
        public int CrmCallTypeLangId { get; set; }
        public int CallTypeId { get; set; }
        public int? LanguageId { get; set; }
        public string CallType { get; set; }

        public virtual CrmCallType CallTypeNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
