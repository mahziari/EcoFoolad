using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmPersonDepartmentsLang
    {
        public int CrmPersonDepartmentsLangId { get; set; }
        public int PersonDepartmentId { get; set; }
        public int LanguageId { get; set; }
        public string PersonDepartment { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmPersonDepartments PersonDepartmentNavigation { get; set; }
    }
}
