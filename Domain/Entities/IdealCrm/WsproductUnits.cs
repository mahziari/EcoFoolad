using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductUnits
    {
        public WsproductUnits()
        {
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            WsorderItems = new HashSet<WsorderItems>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WsproductImportFromExcel = new HashSet<WsproductImportFromExcel>();
            WsproductUnitsLang = new HashSet<WsproductUnitsLang>();
            Wsproducts = new HashSet<Wsproducts>();
            WstmpUserItemCopy = new HashSet<WstmpUserItemCopy>();
        }

        public int ProductUnitId { get; set; }
        public string Unit { get; set; }
        public int? QuantityInUnit { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string UnitEn { get; set; }
        public Guid? Guid { get; set; }
        public double? Fcr { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? UnitLinkAccUnitId { get; set; }
        public double? Fcri { get; set; }
        public string Shpunit { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcel { get; set; }
        public virtual ICollection<WsproductUnitsLang> WsproductUnitsLang { get; set; }
        public virtual ICollection<Wsproducts> Wsproducts { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopy { get; set; }
    }
}
