using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using  Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using Domain.Entities.Users;
using Persistence.Seeds;

namespace Persistence.Contexts
{
    public class IdentityDatabaseContext:IdentityDbContext<User,Role,string>,IIdentityDataBaseContext
    {
        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> options)
            : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser<string>>().ToTable("User","identity");
            modelBuilder.Entity<IdentityRole<string>>().ToTable("Role","identity");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims","identity");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims","identity");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins","identity");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles","identity");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens","identity");
            
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
