using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysDbobjectsLang
    {
        public int CrmsysDbobjectsLangId { get; set; }
        public int DbobjectId { get; set; }
        public int LanguageId { get; set; }
        public string FieldTitle { get; set; }

        public virtual CrmsysDbobjects Dbobject { get; set; }
        public virtual Languages Language { get; set; }
    }
}
