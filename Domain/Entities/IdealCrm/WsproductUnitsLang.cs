using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductUnitsLang
    {
        public int WsproductUnitsLangId { get; set; }
        public int ProductUnitId { get; set; }
        public int LanguageId { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public string UnitEn { get; set; }
        public string Shpunit { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductUnits ProductUnit { get; set; }
    }
}
