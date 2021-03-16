using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class PayRollUserPaymentTypes
    {
        public PayRollUserPaymentTypes()
        {
            PayRollUserPaymentTypesLang = new HashSet<PayRollUserPaymentTypesLang>();
            PayRollUserPayments = new HashSet<PayRollUserPayments>();
        }

        public int PayRollUserPaymentTypeId { get; set; }
        public string PaymentType { get; set; }
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

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PayRollUserPaymentTypesLang> PayRollUserPaymentTypesLang { get; set; }
        public virtual ICollection<PayRollUserPayments> PayRollUserPayments { get; set; }
    }
}
