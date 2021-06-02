using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmOperationsTypeLang
    {
        public int CrmOperationsTypeLangId { get; set; }
        public int OperationsTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Type { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmOperationsType OperationsType { get; set; }
    }
}
