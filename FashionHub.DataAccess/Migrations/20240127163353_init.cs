using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FashionHub.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Shirt" },
                    { 2, 2, "Bags" },
                    { 3, 3, "Trouser" },
                    { 4, 4, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Tech City", "Jiji", "6669990000", "12121", "IL", "123 Tech St" },
                    { 2, "Vid City", "Jumia", "7779990000", "66666", "IL", "999 Vid St" },
                    { 3, "Lala land", "AliExpress", "1113335555", "99999", "NY", "999 Main St" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Description", "ListPrice", "Name", "Price", "Price100", "Price50", "Size" },
                values: new object[,]
                {
                    { 1, 3, "Blue", "This remarkable high waist Jean is beautiful, trendy and affordable for Fashionable women. It is designed and tailored to slim fit and trim all waist. It is Stretchy and elastic. It does not fade. it is durable and long lasting. It gives you a perfect shape you desire. It is so rugged and does not wear out. It is comfortable and superb. Every woman deserve to be beautiful. Admire other people's beauty without questioning your own. ", 99.0, "Ladies High Waist Skinny Jean- Blue", 90.0, 80.0, 85.0, "27-34" },
                    { 2, 1, "Blue, Green, Black", "Men's 2 In 1 Short Sleeve Round Neck T-Shirt & Shorts Set - BlueQuality is our number one priority. This is a very stylish men's T-shirt suit that include a short sleeve and a pair of shorts. It has been carefully designed to stand the test of time. Make sure you can wear it for a long time. You can wear them in interesting places at any time of the day, such as walking, dating and going to work. I believe that I really have many advantages, such as materials, ventilation, style, you need to wear them to feel.   It has a range of details that will make you stand out. No matter how long you wear it, it will continue to maintain its solid form.", 99.0, "Men's 2 In 1 Short Sleeve Round Neck T-Shirt & Shorts Set - Blue", 90.0, 80.0, 85.0, "M, L, XL, XXL" },
                    { 3, 2, "Black, Green, Black, Peach, Brown e.t.c", "Available in a variety of colors, it is easy to match with a variety of clothes. A popular rectangular underarm bag for parties, leisure, commuting, travel and more.", 99.0, "Riapawel Fashion Handbag Bag Shoulder Bags Square Bag", 90.0, 80.0, 85.0, "small" },
                    { 4, 2, "Brown", "Made of high-quality PU, this elegant set includes a card bag, a wallet, a clutch bag, a shoulder bag and a coin purse. The printed design makes you outstanding from others. The wallet is without letter print. Perfect for office ladies who are in business, working, shopping, or dating.", 99.0, "New Ladies Women Handbag - Brown", 90.0, 80.0, 85.0, "small" },
                    { 5, 4, "Black", "Our shop specializes in quality men's and women's clothing. Believe me, you own one of our products, enough to show off like your friends. To avoid choosing the wrong size, please read the size label carefully. Please select the size according to the \"foot length\".If the feet are thick and wide, please buy large shoes; if the shoes are too large, we recommend wearing insoles.", 99.0, "Ladies Sexy Cross Strap High Heels Black", 90.0, 80.0, 85.0, "38-42" },
                    { 6, 3, "Black & Grey", "Joggers from Bubbling Fashion Store comes with its own uniqueness, its brings out the style in you whenever it is worn, joggers are versatile choice for casual clothing which brings out the brilliant gear for chilled days, it is for every one who is stylish and urban. The fabrics are made from high quality which are manufactured and carefully paid to durability and comfortability Men designed combat joggers with high quality material from outfit and sportswear.", 99.0, "Well-tailored Unisex Up & Down Joggers - Black & Grey", 90.0, 80.0, 85.0, "S, M, L, XL, XXL, XXXL" },
                    { 7, 3, "Multi", "Easy to wash and quickly dry when you wash. it made of cotton blended material. nice for both casual and cooperate. Our sweatpants and joggers are made for extreme Comfort, fitted with pristine precision and finely crafted with the highest quality fabric. With these , you do not only feel the difference in fitting and comfort but also have access to a wide range of style purposes. These joggers can be worn for different days in a plethora of ways. Flip Wears now has a history of creating functional yet stylish street-wear, covering everything from retro styles to forward-thinking pieces.", 99.0, "Crew Clothing Cargo Joggers", 90.0, 80.0, 85.0, "S, M, L, XL, XXL, XXXL, XXXXL" },
                    { 8, 1, "Black", "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable Nail the smart and demure look with this, Featuring high round neck, short shirt sleeves , Cotton fabric ,", 99.0, "Ladies Round Neck Polo Printed T-Shirt", 90.0, 80.0, 85.0, "M, L, XL, S" },
                    { 9, 1, "Yellow", "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable Nail the smart and demure look with this, Featuring high round neck, short shirt sleeves , Cotton fabric ,", 99.0, "Boss Lady Ladies Round Neck Polo Printed T-Shirt", 90.0, 80.0, 85.0, "M, L, XL, S" },
                    { 10, 1, "White", "The fabric is cool and relaxed fit create an extremely flattering silhouette and produces a versatile piece that would go with any style of pant for an effortless, laid-back cool look. And at a brilliant value, these top will ensure that you stand out from the crowd this season without breaking the bank! ", 99.0, "Top Long Sleeve Top For Ladies - Knitting Top", 90.0, 80.0, 85.0, "S, M, L" },
                    { 11, 2, "Grey", "Lightweight design is easy for carrying: Made From Durable Polyester Fabric with good features of comfortable and portable.", 99.0, "EILIFINTE B06 Casual Crossbody Shoulder Chest Bag-Grey", 90.0, 80.0, 85.0, "small" },
                    { 12, 2, "Gold", "This fashionable handbag is made of durable, high height leather, leather, decorated with leather, water, cocoa, and cocoa for a long time", 99.0, "Shiny Rhinestone Evening Banquet Bag Handbag Purse - Gold", 90.0, 80.0, 85.0, "small" },
                    { 13, 2, "multi", "Lightweight design is easy for carrying: Made From Durable Polyester Fabric with good features of comfortable and portable.", 99.0, "EILIFINTE B01 Ladies Causal Stylish Shoulder Bag - Plaid", 90.0, 80.0, 85.0, "small" },
                    { 14, 4, "beige", "Material: PU leatherColor: beigeSize: 37, 38, 39, 40Gender: women", 99.0, "Ladies Square Heels Sandals Elegant Summer Slippers", 90.0, 80.0, 85.0, "37-40" },
                    { 15, 4, "Black", "Another beautiful fashion sandals with unique mid heels. One of lasted sandals on Vogue from well know brand fang Kenneth. Is very beautiful, lovely, strong and the heels is very balance that any lady that love unique design can wear it. Is one beautiful sandals you can wear for long. Thank you for always trusting me for the best.", 99.0, "Fang Kenneth New Design Ladies Fashion Sandals-Black", 90.0, 80.0, 85.0, "38-41" },
                    { 16, 4, "Multiple", "Beautiful multiple colors sandals, lovely sandals that can go with any colours of your choice. Nice sandals with perfect fitting. One of trendy Sandals ", 99.0, "Elegant Ladies Multiple Colour Sandals", 90.0, 80.0, 85.0, "37-41" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "\\images\\products\\product-1\\3f8cfae8-6e8b-4f77-a981-e2af59d2bec6.jpg", 1 },
                    { 2, "\\images\\products\\product-2\\f67ce5a4-6e43-460b-a448-94843acc6717.jpg", 2 },
                    { 3, "\\images\\products\\product-3\\af12e749-60c4-4998-a03b-cf84562b6a28.jpg", 3 },
                    { 4, "\\images\\products\\product-4\\5dc8829e-951c-4723-98a9-9a477a271094.jpg", 4 },
                    { 5, "\\images\\products\\product-5\\906d4ff7-589d-43ec-883a-49f486a19351.jpg", 5 },
                    { 6, "\\images\\products\\product-6\\71758c64-0d21-4f1b-b379-316f07753f33.jpg", 6 },
                    { 7, "\\images\\products\\product-7\\7dad1cdd-0c8c-4b34-b257-5827e2b386cd.jpg", 7 },
                    { 8, "\\images\\products\\product-8\\84c8770c-0262-4ea4-9609-e100bf001a3e.jpg", 8 },
                    { 9, "\\images\\products\\product-9\\30f6e2a5-e9c0-4f76-b519-42b39dadf6a0.jpg", 9 },
                    { 10, "\\images\\products\\product-10\\4e22b28c-0fea-44d6-89a1-e5fb478e5646.jpg", 10 },
                    { 11, "\\images\\products\\product-11\\202f3d19-9e90-48fc-8ae5-160a355bbc7c.jpg", 11 },
                    { 12, "\\images\\products\\product-12\\6d98b3eb-715f-40a5-b7a4-3295091d531e.jpg", 12 },
                    { 13, "\\images\\products\\product-13\\f0deca55-6e82-4988-9955-ce5940928bec.jpg", 13 },
                    { 14, "\\images\\products\\product-14\\0a5b0367-dda0-4b5f-b158-935a1c3c5f4b.jpg", 14 },
                    { 15, "\\images\\products\\product-15\\92aeb63e-9661-4c5f-8ee9-9dcc22486684.jpg", 15 },
                    { 16, "\\images\\products\\product-16\\9afd6a4f-c248-473f-b3bc-4ff9237276d1.jpg", 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
