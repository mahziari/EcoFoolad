using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class Wslogo
    {
        public Wslogo()
        {
            WslogoLang = new HashSet<WslogoLang>();
            WsorderDefaultSettingLeftLogo = new HashSet<WsorderDefaultSetting>();
            WsorderDefaultSettingRightLogo = new HashSet<WsorderDefaultSetting>();
            WsorderOrdLlogo = new HashSet<Wsorder>();
            WsorderOrdRlogo = new HashSet<Wsorder>();
            WspreOrderDefaultSettingLeftLogo = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderDefaultSettingRightLogo = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderPordLlogo = new HashSet<WspreOrder>();
            WspreOrderPordRlogo = new HashSet<WspreOrder>();
        }

        public int LogoId { get; set; }
        public byte[] Logo { get; set; }
        public string LogoDescription { get; set; }
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
        public virtual ICollection<WslogoLang> WslogoLang { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSettingLeftLogo { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSettingRightLogo { get; set; }
        public virtual ICollection<Wsorder> WsorderOrdLlogo { get; set; }
        public virtual ICollection<Wsorder> WsorderOrdRlogo { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSettingLeftLogo { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSettingRightLogo { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderPordLlogo { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderPordRlogo { get; set; }
    }
}
