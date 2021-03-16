using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SecLetterType
    {
        public SecLetterType()
        {
            SecLetterTypeLang = new HashSet<SecLetterTypeLang>();
            SecLetters = new HashSet<SecLetters>();
        }

        public int LetterTypeId { get; set; }
        public string LetterTypeTitle { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SecLetterTypeLang> SecLetterTypeLang { get; set; }
        public virtual ICollection<SecLetters> SecLetters { get; set; }
    }
}
