using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmBankingAccounts
    {
        public int BankingAccountId { get; set; }
        public int BranchId { get; set; }
        public int MasterId { get; set; }
        public int AccTypeId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountOwner { get; set; }
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

        public virtual CrmBankingAccountType AccType { get; set; }
        public virtual CrmBankingBranches Branch { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCompany Master { get; set; }
        public virtual CrmCompanyPersons MasterNavigation { get; set; }
    }
}
