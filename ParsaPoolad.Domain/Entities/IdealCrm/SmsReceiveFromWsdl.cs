using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SmsReceiveFromWsdl
    {
        public long Id { get; set; }
        public long? OrderNum { get; set; }
        public string SmsNumber { get; set; }
        public string SmsDesc { get; set; }
        public string GetId { get; set; }
        public string FromNumber { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string ReceiveDatePersian { get; set; }
        public string ReceiveDatePersianPreview { get; set; }
        public DateTime? SendDate { get; set; }
        public string SendDatePersian { get; set; }
        public string SendDatePersianPreview { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string ReceiveDay { get; set; }
        public string ReceiveTime { get; set; }
        public Guid? Guid { get; set; }
        public int? ReceiveType { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
