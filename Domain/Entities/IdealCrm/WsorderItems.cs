using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderItems
    {
        public WsorderItems()
        {
            WsorderItemSerials = new HashSet<WsorderItemSerials>();
            WsorderItemsLang = new HashSet<WsorderItemsLang>();
        }

        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int OrdIprdId { get; set; }
        public double? OrdIquantity { get; set; }
        public decimal? OrdIprice { get; set; }
        public decimal? OrdItotalPrice { get; set; }
        public string OrdIdescription { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string OrdIquantityDesc { get; set; }
        public decimal? OrdIdiscountI { get; set; }
        public decimal? OrdIdiscount { get; set; }
        public decimal? OrdIdiscountPercent { get; set; }
        public decimal? OrdIdiscountIpercent { get; set; }
        public Guid? Guid { get; set; }
        public int? OrdIprdUnitId { get; set; }
        public int? OrdIcurrencyUnitId { get; set; }
        public int? OrdIorderView { get; set; }
        public double? OrdIfcr { get; set; }
        public decimal? OrdItax { get; set; }
        public decimal? OrdItaxIndex { get; set; }
        public bool? OrdIcalculateTax { get; set; }
        public bool? OrdInotVisible { get; set; }
        public double? OrdIfcri { get; set; }
        public bool? OrdInotInSum { get; set; }
        public int? OrdIwhid { get; set; }
        public decimal? OrdIround { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public decimal? OrdIroundPlus { get; set; }
        public double? OrdIpricePartRate { get; set; }
        public decimal? OrdIpricePartI { get; set; }
        public decimal? OrdIpricePartIi { get; set; }
        public int? OrdIlinkAccItemId { get; set; }
        public int? OrdIprdPriceGroupId { get; set; }
        public string OrdItracing { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WscurrencyUnits OrdIcurrencyUnit { get; set; }
        public virtual Wsproducts OrdIprd { get; set; }
        public virtual WsproductUnits OrdIprdUnit { get; set; }
        public virtual WsWareHouse OrdIwh { get; set; }
        public virtual Wsorder Order { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsorderItemSerials> WsorderItemSerials { get; set; }
        public virtual ICollection<WsorderItemsLang> WsorderItemsLang { get; set; }
    }
}
