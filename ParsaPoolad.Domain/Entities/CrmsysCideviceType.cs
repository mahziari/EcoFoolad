using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysCideviceType
    {
        public CrmsysCideviceType()
        {
            CrmsysCisetting = new HashSet<CrmsysCisetting>();
        }

        public int CideviceTypeId { get; set; }
        public int CideviceTypeMode { get; set; }
        public string CideviceType { get; set; }
        public string Cidesc { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmsysCisetting> CrmsysCisetting { get; set; }
    }
}
