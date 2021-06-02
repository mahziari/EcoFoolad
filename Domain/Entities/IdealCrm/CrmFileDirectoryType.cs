using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmFileDirectoryType
    {
        public CrmFileDirectoryType()
        {
            CrmFileDirectoryTypeLang = new HashSet<CrmFileDirectoryTypeLang>();
            CrmFilesDirectory = new HashSet<CrmFilesDirectory>();
            CrmFilesDirectoryTemplate = new HashSet<CrmFilesDirectoryTemplate>();
        }

        public int FileDirectoryTypeId { get; set; }
        public string FileDirectoryType { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public int? FileDirectoryTypeOprId { get; set; }
        public int? OrderView { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual CrmFileDirectoryTypeOpr FileDirectoryTypeOpr { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFileDirectoryTypeLang> CrmFileDirectoryTypeLang { get; set; }
        public virtual ICollection<CrmFilesDirectory> CrmFilesDirectory { get; set; }
        public virtual ICollection<CrmFilesDirectoryTemplate> CrmFilesDirectoryTemplate { get; set; }
    }
}
