using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysRolls
    {
        public CrmsysRolls()
        {
            CrmDyFormWorkflowSteps = new HashSet<CrmDyFormWorkflowSteps>();
            CrmDyForms = new HashSet<CrmDyForms>();
            CrmKnowledgeTankGroupPermission = new HashSet<CrmKnowledgeTankGroupPermission>();
            CrmsysRollPermission = new HashSet<CrmsysRollPermission>();
            CrmsysRollsLang = new HashSet<CrmsysRollsLang>();
            UsersPermission = new HashSet<UsersPermission>();
        }

        public int Id { get; set; }
        public string RollName { get; set; }
        public string Description { get; set; }
        public Guid? Guid { get; set; }
        public bool? LimitPreOrderDiscountActive { get; set; }
        public decimal? LimitPreOrderDiscountPercent { get; set; }
        public bool? LimitOrderDiscountActive { get; set; }
        public decimal? LimitOrderDiscountPercent { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmDyFormWorkflowSteps> CrmDyFormWorkflowSteps { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyForms { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroupPermission> CrmKnowledgeTankGroupPermission { get; set; }
        public virtual ICollection<CrmsysRollPermission> CrmsysRollPermission { get; set; }
        public virtual ICollection<CrmsysRollsLang> CrmsysRollsLang { get; set; }
        public virtual ICollection<UsersPermission> UsersPermission { get; set; }
    }
}
