using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmsysFormActionsLang
    {
        public int CrmsysFormActionsLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string ActionPersianName { get; set; }

        public virtual CrmsysFormActions IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
