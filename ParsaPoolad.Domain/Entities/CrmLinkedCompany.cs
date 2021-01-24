using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmLinkedCompany
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int LinkedCompanyId { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmCompany Company { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmCompany LinkedCompany { get; set; }
        public virtual Users User { get; set; }
    }
}
