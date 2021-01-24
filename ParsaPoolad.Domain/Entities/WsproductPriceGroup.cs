using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductPriceGroup
    {
        public WsproductPriceGroup()
        {
            WsproductImportFromExcel = new HashSet<WsproductImportFromExcel>();
            WsproductPrice = new HashSet<WsproductPrice>();
            WsproductPriceGroupLang = new HashSet<WsproductPriceGroupLang>();
        }

        public int ProductPriceGroupId { get; set; }
        public string ProductPriceGroupName { get; set; }
        public string ProductPriceGroupDesc { get; set; }
        public int? OrderView { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? ShpdefaultPriceGroup { get; set; }
        public bool? ShppriceGroupVisible { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcel { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPrice { get; set; }
        public virtual ICollection<WsproductPriceGroupLang> WsproductPriceGroupLang { get; set; }
    }
}
