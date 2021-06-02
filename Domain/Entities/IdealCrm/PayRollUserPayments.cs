using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class PayRollUserPayments
    {
        public PayRollUserPayments()
        {
            PayRollUserPaymentsLang = new HashSet<PayRollUserPaymentsLang>();
        }

        public int PayRollUserPaymentId { get; set; }
        public int CycleId { get; set; }
        public int PayTypeId { get; set; }
        public decimal Amount { get; set; }
        public string UserAccountNumber { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDatePersian { get; set; }
        public string Description { get; set; }
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

        public virtual PayRollUserCycle Cycle { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual PayRollUserPaymentTypes PayType { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PayRollUserPaymentsLang> PayRollUserPaymentsLang { get; set; }
    }
}
