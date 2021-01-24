using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductShpStockManageTypesLang
    {
        public int WsproductShpStockManageTypesLangId { get; set; }
        public int ProductShpStockManageTypeId { get; set; }
        public string ProductShpStockManageType { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductShpStockManageTypes ProductShpStockManageTypeNavigation { get; set; }
    }
}
