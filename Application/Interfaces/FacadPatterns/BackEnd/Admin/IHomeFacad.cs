using Application.Services.BackEnd.Admin.Home;

namespace Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IHomeFacad
    {
        IAdminHomeServices AdminHomeServices { get; }
    }
}