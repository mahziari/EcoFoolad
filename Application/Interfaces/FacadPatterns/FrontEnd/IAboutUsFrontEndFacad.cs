using Application.Services.BackEnd.Admin.AboutUs;
using Application.Services.FrontEnd.AboutUs;

namespace Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IAboutUsFrontEndFacad
    { 
        IAboutUsFrontEndServices AboutUsFrontEndServices { get; }
    }
}