using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsuserFavproductItems
    {
        public WsuserFavproductItems()
        {
            WsuserFavproductItemsLang = new HashSet<WsuserFavproductItemsLang>();
        }

        public int UserFavproductItemId { get; set; }
        public int UserFavproductId { get; set; }
        public int FavprdIprdId { get; set; }
        public double? FavprdIquantity { get; set; }
        public string FavprdIquantityDesc { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? FavprdIorderView { get; set; }
        public bool? Selector { get; set; }
        public Guid? Guid { get; set; }
        public int? FavprdIwhid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Wsproducts FavprdIprd { get; set; }
        public virtual WsWareHouse FavprdIwh { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual WsuserFavproducts UserFavproduct { get; set; }
        public virtual ICollection<WsuserFavproductItemsLang> WsuserFavproductItemsLang { get; set; }
    }
}
