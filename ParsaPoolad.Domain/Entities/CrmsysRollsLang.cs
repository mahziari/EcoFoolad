using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysRollsLang
    {
        public int CrmsysRollsLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string RollName { get; set; }
        public string Description { get; set; }

        public virtual CrmsysRolls IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
