using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class ProjectsLang
    {
        public int ProjectsLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string AboutCompany { get; set; }
        public string Description { get; set; }

        public virtual Projects IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
