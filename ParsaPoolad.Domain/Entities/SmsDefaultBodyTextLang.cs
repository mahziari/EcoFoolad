using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SmsDefaultBodyTextLang
    {
        public int SmsDefaultBodyTextLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public virtual SmsDefaultBodyText IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
