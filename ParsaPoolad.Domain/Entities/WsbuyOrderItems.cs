using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrderItems
    {
        public WsbuyOrderItems()
        {
            WsbuyOrderItemSerials = new HashSet<WsbuyOrderItemSerials>();
            WsbuyOrderItemsLang = new HashSet<WsbuyOrderItemsLang>();
        }

        public int BuyOrderItemId { get; set; }
        public int BuyOrderId { get; set; }
        public int BordIprdId { get; set; }
        public double? BordIquantity { get; set; }
        public decimal? BordIcost { get; set; }
        public decimal? BordItotalCost { get; set; }
        public string BordIdescription { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string BordIquantityDesc { get; set; }
        public decimal? BordIdiscount { get; set; }
        public decimal? BordIdiscountI { get; set; }
        public Guid? Guid { get; set; }
        public decimal? BordIdiscountPercent { get; set; }
        public decimal? BordIdiscountIpercent { get; set; }
        public int? BordIprdUnitId { get; set; }
        public int? BordIcurrencyUnitId { get; set; }
        public int? BordIorderView { get; set; }
        public double? BordIfcr { get; set; }
        public decimal? BordItax { get; set; }
        public decimal? BordItaxIndex { get; set; }
        public bool? BordIcalculateTax { get; set; }
        public bool? BordInotVisible { get; set; }
        public double? BordIfcri { get; set; }
        public bool? BordInotInSum { get; set; }
        public int? BordIwhid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? BordIlinkAccItemId { get; set; }
        public int? BordIprdCostGroupId { get; set; }
        public string BordItracing { get; set; }

        public virtual WscurrencyUnits BordIcurrencyUnit { get; set; }
        public virtual Wsproducts BordIprd { get; set; }
        public virtual WsproductUnits BordIprdUnit { get; set; }
        public virtual WsWareHouse BordIwh { get; set; }
        public virtual WsbuyOrder BuyOrder { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrderItemSerials> WsbuyOrderItemSerials { get; set; }
        public virtual ICollection<WsbuyOrderItemsLang> WsbuyOrderItemsLang { get; set; }
    }
}
