using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Queries
{
    public interface IGetEditProductServices
    {
        ResultGetEditProductsDto Execute(int id);
    }

    public class GetEditProductServices : IGetEditProductServices
    {
        private readonly IDataBaseContext _context;

        public GetEditProductServices(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditProductsDto Execute(int id)
        {
            // var product = _context.Wsproducts
            //     .Join(_context.WsproductSecondGroup, p =>p.PrdGroupId  , s=> s.PrdSecondGroupId,(p, s) => new { p, s })
            //     .Join(_context.WsproductFirstGroup, e =>e.s.FirstGroupId  , f=> f.PrdFirstGroupId,(e,f)=>new {e,f})
            //     .Join(_context.ParsaPooladMenus, z =>z.f.ParsaPooladMenusId  , m=> m.ParentMenusId,(z,m)=>new {z,m})
            //     .Join(_context.WsproductUnits, x =>x.z.e.p.PrdUnitId  , u=> u.ProductUnitId,(x,u)=>new {x,u})
            //     .Join(_context.CrmCompany, y =>y.x.z.e.p.PrdShpotherSupplierId  , c=> c.CompanyId,(y,c)=>new {y,c})
            //     .Where(p => p.y.x.z.e.p.ProductId==id)
            //     .Select(p=> new GetProductDto
            //     {
            //         PrdGroupId=p.y.x.z.e.s.PrdSecondGroupId,
            //         Sgname=p.y.x.z.e.s.Sgname,
            //         PrdFirstGroupId=p.y.x.z.f.PrdFirstGroupId,
            //         Fgname=p.y.x.z.f.Fgname,
            //         ParentMenusId=p.y.x.m.ParentMenusId,
            //         Name=p.y.x.m.Name,
            //         PrdUnitId=p.y.u.ProductUnitId,
            //         Unit=p.y.u.Unit,
            //         PrdShpotherSupplierId=p.c.CompanyId,
            //         CmpName=p.c.CmpName,
            //         PrdName=p.y.x.z.e.p.PrdName,
            //         PrdSize=p.y.x.z.e.p.PrdSize,
            //         PrdMaxQty=p.y.x.z.e.p.PrdMaxQty,
            //         PrdDescription=p.y.x.z.e.p.PrdDescription,
            //         PrdModel=p.y.x.z.e.p.PrdModel,
            //         PrdPrice=p.y.x.z.e.p.PrdPrice,
            //     }).FirstOrDefault();
            
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