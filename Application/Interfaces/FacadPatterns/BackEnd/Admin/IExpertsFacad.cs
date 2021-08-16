using Application.Services.BackEnd.Admin.Experts;

namespace Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IExpertsFacad
    {
        IExpertsServices ExpertsServices { get; set; }
    }
}