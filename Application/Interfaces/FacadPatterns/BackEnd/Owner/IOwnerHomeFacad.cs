using  Application.Services.BackEnd.Owner.Home.Queries;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Owner
{
    public interface IOwnerHomeFacad
    {
        IGetIndexHomeServices GetIndexHomeServices { get; }
    }
}