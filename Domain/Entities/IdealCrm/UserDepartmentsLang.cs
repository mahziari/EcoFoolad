using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class UserDepartmentsLang
    {
        public int UserDepartmentsLangId { get; set; }
        public int DepartmentId { get; set; }
        public int LanguageId { get; set; }
        public string Department { get; set; }

        public virtual UserDepartments DepartmentNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
