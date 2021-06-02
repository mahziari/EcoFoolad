using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductSecondGroupLang
    {
        public int WsproductSecondGroupLangId { get; set; }
        public int PrdSecondGroupId { get; set; }
        public int LanguageId { get; set; }
        public string Sgname { get; set; }
        public string Sgdescription { get; set; }
        public string SgnameEn { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductSecondGroup PrdSecondGroup { get; set; }
    }
}
