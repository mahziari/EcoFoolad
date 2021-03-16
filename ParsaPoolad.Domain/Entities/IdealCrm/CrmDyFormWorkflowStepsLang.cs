using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmDyFormWorkflowStepsLang
    {
        public int CrmDyFormWorkflowStepLangId { get; set; }
        public int FormWorkflowStepId { get; set; }
        public string WorkflowStepTitle { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmDyFormWorkflowSteps FormWorkflowStep { get; set; }
        public virtual Languages Language { get; set; }
    }
}
