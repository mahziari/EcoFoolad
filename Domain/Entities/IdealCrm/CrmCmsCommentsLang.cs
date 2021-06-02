using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCmsCommentsLang
    {
        public int CrmCmsCommentLangId { get; set; }
        public int CommentId { get; set; }
        public int LanguageId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Description { get; set; }

        public virtual CrmCmsComments Comment { get; set; }
        public virtual Languages Language { get; set; }
    }
}
