using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.IdentityDatabase
{
    public partial class CreateIdentityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHead = table.Column<bool>(type: "bit", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrmUsersId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Credit = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestToBeOwner = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.ProviderKey, x.LoginProvider });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider });
                });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "ClaimName", "ClaimType", "ClaimValue", "IsHead", "ParentId" },
                values: new object[,]
                {
                    { 1, "داشبورد", "Home", "Home", true, null },
                    { 27, "ویرایش درباره ما", "AboutUs", "AboutUs", true, null },
                    { 26, "ویرایش فوتر", "Footers", "Footers", true, null },
                    { 25, "فایل منیجر", "FileManagers", "FileManagers", true, null },
                    { 24, "ویرایش یوزر", "UsersEdit", "UsersEdit", null, 22 },
                    { 23, "نمایش همه یوزر ها", "UsersIndex", "UsersIndex", null, 22 },
                    { 22, "مدیریت یوزر ها", "Users", "Users", true, null },
                    { 21, "مدیریت اسلایدرها", "Sliders", "Sliders", true, null },
                    { 20, "غیر فعال کردن محصول", "ProductsActive", "ProductsActive", null, 15 },
                    { 19, "حذف محصول", "ProductsDelete", "ProductsDelete", null, 15 },
                    { 18, "ویرایش محصول", "ProductsEdit", "ProductsEdit", null, 15 },
                    { 17, "ساخت محصول", "ProductsCreate", "ProductsCreate", null, 15 },
                    { 16, "نمایش محصولات", "ProductsIndex", "ProductsIndex", null, 15 },
                    { 28, "ویرایش ارتباط با ما", "ContactUs", "ContactUs", true, null },
                    { 15, "مدیریت محصولات", "Products", "Products", true, null },
                    { 13, "مدیریت شرکت ها", "Company", "Company", true, null },
                    { 12, "غیرفعال کردن مجله", "BlogsActive", "BlogsActive", null, 7 },
                    { 11, "حذف مجله", "BlogsDelete", "BlogsDelete", null, 7 },
                    { 10, "ویرایش مجله", "BlogsEdit", "BlogsEdit", null, 7 },
                    { 9, "ساخت مجله", "BlogsCreate", "BlogsCreate", null, 7 },
                    { 8, "مشاهده مجله ها", "BlogsIndex", "BlogsIndex", null, 7 },
                    { 7, "مدیریت مجله", "Blogs", "Blogs", true, null },
                    { 6, "حذف دسته بندی مجله", "BlogCategoriesDelete", "BlogCategoriesDelete", null, 2 },
                    { 5, "ویرایش دسته بندی مجله", "BlogCategoriesEdit", "BlogCategoriesEdit", null, 2 },
                    { 4, "ساخت دسته بندی مجله", "BlogCategoriesCreate", "BlogCategoriesCreate", null, 2 },
                    { 3, "مشاهده دسته بندی مجله ها", "BlogCategoriesIndex", "BlogCategoriesIndex", null, 2 },
                    { 2, "مدیریت دسته بندی مجله", "BlogCategories", "BlogCategories", true, null },
                    { 14, "مدیریت منوها", "Menus", "Menus", true, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7990ad8a-92a8-4cda-918c-b71887047e9e", "2bb43ab4-61c4-4435-aa3e-c6ab7b2858de", "فروشنده", "Role", "Owner", "OWNER" },
                    { "2bb43ab4-61c4-4435-aa3e-c6ab7b2858d1", "7990ad8a-92a8-4cda-918c-b71887047e9e", "خریدار", "Role", "User", "USER" },
                    { "8ce221cd-1b57-4e0b-8781-79524b05fcc5", "e27bb24c-7f4a-45f7-b35b-bdf0068d9ff4", "برنامه نویس", "Role", "SeniorProgrammer", "SENIORPROGRAMMER" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 24, "UsersEdit", "UsersEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 23, "UsersIndex", "UsersIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 22, "Users", "Users", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 21, "Sliders", "Sliders", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 20, "ProductsActive", "ProductsActive", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 19, "ProductsDelete", "ProductsDelete", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 18, "ProductsEdit", "ProductsEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 17, "ProductsCreate", "ProductsCreate", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 16, "ProductsIndex", "ProductsIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 15, "Products", "Products", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 14, "Menus", "Menus", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 13, "Company", "Company", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 12, "BlogsActive", "BlogsActive", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 11, "BlogsDelete", "BlogsDelete", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 10, "BlogsEdit", "BlogsEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 9, "BlogsCreate", "BlogsCreate", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 8, "BlogsIndex", "BlogsIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 7, "Blogs", "Blogs", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 6, "BlogCategoriesDelete", "BlogCategoriesDelete", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 5, "BlogCategoriesEdit", "BlogCategoriesEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 4, "BlogCategoriesCreate", "BlogCategoriesCreate", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 3, "BlogCategoriesIndex", "BlogCategoriesIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 2, "BlogCategories", "BlogCategories", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 1, "Home", "Home", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 27, "Footers", "Footers", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 28, "AboutUs", "AboutUs", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 29, "ContactUs", "ContactUs", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 25, "Factory", "Factory", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 26, "FileManagers", "FileManagers", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Credit", "CrmUsersId", "DataCreated", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RequestToBeOwner", "SecurityStamp", "Tel", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5a64e206-d6c0-4386-923f-5104f173e01c", 0, "تهران", "5927a97d-ea14-4449-9efa-7d5ab4b957e5", 0, 1083, new DateTime(2021, 7, 28, 14, 18, 20, 260, DateTimeKind.Local).AddTicks(817), null, "User", null, false, "پنل", true, "خریدار", true, null, null, "09129283405", "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==", "09129283405", true, false, "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS", null, false, "09129283405" },
                    { "6a64e206-d6c0-4386-923f-5104f173e01c", 0, "تهران", "5927a97d-ea14-4449-9efa-7d5ab4b957e5", 0, 1082, new DateTime(2021, 7, 28, 14, 18, 20, 257, DateTimeKind.Local).AddTicks(4794), null, "User", null, false, "حسین", true, "کرجی", true, null, null, "09129283406", "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==", "09129283406", true, false, "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS", null, false, "09129283406" },
                    { "4a64e206-d6c0-4386-923f-5104f173e01c", 0, "تهران", "5927a97d-ea14-4449-9efa-7d5ab4b957e5", 0, 1084, new DateTime(2021, 7, 28, 14, 18, 20, 260, DateTimeKind.Local).AddTicks(871), null, "User", null, false, "پنل", true, "فروشنده", true, null, null, "09129283404", "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==", "09129283404", true, false, "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS", null, false, "09129283404" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2bb43ab4-61c4-4435-aa3e-c6ab7b2858d1", "5a64e206-d6c0-4386-923f-5104f173e01c" },
                    { "8ce221cd-1b57-4e0b-8781-79524b05fcc5", "6a64e206-d6c0-4386-923f-5104f173e01c" },
                    { "7990ad8a-92a8-4cda-918c-b71887047e9e", "4a64e206-d6c0-4386-923f-5104f173e01c" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "dbo");
        }
    }
}
