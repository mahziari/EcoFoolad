using Microsoft.EntityFrameworkCore;
using Domain.Entities.Users;

namespace Persistence.Seeds
{
    public static class ClaimsModelBuilderSeed
    {
        public static void ClaimsSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claims>().HasData(
                new Claims
                {
                    Id = 1, ClaimType = "Home", ClaimValue = "Home", ClaimName = "داشبورد", IsHead = true,
                    ParentId = null
                },
                new Claims
                {
                    Id = 2, ClaimType = "BlogCategories", ClaimValue = "BlogCategories",
                    ClaimName = "مدیریت دسته بندی بلاگ", IsHead = true, ParentId = null
                },
                new Claims
                {
                    Id = 3, ClaimType = "BlogCategoriesIndex", ClaimValue = "BlogCategoriesIndex",
                    ClaimName = "مشاهده دسته بندی بلاگ ها", IsHead = null, ParentId = 2
                },
                new Claims
                {
                    Id = 4, ClaimType = "BlogCategoriesCreate", ClaimValue = "BlogCategoriesCreate",
                    ClaimName = "ساخت دسته بندی بلاگ", IsHead = null, ParentId = 2
                },
                new Claims
                {
                    Id = 5, ClaimType = "BlogCategoriesEdit", ClaimValue = "BlogCategoriesEdit",
                    ClaimName = "ویرایش دسته بندی بلاگ", IsHead = null, ParentId = 2
                },
                new Claims
                {
                    Id = 6, ClaimType = "BlogCategoriesDelete", ClaimValue = "BlogCategoriesDelete",
                    ClaimName = "حذف دسته بندی بلاگ", IsHead = null, ParentId = 2
                },
                new Claims
                {
                    Id = 7, ClaimType = "Blogs", ClaimValue = "Blogs", ClaimName = "مدیریت بلاگ", IsHead = true,
                    ParentId = null
                },
                new Claims
                {
                    Id = 8, ClaimType = "BlogsIndex", ClaimValue = "BlogsIndex", ClaimName = "BlogsIndex",
                    IsHead = null, ParentId = 7
                },
                new Claims
                {
                    Id = 9, ClaimType = "BlogsCreate", ClaimValue = "BlogsCreate", ClaimName = "ساخت بلاگ",
                    IsHead = null, ParentId = 7
                },
                new Claims
                {
                    Id = 10, ClaimType = "BlogsEdit", ClaimValue = "BlogsEdit", ClaimName = "ویرایش بلاگ",
                    IsHead = null, ParentId = 7
                },
                new Claims
                {
                    Id = 11, ClaimType = "BlogsDelete", ClaimValue = "BlogsDelete", ClaimName = "حذف بلاگ",
                    IsHead = null, ParentId = 7
                },
                new Claims
                {
                    Id = 12, ClaimType = "BlogsActive", ClaimValue = "BlogsActive", ClaimName = "غیرفعال کردن بلاگ",
                    IsHead = null, ParentId = 7
                },
                new Claims
                {
                    Id = 13, ClaimType = "Company", ClaimValue = "Company", ClaimName = "مدیریت شرکت ها", IsHead = true,
                    ParentId = null
                },
                new Claims
                {
                    Id = 14, ClaimType = "Menus", ClaimValue = "Menus", ClaimName = "مدیریت منوها", IsHead = true,
                    ParentId = null
                },
                new Claims
                {
                    Id = 15, ClaimType = "Products", ClaimValue = "Products", ClaimName = "مدیریت محصولات",
                    IsHead = true, ParentId = null
                },
                new Claims
                {
                    Id = 16, ClaimType = "ProductsIndex", ClaimValue = "ProductsIndex", ClaimName = "نمایش محصولات",
                    IsHead = null, ParentId = 15
                },
                new Claims
                {
                    Id = 17, ClaimType = "ProductsCreate", ClaimValue = "ProductsCreate", ClaimName = "ساخت محصول",
                    IsHead = null, ParentId = 15
                },
                new Claims
                {
                    Id = 18, ClaimType = "ProductsEdit", ClaimValue = "ProductsEdit", ClaimName = "ویرایش محصول",
                    IsHead = null, ParentId = 15
                },
                new Claims
                {
                    Id = 19, ClaimType = "ProductsDelete", ClaimValue = "ProductsDelete", ClaimName = "حذف محصول",
                    IsHead = null, ParentId = 15
                },
                new Claims
                {
                    Id = 20, ClaimType = "ProductsActive", ClaimValue = "ProductsActive",
                    ClaimName = "غیر فعال کردن محصول", IsHead = null, ParentId = 15
                },
                new Claims
                {
                    Id = 21, ClaimType = "Sliders", ClaimValue = "Sliders", ClaimName = "مدیریت اسلایدرها",
                    IsHead = true, ParentId = null
                },
                new Claims
                {
                    Id = 22, ClaimType = "Users", ClaimValue = "Users", ClaimName = "مدیریت یوزر ها", IsHead = true,
                    ParentId = null
                },
                new Claims
                {
                    Id = 23, ClaimType = "UsersIndex", ClaimValue = "UsersIndex", ClaimName = "نمایش همه یوزر ها",
                    IsHead = null, ParentId = 22
                },
                new Claims
                {
                    Id = 24, ClaimType = "UsersEdit", ClaimValue = "UsersEdit", ClaimName = "ویرایش یوزر",
                    IsHead = null, ParentId = 22
                }
            );
        }
    }
}