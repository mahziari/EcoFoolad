using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmFundLang
    {
        public int CrmFundLangId { get; set; }
        public int FundId { get; set; }
        public int LanguageId { get; set; }
        public string FundDesc { get; set; }

        public virtual CrmFund Fund { get; set; }
        public virtual Languages Language { get; set; }
    }
}
