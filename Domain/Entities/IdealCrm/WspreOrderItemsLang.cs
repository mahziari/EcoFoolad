using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WspreOrderItemsLang
    {
        public int WspreOrderItemsLangId { get; set; }
        public int PreOrderItemId { get; set; }
        public int LanguageId { get; set; }
        public string PordIdescription { get; set; }
        public string PordIquantityDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrderItems PreOrderItem { get; set; }
    }
}
