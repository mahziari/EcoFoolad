using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsorderLang
    {
        public int WsorderLangId { get; set; }
        public int OrderId { get; set; }
        public string OrdTitle { get; set; }
        public string OrdSubject { get; set; }
        public string OrdSpecialWord { get; set; }
        public string OrdDescriptionI { get; set; }
        public string OrdDescriptionIi { get; set; }
        public string OrdSigningI { get; set; }
        public string OrdSigningIi { get; set; }
        public string OrdSigningIii { get; set; }
        public string OrdDiscountTitle { get; set; }
        public string OrdNote { get; set; }
        public string OrdcmpTitle { get; set; }
        public int LanguageId { get; set; }
        public string OrdTotalAmountStr { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Wsorder Order { get; set; }
    }
}
