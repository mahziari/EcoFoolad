using  Application.Services.BackEnd.Admin.Users.Commands;
using Application.Services.BackEnd.Admin.Users.Commands.ActiveRequestToBeOwner;
using  Application.Services.BackEnd.Admin.Users.Queries;
using Application.Services.BackEnd.Admin.Users.Queries.GetIndexUser;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IUsersFacad
    {
        
        IGetIndexUsersServices GetIndexUsersServices { get; }
        IGetIndexUsersServices GetIndexUserOwnerServices { get; }
        // IGetCreateUsersServices GetCreateUsersServices { get; }
        // ICreateUsersServices CreateUsersServices { get; }
        // IGetDetailsUsersServices GetDetailsUsersServices { get; }
        IGetEditUsersServices GetEditUsersServices { get; }
        IEditUsersServices EditUsersServices { get; }
        // IDeleteUsersServices DeleteUsersServices { get; }
        // IActiveUsersServices ActiveUsersServices { get; }
        IActiveRequestToBeOwnerServices ActiveRequestToBeOwnerServices { get; }

    }
}