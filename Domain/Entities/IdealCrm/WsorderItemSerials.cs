using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderItemSerials
    {
        public WsorderItemSerials()
        {
            WsorderItemSerialsLang = new HashSet<WsorderItemSerialsLang>();
        }

        public int OrderItemSerialId { get; set; }
        public int OrderItemId { get; set; }
        public int SerialId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public int? Whid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WsorderItems OrderItem { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsorderItemSerialsLang> WsorderItemSerialsLang { get; set; }
    }
}
