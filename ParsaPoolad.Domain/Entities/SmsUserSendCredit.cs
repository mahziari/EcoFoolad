using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SmsUserSendCredit
    {
        public SmsUserSendCredit()
        {
            SmsUserSendCreditLang = new HashSet<SmsUserSendCreditLang>();
        }

        public int Id { get; set; }
        public int CreditUserId { get; set; }
        public string ImportDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
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
        public DateTime? ImportDateTime { get; set; }

        public virtual Users CreditUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SmsUserSendCreditLang> SmsUserSendCreditLang { get; set; }
    }
}
