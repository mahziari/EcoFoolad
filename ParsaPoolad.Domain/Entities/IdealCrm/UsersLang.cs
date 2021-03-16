using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class UsersLang
    {
        public int UsersLangId { get; set; }
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
