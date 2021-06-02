using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFieldsLang
    {
        public int CrmDyFormFieldLangId { get; set; }
        public int FieldId { get; set; }
        public string FieldTitle { get; set; }
        public string RegularExpressionErrorTxt { get; set; }
        public string PlaceholderTxt { get; set; }
        public string MultiItems { get; set; }
        public string DefaultValue { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmDyFormFields Field { get; set; }
        public virtual Languages Language { get; set; }
    }
}
