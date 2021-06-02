using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsGsmsendingTank
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Body { get; set; }
        public bool? Sended { get; set; }
        public long? RefId { get; set; }
        public string Info { get; set; }
        public int? SendDetailId { get; set; }
        public int? SendUserId { get; set; }
        public string RequestTime { get; set; }
        public string RequestDate { get; set; }
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
