using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WscreditDurationLang
    {
        public int WscreditDurationLangId { get; set; }
        public int CreditDurationId { get; set; }
        public int LanguageId { get; set; }
        public string CreditDuration { get; set; }

        public virtual WscreditDuration CreditDurationNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
