using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductCostLang
    {
        public int WsproductCostLangId { get; set; }
        public int ProductCostId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductCost ProductCost { get; set; }
    }
}
