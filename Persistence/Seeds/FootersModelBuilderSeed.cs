using Domain.Entities.Footer;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeds
{
    public static class FootersModelBuilderSeed
    {
        public static void FootersSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Footer>().HasData(
                new Footer
                {
                    Id = 1,
                    OfficeAddress = "تهران, خ ابوسعید, زیر پل ابو سعید, پلاک 767",
                    FactoryAddress = "تهران, شهر سنگ, نبش خیابان رجایی"
                }
            );
        }
    }
}