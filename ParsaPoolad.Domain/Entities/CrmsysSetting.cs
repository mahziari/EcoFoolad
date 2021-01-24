using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysSetting
    {
        public CrmsysSetting()
        {
            CrmsysSettingLang = new HashSet<CrmsysSettingLang>();
        }

        public int Id { get; set; }
        public string CoName { get; set; }
        public byte[] CoLoGo { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string ServerIp { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string SantralPreNumber { get; set; }
        public string CallerIdserverIp { get; set; }
        public bool? ServiceSip { get; set; }
        public bool? ServiceSgip { get; set; }
        public string RegistrationNumber { get; set; }
        public string EconomicCode { get; set; }
        public string NationalCode { get; set; }
        public string QuickAddress { get; set; }
        public string LockSerial { get; set; }
        public string LockCounter { get; set; }
        public string LockNu { get; set; }
        public bool? LockControl { get; set; }
        public string AppFilePath { get; set; }
        public Guid? Guid { get; set; }
        public bool? ServiceCiip { get; set; }
        public string PublicNotice { get; set; }
        public string ZipCode { get; set; }
        public bool? ServiceFadeAc { get; set; }
        public string RecordingVoiceServerIp { get; set; }
        public bool? ServiceRip { get; set; }
        public bool? CantSaveDupPrsMob { get; set; }
        public bool? CantSaveDupPrsEmail { get; set; }
        public bool? MustFullcnvsRemindDate { get; set; }
        public string CallerIdversion { get; set; }
        public string CallerIdoldVersion { get; set; }
        public string SmsserviceVersion { get; set; }
        public string SmsserviceOldVersion { get; set; }
        public bool? ServiceBuyOrdIp { get; set; }
        public bool? ServiceEmailIp { get; set; }
        public bool? ServiceLetterIp { get; set; }
        public string AppType { get; set; }
        public bool? DisablefrmcmpSearchOnType { get; set; }
        public string SmsgsmserviceVersion { get; set; }
        public string SmsgsmserviceOldVersion { get; set; }
        public int? LanguageId { get; set; }
        public int? DefaultLanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? CmpQdefCountryId { get; set; }
        public string CmpQdefProjectTitle { get; set; }
        public int? CmpQdefProjectGroupId { get; set; }
        public int? CmpQdefcnvsTopicId { get; set; }
        public bool? ServiceAutoSmsip { get; set; }
        public bool? ServiceDecimalIp { get; set; }
        public bool? ServicePrip { get; set; }
        public bool? CmpQnotNullProjectGroup { get; set; }
        public bool? CmpQnotNullProjectGrade { get; set; }
        public bool? CmpQnotNullProjectPriority { get; set; }
        public string Fourl { get; set; }
        public string PrdBarcodeFormula { get; set; }
        public string LinkAccVersion { get; set; }
        public string LinkAccOldVersion { get; set; }
        public bool? CmpQdefPrintAfterSave { get; set; }
        public bool? CantSaveDupTel { get; set; }
        public bool? CantSaveDupFax { get; set; }
        public bool? CantSaveDupZipCode { get; set; }
        public bool? CantSaveDupPrsNationalCode { get; set; }
        public bool? CantSaveDupCmpNationalCode { get; set; }
        public bool? CantSaveDupCmpEconomicCode { get; set; }
        public int? LinkAccSystemId { get; set; }
        public bool? MustFullPrsNationalCode { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccSystems LinkAccSystem { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmsysSettingLang> CrmsysSettingLang { get; set; }
    }
}
