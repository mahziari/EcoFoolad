using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsverificationRequestDetails
    {
        public WsverificationRequestDetails()
        {
            WsverificationRequestDetailsLang = new HashSet<WsverificationRequestDetailsLang>();
        }

        public int VerificationRequestDetailId { get; set; }
        public int VerificationRequestId { get; set; }
        public int ObjectId { get; set; }
        public int ObjectType { get; set; }
        public int VerificationWorkFlowId { get; set; }
        public int VerificationWorkFlowStepId { get; set; }
        public int? VerifyUserId { get; set; }
        public DateTime? VerifyDateTime { get; set; }
        public string VerifyText { get; set; }
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
        public virtual WsverificationRequests VerificationRequest { get; set; }
        public virtual WsverificationWorkFlows VerificationWorkFlow { get; set; }
        public virtual WsverificationWorkFlowSteps VerificationWorkFlowStep { get; set; }
        public virtual Users VerifyUser { get; set; }
        public virtual ICollection<WsverificationRequestDetailsLang> WsverificationRequestDetailsLang { get; set; }
    }
}
