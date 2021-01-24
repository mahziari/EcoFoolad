using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmFilesDirectoryTemplateType
    {
        public CrmFilesDirectoryTemplateType()
        {
            CrmFilesDirectoryTemplate = new HashSet<CrmFilesDirectoryTemplate>();
        }

        public int CrmFilesDirectoryTemplateTypeId { get; set; }
        public string FilesDirectoryTemplateType { get; set; }
        public string AppType { get; set; }
        public Guid? Guid { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmFilesDirectoryTemplate> CrmFilesDirectoryTemplate { get; set; }
    }
}
