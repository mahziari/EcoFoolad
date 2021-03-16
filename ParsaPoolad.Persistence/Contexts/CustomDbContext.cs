using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;


namespace ParsaPoolad.Persistence.Contexts
{
    public class CustomDbContext:IdentityDbContext<User,Role,string>,ICustomDbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Claims> Claims { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(p => new { p.ProviderKey, p.LoginProvider });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(p => new { p.UserId, p.LoginProvider });

            // modelBuilder.Entity<User>().Ignore(p => p.NormalizedEmail);
        }

    }
}