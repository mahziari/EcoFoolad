using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmSystemParts
    {
        public CrmSystemParts()
        {
            CrmDyFormsCrmSysPart = new HashSet<CrmDyForms>();
            CrmDyFormsFosysPart = new HashSet<CrmDyForms>();
            CrmSystemPartsLang = new HashSet<CrmSystemPartsLang>();
        }

        public int SystemPartId { get; set; }
        public string PartTitle { get; set; }
        public string Part { get; set; }
        public string Type { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyFormsCrmSysPart { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyFormsFosysPart { get; set; }
        public virtual ICollection<CrmSystemPartsLang> CrmSystemPartsLang { get; set; }
    }
}
