using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductColorLang
    {
        public int WsproductColorLangId { get; set; }
        public int ProductColorId { get; set; }
        public int LanguageId { get; set; }
        public string Color { get; set; }
        public string ColorDescription { get; set; }
        public string ColorEn { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductColor ProductColor { get; set; }
    }
}
