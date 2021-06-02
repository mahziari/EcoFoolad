using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsDefaultBodyTextGroups
    {
        public SmsDefaultBodyTextGroups()
        {
            SmsDefaultBodyText = new HashSet<SmsDefaultBodyText>();
            SmsDefaultBodyTextGroupsLang = new HashSet<SmsDefaultBodyTextGroupsLang>();
        }

        public int Id { get; set; }
        public short? Code { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public int? OrderView { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SmsDefaultBodyText> SmsDefaultBodyText { get; set; }
        public virtual ICollection<SmsDefaultBodyTextGroupsLang> SmsDefaultBodyTextGroupsLang { get; set; }
    }
}
