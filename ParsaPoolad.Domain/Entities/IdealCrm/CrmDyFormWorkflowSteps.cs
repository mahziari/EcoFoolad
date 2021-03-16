using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmDyFormWorkflowSteps
    {
        public CrmDyFormWorkflowSteps()
        {
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormWorkflowStepsLang = new HashSet<CrmDyFormWorkflowStepsLang>();
        }

        public int FormWorkflowStepId { get; set; }
        public int WorkflowId { get; set; }
        public string WorkflowStepTitle { get; set; }
        public int SubFormId { get; set; }
        public string ReferUserIds { get; set; }
        public int? ReferRollId { get; set; }
        public string MultiReferUserIds { get; set; }
        public string CheckerUserIds { get; set; }
        public bool? NoPrevious { get; set; }
        public bool? NoNextWithOutCheck { get; set; }
        public int? OrderView { get; set; }
        public int? ProgressPercent { get; set; }
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

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmsysRolls ReferRoll { get; set; }
        public virtual CrmDyForms SubForm { get; set; }
        public virtual Users User { get; set; }
        public virtual CrmDyFormWorkflows Workflow { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormWorkflowStepsLang> CrmDyFormWorkflowStepsLang { get; set; }
    }
}
