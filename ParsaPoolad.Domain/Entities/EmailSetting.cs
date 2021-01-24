using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class EmailSetting
    {
        public EmailSetting()
        {
            CrmFoSetting = new HashSet<CrmFoSetting>();
            EmailSendHeader = new HashSet<EmailSendHeader>();
        }

        public int EmailSettingId { get; set; }
        public bool? EmailBulkingIsActive { get; set; }
        public int? EmailBulkingDelayTime { get; set; }
        public string EmailBulkingDailyStarTime { get; set; }
        public string EmailBulkingDailyEndTime { get; set; }
        public string EmailsAttachFilePath { get; set; }
        public string EmailsAttachShareFilePath { get; set; }
        public string CmpPattern { get; set; }
        public string CmpPrsPattern { get; set; }
        public string CmpPrsJobPattern { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string EmailSu { get; set; }
        public string EmailSp { get; set; }
        public string EmailSenderEditorFilePath { get; set; }
        public string EmailsPdfbodyFilePath { get; set; }
        public string AppType { get; set; }
        public string EmailsAttachShareFilePathFtp { get; set; }
        public string EmailsPdfbodyFilePathFtp { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
        public virtual ICollection<EmailSendHeader> EmailSendHeader { get; set; }
    }
}
