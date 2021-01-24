using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsdocOprLang
    {
        public int WsdocOprLangId { get; set; }
        public int DocOprId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual WsdocOpr DocOpr { get; set; }
        public virtual Languages Language { get; set; }
    }
}
