using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductFirstGroup
    {
        public WsproductFirstGroup()
        {
            CrmCmsMenus = new HashSet<CrmCmsMenus>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
            WsproductFirstGroupLang = new HashSet<WsproductFirstGroupLang>();
            WsproductSecondGroup = new HashSet<WsproductSecondGroup>();
        }

        public int PrdFirstGroupId { get; set; }
        public string Fgcode { get; set; }
        public string Fgname { get; set; }
        public string Fgdescription { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string FgnameEn { get; set; }
        public Guid? Guid { get; set; }
        public bool? FginactiveInSale { get; set; }
        public bool? FginactiveInBuy { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public bool? PrdGroupMustExistInPreOrder { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? ParsaPooladMenusId { get; set; }
        public int? IsRemoved { get; set; }

        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenus { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
        public virtual ICollection<WsproductFirstGroupLang> WsproductFirstGroupLang { get; set; }
        public virtual ICollection<WsproductSecondGroup> WsproductSecondGroup { get; set; }
    }
}
