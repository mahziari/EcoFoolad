using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormRegularExpressions
    {
        public CrmDyFormRegularExpressions()
        {
            CrmDyFormFields = new HashSet<CrmDyFormFields>();
            CrmDyFormRegularExpressionsLang = new HashSet<CrmDyFormRegularExpressionsLang>();
        }

        public int FormRegularExpressionId { get; set; }
        public int FieldTypeId { get; set; }
        public string Title { get; set; }
        public string RegularExpression { get; set; }
        public string RegularExpressionOther { get; set; }
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

        public virtual CrmDyFormFieldTypes FieldType { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmDyFormFields> CrmDyFormFields { get; set; }
        public virtual ICollection<CrmDyFormRegularExpressionsLang> CrmDyFormRegularExpressionsLang { get; set; }
    }
}
