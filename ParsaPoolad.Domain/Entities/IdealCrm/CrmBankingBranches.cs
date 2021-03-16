using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmBankingBranches
    {
        public CrmBankingBranches()
        {
            CrmBankingAccounts = new HashSet<CrmBankingAccounts>();
        }

        public int BankingBranchId { get; set; }
        public int? BankId { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string BranchAddress { get; set; }
        public string BranchTel { get; set; }
        public string BranchTelIi { get; set; }
        public string BranchDesc { get; set; }
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

        public virtual CrmBankingBanks Bank { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmBankingAccounts> CrmBankingAccounts { get; set; }
    }
}
