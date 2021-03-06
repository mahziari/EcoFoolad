using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCompanyPersonsTemplateLang
    {
        public int CompanyPersonTemplateLangId { get; set; }
        public int LanguageId { get; set; }
        public int CompanyPersonTemplateId { get; set; }
        public string PrsLname { get; set; }
        public string PrsFname { get; set; }
        public string PrsTelDesc { get; set; }
        public string PrsFaxDesc { get; set; }
        public string PrsAddress { get; set; }
        public string PrsAddressDesc { get; set; }
        public string PrsFatherName { get; set; }
        public string PrsBirthPlace { get; set; }
        public string PrsEducationField { get; set; }
        public string PrsSkill { get; set; }
        public string PrsStudyField { get; set; }
        public string PrsInteresting { get; set; }
        public string PrsSpecialPoint { get; set; }
        public string PrsDescription { get; set; }

        public virtual CrmCompanyPersonsTemplate CompanyPersonTemplate { get; set; }
        public virtual Languages Language { get; set; }
    }
}
