using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCompanyJustAccessGroupIv
    {
        public int Id { get; set; }
        public int CrmUserId { get; set; }
        public int JustAccessGroupIvid { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users CrmUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmCompanyGroupsIv JustAccessGroupIv { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
