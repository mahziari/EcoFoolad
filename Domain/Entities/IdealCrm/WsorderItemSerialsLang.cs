using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderItemSerialsLang
    {
        public int WsorderItemSerialsLangId { get; set; }
        public int OrderItemSerialId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderItemSerials OrderItemSerial { get; set; }
    }
}
