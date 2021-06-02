using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmsysDbtempInfo
    {
        public long Id { get; set; }
        public int? UserId { get; set; }
        public Guid? Guid { get; set; }
        public int? TypeId { get; set; }
        public string Txt { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmsysDbtempInfoType Type { get; set; }
        public virtual Users User { get; set; }
    }
}
