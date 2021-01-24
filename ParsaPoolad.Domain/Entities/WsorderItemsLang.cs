using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsorderItemsLang
    {
        public int WsorderItemsLangId { get; set; }
        public int OrderItemId { get; set; }
        public string OrdIdescription { get; set; }
        public string OrdIquantityDesc { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderItems OrderItem { get; set; }
    }
}
