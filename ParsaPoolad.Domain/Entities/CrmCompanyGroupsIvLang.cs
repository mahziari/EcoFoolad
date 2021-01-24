using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCompanyGroupsIvLang
    {
        public int CrmCompanyGroupsIvlangId { get; set; }
        public int CompanyGroupIvid { get; set; }
        public int LanguageId { get; set; }
        public string GroupIvname { get; set; }
        public string GroupIvdesc { get; set; }

        public virtual CrmCompanyGroupsIv CompanyGroupIv { get; set; }
        public virtual Languages Language { get; set; }
    }
}
