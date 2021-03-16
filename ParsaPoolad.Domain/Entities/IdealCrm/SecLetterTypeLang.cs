using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SecLetterTypeLang
    {
        public int SecLetterTypeLangId { get; set; }
        public int LetterTypeId { get; set; }
        public int LanguageId { get; set; }
        public string LetterTypeTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual SecLetterType LetterType { get; set; }
    }
}
