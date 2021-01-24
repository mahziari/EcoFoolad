using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanySubGroups
    {
        public CrmCompanySubGroups()
        {
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenSubGroup = new HashSet<CrmCompanyForbiddenSubGroup>();
            CrmCompanyJustAccessSubGroup = new HashSet<CrmCompanyJustAccessSubGroup>();
            CrmCompanySubGroupsLang = new HashSet<CrmCompanySubGroupsLang>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int CompanySubGroupId { get; set; }
        public int GroupId { get; set; }
        public string SubGroupName { get; set; }
        public string SubGroupDesc { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? OrderView { get; set; }
        public int? LanguageId { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }

        public virtual CrmCompanyGroups Group { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenSubGroup> CrmCompanyForbiddenSubGroup { get; set; }
        public virtual ICollection<CrmCompanyJustAccessSubGroup> CrmCompanyJustAccessSubGroup { get; set; }
        public virtual ICollection<CrmCompanySubGroupsLang> CrmCompanySubGroupsLang { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
