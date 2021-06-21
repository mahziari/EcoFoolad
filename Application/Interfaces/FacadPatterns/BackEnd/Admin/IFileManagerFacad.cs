using Application.Services.BackEnd.Admin.FileManager;

namespace Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IFileManagerFacad
    {
        IImageUploadService ImageUploadService { get; }
    }
}