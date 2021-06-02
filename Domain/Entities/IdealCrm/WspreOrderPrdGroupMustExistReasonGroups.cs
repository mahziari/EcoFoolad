using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WspreOrderPrdGroupMustExistReasonGroups
    {
        public WspreOrderPrdGroupMustExistReasonGroups()
        {
            WspreOrderPrdGroupMustExistReasonGroupsLang = new HashSet<WspreOrderPrdGroupMustExistReasonGroupsLang>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
        }

        public int PrdGroupMustExistReasonGroupId { get; set; }
        public string PrdGroupMustExistReasonGroupTitle { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? OrderView { get; set; }
        public int LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public bool? NeedReasonTxt { get; set; }

        public virtual Languages Language { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasonGroupsLang> WspreOrderPrdGroupMustExistReasonGroupsLang { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
    }
}
