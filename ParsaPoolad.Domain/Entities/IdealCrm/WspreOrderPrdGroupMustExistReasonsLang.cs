using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WspreOrderPrdGroupMustExistReasonsLang
    {
        public int WspreOrderPrdGroupMustExistReasonsLangId { get; set; }
        public int PrdGroupMustExistReasonId { get; set; }
        public int LanguageId { get; set; }
        public string Reason { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrderPrdGroupMustExistReasons PrdGroupMustExistReason { get; set; }
    }
}
