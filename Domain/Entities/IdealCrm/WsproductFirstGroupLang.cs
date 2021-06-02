using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductFirstGroupLang
    {
        public int WsproductFirstGroupLangId { get; set; }
        public int PrdFirstGroupId { get; set; }
        public int LanguageId { get; set; }
        public string Fgname { get; set; }
        public string Fgdescription { get; set; }
        public string FgnameEn { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductFirstGroup PrdFirstGroup { get; set; }
    }
}
