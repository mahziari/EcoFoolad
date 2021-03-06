using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmLinkAccNoAvSetting
    {
        public CrmLinkAccNoAvSetting()
        {
            CrmLinkAccNoAvSettingDetails = new HashSet<CrmLinkAccNoAvSettingDetails>();
            CrmLinkAccNoAvSettingLang = new HashSet<CrmLinkAccNoAvSettingLang>();
        }

        public int LinkAccNoAvSettingId { get; set; }
        public string PartTitle { get; set; }
        public string PartField { get; set; }
        public string PartValue { get; set; }
        public string ObjectType { get; set; }
        public string PartDescription { get; set; }
        public string PartLabelTitle { get; set; }
        public string Description { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingDetails> CrmLinkAccNoAvSettingDetails { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingLang> CrmLinkAccNoAvSettingLang { get; set; }
    }
}
