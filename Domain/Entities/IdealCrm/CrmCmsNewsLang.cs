using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCmsNewsLang
    {
        public int CrmCmsNewsLangId { get; set; }
        public int NewsId { get; set; }
        public int LanguageId { get; set; }
        public string HeadLine { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmCmsNews News { get; set; }
    }
}
