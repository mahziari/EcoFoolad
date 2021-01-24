using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCmsGallery
    {
        public CrmCmsGallery()
        {
            CrmCmsGalleryItems = new HashSet<CrmCmsGalleryItems>();
            CrmCmsGalleryLang = new HashSet<CrmCmsGalleryLang>();
            CrmFoSettingShpHomeGalleryI = new HashSet<CrmFoSetting>();
            CrmFoSettingShpHomeGalleryIi = new HashSet<CrmFoSetting>();
            CrmFoSettingShpHomeGalleryIii = new HashSet<CrmFoSetting>();
        }

        public int GalleryId { get; set; }
        public string GalleryTitle { get; set; }
        public int? GalleryInterval { get; set; }
        public int? GalleryEffect { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShowTitle { get; set; }
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
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsGalleryItems> CrmCmsGalleryItems { get; set; }
        public virtual ICollection<CrmCmsGalleryLang> CrmCmsGalleryLang { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingShpHomeGalleryI { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingShpHomeGalleryIi { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingShpHomeGalleryIii { get; set; }
    }
}
