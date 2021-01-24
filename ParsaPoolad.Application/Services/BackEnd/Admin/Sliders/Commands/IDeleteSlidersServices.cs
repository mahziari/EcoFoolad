using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Commands
{
    public interface IDeleteSlidersServices
    {
        ResultDeleteSlidersServices Execute(int id);
    }

    public class DeleteSlidersServices : IDeleteSlidersServices
    {
        private readonly IIdentityDataBaseContext _context;
        private readonly IHostingEnvironment _environment;

        public DeleteSlidersServices(IIdentityDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }

        public ResultDeleteSlidersServices Execute(int id)
        {
            
            var slider = _context.Sliders.Find(id);

            if (slider == null)
            {
                return new ResultDeleteSlidersServices
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            
            
            string file =slider.Url;
            string folder = _environment.WebRootPath;
            var filePath = Path.Combine(_environment.WebRootPath, file);
            var fileStream = new FileInfo(filePath);
            if (fileStream.Exists)
            {
                fileStream.Delete();
            }
            
            
            
            _context.Sliders.Remove(slider);
            _context.SaveChanges();

            return new ResultDeleteSlidersServices
            {
                IsSuccess = true,
                Message = "اسلایدر با موفقیت حذف شد"
            };
        }
    }



    public class ResultDeleteSlidersServices
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}