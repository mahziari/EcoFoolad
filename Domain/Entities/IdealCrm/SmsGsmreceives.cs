using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsGsmreceives
    {
        public int Id { get; set; }
        public int? Folder { get; set; }
        public int? Location { get; set; }
        public string ReceiveNumber { get; set; }
        public string ReceiveText { get; set; }
        public DateTime ReceiveTime { get; set; }
        public string ConcatenatedInfo { get; set; }
        public int? Coding { get; set; }
        public int? Status { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
