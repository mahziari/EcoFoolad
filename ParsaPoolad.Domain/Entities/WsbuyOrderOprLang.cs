using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrderOprLang
    {
        public int WsbuyOrderOprLangId { get; set; }
        public int BuyOrderOprId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual WsbuyOrderOpr BuyOrderOpr { get; set; }
        public virtual Languages Language { get; set; }
    }
}
