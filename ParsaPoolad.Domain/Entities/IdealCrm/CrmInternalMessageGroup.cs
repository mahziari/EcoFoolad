using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessageGroup
    {
        public CrmInternalMessageGroup()
        {
            CrmInternalMessageDetails = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageGroupLang = new HashSet<CrmInternalMessageGroupLang>();
        }

        public int InternalMessageGroupId { get; set; }
        public string InternalMessageGroup { get; set; }
        public int? InternalMessageGroupOrder { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetails { get; set; }
        public virtual ICollection<CrmInternalMessageGroupLang> CrmInternalMessageGroupLang { get; set; }
    }
}
