using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsbuyOrderItemSerialsLang
    {
        public int WsbuyOrderItemSerialsLangId { get; set; }
        public int BuyOrderItemSerialId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public string InfoI { get; set; }
        public string InfoIi { get; set; }
        public string InfoIii { get; set; }
        public string InfoIv { get; set; }
        public string InfoV { get; set; }
        public string InfoVi { get; set; }

        public virtual WsbuyOrderItemSerials BuyOrderItemSerial { get; set; }
        public virtual Languages Language { get; set; }
    }
}
