using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SecLetterDefaultSettingsLang
    {
        public int SecLetterDefaultSettingsLangId { get; set; }
        public int LetterDefaultSettingId { get; set; }
        public int LanguageId { get; set; }
        public string Ldtitle { get; set; }
        public string Ldannex { get; set; }
        public string LdcmpNickName { get; set; }
        public string LdcmpPersonNickName { get; set; }
        public string Ldsubject { get; set; }
        public string Ldheader { get; set; }
        public string Ldcontext { get; set; }
        public string Ldfooter { get; set; }
        public string LdsigningI { get; set; }
        public string LdsigningIi { get; set; }
        public string LdsigningIii { get; set; }
        public string LdsigningIv { get; set; }

        public virtual Languages Language { get; set; }
        public virtual SecLetterDefaultSettings LetterDefaultSetting { get; set; }
    }
}
