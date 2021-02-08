using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.DbTwoEntities;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Persistence.Contexts
{
    public class IdentityDataBaseContext:IdentityDbContext<User,Role,string>,IIdentityDataBaseContext
    {
        public IdentityDataBaseContext(DbContextOptions<IdentityDataBaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Claims> Claims { get; set; }








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(p=> new { p.ProviderKey , p.LoginProvider});
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p=> new { p.UserId , p.RoleId});
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(p=> new { p.UserId , p.LoginProvider});

            // modelBuilder.Entity<User>().Ignore(p => p.NormalizedEmail);
        }

    }
}