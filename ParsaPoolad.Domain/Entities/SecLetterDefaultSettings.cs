using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SecLetterDefaultSettings
    {
        public SecLetterDefaultSettings()
        {
            SecLetterDefaultSettingsLang = new HashSet<SecLetterDefaultSettingsLang>();
        }

        public int LetterDefaultSettingId { get; set; }
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
        public int? LdprintFormatId { get; set; }
        public int? LdreferUserId { get; set; }
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
        public int? LdverifierRequestId { get; set; }
        public int? LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual PrintFormat LdprintFormat { get; set; }
        public virtual Users LdreferUser { get; set; }
        public virtual Users LdverifierRequest { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SecLetterDefaultSettingsLang> SecLetterDefaultSettingsLang { get; set; }
    }
}
