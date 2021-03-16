using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmTelegBotMessageType
    {
        public CrmTelegBotMessageType()
        {
            CrmTelegBotChatMessage = new HashSet<CrmTelegBotChatMessage>();
        }

        public int TelegBotMessageTypeId { get; set; }
        public string MessageType { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmTelegBotChatMessage> CrmTelegBotChatMessage { get; set; }
    }
}
