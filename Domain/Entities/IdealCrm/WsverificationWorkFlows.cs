using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsverificationWorkFlows
    {
        public WsverificationWorkFlows()
        {
            Wsorder = new HashSet<Wsorder>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderDefaultSetting = new HashSet<WspreOrderDefaultSetting>();
            WsverificationRequestDetails = new HashSet<WsverificationRequestDetails>();
            WsverificationRequests = new HashSet<WsverificationRequests>();
            WsverificationWorkFlowSteps = new HashSet<WsverificationWorkFlowSteps>();
            WsverificationWorkFlowsLang = new HashSet<WsverificationWorkFlowsLang>();
        }

        public int VerificationWorkFlowId { get; set; }
        public int? ObjectType { get; set; }
        public string VerificationWorkFlowTitle { get; set; }
        public string VerifyRequestText { get; set; }
        public bool SequenceObservation { get; set; }
        public bool IsActive { get; set; }
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
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSetting { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetails { get; set; }
        public virtual ICollection<WsverificationRequests> WsverificationRequests { get; set; }
        public virtual ICollection<WsverificationWorkFlowSteps> WsverificationWorkFlowSteps { get; set; }
        public virtual ICollection<WsverificationWorkFlowsLang> WsverificationWorkFlowsLang { get; set; }
    }
}
