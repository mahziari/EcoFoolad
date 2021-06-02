using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class EmailUserDefaultSetting
    {
        public int EmailUserDefaultSettingId { get; set; }
        public string EudTitle { get; set; }
        public string EudBody { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime RegisterDate { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
