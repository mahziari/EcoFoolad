using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WslogoLang
    {
        public int WslogoLangId { get; set; }
        public int LogoId { get; set; }
        public int LanguageId { get; set; }
        public string LogoDescription { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Wslogo Logo { get; set; }
    }
}
