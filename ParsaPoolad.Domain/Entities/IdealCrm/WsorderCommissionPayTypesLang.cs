using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsorderCommissionPayTypesLang
    {
        public int WsorderCommissionPayTypeLangId { get; set; }
        public int OrderCommissionPayTypeId { get; set; }
        public int LanguageId { get; set; }
        public string CommPayTypeTitle { get; set; }
        public string CommPayTypeDescription { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderCommissionPayTypes OrderCommissionPayType { get; set; }
    }
}
