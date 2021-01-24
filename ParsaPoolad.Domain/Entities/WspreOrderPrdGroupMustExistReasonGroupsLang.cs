using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WspreOrderPrdGroupMustExistReasonGroupsLang
    {
        public int WspreOrderPrdGroupMustExistReasonGroupsLangId { get; set; }
        public int PrdGroupMustExistReasonGroupId { get; set; }
        public int LanguageId { get; set; }
        public string PrdGroupMustExistReasonGroupTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrderPrdGroupMustExistReasonGroups PrdGroupMustExistReasonGroup { get; set; }
    }
}
