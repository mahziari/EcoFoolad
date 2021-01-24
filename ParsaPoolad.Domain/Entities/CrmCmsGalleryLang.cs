using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCmsGalleryLang
    {
        public int CrmCmsGalleryLangId { get; set; }
        public int GalleryId { get; set; }
        public int LanguageId { get; set; }
        public string GalleryTitle { get; set; }

        public virtual CrmCmsGallery Gallery { get; set; }
        public virtual Languages Language { get; set; }
    }
}
