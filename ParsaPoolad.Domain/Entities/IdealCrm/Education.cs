using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class Education
    {
        public Education()
        {
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPersonsTemplate = new HashSet<CrmCompanyPersonsTemplate>();
            CrmCompanyPersonsTmp = new HashSet<CrmCompanyPersonsTmp>();
            EducationLang = new HashSet<EducationLang>();
        }

        public int EducationId { get; set; }
        public string Education1 { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplate> CrmCompanyPersonsTemplate { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmp { get; set; }
        public virtual ICollection<EducationLang> EducationLang { get; set; }
    }
}
