using System.ComponentModel.DataAnnotations;

namespace  Application.Services.BackEnd.Admin.Products.Commands.CreateProducts
{
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