using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Microsoft.AspNetCore.Hosting;

namespace Application.Services.BackEnd.Admin.FileManagers.FacadPattern
{
    public class FileManagerFacad:IFileManagerFacad
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ICustomDbContext _customDbContext;

        public FileManagerFacad(IWebHostEnvironment environment, ICustomDbContext customDbContext)
        {
            _environment = environment;
            _customDbContext = customDbContext;
        }
        
        
        
        private IImageUploadService _imageUploadService;
        public IImageUploadService ImageUploadService
        {
            get
            {
                return _imageUploadService ??= new ImageUploadService(_environment,_customDbContext);
            }
        }
    }
}