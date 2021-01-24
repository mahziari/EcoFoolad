using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WssettlementTypeLang
    {
        public int WssettlementTypeLangId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public int Id { get; set; }

        public virtual WssettlementType IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
