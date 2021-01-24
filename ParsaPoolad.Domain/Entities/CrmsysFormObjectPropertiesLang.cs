using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysFormObjectPropertiesLang
    {
        public int CrmsysFormObjectPropertiesLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string ObjectPersianName { get; set; }

        public virtual CrmsysFormObjectProperties IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
