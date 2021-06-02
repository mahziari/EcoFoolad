using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmCmsComments
    {
        public CrmCmsComments()
        {
            CrmCmsCommentsLang = new HashSet<CrmCmsCommentsLang>();
        }

        public int CommentId { get; set; }
        public int ObjectTypeId { get; set; }
        public int ObjectId { get; set; }
        public int? ParentId { get; set; }
        public int? CrmCompanyId { get; set; }
        public string Ipaddress { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public bool? IsVerified { get; set; }
        public int? VerifiedUserId { get; set; }
        public DateTime? VerifiedDateTime { get; set; }
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

        public virtual CrmCompany CrmCompany { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmCmsObjectTypes ObjectType { get; set; }
        public virtual Users User { get; set; }
        public virtual Users VerifiedUser { get; set; }
        public virtual ICollection<CrmCmsCommentsLang> CrmCmsCommentsLang { get; set; }
    }
}
