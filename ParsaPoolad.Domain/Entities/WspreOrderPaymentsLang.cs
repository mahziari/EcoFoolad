using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WspreOrderPaymentsLang
    {
        public int WspreOrderPaymentsLangId { get; set; }
        public int PreOrderPaymentId { get; set; }
        public int LanguageId { get; set; }
        public string PordpayDescription { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrderPayments PreOrderPayment { get; set; }
    }
}
