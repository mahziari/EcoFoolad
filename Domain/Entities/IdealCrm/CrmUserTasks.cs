using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmUserTasks
    {
        public CrmUserTasks()
        {
            CrmUserTasksLang = new HashSet<CrmUserTasksLang>();
        }

        public int UserTaskId { get; set; }
        public string UserTaskDatePersian { get; set; }
        public DateTime UserTaskDate { get; set; }
        public string UserTaskTime { get; set; }
        public string UserTaskTitle { get; set; }
        public string UserTaskDescription { get; set; }
        public int? UserTaskPriorityId { get; set; }
        public int? UserTaskGroupId { get; set; }
        public int? UserTaskShowAllarm { get; set; }
        public bool? UserTaskDidIt { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string UserTaskRemindDate { get; set; }
        public string UserTaskRemindTime { get; set; }
        public bool? UserTaskIsPublic { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public DateTime? UserTaskRemindDateTime { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual CrmUserTaskGroups UserTaskGroup { get; set; }
        public virtual CrmUserTaskPriorities UserTaskPriority { get; set; }
        public virtual ICollection<CrmUserTasksLang> CrmUserTasksLang { get; set; }
    }
}
