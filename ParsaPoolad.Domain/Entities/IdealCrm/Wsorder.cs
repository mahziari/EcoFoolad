using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class Wsorder
    {
        public Wsorder()
        {
            Wsdoc = new HashSet<Wsdoc>();
            WsorderCommissions = new HashSet<WsorderCommissions>();
            WsorderItems = new HashSet<WsorderItems>();
            WsorderLang = new HashSet<WsorderLang>();
            WsorderPayments = new HashSet<WsorderPayments>();
        }

        public int OrderId { get; set; }
        public int? OrderOprId { get; set; }
        public int? PreOrderId { get; set; }
        public int? PreOrderVerifierId { get; set; }
        public string OrdTitle { get; set; }
        public long OrdNumber { get; set; }
        public string OrdDate { get; set; }
        public int OrdCompanyId { get; set; }
        public int? OrdCompanyPersonId { get; set; }
        public int? OrdProjectId { get; set; }
        public string OrdSubject { get; set; }
        public int? OrdItemCount { get; set; }
        public decimal? OrdItemsAmount { get; set; }
        public decimal? OrdInstallAmount { get; set; }
        public decimal? OrdDiscount { get; set; }
        public decimal? OrdSumAmount { get; set; }
        public decimal? OrdTax { get; set; }
        public decimal? OrdTaxIndex { get; set; }
        public bool? OrdCalculateTax { get; set; }
        public decimal? OrdTotalAmount { get; set; }
        public string OrdTotalAmountStr { get; set; }
        public bool? OrdIsVerified { get; set; }
        public DateTime? OrdVerifiedRegisterDate { get; set; }
        public string OrdVerifiedRegisterDatePersian { get; set; }
        public int? OrdStatusId { get; set; }
        public bool? OrdIsFixed { get; set; }
        public int? OrdGuarantyId { get; set; }
        public string OrdSpecialWord { get; set; }
        public string OrdDescriptionI { get; set; }
        public string OrdDescriptionIi { get; set; }
        public int? OrdDescriptionId { get; set; }
        public int? OrdPrintFormatId { get; set; }
        public int? OrdRlogoId { get; set; }
        public int? OrdLlogoId { get; set; }
        public string OrdSigningI { get; set; }
        public string OrdSigningIi { get; set; }
        public string OrdSigningIii { get; set; }
        public string OrdAccountNumberI { get; set; }
        public string OrdAccountShabaNumberI { get; set; }
        public string OrdAccountNumberIi { get; set; }
        public string OrdAccountShabaNumberIi { get; set; }
        public int? OrdSignatureId { get; set; }
        public string OrdImportDate { get; set; }
        public int? OrdFirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? OrdVerifierId { get; set; }
        public int? OrdSettlementTypeId { get; set; }
        public string OrdDay { get; set; }
        public string OrdTime { get; set; }
        public Guid? Guid { get; set; }
        public decimal? OrdTransportation { get; set; }
        public int? OrdReferUserId { get; set; }
        public decimal? OrdDiscountPercent { get; set; }
        public string OrdDiscountTitle { get; set; }
        public decimal? OrdRound { get; set; }
        public string OrdNote { get; set; }
        public string OrdcmpTitle { get; set; }
        public DateTime? OrdDateTime { get; set; }
        public DateTime? OrdImportDateTime { get; set; }
        public string OrdDeliveryDate { get; set; }
        public DateTime? OrdDeliveryDateTime { get; set; }
        public string OrdDeliveryTime { get; set; }
        public string OrdSerial { get; set; }
        public string AppType { get; set; }
        public int? OrdVerifierRequestId { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? OrdVerificationWorkFlowId { get; set; }
        public int? OrdLinkAccCodeId { get; set; }
        public string OrdLinkAccCode { get; set; }
        public int? OrdLinkAccOrderId { get; set; }
        public string OrdLinkAccOrderNumber { get; set; }
        public int? OrdLinkAccVoucherId { get; set; }
        public string OrdLinkAccVoucherNumber { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCompany OrdCompany { get; set; }
        public virtual CrmCompanyPersons OrdCompanyPerson { get; set; }
        public virtual Users OrdFirstRegisterUser { get; set; }
        public virtual Wsguaranty OrdGuaranty { get; set; }
        public virtual Wslogo OrdLlogo { get; set; }
        public virtual PrintFormat OrdPrintFormat { get; set; }
        public virtual CrmProjects OrdProject { get; set; }
        public virtual Users OrdReferUser { get; set; }
        public virtual Wslogo OrdRlogo { get; set; }
        public virtual WssettlementType OrdSettlementType { get; set; }
        public virtual Wssignature OrdSignature { get; set; }
        public virtual WsorderStatus OrdStatus { get; set; }
        public virtual WsverificationWorkFlows OrdVerificationWorkFlow { get; set; }
        public virtual Users OrdVerifier { get; set; }
        public virtual Users OrdVerifierRequest { get; set; }
        public virtual WsorderOpr OrderOpr { get; set; }
        public virtual WspreOrder PreOrder { get; set; }
        public virtual Users PreOrderVerifier { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissions { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WsorderLang> WsorderLang { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPayments { get; set; }
    }
}
