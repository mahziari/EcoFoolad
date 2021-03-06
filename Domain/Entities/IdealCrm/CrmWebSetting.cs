using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmWebSetting
    {
        public int WebSettingId { get; set; }
        public string KeyFa { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public string RregularExpression { get; set; }
        public bool IsDecoded { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
