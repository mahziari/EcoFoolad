using System;
using Domain.Entities.IdealCrm;

namespace Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto
{
    public class GetIndexProductsDto
    {
        public int ProductId { get; set; }
        public string PrdCode { get; set; }
        public string PrdName { get; set; }
        public string UrlName { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime DateTime { get; set; }
        public int? PrdMaxQty { get; set; }
        public string PrdSize { get; set; }
        public string PrdModel { get; set; }
        public decimal PrdPrice { get; set; }
        public string PrdDescription { get; set; }
        public WsproductUnits PrdUnit { get; set; }
        public WsproductSecondGroup PrdGroup { get; set; }
        public CrmCompany PrdShpotherSupplier { get; set; }
        public GetIndexMenuDto subMenu { get; set; }
    }
}