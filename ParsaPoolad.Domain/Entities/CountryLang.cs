using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CountryLang
    {
        public int CountryLangId { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string Country { get; set; }
        public string CountryDescription { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
