using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanyGroupsIi
    {
        public CrmCompanyGroupsIi()
        {
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyGroupsIiLang = new HashSet<CrmCompanyGroupsIiLang>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int CompanyGroupIiid { get; set; }
        public string GroupIiname { get; set; }
        public string GroupIidesc { get; set; }
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
        public double? Rate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyGroupsIiLang> CrmCompanyGroupsIiLang { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
