using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class EmailSendHeader
    {
        public EmailSendHeader()
        {
            EmailSendAttachment = new HashSet<EmailSendAttachment>();
            EmailSendDetail = new HashSet<EmailSendDetail>();
        }

        public int EmailSendHeaderId { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime StartDateTime { get; set; }
        public string StartDatePersian { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string EndDatePersian { get; set; }
        public int PriorityId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public int EmailUsersInfoId { get; set; }
        public int EmailSettingId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual EmailSetting EmailSetting { get; set; }
        public virtual EmailUsersInfo EmailUsersInfo { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<EmailSendAttachment> EmailSendAttachment { get; set; }
        public virtual ICollection<EmailSendDetail> EmailSendDetail { get; set; }
    }
}
