using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessageLang
    {
        public int CrmInternalMessageLangId { get; set; }
        public int InternalMessageId { get; set; }
        public int LanguageId { get; set; }
        public string MsgSubject { get; set; }
        public string MsgBody { get; set; }

        public virtual CrmInternalMessage InternalMessage { get; set; }
        public virtual Languages Language { get; set; }
    }
}
