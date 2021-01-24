using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCmsFilesLang
    {
        public int CrmCmsFileLangId { get; set; }
        public int FileId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }

        public virtual CrmCmsFiles File { get; set; }
        public virtual Languages Language { get; set; }
    }
}
