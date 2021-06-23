using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCmsNews
    {
        public CrmCmsNews()
        {
            CrmCmsMenus = new HashSet<CrmCmsMenus>();
            CrmCmsNewsLang = new HashSet<CrmCmsNewsLang>();
        }

        public int NewsId { get; set; }
        
        public int NewsGroupId { get; set; }
        public string HeadLine { get; set; }
        
        public string Title { get; set; }
        
        public string NewsSummery { get; set; }
        public DateTime PublishDateTime { get; set; }
        public string NewsBody { get; set; }
        public bool IsVerified { get; set; }
        public int? VerifiedUserId { get; set; }
        public DateTime? VerifiedDateTime { get; set; }
        public bool? CommentActive { get; set; }
        public bool? LikeActive { get; set; }
        public int? OrderView { get; set; }
        public bool? IsTopNews { get; set; }
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
        public int Position { get; set; }
        public string LocalTime { get; set; }
        public int VisitCount { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCmsNewsGroups NewsGroup { get; set; }
        public virtual Users User { get; set; }
        public virtual Users VerifiedUser { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenus { get; set; }
        public virtual ICollection<CrmCmsNewsLang> CrmCmsNewsLang { get; set; }
    }
}
