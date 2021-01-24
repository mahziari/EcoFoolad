using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCmsPagesLang
    {
        public int CrmCmsPageLangId { get; set; }
        public int PageId { get; set; }
        public int LanguageId { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
        public string PageBody { get; set; }
        public string PageFooter { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmCmsPages Page { get; set; }
    }
}
