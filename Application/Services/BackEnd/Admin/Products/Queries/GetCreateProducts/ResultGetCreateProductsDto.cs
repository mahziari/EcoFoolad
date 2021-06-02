using System.Collections.Generic;

namespace  Application.Services.BackEnd.Admin.Products.Queries.GetCreateProducts
{
    public class ResultGetCreateProductsDto
    {
        public List<GetCreateMenusDto> Menus { get; set; }
        public List<GetCreateCompanyDto> Company { get; set; }
        public List<GetCreateProductsUnitDto> ProductsUnit { get; set; }
        
        
        // Validation for Parsing Model Objects to view
        public int PrdGroupId { get; set; }
        public int UserId { get; set; }
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int PrdUnitId { get; set; }
        public int PrdMaxQty { get; set; }
        public string PrdDescription { get; set; }
        public string PrdModel { get; set; }
        public int PrdShpotherSupplierId { get; set; }
        public decimal? PrdPrice { get; set; }
    }
}