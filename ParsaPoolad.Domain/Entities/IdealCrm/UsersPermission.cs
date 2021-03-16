using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class UsersPermission
    {
        public UsersPermission()
        {
            UsersPermissionLang = new HashSet<UsersPermissionLang>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? RollId { get; set; }
        public int PrjId { get; set; }
        public string Description { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string AccessLevel { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Projects Prj { get; set; }
        public virtual CrmsysRolls Roll { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<UsersPermissionLang> UsersPermissionLang { get; set; }
    }
}
