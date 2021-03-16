using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class PayRollUserCycleItemValues
    {
        public int PayRollUserCycleItemValueId { get; set; }
        public int CycleId { get; set; }
        public int CrmUserId { get; set; }
        public int ItemId { get; set; }
        public decimal? Value { get; set; }
        public bool? ValueNotValid { get; set; }
        public string UsefulIds { get; set; }
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
        public virtual PayRollUserCycle Cycle { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual PayRollItems Item { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
