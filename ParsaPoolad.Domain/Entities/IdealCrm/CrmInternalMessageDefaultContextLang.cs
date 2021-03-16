using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessageDefaultContextLang
    {
        public int CrmInternalMessageDefaultContextLangId { get; set; }
        public int InternalMessageDefaultContextId { get; set; }
        public int LanguageId { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
        public string Col6 { get; set; }
        public string Col7 { get; set; }
        public string Col8 { get; set; }
        public string Col9 { get; set; }
        public string Col10 { get; set; }
        public string Col11 { get; set; }
        public string Col12 { get; set; }
        public string Col13 { get; set; }
        public string Col14 { get; set; }
        public string Col15 { get; set; }

        public virtual CrmInternalMessageDefaultContext InternalMessageDefaultContext { get; set; }
        public virtual Languages Language { get; set; }
    }
}
