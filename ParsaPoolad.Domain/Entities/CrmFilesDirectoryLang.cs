using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmFilesDirectoryLang
    {
        public int CrmFilesDirectoryLanId { get; set; }
        public int FileDirectoryId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }

        public virtual CrmFilesDirectory FileDirectory { get; set; }
        public virtual Languages Language { get; set; }
    }
}
