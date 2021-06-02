using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WspreOrderPayments
    {
        public WspreOrderPayments()
        {
            WsorderPayments = new HashSet<WsorderPayments>();
            WspreOrderPaymentsLang = new HashSet<WspreOrderPaymentsLang>();
        }

        public int PreOrderPaymentId { get; set; }
        public string ImportDate { get; set; }
        public int PordpayTypeId { get; set; }
        public int PordpayPreOrderId { get; set; }
        public int? PordpayDocId { get; set; }
        public int? PordpayDocTypeId { get; set; }
        public decimal PordpayAmount { get; set; }
        public string PordpayDocNumber { get; set; }
        public string PordpayDocDate { get; set; }
        public decimal? PordpayDocAmount { get; set; }
        public string PordpayDescription { get; set; }
        public int? PordpayFirstRegisterUserId { get; set; }
        public string PordpayFirstRegisteDatePersian { get; set; }
        public DateTime? PordpayFirstRegisteDate { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public DateTime? PordpayDocDateTime { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? PordpayLinkAccHeaderId { get; set; }
        public string PordpayLinkAccHeaderNumber { get; set; }
        public int? PordpayLinkAccDetailId { get; set; }
        public int? PordpayLinkAccVoucherId { get; set; }
        public string PordpayLinkAccVoucherNumber { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users PordpayFirstRegisterUser { get; set; }
        public virtual WspreOrder PordpayPreOrder { get; set; }
        public virtual WsorderPaymentTypes PordpayType { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPayments { get; set; }
        public virtual ICollection<WspreOrderPaymentsLang> WspreOrderPaymentsLang { get; set; }
    }
}
