using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SmsSetting
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        public decimal? EnCost { get; set; }
        public decimal? FaCost { get; set; }
        public bool? SendIsActive { get; set; }
        public bool? ReceiveIsActive { get; set; }
        public string Description { get; set; }
        public string Tmp { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string CmpTpattern { get; set; }
        public string CmpPattern { get; set; }
        public string PrsTpattern { get; set; }
        public string PrsFnpattern { get; set; }
        public string PrsLnpattern { get; set; }
        public string PrsJobPattern { get; set; }
        public Guid? Guid { get; set; }
        public bool? GetAutoDeliveryIsActive { get; set; }
        public string AppType { get; set; }
        public decimal? LastCreditAmount { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? ActiveSendAfterRegNewNum { get; set; }
        public string SendAfterRegNewNumText { get; set; }
        public bool? SendAfterRegNewNumWeb { get; set; }
        public bool? SendAfterRegNewNumGsm { get; set; }
        public bool? ActiveSendAfterUnKnownNumCall { get; set; }
        public string SendAfterUnKnownNumCallText { get; set; }
        public bool? SendAfterUnKnownNumCallWeb { get; set; }
        public bool? SendAfterUnKnownNumCallGsm { get; set; }
        public bool? ActiveSendAfterKnownCallNum { get; set; }
        public string SendAfterKnownNumCallText { get; set; }
        public bool? SendAfterKnownNumCallWeb { get; set; }
        public bool? SendAfterKnownNumCallGsm { get; set; }
        public bool? ActiveSendBirthCongratulate { get; set; }
        public string SendBirthCongratulateText { get; set; }
        public bool? SendBirthCongratulateWeb { get; set; }
        public bool? SendBirthCongratulateGsm { get; set; }
        public bool? ActiveSendMarriageCongratulate { get; set; }
        public string SendMarriageCongratulateText { get; set; }
        public bool? SendMarriageCongratulateWeb { get; set; }
        public bool? SendMarriageCongratulateGsm { get; set; }
        public int? ProviderId { get; set; }
        public string DomainName { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual SmsProviders Provider { get; set; }
        public virtual Users User { get; set; }
    }
}
