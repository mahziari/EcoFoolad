using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmDyFormsLang
    {
        public int CrmDyFormLangId { get; set; }
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string FormTitle { get; set; }
        public string FormHeader { get; set; }
        public string FormBody { get; set; }
        public string FormFooter { get; set; }
        public string UploadFileDescription { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmDyForms Form { get; set; }
        public virtual Languages Language { get; set; }
    }
}
