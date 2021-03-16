using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCompanyGroupsIv
    {
        public CrmCompanyGroupsIv()
        {
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenGroupIv = new HashSet<CrmCompanyForbiddenGroupIv>();
            CrmCompanyGroupsIvLang = new HashSet<CrmCompanyGroupsIvLang>();
            CrmCompanyJustAccessGroupIv = new HashSet<CrmCompanyJustAccessGroupIv>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int CompanyGroupIvid { get; set; }
        public string GroupIvname { get; set; }
        public string GroupIvdesc { get; set; }
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
        public virtual ICollection<CrmCompanyForbiddenGroupIv> CrmCompanyForbiddenGroupIv { get; set; }
        public virtual ICollection<CrmCompanyGroupsIvLang> CrmCompanyGroupsIvLang { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroupIv> CrmCompanyJustAccessGroupIv { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
