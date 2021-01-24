using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsuserFavproducts
    {
        public WsuserFavproducts()
        {
            WsuserFavproductItems = new HashSet<WsuserFavproductItems>();
            WsuserFavproductsLang = new HashSet<WsuserFavproductsLang>();
        }

        public int UserFavproductId { get; set; }
        public string FavprdTitle { get; set; }
        public string FavprdDesc { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? OrderView { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsuserFavproductItems> WsuserFavproductItems { get; set; }
        public virtual ICollection<WsuserFavproductsLang> WsuserFavproductsLang { get; set; }
    }
}
