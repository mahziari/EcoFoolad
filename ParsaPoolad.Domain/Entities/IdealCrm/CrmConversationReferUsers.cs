using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmConversationReferUsers
    {
        public int ConversationReferUserId { get; set; }
        public int ConversationId { get; set; }
        public int ReferUserId { get; set; }
        public int UserId { get; set; }
        public int? PriorityId { get; set; }
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

        public virtual CrmConversation Conversation { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmConversationPriority Priority { get; set; }
        public virtual Users ReferUser { get; set; }
        public virtual Users User { get; set; }
    }
}
