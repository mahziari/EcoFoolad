using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFieldMasterValues
    {
        public CrmDyFormFieldMasterValues()
        {
            CrmDyFormFieldMasterValueDetails = new HashSet<CrmDyFormFieldMasterValueDetails>();
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
        }

        public int FormFieldMasterValueId { get; set; }
        public int FormId { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyPersonId { get; set; }
        public int? ProjectId { get; set; }
        public int? ConversationId { get; set; }
        public int? MasterObjectId { get; set; }
        public int? DetailObjectId { get; set; }
        public int? SubDetailObjectId { get; set; }
        public bool? IsDeleted { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public bool? IsChecked { get; set; }
        public int? CheckerUserId { get; set; }
        public DateTime? CheckedDate { get; set; }
        public string CheckedDatePersian { get; set; }
        public int? WorkflowId { get; set; }
        public int? WorkflowStepId { get; set; }

        public virtual Users CheckerUser { get; set; }
        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual CrmConversation Conversation { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmDyForms Form { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmProjects Project { get; set; }
        public virtual Users User { get; set; }
        public virtual CrmDyFormWorkflows Workflow { get; set; }
        public virtual CrmDyFormWorkflowSteps WorkflowStep { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValueDetails> CrmDyFormFieldMasterValueDetails { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
    }
}
