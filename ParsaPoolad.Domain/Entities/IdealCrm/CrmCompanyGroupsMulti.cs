using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyGroupsMulti
    {
        public CrmCompanyGroupsMulti()
        {
            CrmCompanyGroupsMultiLang = new HashSet<CrmCompanyGroupsMultiLang>();
            CrmCompanyMultiGroups = new HashSet<CrmCompanyMultiGroups>();
        }

        public int CompanyGroupsMultiId { get; set; }
        public string CompanyGroupsMultiName { get; set; }
        public string CompanyGroupsMultiDesc { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? OrderView { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCompanyGroupsMultiLang> CrmCompanyGroupsMultiLang { get; set; }
        public virtual ICollection<CrmCompanyMultiGroups> CrmCompanyMultiGroups { get; set; }
    }
}
