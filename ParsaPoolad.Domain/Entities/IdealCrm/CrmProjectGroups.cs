using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmProjectGroups
    {
        public CrmProjectGroups()
        {
            CrmFoSetting = new HashSet<CrmFoSetting>();
            CrmProjectGroupsLang = new HashSet<CrmProjectGroupsLang>();
            CrmProjectTitles = new HashSet<CrmProjectTitles>();
            CrmProjects = new HashSet<CrmProjects>();
            CrmProjectsTmp = new HashSet<CrmProjectsTmp>();
        }

        public int ProjectGroupId { get; set; }
        public string ProjectGroup { get; set; }
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

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
        public virtual ICollection<CrmProjectGroupsLang> CrmProjectGroupsLang { get; set; }
        public virtual ICollection<CrmProjectTitles> CrmProjectTitles { get; set; }
        public virtual ICollection<CrmProjects> CrmProjects { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmp { get; set; }
    }
}
