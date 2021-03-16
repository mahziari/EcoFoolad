using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class EmailReceiveFolders
    {
        public EmailReceiveFolders()
        {
            EmailReceive = new HashSet<EmailReceive>();
        }

        public int EmailReceiveFolderId { get; set; }
        public string FolderName { get; set; }
        public int EmailUsersInfoId { get; set; }
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

        public virtual EmailUsersInfo EmailUsersInfo { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<EmailReceive> EmailReceive { get; set; }
    }
}
