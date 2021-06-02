using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderCommissionsLang
    {
        public int WsorderCommissionLangId { get; set; }
        public int OrderCommissionId { get; set; }
        public int LanguageId { get; set; }
        public string CommBaseAmountDecDesc { get; set; }
        public string CommRateDesc { get; set; }
        public string CommDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderCommissions OrderCommission { get; set; }
    }
}
