using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFields
    {
        public CrmDyFormFields()
        {
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
            CrmDyFormFieldsLang = new HashSet<CrmDyFormFieldsLang>();
        }

        public int FormFieldId { get; set; }
        public int ParentFormId { get; set; }
        public int FormId { get; set; }
        public int? FieldTypeId { get; set; }
        public int? ParentFieldId { get; set; }
        public string ParentFieldColor { get; set; }
        public string ParentFieldBgColor { get; set; }
        public string FieldTitle { get; set; }
        public bool? IsRequired { get; set; }
        public int? RegularExpressionId { get; set; }
        public string RegularExpressionErrorTxt { get; set; }
        public long? MinValue { get; set; }
        public long? MaxValue { get; set; }
        public long? StrLength { get; set; }
        public string PlaceholderTxt { get; set; }
        public string MultiItems { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsActive { get; set; }
        public int? ColumnPosition { get; set; }
        public int? OrderView { get; set; }
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
        public virtual CrmDyForms Form { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmDyFormRegularExpressions RegularExpression { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
        public virtual ICollection<CrmDyFormFieldsLang> CrmDyFormFieldsLang { get; set; }
    }
}
