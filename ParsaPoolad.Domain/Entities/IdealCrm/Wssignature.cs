using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class Wssignature
    {
        public Wssignature()
        {
            Wsorder = new HashSet<Wsorder>();
            WsorderDefaultSetting = new HashSet<WsorderDefaultSetting>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderDefaultSetting = new HashSet<WspreOrderDefaultSetting>();
        }

        public int SignatureId { get; set; }
        public byte[] Signature { get; set; }
        public string SignatureDescription { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSetting { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSetting { get; set; }
    }
}
