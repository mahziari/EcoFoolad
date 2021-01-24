using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmConversationStatusGroupsLang
    {
        public int CrmConversationStatusGroupsLangId { get; set; }
        public int ConversationStatusGroupId { get; set; }
        public int LanguageId { get; set; }
        public string ConversationStatusGroup { get; set; }
        public string ConversationStatusGroupDesc { get; set; }

        public virtual CrmConversationStatusGroups ConversationStatusGroupNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
