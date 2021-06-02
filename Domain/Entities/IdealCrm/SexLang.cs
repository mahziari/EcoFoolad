using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SexLang
    {
        public int SexLangId { get; set; }
        public int LanguageId { get; set; }
        public int SexId { get; set; }
        public string SexType { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Sex Sex { get; set; }
    }
}
