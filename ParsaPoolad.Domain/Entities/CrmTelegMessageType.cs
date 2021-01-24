using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmTelegMessageType
    {
        public CrmTelegMessageType()
        {
            CrmTelegChatMessage = new HashSet<CrmTelegChatMessage>();
        }

        public int TelegMessageTypeId { get; set; }
        public string MessageType { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmTelegChatMessage> CrmTelegChatMessage { get; set; }
    }
}
