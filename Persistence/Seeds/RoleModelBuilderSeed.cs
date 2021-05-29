using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeds
{
    public static class RoleModelBuilderSeed
    {
        public static void RoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = "8ce221cd-1b57-4e0b-8781-79524b05fcc5",
                    Description = "برنامه نویس",
                    Name = "SeniorProgrammer",
                    NormalizedName = "SENIORPROGRAMMER",
                    Discriminator = "e27bb24c-7f4a-45f7-b35b-bdf0068d9ff4",
                    ConcurrencyStamp = "e27bb24c-7f4a-45f7-b35b-bdf0068d9ff4"
                }
            );
        }
    }
}