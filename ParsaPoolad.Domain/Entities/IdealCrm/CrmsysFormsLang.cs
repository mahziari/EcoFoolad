using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysFormsLang
    {
        public int CrmsysFormsLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string FormPersianName { get; set; }

        public virtual CrmsysForms IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
