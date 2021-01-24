using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmProjectTitles
    {
        public CrmProjectTitles()
        {
            CrmProjectTitlesLang = new HashSet<CrmProjectTitlesLang>();
        }

        public int ProjectTitleId { get; set; }
        public string ProjectTitle { get; set; }
        public int? ProjectTitleGroupId { get; set; }
        public int? ProjectTitleStatusGroupId { get; set; }
        public int? ProjectTitleGradeId { get; set; }
        public int? ProjectTitlePriorityId { get; set; }
        public string ProjectTitleDesc { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string AppType { get; set; }
        public Guid? Guid { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmProjectGrade ProjectTitleGrade { get; set; }
        public virtual CrmProjectGroups ProjectTitleGroup { get; set; }
        public virtual CrmProjectPriority ProjectTitlePriority { get; set; }
        public virtual CrmConversationStatusGroups ProjectTitleStatusGroup { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmProjectTitlesLang> CrmProjectTitlesLang { get; set; }
    }
}
