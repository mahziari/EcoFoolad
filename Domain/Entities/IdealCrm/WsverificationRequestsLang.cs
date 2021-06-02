using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsverificationRequestsLang
    {
        public int WsverificationRequestLangId { get; set; }
        public int VerificationRequestId { get; set; }
        public int LanguageId { get; set; }
        public string VerificationReqText { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsverificationRequests VerificationRequest { get; set; }
    }
}
