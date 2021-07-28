using Application.Services.BackEnd.Admin.AboutUs;

namespace Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IAboutUsFacad
    {
        IAboutUsServices AboutUsServices { get; }
    }
}