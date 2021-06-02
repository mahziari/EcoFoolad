using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WscurrencyUnits
    {
        public WscurrencyUnits()
        {
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            WscurrencyUnitsLang = new HashSet<WscurrencyUnitsLang>();
            WsorderItems = new HashSet<WsorderItems>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WsproductCost = new HashSet<WsproductCost>();
            WsproductImportFromExcelCostCurrencyUnit = new HashSet<WsproductImportFromExcel>();
            WsproductImportFromExcelPriceCurrencyUnit = new HashSet<WsproductImportFromExcel>();
            WsproductPrice = new HashSet<WsproductPrice>();
            WstmpUserItemCopy = new HashSet<WstmpUserItemCopy>();
        }

        public int CurrencyUnitId { get; set; }
        public string CurrencyUnit { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string CurrencyUnitEn { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<WscurrencyUnitsLang> WscurrencyUnitsLang { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WsproductCost> WsproductCost { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcelCostCurrencyUnit { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcelPriceCurrencyUnit { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPrice { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopy { get; set; }
    }
}
