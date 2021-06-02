using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessage
    {
        public CrmInternalMessage()
        {
            CrmInternalMessageDetails = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageLang = new HashSet<CrmInternalMessageLang>();
        }

        public int InternalMessageId { get; set; }
        public int? MsgMasterId { get; set; }
        public string MsgSubject { get; set; }
        public string MsgBody { get; set; }
        public int MsgFromUserId { get; set; }
        public int? MsgAttachRecId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? MsgTypeId { get; set; }
        public Guid? Guid { get; set; }
        public bool? MsgActiveInCycle { get; set; }
        public int? MsgLastGroupId { get; set; }
        public int? MsgIsFinalised { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public string ApiId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users MsgFromUser { get; set; }
        public virtual CrmInternalMessageType MsgType { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetails { get; set; }
        public virtual ICollection<CrmInternalMessageLang> CrmInternalMessageLang { get; set; }
    }
}
