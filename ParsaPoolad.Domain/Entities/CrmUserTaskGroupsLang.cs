using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmUserTaskGroupsLang
    {
        public int CrmUserTaskGroupsLangId { get; set; }
        public int UserTaskGroupId { get; set; }
        public int LanguageId { get; set; }
        public string UserTaskGroup { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmUserTaskGroups UserTaskGroupNavigation { get; set; }
    }
}
