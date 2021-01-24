using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmDyFormWorkflowsLang
    {
        public int CrmDyFormWorkflowLangId { get; set; }
        public int FormWorkflowId { get; set; }
        public string WorkflowTitle { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmDyFormWorkflows FormWorkflow { get; set; }
        public virtual Languages Language { get; set; }
    }
}
