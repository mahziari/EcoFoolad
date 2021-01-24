using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SecLettersLang
    {
        public int SecLettersLangId { get; set; }
        public int LetterId { get; set; }
        public int LanguageId { get; set; }
        public string LetterAnnex { get; set; }
        public string LettercmpNickName { get; set; }
        public string LettercmpPersonNickName { get; set; }
        public string LetterSubject { get; set; }
        public string LetterHeader { get; set; }
        public string LetterContext { get; set; }
        public string LetterFooter { get; set; }
        public string LetterSigningI { get; set; }
        public string LetterSigningIi { get; set; }
        public string LetterSigningIii { get; set; }
        public string LetterSigningIv { get; set; }

        public virtual Languages Language { get; set; }
        public virtual SecLetters Letter { get; set; }
    }
}
