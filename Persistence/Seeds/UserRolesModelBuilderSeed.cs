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
                    UserId = "5a64e206-d6c0-4386-923f-5104f173e01c",
                    RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5"
                }
            );
        }
    }
}