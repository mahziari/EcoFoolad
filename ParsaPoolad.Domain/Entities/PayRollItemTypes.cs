using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class PayRollItemTypes
    {
        public PayRollItemTypes()
        {
            PayRollItemTypesLang = new HashSet<PayRollItemTypesLang>();
            PayRollItems = new HashSet<PayRollItems>();
        }

        public int PayRollItemTypeId { get; set; }
        public string ItemType { get; set; }
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
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PayRollItemTypesLang> PayRollItemTypesLang { get; set; }
        public virtual ICollection<PayRollItems> PayRollItems { get; set; }
    }
}
