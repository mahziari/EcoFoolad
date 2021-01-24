using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrderItemsLang
    {
        public int WsbuyOrderItemsLangId { get; set; }
        public int BuyOrderItemId { get; set; }
        public int LanguageId { get; set; }
        public string BordIdescription { get; set; }
        public string BordIquantityDesc { get; set; }

        public virtual WsbuyOrderItems BuyOrderItem { get; set; }
        public virtual Languages Language { get; set; }
    }
}
