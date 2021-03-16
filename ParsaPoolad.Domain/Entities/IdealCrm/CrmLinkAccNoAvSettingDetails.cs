using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmLinkAccNoAvSettingDetails
    {
        public CrmLinkAccNoAvSettingDetails()
        {
            CrmLinkAccNoAvSettingDetailsLang = new HashSet<CrmLinkAccNoAvSettingDetailsLang>();
        }

        public int LinkAccNoAvSettingDetailId { get; set; }
        public int LinkAccNoAvSettingId { get; set; }
        public int? ObjectId { get; set; }
        public string PartField { get; set; }
        public string PartValue { get; set; }
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
        public virtual CrmLinkAccNoAvSetting LinkAccNoAvSetting { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingDetailsLang> CrmLinkAccNoAvSettingDetailsLang { get; set; }
    }
}
