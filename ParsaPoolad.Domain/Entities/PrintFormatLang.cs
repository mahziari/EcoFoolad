using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class PrintFormatLang
    {
        public int PrintFormatLangId { get; set; }
        public int PrintFormatId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PrintFormat PrintFormat { get; set; }
    }
}
