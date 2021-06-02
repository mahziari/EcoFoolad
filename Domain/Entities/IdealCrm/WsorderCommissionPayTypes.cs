using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderCommissionPayTypes
    {
        public WsorderCommissionPayTypes()
        {
            WsorderCommissionPayTypesLang = new HashSet<WsorderCommissionPayTypesLang>();
            WsorderCommissions = new HashSet<WsorderCommissions>();
        }

        public int OrderCommissionPayTypeId { get; set; }
        public string CommPayTypeTitle { get; set; }
        public string CommPayTypeDescription { get; set; }
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
        public int? OrderView { get; set; }
        public int LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsorderCommissionPayTypesLang> WsorderCommissionPayTypesLang { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissions { get; set; }
    }
}
