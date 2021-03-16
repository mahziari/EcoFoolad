using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class PayRollUserPaymentTypesLang
    {
        public int PayRollUserPaymentTypeLangId { get; set; }
        public int PayRollUserPaymentTypeId { get; set; }
        public int LanguageId { get; set; }
        public string PaymentType { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PayRollUserPaymentTypes PayRollUserPaymentType { get; set; }
    }
}
