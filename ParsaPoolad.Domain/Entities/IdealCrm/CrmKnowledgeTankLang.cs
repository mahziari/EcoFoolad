using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmKnowledgeTankLang
    {
        public int CrmKnowledgeTankLangId { get; set; }
        public int KnowledgeTankId { get; set; }
        public int LanguageId { get; set; }
        public string KnlgTitle { get; set; }
        public string KnlgSigns { get; set; }
        public string KnlgKnowledge { get; set; }

        public virtual CrmKnowledgeTank KnowledgeTank { get; set; }
        public virtual Languages Language { get; set; }
    }
}
