using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsorderCommissions
    {
        public WsorderCommissions()
        {
            WsorderCommissionsLang = new HashSet<WsorderCommissionsLang>();
        }

        public int OrderCommissionId { get; set; }
        public DateTime CommDateTime { get; set; }
        public string CommDatePersian { get; set; }
        public int CommOrderId { get; set; }
        public int CommCmpId { get; set; }
        public int CommUserId { get; set; }
        public decimal? CommBaseAmountDec { get; set; }
        public string CommBaseAmountDecDesc { get; set; }
        public decimal CommBaseAmount { get; set; }
        public double? CommRate { get; set; }
        public string CommRateDesc { get; set; }
        public decimal CommAmount { get; set; }
        public DateTime? CommEffectiveDateTime { get; set; }
        public string CommEffectiveDatePersian { get; set; }
        public int? CommPayTypeId { get; set; }
        public int? CommStatusId { get; set; }
        public string CommDesc { get; set; }
        public bool? CommIsVerified { get; set; }
        public int? CommVerifierUserId { get; set; }
        public DateTime? CommVerifiedDateTime { get; set; }
        public string CommVerifiedDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public bool? CommIsPaid { get; set; }
        public int? CommIsPaidUserId { get; set; }
        public DateTime? CommIsPaidDateTime { get; set; }
        public string CommIsPaidDatePersian { get; set; }
        public int? CommIsPaidPayRollUserCycleId { get; set; }

        public virtual CrmCompany CommCmp { get; set; }
        public virtual PayRollUserCycle CommIsPaidPayRollUserCycle { get; set; }
        public virtual Users CommIsPaidUser { get; set; }
        public virtual Wsorder CommOrder { get; set; }
        public virtual WsorderCommissionPayTypes CommPayType { get; set; }
        public virtual Users CommUser { get; set; }
        public virtual Users CommVerifierUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsorderCommissionsLang> WsorderCommissionsLang { get; set; }
    }
}
