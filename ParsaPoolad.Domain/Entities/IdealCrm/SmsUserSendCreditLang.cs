using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SmsUserSendCreditLang
    {
        public int SmsUserSendCreditLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }

        public virtual SmsUserSendCredit IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
