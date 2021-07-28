using System.ComponentModel.DataAnnotations;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
 

namespace  Application.Services.BackEnd.Admin.Company.Command
{
    public interface ICreateCompanyServices
    {
        ResultCreateCompanyDto Execute(CreateCompanyServicesDto createCompanyServicesDto);
    }

    public class CreateCompanyServices : ICreateCompanyServices
    {

        private readonly IIdealCrmDataBaseContext _context;
        public CreateCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateCompanyDto Execute(CreateCompanyServicesDto createCompanyServicesDto)
        {
            return new ResultCreateCompanyDto
            {
                IsSuccess = true,
                Message = "مجله با موفقیت اضافه شد"
            };

        }


    }


    public class ResultCreateCompanyDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    internal class UploadDto
    {
        public bool Status { get; set; }
        public string FileNameAddress { get; set; }
    }

    public class CreateCompanyServicesDto
    {
        public int NewsId { get; set; }

        [Display(Name = "نوع بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int NewsGroupId { get; set; }

        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(200, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string Title { get; set; }

        [Display(Name = "توضیح کوتاه بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string NewsSummery { get; set; }

        [Display(Name = "متن بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string NewsBody { get; set; }
        
        [Display(Name = "تصویر بلاگ")]
        [Required(ErrorMessage = "لطفا یک {0} انتخاب کنید")]
        [DataType(DataType.Upload)]
        // [FileExtensions(Extensions = ".png,.jpg,.jpeg,.gif", ErrorMessage = "فرمت عکس نامعتبر است")]
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }
}