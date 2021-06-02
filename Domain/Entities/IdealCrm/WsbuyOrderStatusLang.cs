using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsbuyOrderStatusLang
    {
        public int WsbuyOrderStatusLangId { get; set; }
        public int BuyOrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string BuyOrderStatus { get; set; }

        public virtual WsbuyOrderStatus BuyOrderStatusNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
