using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessageTypeLang
    {
        public int CrmInternalMessageTypeLangId { get; set; }
        public int InternalMessageTypeId { get; set; }
        public int LanguageId { get; set; }
        public string MessageType { get; set; }

        public virtual CrmInternalMessageType InternalMessageType { get; set; }
        public virtual Languages Language { get; set; }
    }
}
