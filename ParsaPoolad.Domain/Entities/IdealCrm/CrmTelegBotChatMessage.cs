﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmTelegBotChatMessage
    {
        public int TelegBotChatMessageId { get; set; }
        public long? MessageId { get; set; }
        public int? MessageTypeId { get; set; }
        public long? ChatId { get; set; }
        public string TextCaption { get; set; }
        public string DownloadFilePath { get; set; }
        public string FileId { get; set; }
        public string FilePath { get; set; }
        public string FileExensions { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? EditDate { get; set; }
        public bool? InComing { get; set; }
        public int? CrmUserId { get; set; }
        public string Logitude { get; set; }
        public string Latitude { get; set; }
        public long? ReplyToMessageId { get; set; }
        public int? SendStatusId { get; set; }
        public DateTime? SendDateTime { get; set; }
        public DateTime? SentDateTime { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ReadDateTime { get; set; }
        public string MessageLanguageCode { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Users CrmUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmTelegBotMessageType MessageType { get; set; }
    }
}
