using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCompanyLang
    {
        public int CrmCompanyLangId { get; set; }
        public int CompanyId { get; set; }
        public int LanguageId { get; set; }
        public string CmpName { get; set; }
        public string CmpFame { get; set; }
        public string CmpActivityType { get; set; }
        public string CmpTelDesc { get; set; }
        public string CmpTelIidesc { get; set; }
        public string CmpFaxDesc { get; set; }
        public string CmpAddress { get; set; }
        public string CmpAddressDesc { get; set; }
        public string CmpInteresting { get; set; }
        public string CmpSpecialPoint { get; set; }
        public string CmpDescription { get; set; }
        public string CmpSpecialWordForCi { get; set; }
        public string CmpInquiry { get; set; }

        public virtual CrmCompany Company { get; set; }
        public virtual Languages Language { get; set; }
    }
}
