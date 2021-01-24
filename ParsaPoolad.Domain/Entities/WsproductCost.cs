using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductCost
    {
        public WsproductCost()
        {
            WsdocItems = new HashSet<WsdocItems>();
            WsproductCostLang = new HashSet<WsproductCostLang>();
        }

        public int ProductCostId { get; set; }
        public int PrdId { get; set; }
        public string DocDate { get; set; }
        public string DocNumber { get; set; }
        public decimal Cost { get; set; }
        public decimal? CurrencyCost { get; set; }
        public int? CurrencyUnitId { get; set; }
        public decimal? TransportCost { get; set; }
        public decimal? ReleasingCost { get; set; }
        public decimal? SlagCost { get; set; }
        public decimal? OtherCost { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? Whid { get; set; }
        public Guid? Guid { get; set; }
        public int? ProductCostGroupId { get; set; }
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
        public virtual WsproductCostGroup ProductCostGroup { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsdocItems> WsdocItems { get; set; }
        public virtual ICollection<WsproductCostLang> WsproductCostLang { get; set; }
    }
}
