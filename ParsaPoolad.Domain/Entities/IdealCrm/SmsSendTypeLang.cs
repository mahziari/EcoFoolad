using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class SmsSendTypeLang
    {
        public int SmsSendTypeLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string SmssendType { get; set; }

        public virtual SmsSendType IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
