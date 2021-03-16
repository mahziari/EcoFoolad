using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCmsFiles
    {
        public CrmCmsFiles()
        {
            CrmCmsFilesLang = new HashSet<CrmCmsFilesLang>();
        }

        public int FileId { get; set; }
        public int ObjectTypeId { get; set; }
        public int ObjectId { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
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
        public virtual Languages Language { get; set; }
        public virtual CrmCmsObjectTypes ObjectType { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsFilesLang> CrmCmsFilesLang { get; set; }
    }
}
