using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmKnowledgeTankPriority
    {
        public CrmKnowledgeTankPriority()
        {
            CrmKnowledgeTank = new HashSet<CrmKnowledgeTank>();
            CrmKnowledgeTankPriorityLang = new HashSet<CrmKnowledgeTankPriorityLang>();
        }

        public int KnowledgeTankPriorityId { get; set; }
        public string KnowledgeTankPriorityTitle { get; set; }
        public string KnowledgeTankPriorityDesc { get; set; }
        public int? KnowledgeTankPriorityOrderView { get; set; }
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
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmKnowledgeTank> CrmKnowledgeTank { get; set; }
        public virtual ICollection<CrmKnowledgeTankPriorityLang> CrmKnowledgeTankPriorityLang { get; set; }
    }
}
