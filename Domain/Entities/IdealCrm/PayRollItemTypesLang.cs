using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class PayRollItemTypesLang
    {
        public int PayRollItemTypeLangId { get; set; }
        public int PayRollItemTypeId { get; set; }
        public int LanguageId { get; set; }
        public string ItemType { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PayRollItemTypes PayRollItemType { get; set; }
    }
}
