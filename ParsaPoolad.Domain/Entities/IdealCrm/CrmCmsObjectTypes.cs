using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmCmsObjectTypes
    {
        public CrmCmsObjectTypes()
        {
            CrmCmsComments = new HashSet<CrmCmsComments>();
            CrmCmsFiles = new HashSet<CrmCmsFiles>();
            CrmCmsLikes = new HashSet<CrmCmsLikes>();
        }

        public int ObjectTypeId { get; set; }
        public string ObjectType { get; set; }
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

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsComments> CrmCmsComments { get; set; }
        public virtual ICollection<CrmCmsFiles> CrmCmsFiles { get; set; }
        public virtual ICollection<CrmCmsLikes> CrmCmsLikes { get; set; }
    }
}
