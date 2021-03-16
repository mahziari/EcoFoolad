using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmTimeAttendance
    {
        public int TimeAttendanceId { get; set; }
        public DateTime TmDate { get; set; }
        public string TmDatePersian { get; set; }
        public int TmTypeId { get; set; }
        public int TmUserId { get; set; }
        public DateTime TmEntryBase { get; set; }
        public DateTime TmEntryTime { get; set; }
        public int TmEntryDelay { get; set; }
        public int TmEntryDelayAllowMin { get; set; }
        public string TmEntryRegisterIp { get; set; }
        public DateTime? TmExitBase { get; set; }
        public DateTime? TmExitTime { get; set; }
        public int? TmExitHurry { get; set; }
        public int? TmExitHurryAllowMin { get; set; }
        public string TmExitRegisterIp { get; set; }
        public string TmDescription { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public short TmYear1 { get; set; }
        public int TmDay { get; set; }
        public int TmDayOfWeek { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users TmUser { get; set; }
        public virtual Users User { get; set; }
    }
}
