using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmTelegBotSetting
    {
        public int TelegBotSettingId { get; set; }
        public string Token { get; set; }
        public string Caption { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public byte[] Picture { get; set; }
        public string WelcomeMessage { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string LanguageCollation { get; set; }
        public bool? IsActive { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
