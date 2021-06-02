using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmLinkedTypeLang
    {
        public int CrmLinkedTypeLangId { get; set; }
        public int LinkedTypeId { get; set; }
        public int LanguageId { get; set; }
        public string LinkTypeName { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmLinkedType LinkedType { get; set; }
    }
}
