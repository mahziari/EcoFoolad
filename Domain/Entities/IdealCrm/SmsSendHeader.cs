using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsSendHeader
    {
        public SmsSendHeader()
        {
            SmsSendDetail = new HashSet<SmsSendDetail>();
        }

        public int Id { get; set; }
        public int SendType { get; set; }
        public string SendTopic { get; set; }
        public long? Sid { get; set; }
        public string FromNumber { get; set; }
        public string SmsBody { get; set; }
        public int? SmsBodyCount { get; set; }
        public string SmsBodyLangType { get; set; }
        public decimal? SmsBodyCost { get; set; }
        public int? NumberCount { get; set; }
        public string Numbers { get; set; }
        public string RefNumbers { get; set; }
        public int? AllsmsCount { get; set; }
        public decimal? UserCost { get; set; }
        public int SendUserId { get; set; }
        public string SendDay { get; set; }
        public string SendDate { get; set; }
        public string SendTime { get; set; }
        public DateTime? SendDateTime { get; set; }
        public string CompaniesId { get; set; }
        public string CompanyPersonsId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? Cmessage { get; set; }
        public DateTime? SchedulDate { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users SendUser { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SmsSendDetail> SmsSendDetail { get; set; }
    }
}
