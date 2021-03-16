using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyGroups
    {
        public CrmCompanyGroups()
        {
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenGroup = new HashSet<CrmCompanyForbiddenGroup>();
            CrmCompanyGroupsLang = new HashSet<CrmCompanyGroupsLang>();
            CrmCompanyJustAccessGroup = new HashSet<CrmCompanyJustAccessGroup>();
            CrmCompanySubGroups = new HashSet<CrmCompanySubGroups>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int CompanyGroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
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
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroup> CrmCompanyForbiddenGroup { get; set; }
        public virtual ICollection<CrmCompanyGroupsLang> CrmCompanyGroupsLang { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroup> CrmCompanyJustAccessGroup { get; set; }
        public virtual ICollection<CrmCompanySubGroups> CrmCompanySubGroups { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
