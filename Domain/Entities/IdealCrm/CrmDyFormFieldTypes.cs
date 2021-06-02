using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFieldTypes
    {
        public CrmDyFormFieldTypes()
        {
            CrmDyFormFieldTypesLang = new HashSet<CrmDyFormFieldTypesLang>();
            CrmDyFormFields = new HashSet<CrmDyFormFields>();
            CrmDyFormRegularExpressions = new HashSet<CrmDyFormRegularExpressions>();
        }

        public int FormFieldTypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeInWeb { get; set; }
        public string TypeInWindows { get; set; }
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

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmDyFormFieldTypesLang> CrmDyFormFieldTypesLang { get; set; }
        public virtual ICollection<CrmDyFormFields> CrmDyFormFields { get; set; }
        public virtual ICollection<CrmDyFormRegularExpressions> CrmDyFormRegularExpressions { get; set; }
    }
}
