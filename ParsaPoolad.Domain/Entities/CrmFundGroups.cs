using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmFundGroups
    {
        public CrmFundGroups()
        {
            CrmFund = new HashSet<CrmFund>();
            CrmFundGroupsLang = new HashSet<CrmFundGroupsLang>();
        }

        public int FundGroupId { get; set; }
        public string GroupName { get; set; }
        public int ParentId { get; set; }
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

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFund> CrmFund { get; set; }
        public virtual ICollection<CrmFundGroupsLang> CrmFundGroupsLang { get; set; }
    }
}
