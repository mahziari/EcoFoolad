using Domain.Entities.AboutUs;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeds
{
    public static class AboutUsModelBuilderSeed
    {
        public static void AboutUsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutUs>().HasData(
                new AboutUs
                {
                    Id = 1, ImageUrl = "#",
                }
            );
        }
    }
}