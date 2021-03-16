using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries
{
    public interface IGetCreateProductServices
    {
        ResultGetCreateProductsDto Execute();
    }

    public class GetCreateProductServices : IGetCreateProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetCreateProductServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCreateProductsDto Execute()
        {
            var menus = _context.ParsaPooladMenus
                .Select(s=>new GetCreateMenusDto
                {
                    ParsaPooladMenusId=s.ParsaPooladMenusId,
                    Name = s.Name
                }).ToList();

            var company = _context.CrmCompany
                .Select(c => new GetCreateCompanyDto
                {
                    CompanyId=c.CompanyId,
                    CmpName=c.CmpName
                }).ToList();
            
            var productsUnit = _context.WsproductUnits
                .Select(c => new GetCreateProductsUnitDto
                {
                    ProductUnitId=c.ProductUnitId,
                    Unit=c.Unit
                }).ToList();

            return new ResultGetCreateProductsDto
            {
                Menus = menus,
                Company = company,
                ProductsUnit = productsUnit,
            };
        }
    }

    public class ResultGetCreateProductsDto
    {
        public List<GetCreateMenusDto> Menus { get; set; }
        public List<GetCreateCompanyDto> Company { get; set; }
        public List<GetCreateProductsUnitDto> ProductsUnit { get; set; }
        
        
        // Validation for Parsing Model Objects to view
        public int PrdGroupId { get; set; }
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int PrdUnitId { get; set; }
        public int PrdMaxQty { get; set; }
        public string PrdDescription { get; set; }
        public string PrdModel { get; set; }
        public int PrdShpotherSupplierId { get; set; }
        public decimal? PrdPrice { get; set; }
        public string UserId { get; set; }
        
        
    }


    public class GetCreateMenusDto
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
    }
    public class GetCreateCompanyDto
    {
        public int CompanyId { get; set; }
        public string CmpName { get; set; }
    }
    
    public class GetCreateProductsUnitDto
    {
        public int ProductUnitId { get; set; }
        public string Unit { get; set; }
    }
    
  
}