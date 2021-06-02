using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsfinancialPeriod
    {
        public WsfinancialPeriod()
        {
            WsWareHouse = new HashSet<WsWareHouse>();
            WsbuyOrder = new HashSet<WsbuyOrder>();
            WsbuyOrderItemSerials = new HashSet<WsbuyOrderItemSerials>();
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            WsbuyOrderPaymentTypes = new HashSet<WsbuyOrderPaymentTypes>();
            WsbuyOrderPayments = new HashSet<WsbuyOrderPayments>();
            WsbuyOrderStatus = new HashSet<WsbuyOrderStatus>();
            WscreditDuration = new HashSet<WscreditDuration>();
            WsdeliveryTime = new HashSet<WsdeliveryTime>();
            Wsdoc = new HashSet<Wsdoc>();
            WsdocItemSerials = new HashSet<WsdocItemSerials>();
            WsdocItems = new HashSet<WsdocItems>();
            Wsguaranty = new HashSet<Wsguaranty>();
            WslinkedProducts = new HashSet<WslinkedProducts>();
            Wslogo = new HashSet<Wslogo>();
            Wsorder = new HashSet<Wsorder>();
            WsorderDefaultSetting = new HashSet<WsorderDefaultSetting>();
            WsorderItemSerials = new HashSet<WsorderItemSerials>();
            WsorderItems = new HashSet<WsorderItems>();
            WsorderPaymentTypes = new HashSet<WsorderPaymentTypes>();
            WsorderPayments = new HashSet<WsorderPayments>();
            WsorderStatus = new HashSet<WsorderStatus>();
            WspayCondition = new HashSet<WspayCondition>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderDefaultSetting = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderItemSpecification = new HashSet<WspreOrderItemSpecification>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WspreOrderOpr = new HashSet<WspreOrderOpr>();
            WspreOrderPayments = new HashSet<WspreOrderPayments>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
            WspreOrderStatus = new HashSet<WspreOrderStatus>();
            WsproductCost = new HashSet<WsproductCost>();
            WsproductFirstGroup = new HashSet<WsproductFirstGroup>();
            WsproductGallery = new HashSet<WsproductGallery>();
            WsproductPicture = new HashSet<WsproductPicture>();
            WsproductPrice = new HashSet<WsproductPrice>();
            WsproductSecondGroup = new HashSet<WsproductSecondGroup>();
            WsproductShpStockManageTypes = new HashSet<WsproductShpStockManageTypes>();
            WsproductSpecification = new HashSet<WsproductSpecification>();
            Wsproducts = new HashSet<Wsproducts>();
            WsproductsRate = new HashSet<WsproductsRate>();
            WsproductsUserDiscount = new HashSet<WsproductsUserDiscount>();
            Wssignature = new HashSet<Wssignature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Fdate { get; set; }
        public string Tdate { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public short? Year1 { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? FpLinkAccFpid { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsWareHouse> WsWareHouse { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<WsbuyOrderItemSerials> WsbuyOrderItemSerials { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<WsbuyOrderPaymentTypes> WsbuyOrderPaymentTypes { get; set; }
        public virtual ICollection<WsbuyOrderPayments> WsbuyOrderPayments { get; set; }
        public virtual ICollection<WsbuyOrderStatus> WsbuyOrderStatus { get; set; }
        public virtual ICollection<WscreditDuration> WscreditDuration { get; set; }
        public virtual ICollection<WsdeliveryTime> WsdeliveryTime { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<WsdocItemSerials> WsdocItemSerials { get; set; }
        public virtual ICollection<WsdocItems> WsdocItems { get; set; }
        public virtual ICollection<Wsguaranty> Wsguaranty { get; set; }
        public virtual ICollection<WslinkedProducts> WslinkedProducts { get; set; }
        public virtual ICollection<Wslogo> Wslogo { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSetting { get; set; }
        public virtual ICollection<WsorderItemSerials> WsorderItemSerials { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WsorderPaymentTypes> WsorderPaymentTypes { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPayments { get; set; }
        public virtual ICollection<WsorderStatus> WsorderStatus { get; set; }
        public virtual ICollection<WspayCondition> WspayCondition { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSetting { get; set; }
        public virtual ICollection<WspreOrderItemSpecification> WspreOrderItemSpecification { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WspreOrderOpr> WspreOrderOpr { get; set; }
        public virtual ICollection<WspreOrderPayments> WspreOrderPayments { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
        public virtual ICollection<WspreOrderStatus> WspreOrderStatus { get; set; }
        public virtual ICollection<WsproductCost> WsproductCost { get; set; }
        public virtual ICollection<WsproductFirstGroup> WsproductFirstGroup { get; set; }
        public virtual ICollection<WsproductGallery> WsproductGallery { get; set; }
        public virtual ICollection<WsproductPicture> WsproductPicture { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPrice { get; set; }
        public virtual ICollection<WsproductSecondGroup> WsproductSecondGroup { get; set; }
        public virtual ICollection<WsproductShpStockManageTypes> WsproductShpStockManageTypes { get; set; }
        public virtual ICollection<WsproductSpecification> WsproductSpecification { get; set; }
        public virtual ICollection<Wsproducts> Wsproducts { get; set; }
        public virtual ICollection<WsproductsRate> WsproductsRate { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscount { get; set; }
        public virtual ICollection<Wssignature> Wssignature { get; set; }
    }
}
