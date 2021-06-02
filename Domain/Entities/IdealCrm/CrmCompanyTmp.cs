using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCompanyTmp
    {
        public CrmCompanyTmp()
        {
            CrmCompanyPersonsTmp = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyTmpLang = new HashSet<CrmCompanyTmpLang>();
            CrmConversationTmp = new HashSet<CrmConversationTmp>();
            CrmProjectsTmp = new HashSet<CrmProjectsTmp>();
        }

        public int CompanyId { get; set; }
        public string ImportDate { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public int? CmpNumber { get; set; }
        public string CmpName { get; set; }
        public string CmpNameEng { get; set; }
        public int? CmpTitleId { get; set; }
        public string CmpFame { get; set; }
        public string CmpActivityType { get; set; }
        public int? CmpGroupId { get; set; }
        public int? CmpSubGroupId { get; set; }
        public int? CmpGroupIdIi { get; set; }
        public int? CmpGroupIdIii { get; set; }
        public int? CmpGroupIdIv { get; set; }
        public int? CmpTypeId { get; set; }
        public int? CmpPresentationId { get; set; }
        public string CmpPreTel { get; set; }
        public string CmpTel { get; set; }
        public string CmpTelUpTo { get; set; }
        public string CmpTelDesc { get; set; }
        public string CmpPreTelIi { get; set; }
        public string CmpTelIi { get; set; }
        public string CmpTelUpToIi { get; set; }
        public string CmpTelIidesc { get; set; }
        public string CmpMobile { get; set; }
        public string CmpFax { get; set; }
        public string CmpFaxDesc { get; set; }
        public int? CmpCountryId { get; set; }
        public int? CmpProvinceId { get; set; }
        public int? CmpCityId { get; set; }
        public string CmpAddress { get; set; }
        public string CmpAddressDesc { get; set; }
        public string CmpZipCode { get; set; }
        public string CmpPostBox { get; set; }
        public string CmpWebSite { get; set; }
        public string CmpEmail { get; set; }
        public string CmpInteresting { get; set; }
        public string CmpSpecialPoint { get; set; }
        public string CmpDescription { get; set; }
        public string CmpUserName { get; set; }
        public string CmpPassword { get; set; }
        public int? CmpFirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int AddType { get; set; }
        public string CmpRegistrationNumber { get; set; }
        public string CmpEconomicCode { get; set; }
        public string CmpNationalCode { get; set; }
        public Guid? Guid { get; set; }
        public string CmpBuyLimit { get; set; }
        public string CmpAccountNumber { get; set; }
        public string CmpAccInquiry { get; set; }
        public string CmpFreight { get; set; }
        public string CmpInquiry { get; set; }
        public int? CmpReferUserId { get; set; }
        public string AppType { get; set; }
        public string CmpSpecialWordForCi { get; set; }
        public string CmpCode { get; set; }
        public string CmpEffectiveDatePersian { get; set; }
        public DateTime? CmpEffectiveDateTime { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public string CmpCoordinateLatitude { get; set; }
        public string CmpCoordinateLongitude { get; set; }
        public DateTime? CmpCoordinateLastDate { get; set; }
        public string CmpCoordinateLastDatePersian { get; set; }
        public int? CmpCoordinateZoomLevel { get; set; }
        public int? CmpCoordinateLastUserId { get; set; }
        public string CmpMultiGroups { get; set; }
        public byte[] CompanyLogo { get; set; }

        public virtual City CmpCity { get; set; }
        public virtual Users CmpCoordinateLastUser { get; set; }
        public virtual Country CmpCountry { get; set; }
        public virtual Users CmpFirstRegisterUser { get; set; }
        public virtual CrmCompanyGroups CmpGroup { get; set; }
        public virtual CrmCompanyGroupsIi CmpGroupIdIiNavigation { get; set; }
        public virtual CrmCompanyGroupsIii CmpGroupIdIiiNavigation { get; set; }
        public virtual CrmCompanyGroupsIv CmpGroupIdIvNavigation { get; set; }
        public virtual CrmCompanyPresentation CmpPresentation { get; set; }
        public virtual Province CmpProvince { get; set; }
        public virtual Users CmpReferUser { get; set; }
        public virtual CrmCompanySubGroups CmpSubGroup { get; set; }
        public virtual CrmCompanyTitle CmpTitle { get; set; }
        public virtual CrmCompanyType CmpType { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmp { get; set; }
        public virtual ICollection<CrmCompanyTmpLang> CrmCompanyTmpLang { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmp { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmp { get; set; }
    }
}
