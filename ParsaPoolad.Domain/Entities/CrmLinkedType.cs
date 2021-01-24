using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmLinkedType
    {
        public CrmLinkedType()
        {
            CrmLinkedTypeLang = new HashSet<CrmLinkedTypeLang>();
            CrmLinkedUsers = new HashSet<CrmLinkedUsers>();
        }

        public int LinkedTypeId { get; set; }
        public short TypeOrder { get; set; }
        public string LinkTypeName { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmLinkedTypeLang> CrmLinkedTypeLang { get; set; }
        public virtual ICollection<CrmLinkedUsers> CrmLinkedUsers { get; set; }
    }
}
