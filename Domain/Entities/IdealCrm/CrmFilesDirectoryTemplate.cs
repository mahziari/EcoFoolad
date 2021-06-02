using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmFilesDirectoryTemplate
    {
        public long FileDirectoryTemplateId { get; set; }
        public string Title { get; set; }
        public string CopyFromPath { get; set; }
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public string AppType { get; set; }
        public Guid? Guid { get; set; }
        public int? FileDirectoryTypeId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? LanguageId { get; set; }
        public int? ObjectId { get; set; }

        public virtual CrmFileDirectoryType FileDirectoryType { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmFilesDirectoryTemplateType Type { get; set; }
        public virtual Users User { get; set; }
    }
}
