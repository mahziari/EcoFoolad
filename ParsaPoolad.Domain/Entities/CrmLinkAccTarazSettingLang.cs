using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmLinkAccTarazSettingLang
    {
        public int CrmLinkAccTarazSettingLangId { get; set; }
        public int LinkAccTarazSettingId { get; set; }
        public int LanguageId { get; set; }
        public string PartDescription { get; set; }
        public string PartLabelTitle { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccTarazSetting LinkAccTarazSetting { get; set; }
    }
}
