using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmTimeAttendanceLog
    {
        public int TimeAttendanceLogId { get; set; }
        public DateTime TmlDate { get; set; }
        public string TmlDatePersian { get; set; }
        public int TmlTypeId { get; set; }
        public int TmlUserId { get; set; }
        public DateTime TmlEntryTime { get; set; }
        public string TmlEntryRegisterIp { get; set; }
        public DateTime? TmlExitTime { get; set; }
        public string TmlExitRegisterIp { get; set; }
        public string TmlDescription { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public short TmlYear1 { get; set; }
        public int TmlDay { get; set; }
        public int TmlDayOfWeek { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users TmlUser { get; set; }
        public virtual Users User { get; set; }
    }
}
