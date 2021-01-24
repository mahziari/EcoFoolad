using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrderPayments
    {
        public WsbuyOrderPayments()
        {
            WsbuyOrderPaymentsLang = new HashSet<WsbuyOrderPaymentsLang>();
        }

        public int BuyOrderPaymentId { get; set; }
        public string ImportDate { get; set; }
        public int BordpayTypeId { get; set; }
        public int BordpayOrderId { get; set; }
        public int? BordpayDocId { get; set; }
        public int? BordpayDocTypeId { get; set; }
        public decimal BordpayAmount { get; set; }
        public string BordpayDocNumber { get; set; }
        public string BordpayDocDate { get; set; }
        public string BordpayDescription { get; set; }
        public int? BordpayFirstRegisterUserId { get; set; }
        public string BordpayFirstRegisteDatePersian { get; set; }
        public DateTime? BordpayFirstRegisteDate { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public DateTime? BordpayDocDateTime { get; set; }
        public Guid? Guid { get; set; }
        public decimal? BordpayDocAmount { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? BordpayLinkAccHeaderId { get; set; }
        public string BordpayLinkAccHeaderNumber { get; set; }
        public int? BordpayLinkAccDetailId { get; set; }
        public int? BordpayLinkAccVoucherId { get; set; }
        public string BordpayLinkAccVoucherNumber { get; set; }

        public virtual Users BordpayFirstRegisterUser { get; set; }
        public virtual WsbuyOrder BordpayOrder { get; set; }
        public virtual WsbuyOrderPaymentTypes BordpayType { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrderPaymentsLang> WsbuyOrderPaymentsLang { get; set; }
    }
}
