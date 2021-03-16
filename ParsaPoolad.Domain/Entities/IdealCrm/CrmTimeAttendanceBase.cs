using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmTimeAttendanceBase
    {
        public int TimeAttendanceBaseId { get; set; }
        public int TmbDay { get; set; }
        public string TmbEntryBase { get; set; }
        public int TmbEntryAllowMin { get; set; }
        public string TmbExitBase { get; set; }
        public int TmbExitAllowMin { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
