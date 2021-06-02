using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsProviders
    {
        public SmsProviders()
        {
            SmsSetting = new HashSet<SmsSetting>();
        }

        public int Id { get; set; }
        public int ProviderIdentity { get; set; }
        public string ProviderName { get; set; }
        public string ProviderDomain { get; set; }
        public string ProviderUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        public decimal? EnCost { get; set; }
        public decimal? FaCost { get; set; }
        public bool? SendIsActive { get; set; }
        public bool? ReceiveIsActive { get; set; }
        public decimal? LastCreditAmount { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }
        public int? OrderView { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public int FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SmsSetting> SmsSetting { get; set; }
    }
}
