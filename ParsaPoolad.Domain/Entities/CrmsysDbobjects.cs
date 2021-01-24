using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysDbobjects
    {
        public CrmsysDbobjects()
        {
            CrmsysDbobjectsLang = new HashSet<CrmsysDbobjectsLang>();
        }

        public int DbobjectId { get; set; }
        public string DbobjectName { get; set; }
        public string FieldName { get; set; }
        public string FieldTitle { get; set; }
        public bool? NotNull { get; set; }
        public int? OrderView { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmsysDbobjectsLang> CrmsysDbobjectsLang { get; set; }
    }
}
