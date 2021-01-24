using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysSettingLang
    {
        public int CrmsysSettingLangId { get; set; }
        public int Id { get; set; }
        public string CoName { get; set; }
        public string Address { get; set; }
        public string PublicNotice { get; set; }
        public string QuickAddress { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmsysSetting IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
