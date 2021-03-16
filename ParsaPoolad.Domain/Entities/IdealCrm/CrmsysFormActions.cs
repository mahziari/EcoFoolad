using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysFormActions
    {
        public CrmsysFormActions()
        {
            CrmsysFormActionsLang = new HashSet<CrmsysFormActionsLang>();
            CrmsysRollPermission = new HashSet<CrmsysRollPermission>();
        }

        public int Id { get; set; }
        public int FormId { get; set; }
        public string ActionPersianName { get; set; }
        public string ActionName { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmsysForms Form { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmsysFormActionsLang> CrmsysFormActionsLang { get; set; }
        public virtual ICollection<CrmsysRollPermission> CrmsysRollPermission { get; set; }
    }
}
