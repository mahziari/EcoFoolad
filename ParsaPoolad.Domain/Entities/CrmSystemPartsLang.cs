using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmSystemPartsLang
    {
        public int CrmSystemPartLangId { get; set; }
        public int SystemPartId { get; set; }
        public string PartTitle { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmSystemParts SystemPart { get; set; }
    }
}
