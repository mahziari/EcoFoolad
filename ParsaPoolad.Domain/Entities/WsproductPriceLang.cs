using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductPriceLang
    {
        public int WsproductPriceLangId { get; set; }
        public int PrdPriceId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductPrice PrdPrice { get; set; }
    }
}
