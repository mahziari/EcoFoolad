using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class City
    {
        public City()
        {
            CityLang = new HashSet<CityLang>();
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenCity = new HashSet<CrmCompanyForbiddenCity>();
            CrmCompanyJustAccessCity = new HashSet<CrmCompanyJustAccessCity>();
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPersonsTemplate = new HashSet<CrmCompanyPersonsTemplate>();
            CrmCompanyPersonsTmp = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
        }

        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string CityCode { get; set; }
        public string City1 { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? FirstUserId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }

        public virtual Users FirstUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<CityLang> CityLang { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCity> CrmCompanyForbiddenCity { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCity> CrmCompanyJustAccessCity { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplate> CrmCompanyPersonsTemplate { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmp { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
    }
}
