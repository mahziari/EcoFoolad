using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmUserTasksLang
    {
        public int CrmUserTasksLangId { get; set; }
        public int UserTaskId { get; set; }
        public int LanguageId { get; set; }
        public string UserTaskTitle { get; set; }
        public string UserTaskDescription { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmUserTasks UserTask { get; set; }
    }
}
