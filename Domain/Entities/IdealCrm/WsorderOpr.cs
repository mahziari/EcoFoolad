using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderOpr
    {
        public WsorderOpr()
        {
            Wsorder = new HashSet<Wsorder>();
            WsorderDefaultSetting = new HashSet<WsorderDefaultSetting>();
            WsorderOprLang = new HashSet<WsorderOprLang>();
        }

        public int OrderOprId { get; set; }
        public string Name { get; set; }
        public Guid? Guid { get; set; }
        public int? OprType { get; set; }
        public int? OrderView { get; set; }
        public int? DocOprId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual WsdocOpr DocOpr { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSetting { get; set; }
        public virtual ICollection<WsorderOprLang> WsorderOprLang { get; set; }
    }
}
