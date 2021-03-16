using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductsUserDiscount
    {
        public WsproductsUserDiscount()
        {
            WsproductsUserDiscountLang = new HashSet<WsproductsUserDiscountLang>();
        }

        public int ProductsUserDiscountId { get; set; }
        public string ProductsUserDiscountDate { get; set; }
        public DateTime ProductsUserDiscountDateTime { get; set; }
        public int ProductGroupId { get; set; }
        public int? DiscountUserId { get; set; }
        public bool? DiscountAllUser { get; set; }
        public int? DiscountProductId { get; set; }
        public bool? DiscountAllPrdInGroup { get; set; }
        public decimal DiscountPercent { get; set; }
        public string Description { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Wsproducts DiscountProduct { get; set; }
        public virtual Users DiscountUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WsproductSecondGroup ProductGroup { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsproductsUserDiscountLang> WsproductsUserDiscountLang { get; set; }
    }
}
