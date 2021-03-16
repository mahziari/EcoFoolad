using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WspreOrderLang
    {
        public int WspreOrderLangId { get; set; }
        public int PreOrderId { get; set; }
        public int LanguageId { get; set; }
        public string PordTitle { get; set; }
        public string PordSubject { get; set; }
        public string PordTotalAmountStr { get; set; }
        public string PordSpecialWord { get; set; }
        public string PordDescriptionI { get; set; }
        public string PordDescriptionIi { get; set; }
        public string PordSigningI { get; set; }
        public string PordSigningIi { get; set; }
        public string PordSigningIii { get; set; }
        public string PordAddress { get; set; }
        public string PordDiscountTitle { get; set; }
        public string PordcmpTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrder PreOrder { get; set; }
    }
}
