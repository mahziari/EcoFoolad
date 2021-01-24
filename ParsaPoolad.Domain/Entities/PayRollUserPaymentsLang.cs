using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class PayRollUserPaymentsLang
    {
        public int PayRollUserPaymentLangId { get; set; }
        public int PayRollUserPaymentId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PayRollUserPayments PayRollUserPayment { get; set; }
    }
}
