using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WspreOrderItemSpecificationLang
    {
        public int WspreOrderItemSpecificationLangId { get; set; }
        public int PreOrderItemSpcflId { get; set; }
        public int LanguageId { get; set; }
        public string Specification { get; set; }
        public string SpecificationI { get; set; }
        public string SpecificationIi { get; set; }

        public virtual Languages Language { get; set; }
    }
}
