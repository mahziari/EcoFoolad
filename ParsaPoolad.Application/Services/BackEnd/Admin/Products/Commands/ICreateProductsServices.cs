using System;
using System.ComponentModel.DataAnnotations;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Commands
{
    public interface ICreateProductsServices
    {
        ResultCreateProductsDto Execute(CreateProductsServicesDto createProductsServicesDto);
    }

    public class CreateProductsServices:ICreateProductsServices {
        private readonly IDataBaseContext _context;

        public CreateProductsServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateProductsDto Execute(CreateProductsServicesDto createProductsServicesDto)
        {
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
                PrdPrice =createProductsServicesDto.PrdPrice,
                PrdInactiveInSale =true,
                UserId= 57,
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
        public int ProductId { get; set; }
        
        [Display(Name = "دسته بندی محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int PrdGroupId { get; set; }
        public string PrdCode { get; set; }
        
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(250, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdName { get; set; }
        
        [Display(Name = "سایز محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(20, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdSize { get; set; }
        public int? PrdColorId { get; set; }
        
        [Display(Name = "واحد محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int? PrdUnitId { get; set; }
        
        [Display(Name = "موجودی محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int? PrdMaxQty { get; set; }
        
        [Display(Name = "توضیحات محصول")]
        [StringLength(1000, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdDescription { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public string RegisterDatePersian { get; set; }
        
        [Display(Name = "مدل محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(250, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string PrdModel { get; set; }
        
        public bool? PrdInactiveInSale { get; set; }
        
        [Display(Name = "شرکت سازنده محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int? PrdShpotherSupplierId { get; set; }
        
        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public decimal? PrdPrice { get; set; }
    }
}