using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class EmailUserTempTank
    {
        public long EmailUserTempTankId { get; set; }
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public int? EmailCmpId { get; set; }
        public int? EmailCmpPrsId { get; set; }
        public string EmailCmpPrsName { get; set; }
        public int? EmailCmpPrjId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string FilePath { get; set; }
        public string FilePathIi { get; set; }
        public string FilePathIii { get; set; }
        public string FilePathIv { get; set; }
        public string FilePathV { get; set; }
        public string EmailCmpName { get; set; }
        public string EmailPrsJob { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual CrmCompany EmailCmp { get; set; }
        public virtual CrmProjects EmailCmpPrj { get; set; }
        public virtual CrmCompanyPersons EmailCmpPrs { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
