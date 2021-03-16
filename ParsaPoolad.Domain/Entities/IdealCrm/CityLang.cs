using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CityLang
    {
        public int CityLangId { get; set; }
        public int CityId { get; set; }
        public int LanguageId { get; set; }
        public string City { get; set; }
        public string Description { get; set; }

        public virtual City CityNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
