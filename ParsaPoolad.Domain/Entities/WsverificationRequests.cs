using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsverificationRequests
    {
        public WsverificationRequests()
        {
            WsverificationRequestDetails = new HashSet<WsverificationRequestDetails>();
            WsverificationRequestsLang = new HashSet<WsverificationRequestsLang>();
        }

        public int VerificationRequestId { get; set; }
        public int VerificationWorkFlowId { get; set; }
        public DateTime VerificationReqDateTime { get; set; }
        public int VerificationReqUserId { get; set; }
        public string VerificationReqText { get; set; }
        public int VerificationReqObjectId { get; set; }
        public int VerificationReqObjectType { get; set; }
        public bool? VerificationReqExpired { get; set; }
        public DateTime? VerificationReqExpiredDateTime { get; set; }
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
        public virtual Users VerificationReqUser { get; set; }
        public virtual WsverificationWorkFlows VerificationWorkFlow { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetails { get; set; }
        public virtual ICollection<WsverificationRequestsLang> WsverificationRequestsLang { get; set; }
    }
}
