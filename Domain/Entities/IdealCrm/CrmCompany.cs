using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCompany
    {
        public CrmCompany()
        {
            CrmBankingAccounts = new HashSet<CrmBankingAccounts>();
            CrmCallHistory = new HashSet<CrmCallHistory>();
            CrmCmsComments = new HashSet<CrmCmsComments>();
            CrmCmsLikes = new HashSet<CrmCmsLikes>();
            CrmCompanyForbiddenCompany = new HashSet<CrmCompanyForbiddenCompany>();
            CrmCompanyJustAccessCompany = new HashSet<CrmCompanyJustAccessCompany>();
            CrmCompanyLang = new HashSet<CrmCompanyLang>();
            CrmCompanyLoGo = new HashSet<CrmCompanyLoGo>();
            CrmCompanyMultiGroups = new HashSet<CrmCompanyMultiGroups>();
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPictureAlbums = new HashSet<CrmCompanyPictureAlbums>();
            CrmCompanyUserForbidden = new HashSet<CrmCompanyUserForbidden>();
            CrmConversation = new HashSet<CrmConversation>();
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
            CrmFilesDirectory = new HashSet<CrmFilesDirectory>();
            CrmLinkedCompanyCompany = new HashSet<CrmLinkedCompany>();
            CrmLinkedCompanyLinkedCompany = new HashSet<CrmLinkedCompany>();
            CrmProjects = new HashSet<CrmProjects>();
            CrmTelegBotContacts = new HashSet<CrmTelegBotContacts>();
            CrmTelegContacts = new HashSet<CrmTelegContacts>();
            EmailReceive = new HashSet<EmailReceive>();
            EmailReceiveAttachments = new HashSet<EmailReceiveAttachments>();
            EmailSendDetail = new HashSet<EmailSendDetail>();
            EmailUserTempTank = new HashSet<EmailUserTempTank>();
            MobCompanyAppInfo = new HashSet<MobCompanyAppInfo>();
            SecLetters = new HashSet<SecLetters>();
            SmsReceive = new HashSet<SmsReceive>();
            SmsSendDetail = new HashSet<SmsSendDetail>();
            SmsTempMobileNumbers = new HashSet<SmsTempMobileNumbers>();
            WsbuyOrder = new HashSet<WsbuyOrder>();
            Wsdoc = new HashSet<Wsdoc>();
            Wsorder = new HashSet<Wsorder>();
            WsorderCommissions = new HashSet<WsorderCommissions>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
            Wsproducts = new HashSet<Wsproducts>();
            WsproductsRate = new HashSet<WsproductsRate>();
        }
        public int CompanyId { get; set; }
        public string ImportDate { get; set; }
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
        public int CmpReferUserId { get; set; }
        public string AppType { get; set; }
        public string CmpSpecialWordForCi { get; set; }
        public string CmpCode { get; set; }
        public string CmpEffectiveDatePersian { get; set; }
        public DateTime? CmpEffectiveDateTime { get; set; }
        public DateTime? ImportDateTime { get; set; }
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
        public bool? CmpFoaccessLinkedCompany { get; set; }
        public int? CmpLinkAccCodeId { get; set; }
        public string CmpLinkAccCode { get; set; }
        public int? CmpLinkAccCustomerId { get; set; }
        public string CmpLinkAccCustomerIdStr { get; set; }
        public bool? CmpIsDraft { get; set; }
        public int? CmpKind { get; set; }
        public int? CmpMainPersonId { get; set; }
        public int? ParsaPooladMenusId { get; set; }
        public int? CrmUsersId { get; set; }
        public bool IsFactory { get; set; }

        public virtual City CmpCity { get; set; }
        public virtual Country CmpCountry { get; set; }
        public virtual CrmCompanyGroups CmpGroup { get; set; }
        public virtual CrmCompanyGroupsIi CmpGroupIdIiNavigation { get; set; }
        public virtual CrmCompanyGroupsIii CmpGroupIdIiiNavigation { get; set; }
        public virtual CrmCompanyGroupsIv CmpGroupIdIvNavigation { get; set; }
        public virtual CrmCompanyPersons CmpMainPerson { get; set; }
        public virtual CrmCompanyPresentation CmpPresentation { get; set; }
        public virtual Province CmpProvince { get; set; }
        public virtual CrmCompanySubGroups CmpSubGroup { get; set; }
        public virtual CrmCompanyTitle CmpTitle { get; set; }
        public virtual CrmCompanyType CmpType { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        
        public virtual ParsaPooladMenus ParsaPooladMenus { get; set; }
        public virtual ICollection<CrmBankingAccounts> CrmBankingAccounts { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistory { get; set; }
        public virtual ICollection<CrmCmsComments> CrmCmsComments { get; set; }
        public virtual ICollection<CrmCmsLikes> CrmCmsLikes { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCompany> CrmCompanyForbiddenCompany { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCompany> CrmCompanyJustAccessCompany { get; set; }
        public virtual ICollection<CrmCompanyLang> CrmCompanyLang { get; set; }
        public virtual ICollection<CrmCompanyLoGo> CrmCompanyLoGo { get; set; }
        public virtual ICollection<CrmCompanyMultiGroups> CrmCompanyMultiGroups { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPictureAlbums> CrmCompanyPictureAlbums { get; set; }
        public virtual ICollection<CrmCompanyUserForbidden> CrmCompanyUserForbidden { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
        public virtual ICollection<CrmFilesDirectory> CrmFilesDirectory { get; set; }
        public virtual ICollection<CrmLinkedCompany> CrmLinkedCompanyCompany { get; set; }
        public virtual ICollection<CrmLinkedCompany> CrmLinkedCompanyLinkedCompany { get; set; }
        public virtual ICollection<CrmProjects> CrmProjects { get; set; }
        public virtual ICollection<CrmTelegBotContacts> CrmTelegBotContacts { get; set; }
        public virtual ICollection<CrmTelegContacts> CrmTelegContacts { get; set; }
        public virtual ICollection<EmailReceive> EmailReceive { get; set; }
        public virtual ICollection<EmailReceiveAttachments> EmailReceiveAttachments { get; set; }
        public virtual ICollection<EmailSendDetail> EmailSendDetail { get; set; }
        public virtual ICollection<EmailUserTempTank> EmailUserTempTank { get; set; }
        public virtual ICollection<MobCompanyAppInfo> MobCompanyAppInfo { get; set; }
        public virtual ICollection<SecLetters> SecLetters { get; set; }
        public virtual ICollection<SmsReceive> SmsReceive { get; set; }
        public virtual ICollection<SmsSendDetail> SmsSendDetail { get; set; }
        public virtual ICollection<SmsTempMobileNumbers> SmsTempMobileNumbers { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissions { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
        public virtual ICollection<Wsproducts> Wsproducts { get; set; }
        public virtual ICollection<WsproductsRate> WsproductsRate { get; set; }
    }
}
