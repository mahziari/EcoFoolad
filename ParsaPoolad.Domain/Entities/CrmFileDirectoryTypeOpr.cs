using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmFileDirectoryTypeOpr
    {
        public CrmFileDirectoryTypeOpr()
        {
            CrmFileDirectoryType = new HashSet<CrmFileDirectoryType>();
            CrmFileDirectoryTypeOprLang = new HashSet<CrmFileDirectoryTypeOprLang>();
        }

        public int FileDirectoryTypeOprId { get; set; }
        public string FileDirectoryTypeOpr { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFileDirectoryType> CrmFileDirectoryType { get; set; }
        public virtual ICollection<CrmFileDirectoryTypeOprLang> CrmFileDirectoryTypeOprLang { get; set; }
    }
}
