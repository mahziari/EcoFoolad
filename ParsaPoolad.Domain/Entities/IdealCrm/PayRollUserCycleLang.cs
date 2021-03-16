using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class PayRollUserCycleLang
    {
        public int PayRollUserCycleLangId { get; set; }
        public int PayRollUserCycleId { get; set; }
        public int LanguageId { get; set; }
        public string CycleTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PayRollUserCycle PayRollUserCycle { get; set; }
    }
}
