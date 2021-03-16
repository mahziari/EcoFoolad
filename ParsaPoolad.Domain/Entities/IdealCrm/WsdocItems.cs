using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsdocItems
    {
        public WsdocItems()
        {
            WsdocItemSerials = new HashSet<WsdocItemSerials>();
            WsdocItemsLang = new HashSet<WsdocItemsLang>();
        }

        public int DocItemId { get; set; }
        public int DocId { get; set; }
        public int PrdId { get; set; }
        public double? Quantity { get; set; }
        public int? CostId { get; set; }
        public decimal? Cost { get; set; }
        public string Description { get; set; }
        public short? IsFix { get; set; }
        public int? Whid { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public bool? NotVisible { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public double? Fcr { get; set; }
        public double? Fcri { get; set; }
        public int? DocIlinkAccItemId { get; set; }
        public string Tracing { get; set; }

        public virtual WsproductCost CostNavigation { get; set; }
        public virtual Wsdoc Doc { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wsproducts Prd { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsdocItemSerials> WsdocItemSerials { get; set; }
        public virtual ICollection<WsdocItemsLang> WsdocItemsLang { get; set; }
    }
}
