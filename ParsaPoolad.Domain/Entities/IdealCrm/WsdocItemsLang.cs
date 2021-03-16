using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsdocItemsLang
    {
        public int WsdocItemsLangId { get; set; }
        public int DocItemId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual WsdocItems DocItem { get; set; }
        public virtual Languages Language { get; set; }
    }
}
