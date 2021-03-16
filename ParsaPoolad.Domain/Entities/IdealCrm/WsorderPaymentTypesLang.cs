using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsorderPaymentTypesLang
    {
        public int WsorderPaymentTypesLangId { get; set; }
        public int OrderPaymentTypeId { get; set; }
        public int LanguageId { get; set; }
        public string OrdpayType { get; set; }
        public string OrdpayTypeDescription { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderPaymentTypes OrderPaymentType { get; set; }
    }
}
