using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductsUserDiscountLang
    {
        public int WsproductsUserDiscountLangId { get; set; }
        public int ProductsUserDiscountId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductsUserDiscount ProductsUserDiscount { get; set; }
    }
}
