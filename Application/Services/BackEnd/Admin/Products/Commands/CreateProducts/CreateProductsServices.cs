using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Identity;
 
using  Domain.Entities;
using  Domain.Entities.IdealCrm;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.Products.Commands.CreateProducts
{
    public class CreateProductsServices:ICreateProductsServices {
        
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly ICustomDbContext _customDbContext;

        public CreateProductsServices(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<Domain.Entities.Users.User> userManager, ICustomDbContext customDbContext)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
            _customDbContext = customDbContext;
        }

        public ResultCreateProductsDto Execute(CreateProductsServicesDto createProductsServicesDto)
        {
            
            var userLoged =  _userManager.GetUserAsync(_httpContext.HttpContext?.User).Result;
            if (userLoged.CrmUsersId != createProductsServicesDto.UserId)
            {
                return new ResultCreateProductsDto
                {
                    IsSuccess = false,
                    Message = "در صورت تکرار مجدد حساب کاربری شما مسدود میگردد"
                };
            }
            
            // Add Product to CRM Db
            Wsproducts product = new Wsproducts()
            {
                PrdGroupId = createProductsServicesDto.PrdGroupId ,
                PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}",
                PrdName = createProductsServicesDto.PrdName ,
                PrdShpotherSupplierId = createProductsServicesDto.PrdShpotherSupplierId ,
                PrdUnitId = createProductsServicesDto.PrdUnitId,
                PrdMaxQty = createProductsServicesDto.PrdMaxQty,
                PrdSize = createProductsServicesDto.PrdSize,
                PrdModel = createProductsServicesDto.PrdModel,
                PrdDescription = createProductsServicesDto.PrdDescription,
                PrdPrice =Convert.ToDecimal(createProductsServicesDto.PrdPrice),
                PrdInactiveInSale =true,
                UserId= userLoged.CrmUsersId,
                Month1=6,
                Fpid = 1,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                LocalTime = DateTime.Now.ToString("s")+"+"+TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),
            };
            _context.Wsproducts.Add(product);
            _context.SaveChanges();

            var CrmPrdID = _context.Wsproducts.OrderBy(p=>p.ProductId).LastOrDefault();
            // Add Product to Custom Db
            var product2 = new Product()
            {
                PrdCrmId = CrmPrdID.ProductId ,
                PrdGroupId = createProductsServicesDto.PrdGroupId ,
                PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}",
                PrdName = createProductsServicesDto.PrdName ,
                PrdShpotherSupplierId = createProductsServicesDto.PrdShpotherSupplierId ,
                PrdUnitId = createProductsServicesDto.PrdUnitId,
                PrdMaxQty = createProductsServicesDto.PrdMaxQty,
                PrdSize = createProductsServicesDto.PrdSize,
                PrdModel = createProductsServicesDto.PrdModel,
                PrdDescription = createProductsServicesDto.PrdDescription,
                PrdPrice =Convert.ToInt32(createProductsServicesDto.PrdPrice),
                PrdInactiveInSale =true,
                UserId= userLoged.CrmUsersId,
                Month1=6,
                Fpid = 1,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                LocalTime = DateTime.Now.ToString("s")+"+"+TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),
            };
            _customDbContext.Products.Add(product2);
            _customDbContext.SaveChanges();

            
            
            
            return new ResultCreateProductsDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت اضافه شد"
            };
        }

    }
}