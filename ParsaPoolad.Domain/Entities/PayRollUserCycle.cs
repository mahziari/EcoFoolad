﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class PayRollUserCycle
    {
        public PayRollUserCycle()
        {
            PayRollUserCycleItemValues = new HashSet<PayRollUserCycleItemValues>();
            PayRollUserCycleLang = new HashSet<PayRollUserCycleLang>();
            PayRollUserPayments = new HashSet<PayRollUserPayments>();
            WsorderCommissions = new HashSet<WsorderCommissions>();
        }

        public int PayRollUserCycleId { get; set; }
        public int CrmUserId { get; set; }
        public string CycleTitle { get; set; }
        public int CycleDuration { get; set; }
        public DateTime CycleDate { get; set; }
        public string CycleDatePersian { get; set; }
        public bool? CycleIsVerified { get; set; }
        public int? CycleVerifierUserId { get; set; }
        public DateTime? CycleVerifiedDate { get; set; }
        public string CycleVerifiedDatePersian { get; set; }
        public int? CyclePrintFormatId { get; set; }
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

        public virtual Users CrmUser { get; set; }
        public virtual PrintFormat CyclePrintFormat { get; set; }
        public virtual Users CycleVerifierUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PayRollUserCycleItemValues> PayRollUserCycleItemValues { get; set; }
        public virtual ICollection<PayRollUserCycleLang> PayRollUserCycleLang { get; set; }
        public virtual ICollection<PayRollUserPayments> PayRollUserPayments { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissions { get; set; }
    }
}
