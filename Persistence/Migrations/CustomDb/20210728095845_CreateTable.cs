using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.CustomDb
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AboutUs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    Body = table.Column<string>(type: "ntext", nullable: true),
                    Member1 = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    Member2 = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    Member3 = table.Column<string>(type: "nvarchar(1500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 58, DateTimeKind.Local).AddTicks(3495)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    SmallDescription = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegisterUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalTime = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 69, DateTimeKind.Local).AddTicks(1243)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 69, DateTimeKind.Local).AddTicks(2674)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileManagers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 69, DateTimeKind.Local).AddTicks(3778)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Footers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telegram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoursOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailLogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "dbo",
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
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 69, DateTimeKind.Local).AddTicks(5258)),
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
                schema: "dbo",
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
                    VisitCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LocalTime = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 69, DateTimeKind.Local).AddTicks(9383)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                schema: "dbo",
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
                name: "UserAddresses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 70, DateTimeKind.Local).AddTicks(1463)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(1500)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallDescription = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Body = table.Column<string>(type: "ntext", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    RegisterUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    LocalTime = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    VisitCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RequestToAuthorFav = table.Column<bool>(type: "bit", nullable: false),
                    IsVideoClip = table.Column<bool>(type: "bit", nullable: false),
                    VideoClipDuration = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 68, DateTimeKind.Local).AddTicks(9660)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_BlogCategories_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalSchema: "dbo",
                        principalTable: "BlogCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 69, DateTimeKind.Local).AddTicks(7551)),
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
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsPay = table.Column<bool>(type: "bit", nullable: false),
                    DatePay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Authority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefIdf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    BasketId = table.Column<long>(type: "bigint", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 28, 14, 28, 45, 68, DateTimeKind.Local).AddTicks(6875)),
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
                        principalSchema: "dbo",
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Footers",
                columns: new[] { "Id", "Copyright", "Description", "Facebook", "FactoryAddress", "HoursOfWork", "Instagram", "Linkedin", "LogoImage", "OfficeAddress", "PhoneNumber1", "PhoneNumber2", "PhoneNumber3", "Photo1", "Photo10", "Photo11", "Photo12", "Photo13", "Photo14", "Photo15", "Photo2", "Photo3", "Photo4", "Photo5", "Photo6", "Photo7", "Photo8", "Photo9", "SiteName", "Telegram", "ThumbnailLogoImage", "Twitter", "WhatsApp", "Youtube" },
                values: new object[] { 1, null, null, null, "تهران, شهر سنگ, نبش خیابان رجایی", null, null, null, null, "تهران, خ ابوسعید, زیر پل ابو سعید, پلاک 767", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                schema: "dbo",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                schema: "dbo",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_Name_Slug",
                schema: "dbo",
                table: "BlogCategories",
                columns: new[] { "Name", "Slug" },
                unique: true,
                filter: "[Name] IS NOT NULL AND [Slug] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogCategoryId_Title_Slug",
                schema: "dbo",
                table: "Blogs",
                columns: new[] { "BlogCategoryId", "Title", "Slug" },
                unique: true,
                filter: "[Title] IS NOT NULL AND [Slug] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                schema: "dbo",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                schema: "dbo",
                table: "Payments",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BasketItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Blogs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Factories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FileManagers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Footers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sliders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserAddresses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Baskets",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BlogCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "dbo");
        }
    }
}
