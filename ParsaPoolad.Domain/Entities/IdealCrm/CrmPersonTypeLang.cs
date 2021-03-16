using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmPersonTypeLang
    {
        public int CrmPersonTypeLangId { get; set; }
        public int PersonTypeId { get; set; }
        public int LanguageId { get; set; }
        public string PersonType { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmPersonType PersonTypeNavigation { get; set; }
    }
}
