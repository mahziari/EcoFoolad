using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class MyWebsites
    {
        public int Id { get; set; }
        public string Website { get; set; }
        public int? ViewOrder { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
