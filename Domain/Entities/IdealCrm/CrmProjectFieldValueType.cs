using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectFieldValueType
    {
        public int ProjectFieldValueTypeId { get; set; }
        public int ValueType { get; set; }
        public int LanguageId { get; set; }
        public string ValueTypeTitle { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? FirstRegisterUserId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
