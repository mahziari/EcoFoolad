using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFieldTypesLang
    {
        public int CrmDyFormFieldTypeLangId { get; set; }
        public int FieldTypeId { get; set; }
        public string TypeName { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmDyFormFieldTypes FieldType { get; set; }
        public virtual Languages Language { get; set; }
    }
}
