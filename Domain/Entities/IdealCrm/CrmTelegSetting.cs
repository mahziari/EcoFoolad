using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmTelegSetting
    {
        public CrmTelegSetting()
        {
            CrmTelegChatMessage = new HashSet<CrmTelegChatMessage>();
            CrmTelegContacts = new HashSet<CrmTelegContacts>();
        }

        public int TelegSettingId { get; set; }
        public string PhoneNumber { get; set; }
        public int? TelegramId { get; set; }
        public int AppApiId { get; set; }
        public string AppApiHash { get; set; }
        public string AppTitle { get; set; }
        public bool IsActive { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmTelegChatMessage> CrmTelegChatMessage { get; set; }
        public virtual ICollection<CrmTelegContacts> CrmTelegContacts { get; set; }
    }
}
