using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.CustomDb
{
    public partial class CreateSlidersClaimsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    table.ForeignKey(
                        name: "FK_Claims_Claims_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Claims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "ClaimName", "ClaimType", "ClaimValue", "IsHead", "ParentId" },
                values: new object[,]
                {
                    { 1, "داشبورد", "Home", "Home", true, null },
                    { 2, "مدیریت دسته بندی بلاگ", "BlogCategories", "BlogCategories", true, null },
                    { 7, "مدیریت بلاگ", "Blogs", "Blogs", true, null },
                    { 13, "مدیریت شرکت ها", "Company", "Company", true, null },
                    { 14, "مدیریت منوها", "Menus", "Menus", true, null },
                    { 15, "مدیریت محصولات", "Products", "Products", true, null },
                    { 21, "مدیریت اسلایدرها", "Sliders", "Sliders", true, null },
                    { 22, "مدیریت یوزر ها", "Users", "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "ClaimName", "ClaimType", "ClaimValue", "IsHead", "ParentId" },
                values: new object[,]
                {
                    { 3, "مشاهده دسته بندی بلاگ ها", "BlogCategoriesIndex", "BlogCategoriesIndex", null, 2 },
                    { 4, "ساخت دسته بندی بلاگ", "BlogCategoriesCreate", "BlogCategoriesCreate", null, 2 },
                    { 5, "ویرایش دسته بندی بلاگ", "BlogCategoriesEdit", "BlogCategoriesEdit", null, 2 },
                    { 6, "حذف دسته بندی بلاگ", "BlogCategoriesDelete", "BlogCategoriesDelete", null, 2 },
                    { 8, "BlogsIndex", "BlogsIndex", "BlogsIndex", null, 7 },
                    { 9, "ساخت بلاگ", "BlogsCreate", "BlogsCreate", null, 7 },
                    { 10, "ویرایش بلاگ", "BlogsEdit", "BlogsEdit", null, 7 },
                    { 11, "حذف بلاگ", "BlogsDelete", "BlogsDelete", null, 7 },
                    { 12, "غیرفعال کردن بلاگ", "BlogsActive", "BlogsActive", null, 7 },
                    { 16, "نمایش محصولات", "ProductsIndex", "ProductsIndex", null, 15 },
                    { 17, "ساخت محصول", "ProductsCreate", "ProductsCreate", null, 15 },
                    { 18, "ویرایش محصول", "ProductsEdit", "ProductsEdit", null, 15 },
                    { 19, "حذف محصول", "ProductsDelete", "ProductsDelete", null, 15 },
                    { 20, "غیر فعال کردن محصول", "ProductsActive", "ProductsActive", null, 15 },
                    { 23, "نمایش همه یوزر ها", "UsersIndex", "UsersIndex", null, 22 },
                    { 24, "ویرایش یوزر", "UsersEdit", "UsersEdit", null, 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Claims_ParentId",
                table: "Claims",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
