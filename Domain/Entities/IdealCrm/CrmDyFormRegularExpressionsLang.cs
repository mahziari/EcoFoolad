using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormRegularExpressionsLang
    {
        public int CrmDyFormRegularExpressionLangId { get; set; }
        public int RegularExpressionId { get; set; }
        public string Title { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmDyFormRegularExpressions RegularExpression { get; set; }
    }
}
