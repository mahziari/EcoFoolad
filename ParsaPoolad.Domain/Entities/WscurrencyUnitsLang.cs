using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WscurrencyUnitsLang
    {
        public int WscurrencyUnitsLangId { get; set; }
        public int CurrencyUnitId { get; set; }
        public int LanguageId { get; set; }
        public string CurrencyUnit { get; set; }
        public string Description { get; set; }
        public string CurrencyUnitEn { get; set; }

        public virtual WscurrencyUnits CurrencyUnitNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
