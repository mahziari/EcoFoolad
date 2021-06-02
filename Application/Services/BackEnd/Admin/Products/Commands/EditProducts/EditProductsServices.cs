using System;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Products.Commands.EditProducts
{
    public class EditProductsServices:IEditProductsServices {
        
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<User> _userManager;
        private readonly ICustomDbContext _customDbContext;

        public EditProductsServices(IIdealCrmDataBaseContext context,IHttpContextAccessor httpContext,UserManager<User> userManager, ICustomDbContext customDbContext)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
            _customDbContext = customDbContext;
        }

        public ResultEditProductsDto Execute(EditProductsServicesDto editProductsServicesDto,int id)
        {
            var userLoged =  _userManager.GetUserAsync(_httpContext.HttpContext?.User).Result;
            if (userLoged.CrmUsersId != editProductsServicesDto.UserId)
            {
                return new ResultEditProductsDto
                {
                    IsSuccess = false,
                    Message = "در صورت تکرار مجدد حساب کاربری شما مسدود میگردد"
                };
            }
            
            // Active Product to CRM Db
            var product = _context.Wsproducts.Find(id);
            product.PrdGroupId = editProductsServicesDto.PrdGroupId;
            product.PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}";
            product.PrdName = editProductsServicesDto.PrdName;
            product.PrdShpotherSupplierId = editProductsServicesDto.PrdShpotherSupplierId;
            product.PrdUnitId = editProductsServicesDto.PrdUnitId;
            product.PrdMaxQty = editProductsServicesDto.PrdMaxQty;
            product.PrdSize = editProductsServicesDto.PrdSize;
            product.PrdModel = editProductsServicesDto.PrdModel;
            product.PrdDescription = editProductsServicesDto.PrdDescription;
            product.PrdPrice = editProductsServicesDto.PrdPrice;
            _context.SaveChanges();
            
            
            
            // Active Product to CustomDbContext Db
            var productCustomDbContext = _customDbContext.Products.Find(id);
            productCustomDbContext.PrdGroupId = editProductsServicesDto.PrdGroupId;
            productCustomDbContext.PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}";
            productCustomDbContext.PrdName = editProductsServicesDto.PrdName;
            productCustomDbContext.PrdShpotherSupplierId = editProductsServicesDto.PrdShpotherSupplierId;
            productCustomDbContext.PrdUnitId = editProductsServicesDto.PrdUnitId;
            productCustomDbContext.PrdMaxQty = editProductsServicesDto.PrdMaxQty;
            productCustomDbContext.PrdSize = editProductsServicesDto.PrdSize;
            productCustomDbContext.PrdModel = editProductsServicesDto.PrdModel;
            productCustomDbContext.PrdDescription = editProductsServicesDto.PrdDescription;
            productCustomDbContext.PrdPrice =Convert.ToInt32(editProductsServicesDto.PrdPrice);
            _customDbContext.SaveChanges();

            return new ResultEditProductsDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت ویرایش شد"
            };
        }

    }
}