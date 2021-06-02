using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsverificationWorkFlowsLang
    {
        public int WsverificationWorkFlowLangId { get; set; }
        public int VerificationWorkFlowId { get; set; }
        public int LanguageId { get; set; }
        public string VerificationWorkFlowTitle { get; set; }
        public string VerifyRequestText { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsverificationWorkFlows VerificationWorkFlow { get; set; }
    }
}
