using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmKnowledgeTankGroup
    {
        public CrmKnowledgeTankGroup()
        {
            CrmKnowledgeTank = new HashSet<CrmKnowledgeTank>();
            CrmKnowledgeTankGroupLang = new HashSet<CrmKnowledgeTankGroupLang>();
            CrmKnowledgeTankGroupPermission = new HashSet<CrmKnowledgeTankGroupPermission>();
        }

        public int KnowledgeTankGroupId { get; set; }
        public string KnowledgeTankGroupTitle { get; set; }
        public string KnowledgeTankGroupDesc { get; set; }
        public int? KnowledgeTankGroupOrderView { get; set; }
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
        public virtual ICollection<CrmKnowledgeTankGroupLang> CrmKnowledgeTankGroupLang { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroupPermission> CrmKnowledgeTankGroupPermission { get; set; }
    }
}
