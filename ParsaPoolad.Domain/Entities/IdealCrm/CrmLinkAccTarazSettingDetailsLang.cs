using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmLinkAccTarazSettingDetailsLang
    {
        public int CrmLinkAccTarazSettingDetailLangId { get; set; }
        public int LinkAccTarazSettingDetailId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccTarazSettingDetails LinkAccTarazSettingDetail { get; set; }
    }
}
