using System.Collections.Generic;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Products.Queries.GetEditProducts
{
    public class ResultGetEditProductsDto
    {
        public Wsproducts Product { get; set; }
        public WsproductFirstGroup SubMenus { get; set; }
        public ParsaPooladMenus SMenus { get; set; }
        public List<GetEditMenusDto> Menus { get; set; }
        public List<GetEditCompanyDto> Company { get; set; }
        public List<GetEditProductsUnitDto> ProductsUnit { get; set; }

        
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
        public string PrdPrice { get; set; }
    }
}