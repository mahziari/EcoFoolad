using  Application.Services.BackEnd.Owner.Profile.Commands;
using  Application.Services.BackEnd.Owner.Profile.Queries;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Owner
{
    public interface IOwnerProfileFacad
    {
        IGetIndexOwnerProfileServices GetIndexOwnerProfileServices { get; }
        IChangePasswordOwnerProfileServices ChangePasswordOwnerProfileServices { get; }
        IGetIndexChangePasswordOwnerProfileServices GetIndexChangePasswordOwnerProfileServices { get; }
    }
}