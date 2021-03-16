using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmFilesDirectory
    {
        public CrmFilesDirectory()
        {
            CrmFilesDirectoryLang = new HashSet<CrmFilesDirectoryLang>();
        }

        public int FileDirectoryId { get; set; }
        public int? FileDirectoryTypeId { get; set; }
        public int? MasterId { get; set; }
        public int? DetailId { get; set; }
        public int? SubDetailId { get; set; }
        public string Title { get; set; }
        public string FolderName { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string CopyFromPath { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string DocDate { get; set; }
        public string DocDay { get; set; }
        public string DocTime { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? DocDateTime { get; set; }
        public int? TypeOprObjectId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? OrderView { get; set; }
        public int? TypeOprObjectIdI { get; set; }
        public int? TypeOprObjectIdIi { get; set; }

        public virtual CrmFileDirectoryType FileDirectoryType { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCompany Master { get; set; }
        public virtual CrmProjects SubDetail { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFilesDirectoryLang> CrmFilesDirectoryLang { get; set; }
    }
}
