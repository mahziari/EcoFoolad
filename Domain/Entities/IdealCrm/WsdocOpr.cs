using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsdocOpr
    {
        public WsdocOpr()
        {
            Wsdoc = new HashSet<Wsdoc>();
            WsdocOprLang = new HashSet<WsdocOprLang>();
            WsorderOpr = new HashSet<WsorderOpr>();
        }

        public int DocOprId { get; set; }
        public string Name { get; set; }
        public Guid? Guid { get; set; }
        public int? OprType { get; set; }
        public int? OrderView { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<WsdocOprLang> WsdocOprLang { get; set; }
        public virtual ICollection<WsorderOpr> WsorderOpr { get; set; }
    }
}
