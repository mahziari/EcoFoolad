using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderPaymentsLang
    {
        public int WsorderPaymentsLangId { get; set; }
        public int OrderPaymentId { get; set; }
        public string OrdpayDescription { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderPayments OrderPayment { get; set; }
    }
}
