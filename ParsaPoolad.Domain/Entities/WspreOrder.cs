using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WspreOrder
    {
        public WspreOrder()
        {
            Wsorder = new HashSet<Wsorder>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WspreOrderLang = new HashSet<WspreOrderLang>();
            WspreOrderPayments = new HashSet<WspreOrderPayments>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
        }

        public int PreOrderId { get; set; }
        public string PordTitle { get; set; }
        public long PordNumber { get; set; }
        public string PordDate { get; set; }
        public int? PordCompanyId { get; set; }
        public int? PordCompanyPersonId { get; set; }
        public int? PordProjectId { get; set; }
        public string PordSubject { get; set; }
        public int? PordItemCount { get; set; }
        public decimal? PordItemsAmount { get; set; }
        public decimal? PordInstallAmount { get; set; }
        public decimal? PordDiscount { get; set; }
        public decimal? PordSumAmount { get; set; }
        public decimal? PordTax { get; set; }
        public decimal? PordTaxIndex { get; set; }
        public bool? PordCalculateTax { get; set; }
        public decimal? PordTotalAmount { get; set; }
        public string PordTotalAmountStr { get; set; }
        public bool? PordIsVerified { get; set; }
        public int? PordVerifierId { get; set; }
        public int? PordVerifierRequestId { get; set; }
        public DateTime? PordVerifiedRegisterDate { get; set; }
        public string PordVerifiedRegisterDatePersian { get; set; }
        public int? PordStatusId { get; set; }
        public bool? PordIsFixed { get; set; }
        public int? PordGuarantyId { get; set; }
        public int? PordPayConditionId { get; set; }
        public int? PordDeliveryTimeId { get; set; }
        public int? PordCreditDurationId { get; set; }
        public string PordSpecialWord { get; set; }
        public string PordDescriptionI { get; set; }
        public string PordDescriptionIi { get; set; }
        public int? PordDescriptionId { get; set; }
        public int? PordPrintFormatId { get; set; }
        public int? PordRlogoId { get; set; }
        public int? PordLlogoId { get; set; }
        public string PordSigningI { get; set; }
        public string PordSigningIi { get; set; }
        public string PordSigningIii { get; set; }
        public string PordAccountNumberI { get; set; }
        public string PordAccountShabaNumberI { get; set; }
        public string PordAccountNumberIi { get; set; }
        public string PordAccountShabaNumberIi { get; set; }
        public string PordAddress { get; set; }
        public string PordTelephone { get; set; }
        public string PordFax { get; set; }
        public string PordWebSite { get; set; }
        public string PordEmail { get; set; }
        public int? PordSignatureId { get; set; }
        public string PordImportDate { get; set; }
        public int? PordFirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string PordDay { get; set; }
        public string PordTime { get; set; }
        public Guid? Guid { get; set; }
        public string PordDiscountTitle { get; set; }
        public decimal? PordDiscountPercent { get; set; }
        public decimal? PordTransportation { get; set; }
        public int? PordReferUserId { get; set; }
        public decimal? PordRound { get; set; }
        public string PordcmpTitle { get; set; }
        public DateTime? PordDateTime { get; set; }
        public DateTime? PordImportDateTime { get; set; }
        public string PordDeliveryDate { get; set; }
        public DateTime? PordDeliveryDateTime { get; set; }
        public string PordDeliveryTime { get; set; }
        public int? PreOrderOprId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? PordVerificationWorkFlowId { get; set; }
        public string PordExpireDate { get; set; }
        public DateTime? PordExpireDateTime { get; set; }
        public int? PordLinkAccPreOrderId { get; set; }
        public string PordLinkAccPreOrderNumber { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCompany PordCompany { get; set; }
        public virtual CrmCompanyPersons PordCompanyPerson { get; set; }
        public virtual WscreditDuration PordCreditDuration { get; set; }
        public virtual WsdeliveryTime PordDeliveryTimeNavigation { get; set; }
        public virtual Users PordFirstRegisterUser { get; set; }
        public virtual Wsguaranty PordGuaranty { get; set; }
        public virtual Wslogo PordLlogo { get; set; }
        public virtual WspayCondition PordPayCondition { get; set; }
        public virtual PrintFormat PordPrintFormat { get; set; }
        public virtual CrmProjects PordProject { get; set; }
        public virtual Users PordReferUser { get; set; }
        public virtual Wslogo PordRlogo { get; set; }
        public virtual Wssignature PordSignature { get; set; }
        public virtual WspreOrderStatus PordStatus { get; set; }
        public virtual WsverificationWorkFlows PordVerificationWorkFlow { get; set; }
        public virtual Users PordVerifier { get; set; }
        public virtual Users PordVerifierRequest { get; set; }
        public virtual WspreOrderOpr PreOrderOpr { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WspreOrderLang> WspreOrderLang { get; set; }
        public virtual ICollection<WspreOrderPayments> WspreOrderPayments { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
    }
}
