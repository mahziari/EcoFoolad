using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmLinkAccNoAvSettingLang
    {
        public int CrmLinkAccNoAvSettingLangId { get; set; }
        public int LinkAccNoAvSettingId { get; set; }
        public int LanguageId { get; set; }
        public string PartDescription { get; set; }
        public string PartLabelTitle { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccNoAvSetting LinkAccNoAvSetting { get; set; }
    }
}
