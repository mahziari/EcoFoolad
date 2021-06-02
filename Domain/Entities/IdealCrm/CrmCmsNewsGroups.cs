using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCmsNewsGroups
    {
        public CrmCmsNewsGroups()
        {
            CrmCmsNews = new HashSet<CrmCmsNews>();
            CrmCmsNewsGroupsLang = new HashSet<CrmCmsNewsGroupsLang>();
        }

        public int NewsGroupId { get; set; }
        public string GroupName { get; set; }
        public string en_GroupName { get; set; }
        public bool? IsActive { get; set; }
        public int? OrderView { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsNews> CrmCmsNews { get; set; }
        public virtual ICollection<CrmCmsNewsGroupsLang> CrmCmsNewsGroupsLang { get; set; }
    }
}
