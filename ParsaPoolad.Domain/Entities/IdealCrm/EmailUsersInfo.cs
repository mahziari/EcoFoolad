using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class EmailUsersInfo
    {
        public EmailUsersInfo()
        {
            CrmFoSetting = new HashSet<CrmFoSetting>();
            EmailReceive = new HashSet<EmailReceive>();
            EmailReceiveFolders = new HashSet<EmailReceiveFolders>();
            EmailSendHeader = new HashSet<EmailSendHeader>();
        }

        public int EmailUsersInfoId { get; set; }
        public int EuUserId { get; set; }
        public string EuNikeName { get; set; }
        public string EuNikeEmail { get; set; }
        public string EuPop3server { get; set; }
        public string EuSmtpserver { get; set; }
        public string EuUserName { get; set; }
        public string EuPassword { get; set; }
        public bool? EuIsActive { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime RegisterDate { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? EuAutoDeleteReceivedEmail { get; set; }
        public bool? EuPop3useSsl { get; set; }
        public int? EuPop3port { get; set; }

        public virtual Users EuUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
        public virtual ICollection<EmailReceive> EmailReceive { get; set; }
        public virtual ICollection<EmailReceiveFolders> EmailReceiveFolders { get; set; }
        public virtual ICollection<EmailSendHeader> EmailSendHeader { get; set; }
    }
}
