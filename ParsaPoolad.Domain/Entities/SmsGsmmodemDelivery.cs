using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SmsGsmmodemDelivery
    {
        public int Id { get; set; }
        public int? SendReference { get; set; }
        public string Number { get; set; }
        public string Dtime { get; set; }
        public string DeliveryFaDateTime { get; set; }
        public int? StatusId { get; set; }
        public int? Dstatus { get; set; }
        public int? Folder { get; set; }
        public int? Location { get; set; }
        public string RegisterDatePersian { get; set; }
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
