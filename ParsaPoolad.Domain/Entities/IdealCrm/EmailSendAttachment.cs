using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class EmailSendAttachment
    {
        public int EmailSendAttachmentId { get; set; }
        public int EmailSendHeaderId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual EmailSendHeader EmailSendHeader { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
