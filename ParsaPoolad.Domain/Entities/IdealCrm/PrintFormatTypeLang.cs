using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class PrintFormatTypeLang
    {
        public int PrintFormatTypeLangId { get; set; }
        public int PrintFormatTypeId { get; set; }
        public int LanguageId { get; set; }
        public string PrintFormatType { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PrintFormatType PrintFormatTypeNavigation { get; set; }
    }
}
