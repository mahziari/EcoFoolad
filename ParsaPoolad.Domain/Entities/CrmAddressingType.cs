using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmAddressingType
    {
        public CrmAddressingType()
        {
            CrmAddressing = new HashSet<CrmAddressing>();
        }

        public int AddTypeId { get; set; }
        public string AddressingType { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmAddressing> CrmAddressing { get; set; }
    }
}
