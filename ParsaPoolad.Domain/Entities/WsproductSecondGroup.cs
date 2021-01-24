using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsproductSecondGroup
    {
        public WsproductSecondGroup()
        {
            CrmCmsMenus = new HashSet<CrmCmsMenus>();
            WsproductSecondGroupLang = new HashSet<WsproductSecondGroupLang>();
            Wsproducts = new HashSet<Wsproducts>();
            WsproductsUserDiscount = new HashSet<WsproductsUserDiscount>();
        }

        public int PrdSecondGroupId { get; set; }
        public int FirstGroupId { get; set; }
        public string Sgcode { get; set; }
        public string Sgname { get; set; }
        public string Sgdescription { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string SgnameEn { get; set; }
        public Guid? Guid { get; set; }
        public bool? SginactiveInSale { get; set; }
        public bool? SginactiveInBuy { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? SglinkAccGroupId { get; set; }
        public string SglinkAccGroupCode { get; set; }
        public int? IsRemoved { get; set; }

        public virtual WsproductFirstGroup FirstGroup { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenus { get; set; }
        public virtual ICollection<WsproductSecondGroupLang> WsproductSecondGroupLang { get; set; }
        public virtual ICollection<Wsproducts> Wsproducts { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscount { get; set; }
    }
}
