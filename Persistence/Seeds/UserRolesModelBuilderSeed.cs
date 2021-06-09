using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeds
{
    public static class UserRolesModelBuilderSeed
    {
        public static void UserRoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "6a64e206-d6c0-4386-923f-5104f173e01c",
                    RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5"
                },
                new IdentityUserRole<string>
                {
                    UserId = "5a64e206-d6c0-4386-923f-5104f173e01c",
                    RoleId = "2bb43ab4-61c4-4435-aa3e-c6ab7b2858d1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "4a64e206-d6c0-4386-923f-5104f173e01c",
                    RoleId = "7990ad8a-92a8-4cda-918c-b71887047e9e"
                }
            );
        }
    }
}