using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class UserDepartments
    {
        public UserDepartments()
        {
            CrmProjects = new HashSet<CrmProjects>();
            CrmProjectsTmp = new HashSet<CrmProjectsTmp>();
            UserDepartmentTicketReferUsers = new HashSet<UserDepartmentTicketReferUsers>();
            UserDepartmentsLang = new HashSet<UserDepartmentsLang>();
            Users = new HashSet<Users>();
        }

        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? DefaultTicketUserId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmProjects> CrmProjects { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmp { get; set; }
        public virtual ICollection<UserDepartmentTicketReferUsers> UserDepartmentTicketReferUsers { get; set; }
        public virtual ICollection<UserDepartmentsLang> UserDepartmentsLang { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
