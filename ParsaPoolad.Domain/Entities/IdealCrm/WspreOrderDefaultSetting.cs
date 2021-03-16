using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WspreOrderDefaultSetting
    {
        public WspreOrderDefaultSetting()
        {
            WspreOrderDefaultSettingLang = new HashSet<WspreOrderDefaultSettingLang>();
        }

        public int PreOrderSettingId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public int? GuarantyId { get; set; }
        public int? PayConditionId { get; set; }
        public int? DeliveryTimeId { get; set; }
        public int? CreditDurationId { get; set; }
        public decimal? TaxIndex { get; set; }
        public bool? CalculateTax { get; set; }
        public string SpecialWord { get; set; }
        public string DescriptionI { get; set; }
        public string DescriptionIi { get; set; }
        public int? PrintFormatId { get; set; }
        public int? RightLogoId { get; set; }
        public int? LeftLogoId { get; set; }
        public string SigningI { get; set; }
        public string SigningIi { get; set; }
        public string SigningIii { get; set; }
        public string AccountNumberI { get; set; }
        public string AccountShabaNumberI { get; set; }
        public string AccountNumberIi { get; set; }
        public string AccountShabaNumberIi { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public int? SignatureId { get; set; }
        public int? VerifierRequestId { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string SettingTitle { get; set; }
        public Guid? Guid { get; set; }
        public int? ReferUserId { get; set; }
        public int? PreOrderOprId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? VerificationWorkFlowId { get; set; }

        public virtual WscreditDuration CreditDuration { get; set; }
        public virtual WsdeliveryTime DeliveryTime { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Wsguaranty Guaranty { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wslogo LeftLogo { get; set; }
        public virtual WspayCondition PayCondition { get; set; }
        public virtual WspreOrderOpr PreOrderOpr { get; set; }
        public virtual PrintFormat PrintFormat { get; set; }
        public virtual Users ReferUser { get; set; }
        public virtual Wslogo RightLogo { get; set; }
        public virtual Wssignature Signature { get; set; }
        public virtual Users User { get; set; }
        public virtual WsverificationWorkFlows VerificationWorkFlow { get; set; }
        public virtual Users VerifierRequest { get; set; }
        public virtual ICollection<WspreOrderDefaultSettingLang> WspreOrderDefaultSettingLang { get; set; }
    }
}
