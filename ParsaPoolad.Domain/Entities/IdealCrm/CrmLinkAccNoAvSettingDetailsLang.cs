using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmLinkAccNoAvSettingDetailsLang
    {
        public int CrmLinkAccNoAvSettingDetailLangId { get; set; }
        public int LinkAccNoAvSettingDetailId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccNoAvSettingDetails LinkAccNoAvSettingDetail { get; set; }
    }
}
