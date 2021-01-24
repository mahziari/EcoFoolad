using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanyGroupsIii
    {
        public CrmCompanyGroupsIii()
        {
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyGroupsIiiLang = new HashSet<CrmCompanyGroupsIiiLang>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int CompanyGroupIiiid { get; set; }
        public string GroupIiiname { get; set; }
        public string GroupIiidesc { get; set; }
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
        public virtual ICollection<CrmCompanyGroupsIiiLang> CrmCompanyGroupsIiiLang { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
