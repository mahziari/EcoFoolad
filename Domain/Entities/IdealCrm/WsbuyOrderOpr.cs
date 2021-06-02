using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsbuyOrderOpr
    {
        public WsbuyOrderOpr()
        {
            WsbuyOrder = new HashSet<WsbuyOrder>();
            WsbuyOrderOprLang = new HashSet<WsbuyOrderOprLang>();
        }

        public int BuyOrderOprId { get; set; }
        public string Name { get; set; }
        public int? OprType { get; set; }
        public int? OrderView { get; set; }
        public int? DocOprId { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<WsbuyOrderOprLang> WsbuyOrderOprLang { get; set; }
    }
}
