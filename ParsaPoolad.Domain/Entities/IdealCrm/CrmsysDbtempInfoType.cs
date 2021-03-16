using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysDbtempInfoType
    {
        public CrmsysDbtempInfoType()
        {
            CrmsysDbtempInfo = new HashSet<CrmsysDbtempInfo>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmsysDbtempInfo> CrmsysDbtempInfo { get; set; }
    }
}
