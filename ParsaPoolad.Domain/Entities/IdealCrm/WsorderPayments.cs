using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsorderPayments
    {
        public WsorderPayments()
        {
            WsorderPaymentsLang = new HashSet<WsorderPaymentsLang>();
        }

        public int OrderPaymentId { get; set; }
        public string ImportDate { get; set; }
        public int OrdpayTypeId { get; set; }
        public int OrdpayOrderId { get; set; }
        public int? OrdpayDocId { get; set; }
        public int? OrdpayDocTypeId { get; set; }
        public decimal OrdpayAmount { get; set; }
        public string OrdpayDocNumber { get; set; }
        public string OrdpayDocDate { get; set; }
        public string OrdpayDescription { get; set; }
        public int? OrdpayFirstRegisterUserId { get; set; }
        public string OrdpayFirstRegisteDatePersian { get; set; }
        public DateTime? OrdpayFirstRegisteDate { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public DateTime? OrdpayDocDateTime { get; set; }
        public Guid? Guid { get; set; }
        public decimal? OrdpayDocAmount { get; set; }
        public int? PreOrderPaymentId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? OrdpayLinkAccHeaderId { get; set; }
        public string OrdpayLinkAccHeaderNumber { get; set; }
        public int? OrdpayLinkAccDetailId { get; set; }
        public int? OrdpayLinkAccVoucherId { get; set; }
        public string OrdpayLinkAccVoucherNumber { get; set; }
        public string OrdpayBankDocNumber { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users OrdpayFirstRegisterUser { get; set; }
        public virtual Wsorder OrdpayOrder { get; set; }
        public virtual WsorderPaymentTypes OrdpayType { get; set; }
        public virtual WspreOrderPayments PreOrderPayment { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsorderPaymentsLang> WsorderPaymentsLang { get; set; }
    }
}
