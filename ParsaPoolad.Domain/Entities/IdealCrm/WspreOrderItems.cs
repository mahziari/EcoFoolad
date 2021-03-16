using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WspreOrderItems
    {
        public WspreOrderItems()
        {
            WspreOrderItemSpecification = new HashSet<WspreOrderItemSpecification>();
            WspreOrderItemsLang = new HashSet<WspreOrderItemsLang>();
        }

        public int PreOrderItemId { get; set; }
        public int PreOrderId { get; set; }
        public int PordIprdId { get; set; }
        public double? PordIquantity { get; set; }
        public decimal? PordIprice { get; set; }
        public decimal? PordItotalPrice { get; set; }
        public string PordIdescription { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string PordIquantityDesc { get; set; }
        public decimal? PordIdiscount { get; set; }
        public decimal? PordIdiscountI { get; set; }
        public decimal? PordIdiscountPercent { get; set; }
        public decimal? PordIdiscountIpercent { get; set; }
        public Guid? Guid { get; set; }
        public int? PordIprdUnitId { get; set; }
        public int? PordIcurrencyUnitId { get; set; }
        public int? PordIorderView { get; set; }
        public double? PordIfcr { get; set; }
        public decimal? PordItax { get; set; }
        public decimal? PordItaxIndex { get; set; }
        public bool? PordIcalculateTax { get; set; }
        public bool? PordInotVisible { get; set; }
        public double? PordIfcri { get; set; }
        public bool? PordInotInSum { get; set; }
        public int? PordIwhid { get; set; }
        public decimal? PordIround { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public decimal? PordIroundPlus { get; set; }
        public int? PordIlinkAccItemId { get; set; }
        public int? PordIprdPriceGroupId { get; set; }
        public string PordItracing { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WscurrencyUnits PordIcurrencyUnit { get; set; }
        public virtual Wsproducts PordIprd { get; set; }
        public virtual WsproductUnits PordIprdUnit { get; set; }
        public virtual WsWareHouse PordIwh { get; set; }
        public virtual WspreOrder PreOrder { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WspreOrderItemSpecification> WspreOrderItemSpecification { get; set; }
        public virtual ICollection<WspreOrderItemsLang> WspreOrderItemsLang { get; set; }
    }
}
