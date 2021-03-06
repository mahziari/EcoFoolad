using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmVersionUpgrade
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string ReleaseDatePersian { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool? Upgraded { get; set; }
        public string UpgradedDatePersian { get; set; }
        public DateTime? UpgradedDate { get; set; }
        public int? UpgradedUserId { get; set; }
        public Guid? GuId { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
