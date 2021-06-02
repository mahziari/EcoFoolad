using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmProjectGradeLang
    {
        public int CrmProjectGradeId { get; set; }
        public int ProjectGradeId { get; set; }
        public int LanguageId { get; set; }
        public string ProjectGrade { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjectGrade ProjectGradeNavigation { get; set; }
    }
}
