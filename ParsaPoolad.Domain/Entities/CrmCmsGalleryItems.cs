using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCmsGalleryItems
    {
        public CrmCmsGalleryItems()
        {
            CrmCmsGalleryItemsLang = new HashSet<CrmCmsGalleryItemsLang>();
        }

        public int GalleryItemId { get; set; }
        public int GalleryId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemTitleFontColor { get; set; }
        public string ItemDesc { get; set; }
        public string ItemDescFontColor { get; set; }
        public string ItemLink { get; set; }
        public string ItemLinkTitle { get; set; }
        public string ItemLinkBgColor { get; set; }
        public string ItemLinkFontColor { get; set; }
        public int? TargetMode { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShowTitle { get; set; }
        public bool? IsShowDesc { get; set; }
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public string FilePath { get; set; }
        public int? OrderView { get; set; }
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
        public virtual CrmCmsGallery Gallery { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsGalleryItemsLang> CrmCmsGalleryItemsLang { get; set; }
    }
}
