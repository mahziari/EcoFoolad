using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductImportFromExcelFieldsLang
    {
        public int WsproductImportFromExcelFieldsLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string FieldCaption { get; set; }

        public virtual WsproductImportFromExcelFields IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
