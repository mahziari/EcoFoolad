using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsdocItemSerialsLang
    {
        public int WsdocItemSerialsLangId { get; set; }
        public int DocItemSerialId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public string InfoI { get; set; }
        public string InfoIi { get; set; }
        public string InfoIii { get; set; }
        public string InfoIv { get; set; }
        public string InfoV { get; set; }
        public string InfoVi { get; set; }

        public virtual WsdocItemSerials DocItemSerial { get; set; }
        public virtual Languages Language { get; set; }
    }
}
