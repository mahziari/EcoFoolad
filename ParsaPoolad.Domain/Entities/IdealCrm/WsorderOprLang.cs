using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsorderOprLang
    {
        public int WsorderOprLangId { get; set; }
        public int OrderOprId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderOpr OrderOpr { get; set; }
    }
}
