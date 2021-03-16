using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCmsMenusLang
    {
        public int CrmCmsMenuLangId { get; set; }
        public int MenuId { get; set; }
        public int LanguageId { get; set; }
        public string MenuTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmCmsMenus Menu { get; set; }
    }
}
