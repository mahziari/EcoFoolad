using System;
using System.Collections.Generic;
using Domain.Entities.Attributes;
using Domain.Entities.Orders;

namespace Domain.Entities.Products
{
    [Auditable]
    public class Product
    {
        public long Id { get; set; }
        public long PrdCrmId { get; set; }
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
        public int PrdPrice { get; set; }
        public int VisitCount { get; set; }
        public string LocalTime { get; set; }
    }
}