using System;
using System.ComponentModel.DataAnnotations;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Commands
{
    public interface IEditProductsServices
    {
        ResultEditProductsDto Execute(EditProductsDto editProductsDto,int id);
    }

    public class EditProductsServices:IEditProductsServices {
        private readonly IDataBaseContext _context;

        public EditProductsServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultEditProductsDto Execute(EditProductsDto editProductsDto,int id)
        {
            var product = _context.Wsproducts.Find(id);

            product.PrdGroupId = editProductsDto.PrdGroupId;
            product.PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}";
            product.PrdName = editProductsDto.PrdName;
            product.PrdShpotherSupplierId = editProductsDto.PrdShpotherSupplierId;
            product.PrdUnitId = editProductsDto.PrdUnitId;
            product.PrdMaxQty = editProductsDto.PrdMaxQty;
            product.PrdSize = editProductsDto.PrdSize;
            product.PrdModel = editProductsDto.PrdModel;
            product.PrdDescription = editProductsDto.PrdDescription;
            product.PrdPrice = editProductsDto.PrdPrice;
            _context.SaveChanges();

            return new ResultEditProductsDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت ویرایش شد"
            };
        }

    }

    public class ResultEditProductsDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class EditProductsDto
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