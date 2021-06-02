using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
 

namespace  Application.Services.BackEnd.Admin.Sliders.Commands
{
    public interface ICreateSlidersServices
    {
        ResultCreateSlidersServices Execute(CreateSlidersServicesDto createSlidersServicesDto);
    }

    public class CreateSlidersServices : ICreateSlidersServices
    {
        private readonly ICustomDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public CreateSlidersServices(ICustomDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }


        public ResultCreateSlidersServices Execute(CreateSlidersServicesDto createSlidersServicesDto)
        {
            
            var uploadedResult = UploadFile(createSlidersServicesDto.Images);
            
            if (!uploadedResult.Status)
            {
                return new ResultCreateSlidersServices
                {
                    IsSuccess = false,
                    Message = "لطفا یک عکس انتخاب کنید"
                };
            }
            
            if (createSlidersServicesDto.Position == 0)
            {
                return new ResultCreateSlidersServices
                {
                    IsSuccess = false,
                    Message = "لطفا موقعیت اسلایدر را انتخاب کنید"
                };
            }
            
            
            Domain.Entities.Slider slider = new Domain.Entities.Slider()
            {
                Active = true,
                Type = "Sliders",
                Url = uploadedResult.FileNameAddress,
                Position = createSlidersServicesDto.Position
            };
            
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            

            return new ResultCreateSlidersServices
            {
                IsSuccess = true,
                Message = "اسلایدر با موفقیت اضافه شد"
            };
        }


        private UploadDto UploadFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
                return new UploadDto()
                {
                    Status = false,
                    FileNameAddress = "",
                };
            
            
            string folder = @"Images/Sliders/";
            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
            if (!Directory.Exists(uploadsRootFolder))
            {
                Directory.CreateDirectory(uploadsRootFolder);
            }

            string fileName = DateTime.Now.Ticks + file.FileName;
            var filePath = Path.Combine(uploadsRootFolder, fileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fileStream);

            return new UploadDto()
            {
                Status = true,
                FileNameAddress = folder + fileName,
            };

        }
    }

    public class ResultCreateSlidersServices
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    internal class UploadDto
    {
        public bool Status { get; set; }
        public string FileNameAddress { get; set; }
    }


    public class CreateSlidersServicesDto
    {
        [Display(Name = "موقعیت اسلایدر")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "لطفا {0} انتخاب کنید")]
        public int Position { get; set; }
        
        
        // [Required(ErrorMessage = "لطفا یک عکس انتخاب کنید")]
        // [DataType(DataType.Upload)]
        // [FileExtensions(Extensions = ".png,.jpg,.jpeg,.gif", ErrorMessage = "فرمت عکس نامعتبر است")]
        public IFormFile Images { get; set; }
    }
}