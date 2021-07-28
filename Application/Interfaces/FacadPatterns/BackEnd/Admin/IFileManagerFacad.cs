using Application.Services.BackEnd.Admin.FileManagers;

namespace Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IFileManagerFacad
    {
        IImageUploadService ImageUploadService { get; }
    }
}