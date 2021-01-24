using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductPrice
    {
        public WsproductPrice()
        {
            WsproductPriceLang = new HashSet<WsproductPriceLang>();
        }

        public int PrdPriceId { get; set; }
        public int PrdId { get; set; }
        public string DocDate { get; set; }
        public string DocNumber { get; set; }
        public decimal Price { get; set; }
        public decimal? CurrencyPrice { get; set; }
        public int? CurrencyUnitId { get; set; }
        public decimal? CooperationPrice { get; set; }
        public decimal? PricePercent { get; set; }
        public decimal? DiscountPrecent { get; set; }
        public decimal? Discount { get; set; }
        public decimal? OtherPrice { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? Whid { get; set; }
        public Guid? Guid { get; set; }
        public int? ProductPriceGroupId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public DateTime? DocDateTime { get; set; }

        public virtual WscurrencyUnits CurrencyUnit { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wsproducts Prd { get; set; }
        public virtual WsproductPriceGroup ProductPriceGroup { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsproductPriceLang> WsproductPriceLang { get; set; }
    }
}
