using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using  Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities.Users;
using Persistence.Seeds;

namespace Persistence.Contexts
{
    public class IdentityDatabaseContext:IdentityDbContext<User,Role,string>
    {
        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> options)
            : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser<string>>().ToTable("User");
            modelBuilder.Entity<IdentityRole<string>>().ToTable("Role");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(p => new { p.ProviderKey, p.LoginProvider });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });
            modelBuilder.Entity<IdentityRoleClaim<string>>().HasKey(p => new { p.Id });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(p => new { p.UserId, p.LoginProvider });
           
            modelBuilder.UserSeed();
            modelBuilder.RoleSeed();
            modelBuilder.RoleClaimsSeed();
            modelBuilder.UserRoleSeed();

            // base.OnModelCreating(modelBuilder);
        }
    }
}
