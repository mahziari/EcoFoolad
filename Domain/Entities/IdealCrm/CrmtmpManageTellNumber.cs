using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmtmpManageTellNumber
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CmpId { get; set; }
        public int? PrsId { get; set; }
        public int? CmpCityId { get; set; }
        public bool? Sel { get; set; }
        public string CmpPreTel { get; set; }
        public string CmpPreTelNew { get; set; }
        public string CmpTel { get; set; }
        public string CmpTelNew { get; set; }
        public string CmpPreTelIi { get; set; }
        public string CmpPreTelIinew { get; set; }
        public string CmpTelIi { get; set; }
        public string CmpTelIinew { get; set; }
        public string CmpFax { get; set; }
        public string CmpFaxNew { get; set; }
        public int? Mode { get; set; }
        public string AppType { get; set; }
        public Guid? Guid { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
