using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmFileDirectoryTypeOprLang
    {
        public int CrmFileDirectoryTypeOprLangId { get; set; }
        public int FileDirectoryTypeOprId { get; set; }
        public int LanguageId { get; set; }
        public string FileDirectoryTypeOpr { get; set; }

        public virtual CrmFileDirectoryTypeOpr FileDirectoryTypeOprNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
