using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WspayConditionLang
    {
        public int WspayConditionLangId { get; set; }
        public int PayConditionId { get; set; }
        public int LanguageId { get; set; }
        public string PayCondition { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspayCondition PayConditionNavigation { get; set; }
    }
}
