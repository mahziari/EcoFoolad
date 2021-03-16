using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Queries
{
    public interface IGetEditProductServices
    {
        ResultGetEditProductsDto Execute(int id);
    }

    public class GetEditProductServices : IGetEditProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditProductServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditProductsDto Execute(int id)
        {
            var product = _context.Wsproducts
                .Include(p=>p.PrdGroup)
                .Include(p => p.PrdUnit)
                .Include(p => p.PrdShpotherSupplier)
                .FirstOrDefault(p => p.ProductId==id);

            var subMenus = _context.WsproductFirstGroup
                .FirstOrDefault(s => s.PrdFirstGroupId == product.PrdGroup.FirstGroupId);
            
            var sMenus = _context.ParsaPooladMenus
                .FirstOrDefault(s => s.ParsaPooladMenusId == subMenus.ParsaPooladMenusId );
            
            
            var menus = _context.ParsaPooladMenus
                .Select(s=>new GetEditMenusDto
                {
                    ParsaPooladMenusId=s.ParsaPooladMenusId,
                    Name = s.Name
                }).ToList();

            var company = _context.CrmCompany
                .Select(c => new GetEditCompanyDto
                {
                    CompanyId=c.CompanyId,
                    CmpName=c.CmpName
                }).ToList();
            
            var productsUnit = _context.WsproductUnits
                .Select(c => new GetEditProductsUnitDto
                {
                    ProductUnitId=c.ProductUnitId,
                    Unit=c.Unit
                }).ToList();

            return new ResultGetEditProductsDto
            {
                Product=product,
                SubMenus=subMenus,
                SMenus=sMenus,
                Menus = menus,
                Company = company,
                ProductsUnit = productsUnit,
            };
        }

        
    }


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
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int PrdUnitId { get; set; }
        public int PrdMaxQty { get; set; }
        public string PrdDescription { get; set; }
        public string PrdModel { get; set; }
        public int PrdShpotherSupplierId { get; set; }
        public string PrdPrice { get; set; }
    }
    
    public class GetParentMenusProductDto
    {
        public string Name { get; set; }
        public int? ParentMenusId { get; set; }
        public int PrdFirstGroupId { get; set; }
        public string Fgname { get; set; }
    
    }
    
    public class GetEditMenusDto
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
    }
    public class GetEditCompanyDto
    {
        public int CompanyId { get; set; }
        public string CmpName { get; set; }
    }
    
    public class GetEditProductsUnitDto
    {
        public int ProductUnitId { get; set; }
        public string Unit { get; set; }
    }
}