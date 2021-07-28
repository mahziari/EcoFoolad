using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateFirstTables : Migration
    {
          protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 213, DateTimeKind.Local).AddTicks(2902)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_ReciverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 219, DateTimeKind.Local).AddTicks(2161)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrdCrmId = table.Column<long>(type: "bigint", nullable: false),
                    PrdGroupId = table.Column<int>(type: "int", nullable: false),
                    PrdCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdLatinName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdColorId = table.Column<int>(type: "int", nullable: true),
                    PrdUnitId = table.Column<int>(type: "int", nullable: true),
                    PrdMinQty = table.Column<int>(type: "int", nullable: true),
                    PrdMaxQty = table.Column<int>(type: "int", nullable: true),
                    PrdSleepDay = table.Column<int>(type: "int", nullable: true),
                    PrdFirstSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdSecondSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdThirdSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdFirstBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdSecondBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdThirdBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Month1 = table.Column<short>(type: "smallint", nullable: false),
                    Fpid = table.Column<int>(type: "int", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDatePersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdBarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdBarCodeTypeId = table.Column<int>(type: "int", nullable: true),
                    PrdAutoNumBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdAutoNumBarCodeTypeId = table.Column<int>(type: "int", nullable: true),
                    PrdAutoCharBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdAutoCharBarCodeTypeId = table.Column<int>(type: "int", nullable: true),
                    PrdModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrdInactiveInSale = table.Column<bool>(type: "bit", nullable: true),
                    PrdInactiveInBuy = table.Column<bool>(type: "bit", nullable: true),
                    AppType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    FirstRegisterUserId = table.Column<int>(type: "int", nullable: true),
                    FirstRegisterDatePersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstRegisterDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrdCommissionDisable = table.Column<bool>(type: "bit", nullable: true),
                    PrdCommissionPercentRate = table.Column<double>(type: "float", nullable: true),
                    PrdShpisActive = table.Column<bool>(type: "bit", nullable: true),
                    PrdShptitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdShpcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdShpmodel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdShpdescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdShpdescriptionIi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdShpstockManageTypeId = table.Column<int>(type: "int", nullable: true),
                    PrdShpstockManualyCount = table.Column<double>(type: "float", nullable: true),
                    PrdShphiddenPriceInNoStock = table.Column<bool>(type: "bit", nullable: true),
                    PrdShpselfSupplier = table.Column<bool>(type: "bit", nullable: true),
                    PrdShpotherSupplierId = table.Column<int>(type: "int", nullable: true),
                    PrdLinkAccPrdId = table.Column<int>(type: "int", nullable: true),
                    PrdLinkAccPrdCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderView = table.Column<int>(type: "int", nullable: true),
                    PrdPrice = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 219, DateTimeKind.Local).AddTicks(6048)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
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

            migrationBuilder.CreateTable(
                name: "User",
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
                    RequestToBeOwner = table.Column<bool>(type: "bit", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 219, DateTimeKind.Local).AddTicks(8870)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciverNAme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 220, DateTimeKind.Local).AddTicks(52)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
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

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 219, DateTimeKind.Local).AddTicks(4276)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    BasketId = table.Column<long>(type: "bigint", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 12, 13, 2, 42, 218, DateTimeKind.Local).AddTicks(8427)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "ClaimName", "ClaimType", "ClaimValue", "IsHead", "ParentId" },
                values: new object[,]
                {
                    { 2, "مدیریت دسته بندی مجله", "BlogCategories", "BlogCategories", true, null },
                    { 4, "ساخت دسته بندی مجله", "BlogCategoriesCreate", "BlogCategoriesCreate", null, 2 },
                    { 5, "ویرایش دسته بندی مجله", "BlogCategoriesEdit", "BlogCategoriesEdit", null, 2 },
                    { 6, "حذف دسته بندی بلاگ", "BlogCategoriesDelete", "BlogCategoriesDelete", null, 2 },
                    { 7, "مدیریت بلاگ", "Blogs", "Blogs", true, null },
                    { 8, "مشاهده بلاگ ها", "BlogsIndex", "BlogsIndex", null, 7 },
                    { 9, "ساخت بلاگ", "BlogsCreate", "BlogsCreate", null, 7 },
                    { 10, "ویرایش بلاگ", "BlogsEdit", "BlogsEdit", null, 7 },
                    { 11, "حذف بلاگ", "BlogsDelete", "BlogsDelete", null, 7 },
                    { 12, "غیرفعال کردن بلاگ", "BlogsActive", "BlogsActive", null, 7 },
                    { 13, "مدیریت شرکت ها", "Company", "Company", true, null },
                    { 14, "مدیریت منوها", "Menus", "Menus", true, null },
                    { 3, "مشاهده دسته بندی بلاگ ها", "BlogCategoriesIndex", "BlogCategoriesIndex", null, 2 },
                    { 15, "مدیریت محصولات", "Products", "Products", true, null },
                    { 17, "ساخت محصول", "ProductsCreate", "ProductsCreate", null, 15 },
                    { 18, "ویرایش محصول", "ProductsEdit", "ProductsEdit", null, 15 },
                    { 19, "حذف محصول", "ProductsDelete", "ProductsDelete", null, 15 },
                    { 20, "غیر فعال کردن محصول", "ProductsActive", "ProductsActive", null, 15 },
                    { 21, "مدیریت اسلایدرها", "Sliders", "Sliders", true, null },
                    { 22, "مدیریت یوزر ها", "Users", "Users", true, null },
                    { 23, "نمایش همه یوزر ها", "UsersIndex", "UsersIndex", null, 22 },
                    { 24, "ویرایش یوزر", "UsersEdit", "UsersEdit", null, 22 },
                    { 16, "نمایش محصولات", "ProductsIndex", "ProductsIndex", null, 15 },
                    { 1, "داشبورد", "Home", "Home", true, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ce221cd-1b57-4e0b-8781-79524b05fcc5", "e27bb24c-7f4a-45f7-b35b-bdf0068d9ff4", "برنامه نویس", "Role", "SeniorProgrammer", "SENIORPROGRAMMER" },
                    { "2bb43ab4-61c4-4435-aa3e-c6ab7b2858d1", "7990ad8a-92a8-4cda-918c-b71887047e9e", "خریدار", "Role", "User", "USER" },
                    { "7990ad8a-92a8-4cda-918c-b71887047e9e", "2bb43ab4-61c4-4435-aa3e-c6ab7b2858de", "فروشنده", "Role", "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "Home", "Home", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 13, "Company", "Company", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 6, "BlogCategoriesDelete", "BlogCategoriesDelete", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 7, "Blogs", "Blogs", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 8, "BlogsIndex", "BlogsIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 9, "BlogsCreate", "BlogsCreate", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 10, "BlogsEdit", "BlogsEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 11, "BlogsDelete", "BlogsDelete", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 12, "BlogsActive", "BlogsActive", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 3, "BlogCategoriesIndex", "BlogCategoriesIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 14, "Menus", "Menus", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 15, "Products", "Products", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 16, "ProductsIndex", "ProductsIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 17, "ProductsCreate", "ProductsCreate", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 18, "ProductsEdit", "ProductsEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" }
                });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 19, "ProductsDelete", "ProductsDelete", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 20, "ProductsActive", "ProductsActive", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 21, "Sliders", "Sliders", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 22, "Users", "Users", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 23, "UsersIndex", "UsersIndex", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 24, "UsersEdit", "UsersEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 2, "BlogCategories", "BlogCategories", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 5, "BlogCategoriesEdit", "BlogCategoriesEdit", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" },
                    { 4, "BlogCategoriesCreate", "BlogCategoriesCreate", "8ce221cd-1b57-4e0b-8781-79524b05fcc5" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Credit", "CrmUsersId", "DataCreated", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RemoveTime", "RequestToBeOwner", "SecurityStamp", "Tel", "TwoFactorEnabled", "UpdateTime", "UserName" },
                values: new object[,]
                {
                    { "6a64e206-d6c0-4386-923f-5104f173e01c", 0, "تهران", "5927a97d-ea14-4449-9efa-7d5ab4b957e5", 0, 61, new DateTime(2021, 6, 12, 13, 2, 42, 240, DateTimeKind.Local).AddTicks(3519), null, "User", null, false, "حسین", true, "کرجی", true, null, null, "09129283406", "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==", "09129283406", true, null, false, "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS", null, false, null, "09129283406" },
                    { "5a64e206-d6c0-4386-923f-5104f173e01c", 0, "تهران", "5927a97d-ea14-4449-9efa-7d5ab4b957e5", 0, 61, new DateTime(2021, 6, 12, 13, 2, 42, 240, DateTimeKind.Local).AddTicks(4146), null, "User", null, false, "پنل", true, "خریدار", true, null, null, "09129283405", "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==", "09129283405", true, null, false, "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS", null, false, null, "09129283405" },
                    { "4a64e206-d6c0-4386-923f-5104f173e01c", 0, "تهران", "5927a97d-ea14-4449-9efa-7d5ab4b957e5", 0, 61, new DateTime(2021, 6, 12, 13, 2, 42, 240, DateTimeKind.Local).AddTicks(4165), null, "User", null, false, "پنل", true, "خریدار", true, null, null, "09129283404", "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==", "09129283404", true, null, false, "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS", null, false, null, "09129283404" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8ce221cd-1b57-4e0b-8781-79524b05fcc5", "6a64e206-d6c0-4386-923f-5104f173e01c" },
                    { "2bb43ab4-61c4-4435-aa3e-c6ab7b2858d1", "5a64e206-d6c0-4386-923f-5104f173e01c" },
                    { "7990ad8a-92a8-4cda-918c-b71887047e9e", "4a64e206-d6c0-4386-923f-5104f173e01c" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
