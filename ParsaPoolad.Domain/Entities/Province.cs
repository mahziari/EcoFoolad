using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class Province
    {
        public Province()
        {
            City = new HashSet<City>();
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenProvince = new HashSet<CrmCompanyForbiddenProvince>();
            CrmCompanyJustAccessProvince = new HashSet<CrmCompanyJustAccessProvince>();
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPersonsTemplate = new HashSet<CrmCompanyPersonsTemplate>();
            CrmCompanyPersonsTmp = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            ProvinceLang = new HashSet<ProvinceLang>();
        }

        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
        public string ProvinceCode { get; set; }
        public string Province1 { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Country Country { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenProvince> CrmCompanyForbiddenProvince { get; set; }
        public virtual ICollection<CrmCompanyJustAccessProvince> CrmCompanyJustAccessProvince { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplate> CrmCompanyPersonsTemplate { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmp { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<ProvinceLang> ProvinceLang { get; set; }
    }
}
