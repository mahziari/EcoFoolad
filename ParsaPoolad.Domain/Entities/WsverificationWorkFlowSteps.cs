using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsverificationWorkFlowSteps
    {
        public WsverificationWorkFlowSteps()
        {
            WsverificationRequestDetails = new HashSet<WsverificationRequestDetails>();
            WsverificationWorkFlowStepsLang = new HashSet<WsverificationWorkFlowStepsLang>();
        }

        public int VerificationWorkFlowStepId { get; set; }
        public int VerificationWorkFlowId { get; set; }
        public string VerificationWorkFlowStepTitle { get; set; }
        public int? VerifyUserId { get; set; }
        public int? AlternateVerifyUserId { get; set; }
        public string VerifyText { get; set; }
        public int? OrderView { get; set; }
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

        public virtual Users AlternateVerifyUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual WsverificationWorkFlows VerificationWorkFlow { get; set; }
        public virtual Users VerifyUser { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetails { get; set; }
        public virtual ICollection<WsverificationWorkFlowStepsLang> WsverificationWorkFlowStepsLang { get; set; }
    }
}
