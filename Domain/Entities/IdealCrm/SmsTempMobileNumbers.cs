using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsTempMobileNumbers
    {
        public long Id { get; set; }
        public bool? Selector { get; set; }
        public string Mobile { get; set; }
        public string CompanyName { get; set; }
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public int? CompanyPersonId { get; set; }
        public int MobileLength { get; set; }
        public string MobilePreNum { get; set; }
        public int UserId { get; set; }
        public string CmpTitle { get; set; }
        public string CmpName { get; set; }
        public string PrsTitle { get; set; }
        public string PrsFname { get; set; }
        public string PrsLname { get; set; }
        public string PrsJob { get; set; }
        public string Body { get; set; }
        public int? BodyCount { get; set; }
        public string BodyLangType { get; set; }
        public decimal? BodyCost { get; set; }
        public int? Sid { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
