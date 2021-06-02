using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class PayRollItems
    {
        public PayRollItems()
        {
            PayRollItemsLang = new HashSet<PayRollItemsLang>();
            PayRollUserCycleItemValues = new HashSet<PayRollUserCycleItemValues>();
            PayRollUserDefaultItems = new HashSet<PayRollUserDefaultItems>();
        }

        public int PayRollItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemKind { get; set; }
        public int ItemTypeId { get; set; }
        public decimal? ItemDefaultValue { get; set; }
        public string ItemFormulaTag { get; set; }
        public string ItemFormula { get; set; }
        public bool? ItemJustForShow { get; set; }
        public bool? ItemIsActive { get; set; }
        public int? ItemOrderView { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual PayRollItemTypes ItemType { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PayRollItemsLang> PayRollItemsLang { get; set; }
        public virtual ICollection<PayRollUserCycleItemValues> PayRollUserCycleItemValues { get; set; }
        public virtual ICollection<PayRollUserDefaultItems> PayRollUserDefaultItems { get; set; }
    }
}
