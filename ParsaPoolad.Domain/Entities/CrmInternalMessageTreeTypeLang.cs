using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmInternalMessageTreeTypeLang
    {
        public int CrmInternalMessageTreeTypeLangId { get; set; }
        public int InternalMessageTreeTypeId { get; set; }
        public int LanguageId { get; set; }
        public string MessageTreeType { get; set; }

        public virtual CrmInternalMessageTreeType InternalMessageTreeType { get; set; }
        public virtual Languages Language { get; set; }
    }
}
