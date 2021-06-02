﻿using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmKnowledgeTank
    {
        public CrmKnowledgeTank()
        {
            CrmKnowledgeTankLang = new HashSet<CrmKnowledgeTankLang>();
        }

        public int KnowledgeTankId { get; set; }
        public string KnlgTitle { get; set; }
        public string KnlgSigns { get; set; }
        public string KnlgKnowledge { get; set; }
        public int? KnlgPriorityId { get; set; }
        public int KnlgGroupId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmKnowledgeTankGroup KnlgGroup { get; set; }
        public virtual CrmKnowledgeTankPriority KnlgPriority { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmKnowledgeTankLang> CrmKnowledgeTankLang { get; set; }
    }
}
