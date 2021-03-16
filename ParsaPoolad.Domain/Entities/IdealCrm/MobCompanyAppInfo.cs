using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class MobCompanyAppInfo
    {
        public int MobCompanyAppInfoId { get; set; }
        public int CompanyId { get; set; }
        public int CompanyPersonId { get; set; }
        public string RegisterCode { get; set; }
        public string DownloadUrl { get; set; }
        public string WcfUrl { get; set; }
        public string ExtraCode { get; set; }
        public bool? IsActive { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public Guid? Guid { get; set; }
        public string ImeiCode { get; set; }
        public string Cmp { get; set; }
        public int? DevTypeId { get; set; }
        public string AppName { get; set; }
        public string LastVersion { get; set; }
        public string NewVersionDownloadUrl { get; set; }

        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
