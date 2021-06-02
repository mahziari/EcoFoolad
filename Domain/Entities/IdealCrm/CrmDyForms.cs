using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyForms
    {
        public CrmDyForms()
        {
            CrmCmsMenus = new HashSet<CrmCmsMenus>();
            CrmCmsPages = new HashSet<CrmCmsPages>();
            CrmDyFormFieldMasterValueDetails = new HashSet<CrmDyFormFieldMasterValueDetails>();
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
            CrmDyFormFields = new HashSet<CrmDyFormFields>();
            CrmDyFormUserAccess = new HashSet<CrmDyFormUserAccess>();
            CrmDyFormWorkflowSteps = new HashSet<CrmDyFormWorkflowSteps>();
            CrmDyFormWorkflows = new HashSet<CrmDyFormWorkflows>();
            CrmDyFormsLang = new HashSet<CrmDyFormsLang>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
        }

        public int FormId { get; set; }
        public string FormName { get; set; }
        public string FormTitle { get; set; }
        public string FormTitleColor { get; set; }
        public string FormBgColor { get; set; }
        public string FormHeader { get; set; }
        public string FormBody { get; set; }
        public string FormFooter { get; set; }
        public bool? HaveUploadFile { get; set; }
        public string UploadFileDescription { get; set; }
        public int? UploadFileCount { get; set; }
        public int? UploadFileMaxSize { get; set; }
        public int? ColumnCount { get; set; }
        public bool? IsActive { get; set; }
        public int? OrderView { get; set; }
        public int? ParentFormId { get; set; }
        public int? CrmSysPartId { get; set; }
        public int? FosysPartId { get; set; }
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
        public string UploadFileExtension { get; set; }
        public int? PrintFormatId { get; set; }
        public bool? FoisVisible { get; set; }
        public bool? FoisEnable { get; set; }
        public bool? FocanInsertMulti { get; set; }
        public string EnableForUsersId { get; set; }
        public int? EnableForRollId { get; set; }
        public string CheckerUsersId { get; set; }
        public int? WorkflowId { get; set; }

        public virtual CrmSystemParts CrmSysPart { get; set; }
        public virtual CrmsysRolls EnableForRoll { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmSystemParts FosysPart { get; set; }
        public virtual Languages Language { get; set; }
        public virtual PrintFormat PrintFormat { get; set; }
        public virtual Users User { get; set; }
        public virtual CrmDyFormWorkflows Workflow { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenus { get; set; }
        public virtual ICollection<CrmCmsPages> CrmCmsPages { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValueDetails> CrmDyFormFieldMasterValueDetails { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
        public virtual ICollection<CrmDyFormFields> CrmDyFormFields { get; set; }
        public virtual ICollection<CrmDyFormUserAccess> CrmDyFormUserAccess { get; set; }
        public virtual ICollection<CrmDyFormWorkflowSteps> CrmDyFormWorkflowSteps { get; set; }
        public virtual ICollection<CrmDyFormWorkflows> CrmDyFormWorkflows { get; set; }
        public virtual ICollection<CrmDyFormsLang> CrmDyFormsLang { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
    }
}
