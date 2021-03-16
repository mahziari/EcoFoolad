using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyPersons
    {
        public CrmCompanyPersons()
        {
            CrmBankingAccounts = new HashSet<CrmBankingAccounts>();
            CrmCallHistory = new HashSet<CrmCallHistory>();
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyPersonsLang = new HashSet<CrmCompanyPersonsLang>();
            CrmConversation = new HashSet<CrmConversation>();
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
            CrmPersonPicture = new HashSet<CrmPersonPicture>();
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
            WspreOrder = new HashSet<WspreOrder>();
        }

        public int CompanyPersonId { get; set; }
        public int PrsCompanyId { get; set; }
        public string PrsLname { get; set; }
        public string PrsFname { get; set; }
        public int? PrsTitleId { get; set; }
        public int? PrsJobId { get; set; }
        public int? PrsTypeId { get; set; }
        public int? PrsGroupId { get; set; }
        public int? PrsSexId { get; set; }
        public int? PrsEducationId { get; set; }
        public string PrsPreTel { get; set; }
        public string PrsTel { get; set; }
        public string PrsTelUpTo { get; set; }
        public string PrsTelDesc { get; set; }
        public string PrsTelIi { get; set; }
        public string PrsFax { get; set; }
        public string PrsFaxDesc { get; set; }
        public string PrsMobile { get; set; }
        public string PrsWebSite { get; set; }
        public string PrsEmail { get; set; }
        public string PrsEmailIi { get; set; }
        public int? PrsCountryId { get; set; }
        public int? PrsProvinceId { get; set; }
        public int? PrsCityId { get; set; }
        public string PrsAddress { get; set; }
        public string PrsAddressDesc { get; set; }
        public string PrsZipCode { get; set; }
        public string PrsPostBox { get; set; }
        public string PrsNationalCode { get; set; }
        public string PrsIdentityNumber { get; set; }
        public string PrsFatherName { get; set; }
        public string PrsBirthDate { get; set; }
        public string PrsBirthPlace { get; set; }
        public bool? PrsIsMarried { get; set; }
        public string PrsMarriageDate { get; set; }
        public string PrsEducationField { get; set; }
        public string PrsSkill { get; set; }
        public string PrsStudyField { get; set; }
        public string PrsInteresting { get; set; }
        public string PrsSpecialPoint { get; set; }
        public string PrsDescription { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int AddType { get; set; }
        public string ImportDate { get; set; }
        public int? PrsFirstRegisterUserId { get; set; }
        public int? PrsDepartmentId { get; set; }
        public bool? PrsStopSendSms { get; set; }
        public int? PrsOrderView { get; set; }
        public bool? PrsWorkingOut { get; set; }
        public Guid? Guid { get; set; }
        public int? CompanyPersonTemplateId { get; set; }
        public string AppType { get; set; }
        public DateTime? PrsBirthDateTime { get; set; }
        public DateTime? PrsMarriageDateTime { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? PrsTelegramId { get; set; }

        public virtual CrmCompanyPersonsTemplate CompanyPersonTemplate { get; set; }
        public virtual Languages Language { get; set; }
        public virtual City PrsCity { get; set; }
        public virtual CrmCompany PrsCompany { get; set; }
        public virtual Country PrsCountry { get; set; }
        public virtual CrmPersonDepartments PrsDepartment { get; set; }
        public virtual Education PrsEducation { get; set; }
        public virtual CrmPersonGroups PrsGroup { get; set; }
        public virtual CrmPersonJobs PrsJob { get; set; }
        public virtual Province PrsProvince { get; set; }
        public virtual Sex PrsSex { get; set; }
        public virtual CrmPersonTitle PrsTitle { get; set; }
        public virtual CrmPersonType PrsType { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmBankingAccounts> CrmBankingAccounts { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistory { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyPersonsLang> CrmCompanyPersonsLang { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
        public virtual ICollection<CrmPersonPicture> CrmPersonPicture { get; set; }
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
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
    }
}
