using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmsysForms
    {
        public CrmsysForms()
        {
            CrmsysFormActions = new HashSet<CrmsysFormActions>();
            CrmsysFormObjectProperties = new HashSet<CrmsysFormObjectProperties>();
            CrmsysFormsLang = new HashSet<CrmsysFormsLang>();
            CrmsysRollPermission = new HashSet<CrmsysRollPermission>();
        }

        public int Id { get; set; }
        public string FormPersianName { get; set; }
        public string FormName { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmsysFormActions> CrmsysFormActions { get; set; }
        public virtual ICollection<CrmsysFormObjectProperties> CrmsysFormObjectProperties { get; set; }
        public virtual ICollection<CrmsysFormsLang> CrmsysFormsLang { get; set; }
        public virtual ICollection<CrmsysRollPermission> CrmsysRollPermission { get; set; }
    }
}
