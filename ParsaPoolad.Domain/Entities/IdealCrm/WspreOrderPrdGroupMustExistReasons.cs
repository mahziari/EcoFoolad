using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WspreOrderPrdGroupMustExistReasons
    {
        public WspreOrderPrdGroupMustExistReasons()
        {
            WspreOrderPrdGroupMustExistReasonsLang = new HashSet<WspreOrderPrdGroupMustExistReasonsLang>();
        }

        public int PrdGroupMustExistReasonId { get; set; }
        public int PrdGroupMustExistReasonGroupId { get; set; }
        public int? CompanyId { get; set; }
        public int CmpProjectId { get; set; }
        public int? PreOrderId { get; set; }
        public int PrdFirstGroupId { get; set; }
        public string Reason { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmProjects CmpProject { get; set; }
        public virtual CrmCompany Company { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WsproductFirstGroup PrdFirstGroup { get; set; }
        public virtual WspreOrderPrdGroupMustExistReasonGroups PrdGroupMustExistReasonGroup { get; set; }
        public virtual WspreOrder PreOrder { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasonsLang> WspreOrderPrdGroupMustExistReasonsLang { get; set; }
    }
}
