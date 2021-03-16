using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsWareHouse
    {
        public WsWareHouse()
        {
            WsWareHouseLang = new HashSet<WsWareHouseLang>();
            WsbuyOrderItemSerials = new HashSet<WsbuyOrderItemSerials>();
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            Wsdoc = new HashSet<Wsdoc>();
            WsdocItemSerials = new HashSet<WsdocItemSerials>();
            WsdocItems = new HashSet<WsdocItems>();
            WsorderItemSerials = new HashSet<WsorderItemSerials>();
            WsorderItems = new HashSet<WsorderItems>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WsproductCost = new HashSet<WsproductCost>();
            WsproductPicture = new HashSet<WsproductPicture>();
            WsproductPrice = new HashSet<WsproductPrice>();
            WstmpUserItemCopy = new HashSet<WstmpUserItemCopy>();
            WsuserFavproductItems = new HashSet<WsuserFavproductItems>();
        }

        public int WareHouseId { get; set; }
        public string WrhsName { get; set; }
        public string WrhsCode { get; set; }
        public string WrhsAddress { get; set; }
        public string WrhsPreTel { get; set; }
        public string WrhsTel { get; set; }
        public string WrhsTelSecond { get; set; }
        public string WrhsTelThird { get; set; }
        public string WrhsFax { get; set; }
        public string WrhsFaxSecond { get; set; }
        public string WrhsArea { get; set; }
        public string WrhsPerson { get; set; }
        public string WrhsDescription { get; set; }
        public short? IsFix { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? WrhsDeActive { get; set; }
        public int? OrderView { get; set; }
        public int? WrhsLinkAccWhId { get; set; }
        public string WrhsLinkAccWhCode { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsWareHouseLang> WsWareHouseLang { get; set; }
        public virtual ICollection<WsbuyOrderItemSerials> WsbuyOrderItemSerials { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<WsdocItemSerials> WsdocItemSerials { get; set; }
        public virtual ICollection<WsdocItems> WsdocItems { get; set; }
        public virtual ICollection<WsorderItemSerials> WsorderItemSerials { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WsproductCost> WsproductCost { get; set; }
        public virtual ICollection<WsproductPicture> WsproductPicture { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPrice { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopy { get; set; }
        public virtual ICollection<WsuserFavproductItems> WsuserFavproductItems { get; set; }
    }
}
