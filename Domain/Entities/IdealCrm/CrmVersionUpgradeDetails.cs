using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmVersionUpgradeDetails
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string ActionName { get; set; }
        public bool? Succeed { get; set; }
        public string ActionValue { get; set; }
        public string RunDatePersian { get; set; }
        public DateTime? RunDate { get; set; }
        public int? RunUserId { get; set; }
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
