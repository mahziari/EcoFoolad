using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmLinkAccSettingLang
    {
        public int CrmLinkAccSettingLangId { get; set; }
        public int LinkAccSettingId { get; set; }
        public int LanguageId { get; set; }
        public string PartDescription { get; set; }
        public string PartLabelTitle { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccSetting LinkAccSetting { get; set; }
    }
}
