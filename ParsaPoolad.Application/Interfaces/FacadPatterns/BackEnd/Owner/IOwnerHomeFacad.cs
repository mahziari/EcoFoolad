using ParsaPoolad.Application.Services.BackEnd.Owner.Home.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Owner
{
    public interface IOwnerHomeFacad
    {
        IGetIndexHomeServices GetIndexHomeServices { get; }
    }
}