using System.Collections.Generic;
using Domain.Entities.Users;

namespace Application.Services.BackEnd.Admin.Users.Queries.GetIndexUser
{
    public class ResultGetIndexUsersDto
    {
        public List<Domain.Entities.Users.User> Users { get; set; }
        
        public string Id { get; set; }
        public string RoleName { get; set; }
    }
}