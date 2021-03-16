using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFieldValuesLang
    {
        public int CrmDyFormFieldValueLangId { get; set; }
        public int FieldValueId { get; set; }
        public string Value { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmDyFormFieldValues FieldValue { get; set; }
        public virtual Languages Language { get; set; }
    }
}
