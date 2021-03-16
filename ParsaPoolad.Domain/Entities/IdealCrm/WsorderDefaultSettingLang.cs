using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsorderDefaultSettingLang
    {
        public int WsorderDefaultSettingLangId { get; set; }
        public int OrderSettingId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string SpecialWord { get; set; }
        public string DescriptionI { get; set; }
        public string DescriptionIi { get; set; }
        public string SettingTitle { get; set; }
        public string SigningI { get; set; }
        public string SigningIi { get; set; }
        public string SigningIii { get; set; }
        public string Note { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderDefaultSetting OrderSetting { get; set; }
    }
}
