using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsbuyOrderPaymentTypesLang
    {
        public int WsbuyOrderPaymentTypesLangId { get; set; }
        public int BuyOrderPaymentTypeId { get; set; }
        public int LanguageId { get; set; }
        public string BordpayType { get; set; }
        public string BordpayTypeDescription { get; set; }

        public virtual WsbuyOrderPaymentTypes BuyOrderPaymentType { get; set; }
        public virtual Languages Language { get; set; }
    }
}
