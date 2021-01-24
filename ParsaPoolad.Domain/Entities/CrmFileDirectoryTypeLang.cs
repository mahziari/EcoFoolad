using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmFileDirectoryTypeLang
    {
        public int CrmFileDirectoryTypeLangId { get; set; }
        public int FileDirectoryTypeId { get; set; }
        public int LanguageId { get; set; }
        public string FileDirectoryType { get; set; }

        public virtual CrmFileDirectoryType FileDirectoryTypeNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
