using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductCostGroupLang
    {
        public int WsproductCostGroupLangId { get; set; }
        public int ProductCostGroupId { get; set; }
        public int LanguageId { get; set; }
        public string ProductCostGroupName { get; set; }
        public string ProductCostGroupDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductCostGroup ProductCostGroup { get; set; }
    }
}
