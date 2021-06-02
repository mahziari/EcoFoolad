using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductPriceGroupLang
    {
        public int WsproductPriceGroupLangId { get; set; }
        public int ProductPriceGroupId { get; set; }
        public int LanguageId { get; set; }
        public string ProductPriceGroupName { get; set; }
        public string ProductPriceGroupDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductPriceGroup ProductPriceGroup { get; set; }
    }
}
