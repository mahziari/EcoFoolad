using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmBankingBanks
    {
        public CrmBankingBanks()
        {
            CrmBankingBranches = new HashSet<CrmBankingBranches>();
        }

        public int BankingBankId { get; set; }
        public string Code { get; set; }
        public string BankName { get; set; }
        public string BankDesc { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmBankingBranches> CrmBankingBranches { get; set; }
    }
}
