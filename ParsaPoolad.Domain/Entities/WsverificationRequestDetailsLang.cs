using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsverificationRequestDetailsLang
    {
        public int WsverificationRequestDetailLangId { get; set; }
        public int VerificationRequestDetailId { get; set; }
        public int LanguageId { get; set; }
        public string VerifyText { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsverificationRequestDetails VerificationRequestDetail { get; set; }
    }
}
