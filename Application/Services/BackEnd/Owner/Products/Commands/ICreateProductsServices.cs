using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
 
using  Domain.Entities;
using  Domain.Entities.IdealCrm;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Owner.Products.Commands
{
    public interface ICreateProductsServices
    {
        ResultCreateProductsDto Execute(CreateProductsServicesDto createProductsServicesDto);
    }

    public class CreateProductsServices:ICreateProductsServices {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<User> _userManager;

        public CreateProductsServices(IIdealCrmDataBaseContext context , IHttpContextAccessor httpContext, UserManager<User> userManager)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
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
                // UserId= Convert.ToInt32(_httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier)),
                UserId=createProductsServicesDto.UserId ,
                Month1=6,
                Fpid = 1,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
            };



            
            _context.Wsproducts.Add(product);
            _context.SaveChanges();

            return new ResultCreateProductsDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت اضافه شد"
            };
        }
    }

    public class ResultCreateProductsDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    
    public class CreateProductsServicesDto
    {
        
        [Display(Name = "دسته بندی محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int PrdGroupId { get; set; }
        
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(250, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdName { get; set; }
        
        [Display(Name = "سایز محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(20, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdSize { get; set; }
        public int UserId { get; set; }
        
        [Display(Name = "واحد محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int? PrdUnitId { get; set; }
        
        [Display(Name = "موجودی محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int? PrdMaxQty { get; set; }
        
        [Display(Name = "توضیحات محصول")]
        [StringLength(4000, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdDescription { get; set; }

        [Display(Name = "مدل محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(250, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdModel { get; set; }
        
        [Display(Name = "شرکت سازنده محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int PrdShpotherSupplierId { get; set; }
        
        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public decimal? PrdPrice { get; set; }
    }
}