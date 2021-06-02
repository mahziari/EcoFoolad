using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class UserLoginAllowedTimes
    {
        public int UserLoginAllowedTimeId { get; set; }
        public int CrmUserId { get; set; }
        public int? DayNumber { get; set; }
        public string Ftime { get; set; }
        public string Ttime { get; set; }
        public string FdatePersian { get; set; }
        public DateTime? Fdatetime { get; set; }
        public string TdatePersian { get; set; }
        public DateTime? Tdatetime { get; set; }
        public string Ipaddress { get; set; }
        public int FirstUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }

        public virtual Users CrmUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Users FirstUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
