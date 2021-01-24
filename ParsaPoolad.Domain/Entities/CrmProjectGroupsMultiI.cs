using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmProjectGroupsMultiI
    {
        public CrmProjectGroupsMultiI()
        {
            CrmProjectGroupsMultiILang = new HashSet<CrmProjectGroupsMultiILang>();
            CrmProjectMultiIgroups = new HashSet<CrmProjectMultiIgroups>();
        }

        public int ProjectGroupsMultiIid { get; set; }
        public string ProjectGroupsMultiIname { get; set; }
        public string ProjectGroupsMultiIdesc { get; set; }
        public bool? IsDefualtField { get; set; }
        public int? SortCode { get; set; }
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
        public virtual Users User { get; set; }
        public virtual ICollection<CrmProjectGroupsMultiILang> CrmProjectGroupsMultiILang { get; set; }
        public virtual ICollection<CrmProjectMultiIgroups> CrmProjectMultiIgroups { get; set; }
    }
}
