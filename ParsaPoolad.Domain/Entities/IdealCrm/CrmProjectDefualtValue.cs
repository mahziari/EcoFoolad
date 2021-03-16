using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmProjectDefualtValue
    {
        public CrmProjectDefualtValue()
        {
            CrmProjectDefualtValueLang = new HashSet<CrmProjectDefualtValueLang>();
        }

        public int ProjectDefualtValueId { get; set; }
        public int FieldTitleId { get; set; }
        public string DefualtValue { get; set; }
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

        public virtual CrmProjectFieldTitle FieldTitle { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmProjectDefualtValueLang> CrmProjectDefualtValueLang { get; set; }
    }
}
