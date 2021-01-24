using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsguarantyLang
    {
        public int WsguarantyLangId { get; set; }
        public int GuarantyId { get; set; }
        public int LanguageId { get; set; }
        public string Guaranty { get; set; }

        public virtual Wsguaranty GuarantyNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
