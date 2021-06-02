using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectFieldTitle
    {
        public CrmProjectFieldTitle()
        {
            CrmProjectDefualtValue = new HashSet<CrmProjectDefualtValue>();
            CrmProjectFieldTitleLang = new HashSet<CrmProjectFieldTitleLang>();
            CrmProjectInformations = new HashSet<CrmProjectInformations>();
        }

        public int ProjectFieldTitleId { get; set; }
        public int? ProjectId { get; set; }
        public string FieldTitle { get; set; }
        public bool? IsDefualtField { get; set; }
        public int ValueType { get; set; }
        public int? SortCode { get; set; }
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

        public virtual Languages Language { get; set; }
        public virtual CrmProjects Project { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmProjectDefualtValue> CrmProjectDefualtValue { get; set; }
        public virtual ICollection<CrmProjectFieldTitleLang> CrmProjectFieldTitleLang { get; set; }
        public virtual ICollection<CrmProjectInformations> CrmProjectInformations { get; set; }
    }
}
