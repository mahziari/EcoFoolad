using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsbuyOrderPaymentsLang
    {
        public int WsbuyOrderPaymentsLangId { get; set; }
        public int BuyOrderPaymentId { get; set; }
        public int LanguageId { get; set; }
        public string BordpayDescription { get; set; }

        public virtual WsbuyOrderPayments BuyOrderPayment { get; set; }
        public virtual Languages Language { get; set; }
    }
}
