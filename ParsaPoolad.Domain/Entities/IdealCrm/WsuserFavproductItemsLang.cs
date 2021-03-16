using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsuserFavproductItemsLang
    {
        public int WsuserFavproductItemsLangId { get; set; }
        public int UserFavproductItemId { get; set; }
        public int LanguageId { get; set; }
        public string FavprdIquantityDesc { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsuserFavproductItems UserFavproductItem { get; set; }
    }
}
