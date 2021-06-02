using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class PayRollItemsLang
    {
        public int PayRollItemLangId { get; set; }
        public int PayRollItemId { get; set; }
        public int LanguageId { get; set; }
        public string ItemName { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PayRollItems PayRollItem { get; set; }
    }
}
