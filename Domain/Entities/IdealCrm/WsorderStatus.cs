using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderStatus
    {
        public WsorderStatus()
        {
            Wsorder = new HashSet<Wsorder>();
            WsorderStatusLang = new HashSet<WsorderStatusLang>();
        }

        public int OrderStatusId { get; set; }
        public string OrderStatus { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? OrderView { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderStatusLang> WsorderStatusLang { get; set; }
    }
}
