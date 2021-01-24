using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class EmailDefaultBodyTextLang
    {
        public int EmailDefaultBodyTextLangId { get; set; }
        public int EmailDefaultBodyTextId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public virtual EmailDefaultBodyText EmailDefaultBodyText { get; set; }
        public virtual Languages Language { get; set; }
    }
}
