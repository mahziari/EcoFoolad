using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WstmpUserItemCopy
    {
        public int ItemId { get; set; }
        public int? PrdId { get; set; }
        public double? PrdQuantity { get; set; }
        public string QuantityDesc { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountI { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountIpercent { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Description { get; set; }
        public int? PrdUnitId { get; set; }
        public int? CurrencyUnitId { get; set; }
        public int? OrderView { get; set; }
        public double? Fcr { get; set; }
        public string Tmp1 { get; set; }
        public string Tmp2 { get; set; }
        public int UserId { get; set; }
        public string CopyType { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxIndex { get; set; }
        public bool? CalculateTax { get; set; }
        public bool? NotVisible { get; set; }
        public Guid? Guid { get; set; }
        public double? Fcri { get; set; }
        public bool? NotInSum { get; set; }
        public int? Whid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? ObjItemId { get; set; }
        public int? PrdPriceGroupId { get; set; }

        public virtual WscurrencyUnits CurrencyUnit { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wsproducts Prd { get; set; }
        public virtual WsproductUnits PrdUnit { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
    }
}
