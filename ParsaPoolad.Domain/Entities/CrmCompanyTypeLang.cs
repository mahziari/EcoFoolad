using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanyTypeLang
    {
        public int CrmCompanyTypeLangId { get; set; }
        public int CompanyTypeId { get; set; }
        public int LanguageId { get; set; }
        public string CompanyTypeName { get; set; }

        public virtual CrmCompanyType CompanyType { get; set; }
        public virtual Languages Language { get; set; }
    }
}
