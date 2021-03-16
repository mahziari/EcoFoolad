using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class PrintFormat
    {
        public PrintFormat()
        {
            CrmDyForms = new HashSet<CrmDyForms>();
            PayRollUserCycle = new HashSet<PayRollUserCycle>();
            PrintFormatLang = new HashSet<PrintFormatLang>();
            SecLetterDefaultSettings = new HashSet<SecLetterDefaultSettings>();
            SecLetters = new HashSet<SecLetters>();
            WsbuyOrder = new HashSet<WsbuyOrder>();
            Wsorder = new HashSet<Wsorder>();
            WsorderDefaultSetting = new HashSet<WsorderDefaultSetting>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderDefaultSetting = new HashSet<WspreOrderDefaultSetting>();
        }

        public int PrintFormatId { get; set; }
        public int PrintFormatTypeId { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string FileNameWeb { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual PrintFormatType PrintFormatType { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyForms { get; set; }
        public virtual ICollection<PayRollUserCycle> PayRollUserCycle { get; set; }
        public virtual ICollection<PrintFormatLang> PrintFormatLang { get; set; }
        public virtual ICollection<SecLetterDefaultSettings> SecLetterDefaultSettings { get; set; }
        public virtual ICollection<SecLetters> SecLetters { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSetting { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSetting { get; set; }
    }
}
