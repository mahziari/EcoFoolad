using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormWorkflows
    {
        public CrmDyFormWorkflows()
        {
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormWorkflowSteps = new HashSet<CrmDyFormWorkflowSteps>();
            CrmDyFormWorkflowsLang = new HashSet<CrmDyFormWorkflowsLang>();
            CrmDyForms = new HashSet<CrmDyForms>();
        }

        public int FormWorkflowId { get; set; }
        public string WorkflowTitle { get; set; }
        public int DyFormId { get; set; }
        public bool? IsActive { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public int? WorkflowPanelShowType { get; set; }
        public bool? WorkflowPanelHide { get; set; }

        public virtual CrmDyForms DyForm { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormWorkflowSteps> CrmDyFormWorkflowSteps { get; set; }
        public virtual ICollection<CrmDyFormWorkflowsLang> CrmDyFormWorkflowsLang { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyForms { get; set; }
    }
}
