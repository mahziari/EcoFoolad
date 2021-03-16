using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmKnowledgeTankGroupLang
    {
        public int CrmKnowledgeTankGroupLangId { get; set; }
        public int KnowledgeTankGroupId { get; set; }
        public int LanguageId { get; set; }
        public string KnowledgeTankGroupTitle { get; set; }
        public string KnowledgeTankGroupDesc { get; set; }

        public virtual CrmKnowledgeTankGroup KnowledgeTankGroup { get; set; }
        public virtual Languages Language { get; set; }
    }
}
