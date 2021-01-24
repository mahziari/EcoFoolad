using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class Wsguaranty
    {
        public Wsguaranty()
        {
            WsguarantyLang = new HashSet<WsguarantyLang>();
            Wsorder = new HashSet<Wsorder>();
            WsorderDefaultSetting = new HashSet<WsorderDefaultSetting>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderDefaultSetting = new HashSet<WspreOrderDefaultSetting>();
        }

        public int GuarantyId { get; set; }
        public string Guaranty { get; set; }
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
        public virtual ICollection<WsguarantyLang> WsguarantyLang { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSetting { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSetting { get; set; }
    }
}
