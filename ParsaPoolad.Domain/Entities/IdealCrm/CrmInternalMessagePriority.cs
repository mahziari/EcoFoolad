using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessagePriority
    {
        public CrmInternalMessagePriority()
        {
            CrmInternalMessagePriorityLang = new HashSet<CrmInternalMessagePriorityLang>();
        }

        public int InternalMessagePriorityId { get; set; }
        public string InternalMessagePriority { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string AppType { get; set; }
        public Guid? Guid { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmInternalMessagePriorityLang> CrmInternalMessagePriorityLang { get; set; }
    }
}
