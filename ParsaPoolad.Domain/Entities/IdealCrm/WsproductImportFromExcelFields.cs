using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductImportFromExcelFields
    {
        public WsproductImportFromExcelFields()
        {
            WsproductImportFromExcelFieldsLang = new HashSet<WsproductImportFromExcelFieldsLang>();
        }

        public int Id { get; set; }
        public int? OrderNum { get; set; }
        public int? GroupNum { get; set; }
        public string FieldName { get; set; }
        public string FieldCaption { get; set; }
        public bool? IsActive { get; set; }
        public bool? Selector { get; set; }
        public bool? HaveSearch { get; set; }
        public string AppType { get; set; }
        public string SpinsertParamName { get; set; }
        public string FieldType { get; set; }
        public int? FieldSize { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<WsproductImportFromExcelFieldsLang> WsproductImportFromExcelFieldsLang { get; set; }
    }
}
