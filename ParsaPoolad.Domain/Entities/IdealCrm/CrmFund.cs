using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmFund
    {
        public CrmFund()
        {
            CrmFundLang = new HashSet<CrmFundLang>();
        }

        public int FundId { get; set; }
        public int FundGroupId { get; set; }
        public int CrmUserId { get; set; }
        public DateTime FundDate { get; set; }
        public string FundDatePersian { get; set; }
        public long FundNumber { get; set; }
        public decimal? FundCredit { get; set; }
        public decimal? FundDebit { get; set; }
        public decimal? FundRemain { get; set; }
        public string FundDesc { get; set; }
        public int? FundOrderView { get; set; }
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

        public virtual Users CrmUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmFundGroups FundGroup { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFundLang> CrmFundLang { get; set; }
    }
}
