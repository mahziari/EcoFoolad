using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsverificationWorkFlowStepsLang
    {
        public int WsverificationWorkFlowStepLangId { get; set; }
        public int VerificationWorkFlowStepId { get; set; }
        public int LanguageId { get; set; }
        public string VerificationWorkFlowStepTitle { get; set; }
        public string VerifyText { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsverificationWorkFlowSteps VerificationWorkFlowStep { get; set; }
    }
}
