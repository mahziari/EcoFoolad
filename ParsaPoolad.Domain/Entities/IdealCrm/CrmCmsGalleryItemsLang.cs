using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCmsGalleryItemsLang
    {
        public int CrmCmsGalleryItemLangId { get; set; }
        public int GalleryItemId { get; set; }
        public int LanguageId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemDesc { get; set; }
        public string ItemLinkTitle { get; set; }

        public virtual CrmCmsGalleryItems GalleryItem { get; set; }
        public virtual Languages Language { get; set; }
    }
}
