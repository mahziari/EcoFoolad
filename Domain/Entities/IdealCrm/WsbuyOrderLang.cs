using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsbuyOrderLang
    {
        public int WsbuyOrderLangId { get; set; }
        public int BuyOrderId { get; set; }
        public int LanguageId { get; set; }
        public string BordTitle { get; set; }
        public string BordSubject { get; set; }
        public string BordTotalAmountStr { get; set; }
        public string BordDiscountTitle { get; set; }
        public string BordNote { get; set; }
        public string BordcmpTitle { get; set; }

        public virtual WsbuyOrder BuyOrder { get; set; }
        public virtual Languages Language { get; set; }
    }
}
