using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmProjectTitlesLang
    {
        public int CrmProjectTitlesLangId { get; set; }
        public int ProjectTitleId { get; set; }
        public int LanguageId { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectTitleDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectTitles ProjectTitleNavigation { get; set; }
    }
}
