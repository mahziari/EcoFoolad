using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmFoSettingLang
    {
        public int CrmFoSettingLandId { get; set; }
        public int? FoSettingId { get; set; }
        public string PrjDefaultTitle { get; set; }
        public string PrjDefaultPostFix { get; set; }
        public string CnvsDefaultDesc { get; set; }
        public string CnvsDefaultReferDesc { get; set; }
        public int LanguageId { get; set; }
        public string CnvsDescTooltip { get; set; }
        public string TicketDescTooltip { get; set; }
        public string TicketSubjectDefaultContext { get; set; }
        public string LoginTitle { get; set; }
        public string LoginFormTitle { get; set; }
        public string LoginRegLinkTitle { get; set; }
        public string RegTitle { get; set; }
        public string RegFormTitle { get; set; }
        public string RegLoginLinkTitle { get; set; }
        public string ShpHomePrdPartTitle { get; set; }

        public virtual CrmFoSetting FoSetting { get; set; }
        public virtual Languages Language { get; set; }
    }
}
