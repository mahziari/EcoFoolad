using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace  Domain.Entities.IdealCrm
{
    public partial class Wsproducts
    {
        public Wsproducts()
        {
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            WsdocItems = new HashSet<WsdocItems>();
            WslinkedProductsLinkedPrd = new HashSet<WslinkedProducts>();
            WslinkedProductsPrd = new HashSet<WslinkedProducts>();
            WsorderItems = new HashSet<WsorderItems>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WsproductCost = new HashSet<WsproductCost>();
            WsproductGallery = new HashSet<WsproductGallery>();
            WsproductPicture = new HashSet<WsproductPicture>();
            WsproductPrice = new HashSet<WsproductPrice>();
            WsproductSpecification = new HashSet<WsproductSpecification>();
            WsproductsLang = new HashSet<WsproductsLang>();
            WsproductsRate = new HashSet<WsproductsRate>();
            WsproductsUserDiscount = new HashSet<WsproductsUserDiscount>();
            WstmpUserItemCopy = new HashSet<WstmpUserItemCopy>();
            WsuserFavproductItems = new HashSet<WsuserFavproductItems>();
        }

        public int ProductId { get; set; }
        public int PrdGroupId { get; set; }
        public string PrdCode { get; set; }
        public string PrdName { get; set; }
        public string PrdLatinName { get; set; }
        public string PrdType { get; set; }
        public string PrdDesign { get; set; }
        public string PrdSize { get; set; }
        public int? PrdColorId { get; set; }
        public int? PrdUnitId { get; set; }
        public int? PrdMinQty { get; set; }
        public int? PrdMaxQty { get; set; }
        public int? PrdSleepDay { get; set; }
        public string PrdFirstSerial { get; set; }
        public string PrdSecondSerial { get; set; }
        public string PrdThirdSerial { get; set; }
        public string PrdFirstBarcode { get; set; }
        public string PrdSecondBarcode { get; set; }
        public string PrdThirdBarcode { get; set; }
        public string PrdDescription { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string PrdBarCode { get; set; }
        public int? PrdBarCodeTypeId { get; set; }
        public string PrdAutoNumBarcode { get; set; }
        public int? PrdAutoNumBarCodeTypeId { get; set; }
        public string PrdAutoCharBarcode { get; set; }
        public int? PrdAutoCharBarCodeTypeId { get; set; }
        public string PrdModel { get; set; }
        public Guid? Guid { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public bool? PrdInactiveInBuy { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? PrdCommissionDisable { get; set; }
        public double? PrdCommissionPercentRate { get; set; }
        public bool? PrdShpisActive { get; set; }
        public string PrdShptitle { get; set; }
        public string PrdShpcode { get; set; }
        public string PrdShpmodel { get; set; }
        public string PrdShpdescription { get; set; }
        public string PrdShpdescriptionIi { get; set; }
        public int? PrdShpstockManageTypeId { get; set; }
        public double? PrdShpstockManualyCount { get; set; }
        public bool? PrdShphiddenPriceInNoStock { get; set; }
        public bool? PrdShpselfSupplier { get; set; }
        public int? PrdShpotherSupplierId { get; set; }
        public int? PrdLinkAccPrdId { get; set; }
        public string PrdLinkAccPrdCode { get; set; }
        public int? OrderView { get; set; }
        public decimal? PrdPrice { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WsproductColor PrdColor { get; set; }
        public virtual WsproductSecondGroup PrdGroup { get; set; }
        public virtual CrmCompany PrdShpotherSupplier { get; set; }
        public virtual WsproductUnits PrdUnit { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<WsdocItems> WsdocItems { get; set; }
        public virtual ICollection<WslinkedProducts> WslinkedProductsLinkedPrd { get; set; }
        public virtual ICollection<WslinkedProducts> WslinkedProductsPrd { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WsproductCost> WsproductCost { get; set; }
        public virtual ICollection<WsproductGallery> WsproductGallery { get; set; }
        public virtual ICollection<WsproductPicture> WsproductPicture { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPrice { get; set; }
        public virtual ICollection<WsproductSpecification> WsproductSpecification { get; set; }
        public virtual ICollection<WsproductsLang> WsproductsLang { get; set; }
        public virtual ICollection<WsproductsRate> WsproductsRate { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscount { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopy { get; set; }
        public virtual ICollection<WsuserFavproductItems> WsuserFavproductItems { get; set; }
    }
}
