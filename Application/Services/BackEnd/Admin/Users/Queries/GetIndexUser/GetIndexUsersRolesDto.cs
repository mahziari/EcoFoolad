namespace Application.Services.BackEnd.Admin.Users.Queries.GetIndexUser
{
    public class GetIndexUsersRolesDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Claim { get; set; }
    }
}