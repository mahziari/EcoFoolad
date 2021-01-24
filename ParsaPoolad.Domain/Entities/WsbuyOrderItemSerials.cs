using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrderItemSerials
    {
        public WsbuyOrderItemSerials()
        {
            WsbuyOrderItemSerialsLang = new HashSet<WsbuyOrderItemSerialsLang>();
        }

        public int BuyOrderItemSerialId { get; set; }
        public int BuyOrderItemId { get; set; }
        public string Serial { get; set; }
        public int? StatusId { get; set; }
        public string Description { get; set; }
        public short? IsFix { get; set; }
        public int? Whid { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? SerialId { get; set; }
        public bool? IsAutoBarcode { get; set; }
        public int? TblTmpBarcodeId { get; set; }
        public DateTime? ExpDate { get; set; }
        public string ExpDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public string InfoI { get; set; }
        public string InfoIi { get; set; }
        public string InfoIii { get; set; }
        public string InfoIv { get; set; }
        public string InfoV { get; set; }
        public string InfoVi { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual WsbuyOrderItems BuyOrderItem { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsbuyOrderItemSerialsLang> WsbuyOrderItemSerialsLang { get; set; }
    }
}
