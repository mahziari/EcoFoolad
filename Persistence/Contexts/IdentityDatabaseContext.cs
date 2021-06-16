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
            modelBuilder.Entity<IdentityUser<string>>().ToTable("User","dbo");
            modelBuilder.Entity<IdentityRole<string>>().ToTable("Role","dbo");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims","dbo");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims","dbo");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins","dbo");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles","dbo");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens","dbo");
            
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
