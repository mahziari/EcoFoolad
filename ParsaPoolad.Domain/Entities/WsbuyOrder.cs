using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrder
    {
        public WsbuyOrder()
        {
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            WsbuyOrderLang = new HashSet<WsbuyOrderLang>();
            WsbuyOrderPayments = new HashSet<WsbuyOrderPayments>();
            Wsdoc = new HashSet<Wsdoc>();
        }

        public int BuyOrderId { get; set; }
        public int? BuyOrderOprId { get; set; }
        public int? PreBuyOrderId { get; set; }
        public int? PreBuyOrderVerifierId { get; set; }
        public string BordTitle { get; set; }
        public long BordNumber { get; set; }
        public string BordOrderNumber { get; set; }
        public string BordDate { get; set; }
        public string BordOrderDate { get; set; }
        public DateTime? BordOrderDateTime { get; set; }
        public int BordCompanyId { get; set; }
        public int? BordCompanyPersonId { get; set; }
        public int? BordProjectId { get; set; }
        public string BordSubject { get; set; }
        public int? BordItemCount { get; set; }
        public decimal? BordItemsAmount { get; set; }
        public decimal? BordDiscount { get; set; }
        public decimal? BordSumAmount { get; set; }
        public decimal? BordTax { get; set; }
        public decimal? BordTaxIndex { get; set; }
        public bool? BordCalculateTax { get; set; }
        public decimal? BordTotalAmount { get; set; }
        public string BordTotalAmountStr { get; set; }
        public bool? BordIsVerified { get; set; }
        public int? BordStatusId { get; set; }
        public bool? BordIsFixed { get; set; }
        public int? BordPrintFormatId { get; set; }
        public string BordImportDate { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? BordVerifierId { get; set; }
        public DateTime? BordVerifiedRegisterDate { get; set; }
        public string BordVerifiedRegisterDatePersian { get; set; }
        public int? BordFirstRegisterUserId { get; set; }
        public int? BordSettlementTypeId { get; set; }
        public string BordDay { get; set; }
        public string BordTime { get; set; }
        public decimal? BordTransportation { get; set; }
        public int? BordReferUserId { get; set; }
        public decimal? BordRound { get; set; }
        public decimal? BordDiscountPercent { get; set; }
        public string BordDiscountTitle { get; set; }
        public string BordNote { get; set; }
        public DateTime? BordDateTime { get; set; }
        public DateTime? BordImportDateTime { get; set; }
        public string BordcmpTitle { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? BordLinkAccCodeId { get; set; }
        public string BordLinkAccCode { get; set; }
        public int? BordLinkAccBuyOrderId { get; set; }
        public string BordLinkAccBuyOrderNumber { get; set; }
        public int? BordLinkAccVoucherId { get; set; }
        public string BordLinkAccVoucherNumber { get; set; }

        public virtual CrmCompany BordCompany { get; set; }
        public virtual CrmCompanyPersons BordCompanyPerson { get; set; }
        public virtual Users BordFirstRegisterUser { get; set; }
        public virtual PrintFormat BordPrintFormat { get; set; }
        public virtual CrmProjects BordProject { get; set; }
        public virtual Users BordReferUser { get; set; }
        public virtual WsbuyOrderStatus BordStatus { get; set; }
        public virtual Users BordVerifier { get; set; }
        public virtual WsbuyOrderOpr BuyOrderOpr { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<WsbuyOrderLang> WsbuyOrderLang { get; set; }
        public virtual ICollection<WsbuyOrderPayments> WsbuyOrderPayments { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
    }
}
