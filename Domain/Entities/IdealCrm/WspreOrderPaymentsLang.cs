using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
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
