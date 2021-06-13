using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeds
{
    public static class RoleClaimsModelBuilderSeed
    {
        public static void RoleClaimsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(
                new IdentityRoleClaim<string>
                {
                    Id = 1, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Home", ClaimValue = "Home"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 2, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogCategories",
                    ClaimValue = "BlogCategories"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 3, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogCategoriesIndex",
                    ClaimValue = "BlogCategoriesIndex"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 4, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogCategoriesCreate",
                    ClaimValue = "BlogCategoriesCreate"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 5, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogCategoriesEdit",
                    ClaimValue = "BlogCategoriesEdit"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 6, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogCategoriesDelete",
                    ClaimValue = "BlogCategoriesDelete"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 7, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Blogs", ClaimValue = "Blogs"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 8, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogsIndex",
                    ClaimValue = "BlogsIndex"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 9, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogsCreate",
                    ClaimValue = "BlogsCreate"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 10, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogsEdit",
                    ClaimValue = "BlogsEdit"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 11, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogsDelete",
                    ClaimValue = "BlogsDelete"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 12, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "BlogsActive",
                    ClaimValue = "BlogsActive"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 13, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Company",
                    ClaimValue = "Company"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 14, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Menus", ClaimValue = "Menus"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 15, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Products",
                    ClaimValue = "Products"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 16, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "ProductsIndex",
                    ClaimValue = "ProductsIndex"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 17, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "ProductsCreate",
                    ClaimValue = "ProductsCreate"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 18, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "ProductsEdit",
                    ClaimValue = "ProductsEdit"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 19, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "ProductsDelete",
                    ClaimValue = "ProductsDelete"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 20, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "ProductsActive",
                    ClaimValue = "ProductsActive"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 21, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Sliders",
                    ClaimValue = "Sliders"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 22, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Users", ClaimValue = "Users"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 23, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "UsersIndex",
                    ClaimValue = "UsersIndex"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 24, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "UsersEdit",
                    ClaimValue = "UsersEdit"
                },
                new IdentityRoleClaim<string>
                {
                    Id = 25, RoleId = "8ce221cd-1b57-4e0b-8781-79524b05fcc5", ClaimType = "Factory",
                    ClaimValue = "Factory"
                }
            );
        }
    }
}