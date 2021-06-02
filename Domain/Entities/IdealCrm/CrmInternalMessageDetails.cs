using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmInternalMessageDetails
    {
        public int InternalMessageDetailId { get; set; }
        public int? MsgdInternalMessageId { get; set; }
        public int MsgdTypeId { get; set; }
        public int? MsgdOldTypeId { get; set; }
        public int MsgdFromUserId { get; set; }
        public int MsgdToUserId { get; set; }
        public string MsgdSendDate { get; set; }
        public string MsgdSendTime { get; set; }
        public DateTime MsgdSendDateTime { get; set; }
        public string MsgdReceiveDate { get; set; }
        public string MsgdReceiveTime { get; set; }
        public DateTime? MsgdReceiveDateTime { get; set; }
        public bool? MsgdIsRead { get; set; }
        public string MsgdReadDate { get; set; }
        public string MsgdReadTime { get; set; }
        public DateTime? MsgdReadDateTime { get; set; }
        public int? MsgdPriorityId { get; set; }
        public bool? MsgdIsDraft { get; set; }
        public bool? MsgdIsDeleted { get; set; }
        public string MsgdAttachFile { get; set; }
        public int? MsgdAttachRecId { get; set; }
        public string MsgdAttachRecDesc { get; set; }
        public int? MsgdGroupId { get; set; }
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
        public int? MsgdAttachRecIdI { get; set; }
        public string MsgdAttachRecDescI { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users MsgdFromUser { get; set; }
        public virtual CrmInternalMessageGroup MsgdGroup { get; set; }
        public virtual CrmInternalMessage MsgdInternalMessage { get; set; }
        public virtual Users MsgdToUser { get; set; }
        public virtual CrmInternalMessageType MsgdType { get; set; }
        public virtual Users User { get; set; }
    }
}
