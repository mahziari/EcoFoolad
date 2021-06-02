using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class Projects
    {
        public Projects()
        {
            ProjectsLang = new HashSet<ProjectsLang>();
            UsersPermission = new HashSet<UsersPermission>();
        }

        public int Id { get; set; }
        public short Code { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string Version { get; set; }
        public string OldVersion { get; set; }
        public string Company { get; set; }
        public string AboutCompany { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public byte[] LogoPic { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<ProjectsLang> ProjectsLang { get; set; }
        public virtual ICollection<UsersPermission> UsersPermission { get; set; }
    }
}
