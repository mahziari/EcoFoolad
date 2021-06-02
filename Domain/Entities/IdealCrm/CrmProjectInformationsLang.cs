using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectInformationsLang
    {
        public int ProjectInformationLangId { get; set; }
        public int ProjectInformationId { get; set; }
        public int LanguageId { get; set; }
        public string FieldValue { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectInformations ProjectInformation { get; set; }
    }
}
