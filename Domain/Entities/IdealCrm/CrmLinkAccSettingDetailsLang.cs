using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmLinkAccSettingDetailsLang
    {
        public int CrmLinkAccSettingDetailLangId { get; set; }
        public int LinkAccSettingDetailId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccSettingDetails LinkAccSettingDetail { get; set; }
    }
}
