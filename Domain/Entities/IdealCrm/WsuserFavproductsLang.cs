using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsuserFavproductsLang
    {
        public int WsuserFavproductsLangId { get; set; }
        public int UserFavproductId { get; set; }
        public int LanguageId { get; set; }
        public string FavprdTitle { get; set; }
        public string FavprdDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsuserFavproducts UserFavproduct { get; set; }
    }
}
