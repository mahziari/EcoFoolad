using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class Country
    {
        public Country()
        {
            CountryLang = new HashSet<CountryLang>();
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPersonsTemplate = new HashSet<CrmCompanyPersonsTemplate>();
            CrmCompanyPersonsTmp = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            Province = new HashSet<Province>();
        }

        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string Country1 { get; set; }
        public string CountryDescription { get; set; }
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
        public virtual ICollection<CountryLang> CountryLang { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplate> CrmCompanyPersonsTemplate { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmp { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<Province> Province { get; set; }
    }
}
