using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SecLetters
    {
        public SecLetters()
        {
            SecLettersLang = new HashSet<SecLettersLang>();
        }

        public int LetterId { get; set; }
        public int LetterTypeId { get; set; }
        public string LetterDate { get; set; }
        public DateTime LetterDateTime { get; set; }
        public string LetterPreNumber { get; set; }
        public long LetterNumber { get; set; }
        public string LetterPreNumberIi { get; set; }
        public long? LetterNumberIi { get; set; }
        public string LetterAnnex { get; set; }
        public int? LetterCompanyId { get; set; }
        public string LettercmpNickName { get; set; }
        public int? LettercmpPersonId { get; set; }
        public string LettercmpPersonNickName { get; set; }
        public int? LettercmpProjectId { get; set; }
        public string LetterSubject { get; set; }
        public string LetterHeader { get; set; }
        public string LetterContext { get; set; }
        public string LetterFooter { get; set; }
        public string LetterSigningI { get; set; }
        public string LetterSigningIi { get; set; }
        public string LetterSigningIii { get; set; }
        public string LetterSigningIv { get; set; }
        public int? LetterPrintFormatId { get; set; }
        public string LetterLastPrintDate { get; set; }
        public string LetterLastPrintTime { get; set; }
        public DateTime? LetterLastPrintDateTime { get; set; }
        public bool? LetterIsVerified { get; set; }
        public int? LetterVerifierId { get; set; }
        public int? LetterVerifierRequestId { get; set; }
        public DateTime? LetterVerifiedRegisterDate { get; set; }
        public string LetterVerifiedRegisterDatePersian { get; set; }
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
        public virtual CrmCompany LetterCompany { get; set; }
        public virtual PrintFormat LetterPrintFormat { get; set; }
        public virtual SecLetterType LetterType { get; set; }
        public virtual Users LetterVerifier { get; set; }
        public virtual Users LetterVerifierRequest { get; set; }
        public virtual CrmCompanyPersons LettercmpPerson { get; set; }
        public virtual CrmProjects LettercmpProject { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SecLettersLang> SecLettersLang { get; set; }
    }
}
