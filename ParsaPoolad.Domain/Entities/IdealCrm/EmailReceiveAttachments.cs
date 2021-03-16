using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class EmailReceiveAttachments
    {
        public int EmailReceiveAttachmentId { get; set; }
        public int EmailReceiveId { get; set; }
        public string ContentId { get; set; }
        public string FileName { get; set; }
        public string SaveFilePath { get; set; }
        public string FileType { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyPersonId { get; set; }
        public int? ProjectId { get; set; }
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

        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual EmailReceive EmailReceive { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmProjects Project { get; set; }
        public virtual Users User { get; set; }
    }
}
