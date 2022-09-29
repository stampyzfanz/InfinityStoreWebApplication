using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfinityWebApplication.Migrations
{
    public partial class initial : Migration
    {
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "AttributesSet",
                columns: table => new
                {
                    AttributesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Franchise = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Brand = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Articulation = table.Column<bool>(type: "bit", nullable: true),
                    CollectiblesManufacturer = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    FigureType = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    ChanceOfAChase = table.Column<bool>(type: "bit", nullable: true),
                    Finish = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Height = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    PopVinylType = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributesSet", x => x.AttributesId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Suburb = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Postcode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributesId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "money", nullable: false),
                    SalePrice = table.Column<decimal>(type: "money", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_AttributesSet_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "AttributesSet",
                        principalColumn: "AttributesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStockSet",
                columns: table => new
                {
                    ProductStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStockSet", x => x.ProductStockId);
                    table.ForeignKey(
                        name: "FK_ProductStockSet_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStockSet_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.ProductOrderId);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AttributesSet",
                columns: new[] { "AttributesId", "Articulation", "Brand", "ChanceOfAChase", "CollectiblesManufacturer", "FigureType", "Finish", "Franchise", "Height", "PopVinylType" },
                values: new object[,]
                {
                    { 1, null, "Nintendo", null, null, null, null, "Animal Crossing", null, null },
                    { 2, null, "Universal", null, null, null, null, "The Office", null, null },
                    { 3, null, "2K Games", null, null, null, null, "Borderlands", null, null },
                    { 4, null, "Star Wars", null, null, null, null, "The Mandalorian", null, null },
                    { 5, null, "Hasbro", null, null, null, null, "Transformers", null, null },
                    { 6, null, "CD Projekt RED", null, null, null, null, "Cyberpunk", null, null },
                    { 7, null, "Marvel", null, null, null, null, "Deadpool", null, null },
                    { 8, null, "Funko", true, null, null, null, "DC Comics", null, null },
                    { 9, null, "Mattel", null, null, null, null, "Masters of The Universe", null, null },
                    { 10, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Obi-Wan Kenobi", null, null },
                    { 11, true, "Hasbro", null, "Hasbro", "Action Figure", null, "Star Wars", null, null },
                    { 12, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Book of Boba Fett", null, null },
                    { 13, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Obi-Wan Kenobi", null, null },
                    { 14, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Obi-Wan Kenobi", null, null },
                    { 15, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Clone Wars", null, null },
                    { 16, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Mandalorian", null, null },
                    { 17, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Obi-Wan Kenobi", null, null },
                    { 18, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Mandalorian", null, null },
                    { 19, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Clone Wars", null, null },
                    { 20, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Clone Wars", null, null },
                    { 21, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Clone Wars", null, null },
                    { 22, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Mandalorian", null, null },
                    { 23, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Star Wars", null, null },
                    { 24, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Star Wars", null, null },
                    { 25, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Rogue One", null, null },
                    { 26, true, "Star Wars", null, "Hasbro", "Action Figure", null, "A New Hope", null, null },
                    { 27, true, "Pokemon", null, "Jazwares", "Action Figure", null, "Pokemon", null, null },
                    { 28, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Star Wars", null, null },
                    { 29, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Star Wars", null, null },
                    { 30, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Mandalorian", null, null },
                    { 31, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Attack of the Clones", null, null },
                    { 32, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Obi-Wan Kenobi", null, null },
                    { 33, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Solo", null, null },
                    { 34, true, "Hasbro", null, "Hasbro", "Action Figure", null, "Transformers", null, null },
                    { 35, true, "Marvel", null, "Hasbro", "Action Figure", null, "Spider-Man", null, null },
                    { 36, true, "Marvel", null, "Hasbro", "Action Figure", null, "Thor", null, null },
                    { 37, true, "Pokemon", null, "Jazwares", "Action Figure", null, "Pokemon", null, null },
                    { 38, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Mandalorian", null, null },
                    { 39, true, "Star Wars", null, "Hasbro", "Action Figure", null, "The Mandalorian", null, null },
                    { 40, true, "Hasbro", null, "Takara Tomy", "Action Figure", null, "Transformers", null, null },
                    { 41, true, "Star Wars", null, "Hasbro", "Action Figure", null, "Star Wars", null, null },
                    { 42, null, "Pokemon", null, null, null, "Metallic", "Pokemon", "3.75\"", "Pop!" }
                });

            migrationBuilder.InsertData(
                table: "AttributesSet",
                columns: new[] { "AttributesId", "Articulation", "Brand", "ChanceOfAChase", "CollectiblesManufacturer", "FigureType", "Finish", "Franchise", "Height", "PopVinylType" },
                values: new object[,]
                {
                    { 43, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 44, null, "Pokemon", null, null, null, "Flocked", "Pokemon", "3.75\"", "Pop!" },
                    { 45, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 46, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 47, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 48, null, "Pokemon", null, null, null, "Standard", "Pokemon", "10\"", "Pop!" },
                    { 49, null, "Pokemon", null, null, null, "Metallic", "Pokemon", "3.75\"", "Pop!" },
                    { 50, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 51, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 52, null, "Pokemon", null, null, null, "Standard", "Pokemon", "1.5\"", "Pocket Pop!" },
                    { 53, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 54, null, "Pokemon", null, null, null, "Standard", "Pokemon", "10\"", "Pop!" },
                    { 55, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 56, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 57, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 58, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 59, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 60, null, "Pokemon", null, null, null, "Metallic", "Pokemon", "3.75\"", "Pop!" },
                    { 61, null, "Pokemon", null, null, null, "Metallic", "Pokemon", "3.75\"", "Pop!" },
                    { 62, null, "Pokemon", null, null, null, "Standard", "Pokemon", "10\"", "Pop!" },
                    { 63, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 64, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 65, null, "Pokemon", null, null, null, "Diamond Glitter", "Pokemon", "3.75\"", "Pop!" },
                    { 66, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 67, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 68, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" },
                    { 69, null, "Pokemon", null, null, null, "Standard", "Pokemon", "3.75\"", "Pop!" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 1, "Cnr Hamersley Street & Napier Terrace", -17.955255026395999, 122.24088728428001, "6725", "WA", "Broome", "BROOME WA" },
                    { 2, "McWhirters Building, Brunswick St Mall", -27.45736412151, 153.03401792336999, "4006", "QLD", "Fortitude Valley", "MCWHIRTERS II QLD" },
                    { 3, "Kawana Shopping World, Point Cartwright Drive", -26.702487734609001, 153.13119649887, "4575", "QLD", "Kawana", "KAWANA SHOPPINGWORLD II QLD" },
                    { 4, "Victoria Gardens Shopping Centre, Victoria St", -37.813165927463999, 145.01069068909001, "3121", "VIC", "Richmond", "VICTORIA GARDENS VIC" },
                    { 5, "Clifford Gardens SC, Cnr Anzac Parade & James St", -27.56471462939, 151.93239927292001, "4350", "QLD", "Toowoomba", "CLIFFORD GARDENS QLD" },
                    { 6, "Erina Fair Shopping Centre, Terrigal Drive", -33.436652234599002, 151.39281392097001, "2250", "NSW", "Erina", "ERINA FAIR II" },
                    { 7, "Neeta City II Shopping Centre, Smart Street", -33.86952473086, 150.95653116702999, "2165", "NSW", "Farifield", "NEETA CITY II NSW" },
                    { 8, "Highpoint Shopping Centre, Rosamond Road", -37.773615116415002, 144.88870382309, "3032", "VIC", "Maribyrnong", "HIGHPOINT F/C II VIC" },
                    { 9, "Lismore Shopping Centre, Cnr Brewster & McKenzie Streets", -28.810685984129002, 153.28634619713, "2408", "QLD", "Lismore", "LISMORE SQUARE SC NSW" },
                    { 10, "Westpoint Shopping Centre", -33.770184, 150.908501, "2148", "NSW", "Blacktown", "BLACKTOWN FOOD COURT II NSW" },
                    { 11, "Westfield Penrith, 569-589 High Street", -33.750766612942002, 150.69483876228, "2750", "NSW", "Penrith", "PENRITH PLAZA II NSW" },
                    { 12, "Westfield Shopping Centre, Gold Coast Hwy", -27.927222914283, 153.33599925041, "4210", "QLD", "Helensvale", "HELENSVALE WESTFIELD QLD" },
                    { 13, "Macarthur Square Shopping Centre, 200 Gilchrist Drive", -34.073475114791002, 150.79772830009, "2560", "NSW", "Campbelltown", "MACARTHUR SQUARE II NSW" },
                    { 14, "Waverley Gardens S/C, Cnr Police & Jackson Roads", -37.934936497941003, 145.18904149532, "3170", "VIC", "Mulgrave", "WAVERLEY GARDENS II VIC" },
                    { 15, "Domestic Terminal", -33.934138493254999, 151.17981433867999, "2020", "NSW", "Mascot", "SYDNEY DOMESTIC TERMINAL II NSW" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 16, "Westfield Shopping Centre, George Street", -33.918140997755003, 150.92463970183999, "2170", "NSW", "Liverpool", "LIVERPOOL F/C II NSW" },
                    { 17, "Colonnades Shopping Centre", -35.142230765344998, 138.49530458449999, "5168", "SA", "Noarlunga Beach", "COLONNADES II SA" },
                    { 18, "Rouse Hill Town Centre, Main St (Cnr Civic Way)", -33.691343624909997, 150.92516541481001, "2155", "NSW", "Rouse Hill", "ROUSE HILL TOWN CENTRE NSW" },
                    { 19, "1 Main Street", -27.677399975568999, 152.90245771407999, "4030", "QLD", "Springfield Lakes", "SPRINGFIELD ORION F/C QLD" },
                    { 20, "Cnr Pine Street & The Terrace", -27.609392926356001, 152.75902926922001, "4305", "QLD", "Ipswich", "RIVERLINK F/C QLD" },
                    { 21, "7-11 Martyn Street", -16.922883903035, 145.76692342758, "4870", "QLD", "Cairns", "CAIRNS CITY QLD" },
                    { 22, "Bankstown Centro Shopping Centre", -33.916867834841, 151.03881597519, "2200", "NSW", "Bankstown", "BANKSTOWN CENTRO F/C II NSW" },
                    { 23, "Westfield Doncaster Shopping Centre, Doncaster Road", -37.786470392414998, 145.12551069259999, "3108", "VIC", "Doncaster", "DONCASTER F/C II VIC" },
                    { 24, "Westfield Shopping Centre, Northcott Drive", -32.940781626693997, 151.71052397696999, "2289", "NSW", "Kotara", "KOTARA F/C II NSW" },
                    { 25, "Elizabeth Shopping Centre, Elizabeth Way", -34.718546073536999, 138.66851091385001, "5112", "SA", "Elizabeth", "ELIZABETH FOODCOURT SA" },
                    { 26, "225H Forest Road", -33.966440353164003, 151.10170841217001, "2220", "NSW", "Hurstville", "HURSTVILLE CENTRAL NSW" },
                    { 27, "Freshwater Place", -37.821719766576997, 144.96266841888001, "3006", "VIC", "Southbank", "FRESHWATER PLACE VIC" },
                    { 28, "Campbelltown Mall, 271 Queen Street", -34.069209291908997, 150.81105351447999, "2560", "NSW", "Campbelltown", "CAMPBELLTOWN MALL II NSW" },
                    { 29, "Westfield Shopping Centre, Northlakes Drive", -27.240945442705002, 153.01724750433999, "4509", "QLD", "Mango Hill", "NORTH LAKES WESTFIELD QLD" },
                    { 30, "Forest Hill Shopping Centre, 270 Canterbury Road", -37.835022120684002, 145.1656794548, "3131", "VIC", "Forest Hill", "FOREST HILL VIC" },
                    { 31, "Food Atrium, 19-33 Robina Town Centre Drive", -28.077944134987, 153.38564157485999, "4230", "QLD", "Robina", "ROBINA FC II QLD" },
                    { 32, "Lower Ground Floor, Westfield Central Plaza", -33.870504632439001, 151.20747327805, "2000", "NSW", "Sydney", "Sydney Central Westfield Plaza, NSW" },
                    { 33, "Plenty Valley Shopping Centre, 415 McDonalds Rd", -37.651886078384997, 145.07171373694999, "3082", "VIC", "Mill Park", "PLENTY VALLEY S/C VIC" },
                    { 34, "Narellan Town Centre, 326 Camden Valley Way", -34.042436351086003, 150.73654174805, "2567", "NSW", "Narellan", "NARELLAN TOWN CENTRE II NSW" },
                    { 35, "Highfields Village Shopping Centre, Highfields Rd (cnr Lauder Drv)", -27.450494876463999, 151.94475889206001, "4352", "QLD", "Highfields", "HIGHFIELDS QLD" },
                    { 36, "Northland Shopping Centre, 2-50 Murray Road", -37.739227295123001, 145.03087162970999, "3072", "VIC", "Preston", "NORTHLAND SHOPPING CENTRE II VIC" },
                    { 37, "Crown Casino, 8 Whiteman Street", -37.823390088842999, 144.95823630370001, "3006", "VIC", "Southbank", "CROWN CASINO II VIC" },
                    { 38, "Carnes Hill Market Place 1-3 Main Street", -33.937289565504997, 150.84533214569001, "2171", "NSW", "Carnes Hill", "CARNES HILL NSW" },
                    { 39, "21-29 Stuart Highway", -12.449892570614001, 130.84074139595, "0820", "NT", "Stuart Park", "STUART PARK NT" },
                    { 40, "36 Richmond Road", -20.000582003472001, 148.23739886284, "4805", "QLD", "Bowen", "BOWEN QLD" },
                    { 41, "Werribee Plaza Shopping Centre, Heaths Rd (cnr Derrimut Rd)", -37.875230256190001, 144.68096137046999, "3030", "VIC", "Werribee", "WERRIBEE PLAZA VIC" },
                    { 42, "94 Princes Freeway", -38.031168999999998, 145.34714640000001, "3809", "VIC", "Officer", "PAKENHAM BYPASS INBOUND" },
                    { 43, "125-145 Brisbane Road", -27.833003999999999, 153.02674099999999, "4280", "QLD", "Jimboomba", "JIMBOOMBA" },
                    { 44, "447 Southport - Nerang Road", -27.984383000000001, 153.36631800000001, "4214", "QLD", "Molendinar", "ASHMORE" },
                    { 45, "2 Little Boundary Road", -37.823348000000003, 144.82381000000001, "3025", "VIC", "Brooklyn", "BROOKLYN" },
                    { 46, "Stockland Mall, McFarlane Street", -33.834525964868, 150.98900735378001, "2160", "NSW", "Merrylands", "MERRYLANDS FC II" },
                    { 47, "100 Waverley Road", -37.876049700000003, 145.04780360000001, "3145", "VIC", "Malvern East", "MALVERN EAST" },
                    { 48, "350 Redbank Plains Road", -27.644986384062999, 152.87267315211, "4300", "QLD", "Bellbird Park", "BELLBIRD PARK" },
                    { 49, "Cnr Majura Road & Mustang Avenue", -35.295370300000002, 149.1897846, "2609", "ACT", "Majura", "MAJURA PARK" },
                    { 50, "7 Treelands Drive", -29.426544, 153.327157, "2464", "NSW", "Yamba", "YAMBA" },
                    { 51, "51-57 Maroondah Highway", -37.8169325, 145.22035779999999, "3134", "VIC", "Ringwood", "RINGWOOD" },
                    { 52, "Bellbowrie Shopping Plaza, Moggill Rd", -27.563902980195, 152.88677934722, "4070", "QLD", "Bellbowrie", "BELLBOWRIE QLD" },
                    { 53, "2 Lyn Parade", -33.9276172, 150.88814360000001, "2170", "NSW", "Cartwright", "CARTWRIGHT" },
                    { 54, "4 Oasis Court", -27.246081, 153.08207300000001, "4019", "QLD", "Clontarf", "CLONTARF" },
                    { 55, "Charlestown Square Shopping Centre, 30 Pearson Street", -32.965747968724997, 151.69359517724999, "2290", "NSW", "Charlestown", "CHARLESTOWN SQUARE NSW" },
                    { 56, "20 Settlers Avenue", -32.332541361178002, 115.81459879875, "6171", "WA", "Baldivis", "BALDIVIS" },
                    { 57, "Rockhampton Fair Shopping Centre, Yaamba Rd", -23.354086032529999, 150.52305936812999, "4701", "QLD", "Rockhampton North", "ROCKHAMPTON NORTH" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 58, "Cnr Shute Harbour & Paluma Roads", -20.289438400000002, 148.67731269999999, "4802", "QLD", "Cannonvale", "CANNONVALE" },
                    { 59, "Stockland Rockhampton Shopping Centre, Yaamba Rd", -23.354164999999998, 150.522289, "4700", "QLD", "Rockhampton North", "ROCKHAMPTON STOCKLAND FC" },
                    { 60, "Cnr Goodwin Drive and Coolgarra Ave", -27.068069123036999, 153.16083884061001, "4507", "QLD", "Bribie Island", "BRIBIE ISLAND" },
                    { 61, "19 Government Road", -27.598672000000001, 152.95926, "4077", "QLD", "Richlands", "RICHLANDS" },
                    { 62, "1 Pridham Boulevard", -35.277454264847997, 138.46042513846999, "5173", "SA", "Aldinga Beach", "ALDINGA" },
                    { 63, "261 Warrigal Road (cnr Underwood Road)", -27.589907955592999, 153.08530060678001, "4077", "QLD", "Eight Mile Plains", "EIGHT MILE PLAINS" },
                    { 64, "1 Jondique Avenue Cnr Gooding Drive", -28.045546999999999, 153.36722499999999, "4226", "QLD", "Merrimac", "MERRIMAC" },
                    { 65, "Cnr Pitcairn Way & Archipelago Street", -27.943548, 153.3207803, "4211", "QLD", "Pacific Pines", "PACIFIC PINES" },
                    { 66, "Cnr Jedfire Street & Mt Lindsay Highway", -27.696337767591, 153.03766081971, "4125", "QLD", "Park Ridge", "PARK RIDGE" },
                    { 67, "Cnr Allambie Lane & Riverway Drive", -19.365776100000001, 146.7317194, "4815", "QLD", "Rasmussen", "TOWNSVILLE RASMUSSEN" },
                    { 68, "3-7 Tarro Street", -32.825879999999998, 151.48826199999999, "2327", "NSW", "Kurri Kurri", "KURRI KURRI" },
                    { 69, "67-71 Argyle Street", -34.167127805027, 150.61227795400001, "2571", "NSW", "Picton", "PICTON" },
                    { 70, "Cnr Soldiers Road & Bass Highway", -38.472203700000001, 145.47479860000001, "3991", "VIC", "Bass", "BASS" },
                    { 71, "Melbourne Central Shopping Centre, 300 Lonsdale St", -37.811072342496999, 144.96329069138, "3000", "VIC", "Melbourne", "MELBOURNE CENTRAL UPPER" },
                    { 72, "302-322 Logan River Road", -27.710044100000001, 153.16136460000001, "4133", "QLD", "Waterford", "HOLMVIEW" },
                    { 73, "Cnr Bruce Highway & Cairns Road", -17.085570300000001, 145.77755310000001, "4865", "QLD", "Gordonvale", "GORDONVALE" },
                    { 74, "392 Chapel Steet", -37.8457656, 144.99449150000001, "3141", "VIC", "South Yarra", "CHAPEL STREET" },
                    { 75, "Cnr Heatherton & Stud Roads", -37.970969799999999, 145.22341729999999, "3175", "VIC", "Dandenong North   ", "DANDENONG NORTH" },
                    { 76, "4465 South Gippsland Highway", -38.242111000000001, 145.53465299999999, "3894", "VIC   ", "Caldermeade", "CALDERMEADE" },
                    { 77, "208 Beaufort Cnr Parry Streets", -31.9465562, 115.86453520000001, "6003", "WA", "Northbridge", "NORTHBRIDGE WA" },
                    { 78, "235 Byrnes Streets (cnr Rankin Street)", -16.997049471911001, 145.42328793006001, "4880", "QLD", "Mareeba", "MAREEBA" },
                    { 79, "5-7 Tuaggra Street", -37.048985999999999, 143.743045, "3465", "VIC", "Maryborough", "MARYBOROUGH" },
                    { 80, "150-152 Churchill Street", -25.236041, 152.274902, "4660", "QLD", "Childers", "CHILDERS" },
                    { 81, "Cnr Sayers & Forsyth Roads", -37.862843599999998, 144.7317597, "3027", "VIC", "Williams Landing", "WYNDHAM WATERS" },
                    { 82, "Caneland Central Shopping Centre, Mangrove Road", -21.137904271097, 149.17801472321, "4740", "QLD", "Mackay", "MACKAY FOOD COURT II" },
                    { 83, "25a Robertsons Road", -37.484729999999999, 144.586186, "3437", "VIC", "Gisborne", "GISBORNE" },
                    { 84, "590 Mt Gravatt-Capalaba Road", -27.548309303637001, 153.10830262335, "4122", "QLD", "Wishart", "WISHART" },
                    { 85, "20 Mt Derrimut Road", -37.784001000000004, 144.77174099999999, "3030", "VIC   ", "Derrimut", "DERRIMUT VIC" },
                    { 86, "117 Dempster Street", -33.864581999999999, 121.890173, "6450", "WA", "Esperance", "ESPERANCE" },
                    { 87, "Euroa Service Centre, Hume Highway", -36.743505999999996, 145.591643, "3666", "VIC   ", "Euroa", "EUROA VIC" },
                    { 88, "95 Forest Lakes Drive", -32.069765704681998, 115.95247436442, "6108", "WA", "Forest Lakes", "FOREST LAKES WA" },
                    { 89, "141 Parramatta Road", -33.884691463468002, 151.13626260061, "2045", "NSW  ", "Haberfield", "HABERFIELD NSW" },
                    { 90, "414 Warrigal Road", -37.950865499999999, 145.07719059999999, "3202", "VIC", "Heatherton", "HEATHERTON VIC" },
                    { 91, "84 Hardwick Crescent (cnr Starke Street)", -35.220202, 149.01799399999999, "2615", "ACT ", "Holt", "KIPPAX" },
                    { 92, "Cnr Morrison & Farrall Roads", -31.885896200000001, 116.0334818, "6056", "WA", "Midvale", "MIDVALE WA" },
                    { 93, "(Cnr Argyle & Melville Streets)", -42.878736699999997, 147.32647489999999, "7000", "TAS", "Hobart", "NORTH HOBART TAS" },
                    { 94, "170 Pascoe Road", -27.764602, 153.24428700000001, "4208", "QLD", "Ormeau", "ORMEAU QLD" },
                    { 95, "Stockland Shellharbour Shopping Centre", -34.562235899999997, 150.83851809999999, "2529", "NSW", "Shellharbour", "SHELLHARBOUR F/C" },
                    { 96, "74 Hoskins Street", -34.441183000000002, 147.53082499999999, "2666", "NSW", "Temora", "TEMORA NSW" },
                    { 97, "Cnr Connolly & Lukin Drive", -31.654356199999999, 115.7135184, "6036", "WA", "Butler", "BUTLER" },
                    { 98, "113 Chinchilla Street", -26.738278000000001, 150.62941699999999, "4413", "QLD", "Chinchilla", "CHINCHILLA" },
                    { 99, "Premises 2, Lot 15, Crown Entertainment Complex", -31.9607025, 115.8950269, "6100", "WA", "Burswood", "CROWN PERTH" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 100, "39 Glenlyon Street", -23.842870999999999, 151.25264999999999, "4680", "QLD", "Gladstone", "GLADSTONE CITY" },
                    { 101, "122 Brookman Street (cnr Lane Street)", -30.749299000000001, 121.46774000000001, "6430", "WA", "Kalgoorlie", "KALGOORLIE CBD" },
                    { 102, "661  Northbourne Avenue", -35.230972299999998, 149.15068600000001, "2911", "ACT", "Lyneham", "MITCHELL ACT" },
                    { 103, "Cnr Moranbah Access & Cunningham Roads", -22.0009139, 148.04576539999999, "4744", "QLD", "Moranbah", "MORANBAH" },
                    { 104, "Cnr Lavis Lane & Nelson Bay Road", -32.818233900000003, 151.84592090000001, "2318", "NSW", "Williamtown", "WILLIAMTOWN" },
                    { 105, "2 Parsons Road (cnr Pacific Highway)", -33.385867500000003, 151.36615689999999, "2250", "NSW", "Lisarow", "LISAROW NSW" },
                    { 106, "2 Simeoni Drive", -28.822325500000002, 153.3274318, "2480", "NSW", "Goonellabah", "GOONELLABAH NSW" },
                    { 107, "1 Lasso Road", -34.0313515, 150.77206200000001, "2557", "NSW", "Gregory Hills", "GREGORY HILLS NSW" },
                    { 108, "7 Fitzgerald Road", -37.843683212523999, 144.78161832275001, "3026", "VIC", "Laverton North", "LAVERTON NORTH VIC" },
                    { 109, "2 Peachtree Road", -33.745653500000003, 150.6910225, "2750", "NSW", "Penrith", "PENRITH NORTH NSW" },
                    { 110, "Norwest Marketown, 4 Century Circuit", -33.733001999999999, 150.96250499999999, "2153", "NSW", "Baulkham Hills", "NORWEST MARKETOWN" },
                    { 111, "Cnr Grand Entrance & Constellation Drive", -33.282719, 115.74377800000001, "6233", "WA", "Treendale", "TREENDALE" },
                    { 112, "Newpark Shopping Centre, Cnr Marangaroo & Templeton Crescent", -31.835507199999999, 115.8297348, "6064", "WA", "Girrawheen", "GIRRAWHEEN" },
                    { 113, "Davis St (Cnr Anzac Ave)", -27.565835, 151.92782199999999, "4350", "QLD", "Harristown", "HARRISTOWN" },
                    { 114, "50-52 Bauer Street", -24.818460000000002, 152.45726400000001, "4670", "QLD", "Bargara", "BARGARA" },
                    { 115, "13-47 Rosewood Drive", -21.063796824501001, 149.15785789489999, "4740", "QLD", "Rural View", "MACKAY NORTHERN BEACHES" },
                    { 116, "2412 Plenty Road", -37.516211800000001, 145.11491000000001, "3757", "VIC", "Whittlesea", "WHITTLESEA" },
                    { 117, "Cnr Burnett & George Streets", -42.782727899999998, 147.06327400000001, "7140", "TAS", "New Norfolk", "NEW NORFOLK" },
                    { 118, "582-586 Napier Street", -36.722250000000003, 144.312602, "3550", "VIC", "White Hills", "EPSOM" },
                    { 119, "1501 Eastlink Southbound", -37.898567, 145.23036200000001, "3179", "VIC   ", "Scoresby", "EASTLINK SOUTHBOUND" },
                    { 120, "285 Victoria Cross Parade", -36.137629800585998, 146.90895983069001, "3690", "VIC", "Wodonga", "WODONGA HOMEMAKER CENTRE" },
                    { 121, "108 Canterbury Road", -37.819533999999997, 145.31462500000001, "3137", "VIC", "Kilsyth", "KILSYTH" },
                    { 122, "12-22 McLennan Street", -36.392753999999996, 145.363022, "3629", "VIC", "Mooroopna", "MOOROOPNA" },
                    { 123, "Cnr Kerr Street & Bangalow Road", -28.856966, 153.56093469999999, "2478", "NSW", "Ballina", "BALLINA CENTRAL NSW" },
                    { 124, "Cnr Pat O'Leary Drive & Great Western Highway", -33.419394400000002, 149.61870339999999, "2795", "NSW", "Kelso", "KELSO NSW" },
                    { 125, "Gracemere Shoppingworld, 1 McLaughlin Street", -23.4367226, 150.4558825, "4702", "QLD", "Gracemere", "GRACEMERE" },
                    { 126, "150-154 Station Road", -27.1545746, 152.9717048, "4505", "QLD", "Burpengary", "BURPENGARY" },
                    { 127, "17-19 Doon Street", -23.584828999999999, 148.883869, "4717", "QLD", "Blackwater", "BLACKWATER" },
                    { 128, "18/30 Kelly Street (New England Highway)", -32.040554999999998, 150.86551900000001, "2337", "NSW", "Scone", "SCONE NSW" },
                    { 129, "Cnr Nexis Drive & North Shore Boulevard", -19.256594379292, 146.70185489867001, "4810", "QLD", "Burdell", "TOWNSVILLE NORTHSHORE" },
                    { 130, "641-659 Bellarine Highway", -38.186589593543999, 144.45517442097, "3224", "VIC", "Leopold", "LEOPOLD" },
                    { 131, "1-3 Rolland Street", -36.955457449107001, 140.74650148710001, "5271", "SA", "Naracoorte", "NARACOORTE" },
                    { 132, "Devonport Homemaker Centre, 3/3 Friend Street", -41.219175999999997, 146.42075500000001, "7310", "TAS", "Devonport", "DEVONPORT HOMEMAKER CENTRE" },
                    { 133, "Chadstone Shopping Centre, 1341 Dandenong Rd", -37.887709200000003, 145.08004209999999, "3148", "VIC", "Chadstone", "CHADSTONE SHOPPING CENTRE" },
                    { 134, "Wintergarden Shopping Centre, Queen Street", -27.4675099, 153.02799970000001, "4000", "QLD", "Brisbane", "WINTERGARDEN II" },
                    { 135, "1464 Ferntree Gully Road", -37.901386000000002, 145.24213399999999, "3180", "VIC", "Knoxfield", "KNOXFIELD VIC" },
                    { 136, "83-87 Broadwater Avenue", -27.8782362, 153.3654971, "4212", "QLD", "Hope Island", "HOPE ISLAND QLD" },
                    { 137, "1 Baynes Place", -34.849282000000002, 138.50806600000001, "5015", "SA", "Port Adelaide", "PORT ADELAIDE" },
                    { 138, "236-238 New Cleveland Road", -27.480157800000001, 153.1399547, "4173", "QLD", "Tingalpa", "TINGALPA, QLD" },
                    { 139, "430-438 Ocean Beach Road", -33.520721000000002, 151.31711300000001, "2257", "NSW", "Umina", "UMINA NSW" },
                    { 140, "1A George Street", -32.900195235981997, 151.75260786871999, "2304", "NSW", "Mayfield East", "MAYFIELD INDUSTRIAL DRIVE" },
                    { 141, "Curtis Road", -34.670630000000003, 138.677254, "5115", "SA", "Munno Para", "CURTIS RD, MUNNO PARA WEST" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 142, "Cnr Centenary Drive & Wyndham Avenue", -23.948248, 151.35310580000001, "4680", "QLD", "Boyne Island", "BOYNE ISLAND" },
                    { 143, "61 Sallys Corner Road", -34.607470992350997, 150.22832751274001, "2577", "NSW", "Exeter", "SUTTON FOREST SOUTHBOUND" },
                    { 144, "235 Great Eastern Hwy (cnr Daly St)", -31.942542, 115.925299, "6107", "WA", "Belmont", "ASCOT WATERS" },
                    { 145, "13 First Street", -14.464072016333001, 132.26450085639999, "0850", "NT", "Katherine", "KATHERINE" },
                    { 146, "330 Hume Highway ", -33.930982853486, 150.91783761977999, "2170", "NSW", "Liverpool South", "LIVERPOOL SOUTH NSW" },
                    { 147, "Greensborough Plaza Shopping Centre, The Circuit", -37.702107168826998, 145.10305523872, "3088", "VIC", "Greensborough", "GREENSBOROUGH VIC" },
                    { 148, "22-24 Cobra Street", -32.252775910639002, 148.60200226307001, "2830", "NSW", "Dubbo", "DUBBO NSW" },
                    { 149, "23 Maitland Road", -32.847617656855, 151.69422984123, "2322", "NSW", "Hexham", "HEXHAM NSW" },
                    { 150, "970 Nepean Highway", -38.230772491536001, 145.04447042941999, "3931", "VIC", "Mornington", "MORNINGTON VIC" },
                    { 151, "Traralgon Centre Plaza, 24-26 Argyle Street", -38.194026586222002, 146.5397644043, "3844", "VIC", "Traralgon", "TRARALGON VIC" },
                    { 152, "4 Brechin Drive", -38.022204438637999, 145.30216097962, "3805", "VIC", "Narre Warren", "FOUNTAIN GATE VIC" },
                    { 153, "Cowlishaw Street", -35.416911692913999, 149.06567573546999, "2900", "ACT", "Tuggeranong", "TUGGERANONG ACT" },
                    { 154, "152 Bunnerong Road", -33.945108883677001, 151.22294962405999, "2036", "NSW", "Eastgardens", "EASTGARDENS NSW" },
                    { 155, "Westfield Shoppingtown, 476-478 Cross Street", -33.965617273013997, 151.10545277596, "2220", "NSW", "Hurstville", "HURSTVILLE W/F NSW" },
                    { 156, "Westfield Shoppingtown, 1015 Sandgate Rd", -27.409118938187, 153.06066513062001, "4012", "QLD", "Toombul", "TOOMBUL II QLD" },
                    { 157, "11 Manning River Drive", -31.896961000000001, 152.49615800000001, "2430", "NSW", "Taree", "TAREE NSW" },
                    { 158, "Westfield Shopping Centre, Benjamin Way", -35.238425101853998, 149.06709194183, "2617", "NSW", "Belconnen", "BELCONNEN FOOD COURT ACT" },
                    { 159, "312 Canterbury Road", -33.904671661991998, 151.12794980407, "2193", "NSW", "Hurlstone Park", "HURLSTONE PARK NSW" },
                    { 160, "494 Rocky Point Road", -33.991215784895999, 151.13325923681001, "2219", "NSW", "Sans Souci", "SANS SOUCI NSW" },
                    { 161, "Elizabeth & McLean Streets", -33.917840515216, 150.91219961643, "2170", "NSW", "Liverpool", "LIVERPOOL WEST NSW" },
                    { 162, "543 Forest Road", -33.952575951290001, 151.12195104361001, "2207", "NSW", "Bexley", "BEXLEY NSW" },
                    { 163, "Springvale Rd (Cnr High Street Rd)", -37.874814225107997, 145.16719087958001, "3150", "VIC", "Glen Waverley", "GLEN WAVERLEY VIC" },
                    { 164, "10 Barker Street", -33.919857066615997, 151.22745573520999, "2032", "NSW", "Kingsford", "KINGSFORD NSW" },
                    { 165, "140-146 Pacific Highway", -33.708927618810002, 151.10095471144001, "2077", "NSW", "Waitara", "WAITARA NSW" },
                    { 166, "Cnr Victoria Parade & Smith Street", -37.808596199038, 144.98276889324001, "3066", "VIC", "Collingwood", "COLLINGWOOD VIC" },
                    { 167, "Nepean Highway & Glenhuntly Road", -37.884392930228003, 144.99827206135001, "3185", "VIC", "Elsternwick", "ELSTERNWICK VIC" },
                    { 168, "1171 Canterbury Road", -33.930535535423999, 151.065774858, "2196", "NSW", "Punchbowl", "PUNCHBOWL NSW" },
                    { 169, "661-663 Warrigal Road", -37.923186164203003, 145.08205354213999, "3167", "VIC", "South Oakleigh", "SOUTH OAKLEIGH VIC" },
                    { 170, "27 Sherwood Road", -33.834325446926997, 150.96855819224999, "2160", "NSW", "Merrylands", "MERRYLANDS NSW" },
                    { 171, "484 Malvern Road", -37.848178054234999, 145.00255554914, "3181", "VIC", "Prahran", "PRAHRAN VIC" },
                    { 172, "385 Victoria Road", -33.824098408255999, 151.12506240606001, "2111", "NSW", "Gladesville", "GLADESVILLE NSW" },
                    { 173, "101 Maroondah Highway", -37.788661120569003, 145.26870980858999, "3136", "VIC", "Croydon", "CROYDON VIC" },
                    { 174, "37 President Avenue", -34.042590817513002, 151.12057641148999, "2229", "NSW", "Caringbah", "CARINGBAH NSW" },
                    { 175, "1364 Gympie Road", -27.363248055915001, 153.01689147949, "4034", "QLD", "Aspley", "ASPLEY QLD" },
                    { 176, "312 Queen Street", -34.071371113371001, 150.81077992915999, "2560", "NSW", "Campbelltown", "CAMPBELLTOWN NSW" },
                    { 177, "Cnr Pacific Highway & Glover Streets", -33.034570140607002, 151.66136071086001, "2280", "NSW", "Belmont", "BELMONT NSW" },
                    { 178, "32 The Esplanade (cnr Acland Street)", -37.866809668414, 144.97766196728, "3182", "VIC", "St Kilda", "ST KILDA VIC" },
                    { 179, "863 George Street", -33.883791210010003, 151.20247498155001, "2000", "NSW", "Railway Square", "BROADWAY NSW" },
                    { 180, "260 Racecourse Road", -37.788181010085999, 144.93212878704, "3031", "VIC", "Flemington", "FLEMINGTON VIC" },
                    { 181, "Cnr Badham Street & Dickson Place", -35.249820405973999, 149.13813829422, "2602", "NSW", "Dickson", "DICKSON ACT" },
                    { 182, "Cnr Burwood Highway & Scott Grove", -37.850912312892, 145.09773105382999, "3125", "VIC", "Burwood", "BURWOOD VIC" },
                    { 183, "1902 Logan Road", -27.555838136999, 153.0804759264, "4122", "QLD", "Mount Gravatt", "MOUNT GRAVATT QLD" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 184, "Nepean Highway (cnr Jamieson Street)", -37.960622440000002, 145.05482644, "3192", "VIC", "Cheltenham", "CHELTENHAM VIC" },
                    { 185, "Namatjira Drive & McNally Street", -35.339551126616001, 149.05337780714001, "2611", "NSW", "Weston", "WESTON ACT" },
                    { 186, "225 Windsor Road", -33.773983846047003, 151.00150376558, "2152", "NSW", "Northmead", "NORTHMEAD NSW" },
                    { 187, "396 Ballarat Road", -37.778300428097999, 144.84317868948, "3020", "VIC", "Sunshine", "SUNSHINE VIC" },
                    { 188, "67-69 High Street", -38.170448947072003, 144.34798389673, "3220", "VIC", "Belmont", "GEELONG(BELMONT) VIC" },
                    { 189, "740-742 Burwood Highway", -37.880076368825002, 145.26771605015, "3156", "VIC", "Ferntree Gully", "FERNTREE GULLY VIC" },
                    { 190, "120 Bell Street", -37.753021666178, 145.05156487226, "3084", "VIC", "Heidelberg", "HEIDELBERG VIC" },
                    { 191, "297 Lane Cove Road", -33.783499042589, 151.13051533698999, "2113", "NSW", "North Ryde", "NORTH RYDE NSW" },
                    { 192, "333 Ipswich Road", -27.504833749054999, 153.03395032883, "4103", "QLD", "Annerley", "ANNERLEY QLD" },
                    { 193, "22 Princes Highway", -34.434522639648002, 150.86219787598, "2525", "NSW", "Figtree", "FIGTREE NSW" },
                    { 194, "318 Whitehorse Road", -37.813430799873998, 145.08482694625999, "3103", "VIC", "Balwyn", "BALWYN VIC" },
                    { 195, "Cnr Princes Highway & Elonera Road", -37.961197646670001, 145.18865525723001, "3174", "VIC", "Noble Park", "NOBLE PARK VIC" },
                    { 196, "63 High Street", -36.760863314833998, 144.27646547556, "3550", "VIC", "Bendigo", "BENDIGO VIC" },
                    { 197, "425 Main North Road (cnr Warwick Street)", -34.861522748585003, 138.60155224799999, "5085", "SA", "Enfield", "ENFIELD SA" },
                    { 198, "Cnr Takalvan & Heidke Streets", -24.887546001703001, 152.32055783272, "4670", "QLD", "Bundaberg", "BUNDABERG QLD" },
                    { 199, "235 Old Cleveland Road", -27.496601949108001, 153.05615231395001, "4151", "QLD", "Coorparoo", "COORPAROO QLD" },
                    { 200, "Turner Drive", -34.878306909663003, 138.49309444427001, "5021", "SA", "West Lakes", "WESTLAKES SA" },
                    { 201, "465-467 Payneham Road", -34.890269611765, 138.65366220473999, "5070", "SA", "Felixstow", "FELIXSTOW SA" },
                    { 202, "Cnr South & Torrens Roads", -34.888886850261997, 138.57035279274001, "5008", "SA", "Croydon", "CROYDON SA" },
                    { 203, "277 Margaret Street", -27.560296684583001, 151.95073485373999, "4350", "QLD", "Toowoomba", "TOOWOOMBA QLD" },
                    { 204, "476 Anzac Highway", -34.975256461964001, 138.53811532258999, "5038", "SA", "Camden Park", "CAMDEN PARK SA" },
                    { 205, "Cnr Wellington & Springvale Roads", -37.918031842376998, 145.15823364258, "3170", "VIC", "Mulgrave", "MULGRAVE VIC" },
                    { 206, "Cnr Princes Highway & Mianga Avenue", -34.066360846830001, 151.01499259472001, "2233", "NSW", "Engadine", "ENGADINE NSW" },
                    { 207, "217-221 Glen Osmond Road", -34.948736797971002, 138.62976506352001, "5063", "SA", "Frewville", "FREWVILLE SA" },
                    { 208, "17 Victoria Street", -37.562622044923003, 143.86527210474, "3350", "VIC", "Bakery Hill", "BALLARAT BAKERY HILL VIC" },
                    { 209, "45-47 Darlinghurst Road", -33.873630777342001, 151.22356183827, "2011", "NSW", "Kings Cross", "KINGS CROSS NSW" },
                    { 210, "Anzac Avenue", -33.30752333137, 151.41871869564, "2259", "NSW", "Wyong", "WYONG NSW" },
                    { 211, "179 Sandgate Road", -27.432508485673001, 153.04322004318001, "4010", "QLD", "Albion", "ALBION QLD" },
                    { 212, "314 Mountain Highway", -37.848006497832003, 145.23044943810001, "3152", "VIC", "Wantirna", "WANTIRNA VIC" },
                    { 213, "107 Maitland Road", -32.899623635856003, 151.74013316630999, "2304", "NSW", "Mayfield", "MAYFIELD NSW" },
                    { 214, "Cnr Princes Highway & Formosa Street", -34.009044999533998, 151.10353767871999, "2224", "NSW", "Sylvania", "SYLVANIA NSW" },
                    { 215, "Cnr Church Street & Victoria Road", -33.808131533443998, 151.00500404835, "2151", "NSW", "Parramatta Nth", "PARRAMATTA NORTH NSW" },
                    { 216, "116 Parramatta Road", -33.844577994661002, 151.0409912467, "2144", "NSW", "Auburn", "AUBURN NSW" },
                    { 217, "37 Rickard Road", -33.914000922831001, 151.03848069905999, "2200", "NSW", "Bankstown", "BANKSTOWN NSW" },
                    { 218, "799 King Georges Road", -33.977317610095, 151.10411971807, "2221", "NSW", "Hurstville", "HURSTVILLE SOUTH NSW" },
                    { 219, "375-377 George Street", -33.869255255953, 151.20682552457001, "2000", "NSW", "Sydney", "The Strand Arcade NSW" },
                    { 220, "65 Pacific Highway", -33.426903927699001, 151.32466167211999, "2250", "NSW", "Gosford West", "GOSFORD WEST NSW" },
                    { 221, "Cnr Military Road & Winnie Street", -33.829782475542999, 151.22678786515999, "2090", "NSW", "Cremorne", "CREMORNE NSW" },
                    { 222, "Cnr High & Kendall Streets", -33.755400750527997, 150.70730030537001, "2750", "NSW", "Penrith", "PENRITH NSW" },
                    { 223, "3 Showground Road", -33.733434324488002, 151.00278317927999, "2154", "NSW", "Castle Hill", "CASTLE HILL NSW" },
                    { 224, "6 Mitchell Road", -33.762083904354, 151.27443730831001, "2100", "NSW", "Brookvale", "BROOKVALE NSW" },
                    { 225, "Cnr Townsend & Hume Streets", -36.084389989611999, 146.91259839630001, "2640", "VIC", "Albury", "ALBURY NSW" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 226, "79-89 Keilor Road", -37.742198901355003, 144.90395486355001, "3042", "VIC", "North Essendon", "NIDDRIE VIC" },
                    { 227, "406 Bourke Street", -37.814466971611999, 144.96178328990999, "3000", "VIC", "Melbourne", "BOURKE ST WEST VIC" },
                    { 228, "Cnr Princes & Midland Highways", -38.240489055566002, 146.41941905022, "3840", "VIC", "Morwell", "MORWELL VIC" },
                    { 229, "400 Melbourne Road", -38.102473260076998, 144.35366749763, "3220", "VIC", "Geelong North", "GEELONG NORTH VIC" },
                    { 230, "Macquarie Shopping Centre, Cnr Herring & Waterloo Roads", -33.776177696455001, 151.11979722977, "2113", "NSW", "North Ryde", "Macquarie Shopping Centre NSW" },
                    { 231, "1333 Dandenong Rd", -37.88628968151, 145.07792830467, "3145", "VIC", "Malvern East", "Chadstone" },
                    { 232, "Cnr Marius & Roderick Streets", -31.095526115041999, 150.9363797307, "2340", "NSW", "Tamworth", "TAMWORTH NSW" },
                    { 233, "Cnr Cheltenham & Perry Roads", -37.994881754139001, 145.17469167709001, "3175", "VIC", "Keysborough", "KEYSBOROUGH VIC" },
                    { 234, "109 Pacific Highway", -32.964584812868999, 151.69593304396, "2290", "NSW", "Charlestown", "CHARLESTOWN NSW" },
                    { 235, "356-406 Main Street", -37.757860963791003, 145.35629063844999, "3140", "VIC", "Lilydale", "LILYDALE VIC" },
                    { 236, "2 Robinson Road", -32.288021484624998, 115.74056982994, "6168", "WA", "Rockingham", "ROCKINGHAM WA" },
                    { 237, "Minto Mall, 9 Pembroke Rd", -34.030295965802999, 150.84839522838999, "2566", "NSW", "Minto", "MINTO NSW" },
                    { 238, "44 Hindley Street", -34.922940890915001, 138.59778910874999, "5000", "SA", "Adelaide", "HINDLEY STREET SA" },
                    { 239, "524 Hay Street", -31.947138972358999, 115.81224211099, "6014", "WA", "Jolimont", "Jolimont Rebuild" },
                    { 240, "600 George Street", -33.875499728607998, 151.20666056870999, "2000", "NSW", "Sydney", "Plaza NSW" },
                    { 241, "339 Goodwood Road", -34.965954839246002, 138.59113991261, "5034", "SA", "Kings Park", "CROSS ROADS SA" },
                    { 242, "624-628 Wyndham Street", -36.399437355591999, 145.3949868679, "3630", "VIC", "Shepparton", "SHEPPARTON VIC" },
                    { 243, "Edward St (Cnr Fox Street)", -35.118873037706997, 147.36346542835, "2650", "NSW", "Wagga Wagga", "WAGGA WAGGA NSW" },
                    { 244, "Cnr Lloyd Street & Great Eastern Highway", -31.892281632233999, 116.01307690144, "6056", "WA", "Midland", "MIDLAND WA" },
                    { 245, "Cnr Leach Highway & North Lake Road", -32.045573831337997, 115.81920683384, "6156", "WA", "Melville", "MELVILLE WA" },
                    { 246, "224 Sunnyholt Road", -33.744240930095003, 150.91610491276001, "2148", "NSW", "Kings Park", "KINGS PARK NSW" },
                    { 247, "203 Old Cleveland Road", -27.521873521248001, 153.19846361876, "4157", "QLD", "Capalaba", "CAPALABA QLD" },
                    { 248, "168 Marine Parade", -27.956396538233001, 153.40890705584999, "4215", "QLD", "Southport", "LABRADOR QLD" },
                    { 249, "100-110 Bathurst Road", -33.292447156385002, 149.11155492066999, "2800", "NSW", "Orange", "ORANGE NSW" },
                    { 250, "Cnr Brisbane Road & Hamilton Street", -27.612573011140999, 152.79668748379001, "4304", "QLD", "Booval", "BOOVAL QLD" },
                    { 251, "395 Deakin Avenue", -34.202680868285, 142.14034080504999, "3500", "VIC", "Mildura", "MILDURA VIC" },
                    { 252, "94 Silvyn Street (cnr Anzac Ave)", -27.229542540409, 153.10827434063, "4020", "QLD", "Redcliffe", "REDCLIFFE QLD" },
                    { 253, "Noarlunga Fast Food Village, Cnr Beach & Dyson Roads", -35.139296062074997, 138.48671346903001, "5168", "SA", "Noarlunga", "NOARLUNGA SA" },
                    { 254, "Cnr Albany Highway & Olga Road", -32.051130123474998, 115.98306834698001, "6109", "WA", "Maddington", "MADDINGTON WA" },
                    { 255, "Cnr Princes Highway & Brown's Road", -34.904343528437998, 150.60282494907, "2540", "NSW", "South Nowra", "SOUTH NOWRA NSW" },
                    { 256, "Windsor Road (cnr Groves Avenue)", -33.625201866038999, 150.8375108242, "2756", "NSW", "Windsor", "WINDSOR NSW" },
                    { 257, "761 Pacific Highway", -33.755300398902001, 151.15280717611, "2072", "NSW", "Gordon", "GORDON NSW" },
                    { 258, "1 Cavill Avenue", -28.00199415897, 153.43078894477, "4217", "QLD", "Surfers Paradise", "CAVILL III QLD" },
                    { 259, "1035 Albany Highway (cnr Alday Street)", -31.99392328958, 115.91205954551999, "6102", "WA", "East Victoria Park", "EAST VICTORIA PARK WA" },
                    { 260, "34-48 Morris Road", -37.880065783517999, 144.70172166824, "3030", "VIC", "Hoppers Crossing", "HOPPERS CROSSING VIC" },
                    { 261, "Cnr Mulgoa Road & Panther Place", -33.759258623953997, 150.6842815876, "2750", "NSW", "Penrith", "PENRITH LEAGUES NSW" },
                    { 262, "5 Leichhardt St (cnr Wembley Rd)", -27.641926204116999, 153.10671329498001, "4114", "QLD", "Woodridge", "LOGAN CENTRAL QLD" },
                    { 263, "2 River Road", -33.938922914411002, 151.01829171181001, "2212", "NSW", "Revesby", "REVESBY NSW" },
                    { 264, "Cnr Hume Highway & Cutler Road", -33.897380727181996, 150.95335006714001, "2166", "NSW", "Lansvale", "LANSVALE NSW" },
                    { 265, "173 Mickleham Road", -37.688294822233999, 144.88167643547001, "3043", "VIC", "Tullamarine", "TULLAMARINE VIC" },
                    { 266, "Cnr Forest Way & Russell Streets", -33.749796489875997, 151.22421026230001, "2086", "NSW", "Frenchs Forest", "FORESTWAY NSW" },
                    { 267, "69 Jull Street", -32.149893442368999, 116.01906090975, "6112", "WA", "Armadale", "ARMADALE WA" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 268, "1965 Gold Coast Highway", -28.0779605, 153.44610950000001, "4220", "QLD", "Burleigh Heads", "BURLEIGH HEADS QLD" },
                    { 269, "77 Bowman Road", -26.803412186384001, 153.12145471573001, "4551", "QLD", "Caloundra", "CALOUNDRA QLD" },
                    { 270, "Cnr Park Terrace & Church Street", -34.764225186901001, 138.64555120468, "5108", "SA", "Salisbury", "SALISBURY SA" },
                    { 271, "Elizabeth Shopping Centre, Elizabeth Way", -34.716709564873, 138.6659091711, "5112", "SA", "Elizabeth", "ELIZABETH SA" },
                    { 272, "22-24 Waniassa Street", -35.349534267865003, 149.24155354499999, "2620", "NSW", "Queanbeyan", "QUEANBEYAN NSW" },
                    { 273, "2 Terrigal Drive", -33.435192856279997, 151.39605402946, "2250", "NSW", "Erina", "ERINA NSW" },
                    { 274, "Cnr Harbord & Campbelltown Roads", -34.049077042245003, 150.82588076591, "2560", "NSW", "Woodbine", "WOODBINE NSW" },
                    { 275, "Molly Morgan Drive", -32.761145442935998, 151.59330904484, "2320", "NSW", "Maitland", "MAITLAND EAST NSW" },
                    { 276, "Pittwater Road (cnr Warriewood Rd)", -33.692689329270003, 151.30320668221, "2100", "NSW", "Warriewood", "WARRIEWOOD NSW" },
                    { 277, "223 Cranbourne Road", -38.151575858514001, 145.15132427216, "3199", "VIC", "Karingal", "KARINGAL VIC" },
                    { 278, "11-15 Elizabeth Street", -37.817793641469002, 144.96465057135001, "3000", "VIC", "Melbourne", "ELIZABETH STREET VIC" },
                    { 279, "Bay Street (cnr Park Street)", -31.427825448591001, 152.89685726165999, "2444", "NSW", "Port Macquarie", "PORT MACQUARIE NSW" },
                    { 280, "371-373 South Road", -35.105510845043, 138.52619022131, "5162", "SA", "Morphett Vale", "REYNELLA SA" },
                    { 281, "218-226 Pennant Hills Road", -33.729603173091, 151.08257755637001, "2120", "NSW", "Thornleigh", "THORNLEIGH NSW" },
                    { 282, "251 Princes Highway", -34.567222860058997, 150.80303639173999, "2527", "NSW", "Albion Park", "ALBION PARK RAIL NSW" },
                    { 283, "144-146 Bellarine Highway", -38.173729991217002, 144.40133303403999, "3219", "VIC", "Newcomb", "NEWCOMB VIC" },
                    { 284, "Marina Mirage, Seaworld Drive", -27.967950545312998, 153.42659890652001, "4215", "QLD", "Main Beach", "MARINA MIRAGE QLD" },
                    { 285, "Cnr Ballarat & Robinsons Roads", -37.761694853892003, 144.75531756877999, "3023", "VIC", "Deer Park", "DEER PARK VIC" },
                    { 286, "Bruce Highway", -16.962458687257001, 145.74603170156001, "4870", "QLD", "Cairns", "Cairns Woree" },
                    { 287, "147-149 Hugh Street", -19.270766686883999, 146.78249090910001, "4812", "QLD", "Townsville", "TOWNSVILLE LAKES QLD" },
                    { 288, "349-353 Whitehorse Road", -37.817891108517003, 145.1766268909, "3131", "VIC", "Nunawading", "NUNAWADING II VIC" },
                    { 289, "199 Queens Parade", -37.787235617854002, 144.99368950725, "3068", "VIC", "Clifton Hill", "CLIFTON HILL VIC" },
                    { 290, "Cnr King & Steel Streets", -32.928415859921003, 151.76401019095999, "2300", "NSW", "Newcastle", "KING STREET" },
                    { 291, "631 Main Road (cnr Impala St)", -32.925675969406001, 151.63394182920001, "2285", "NSW", "Edgeworth", "EDGEWORTH NSW" },
                    { 292, "Cnr Great Western Highway & Colyton Road", -33.781229581391997, 150.81933081150001, "2760", "NSW", "Minchinbury", "MINCHINBURY NSW" },
                    { 293, "Cnr Coburns & Barries Roads", -37.687335418030997, 144.56733226776001, "3337", "VIC", "West Melton", "MELTON VIC" },
                    { 294, "825-827 Ruthven Street", -27.589221719348998, 151.94800972939001, "4350", "QLD", "Toowoomba", "TOOWOOMBA SOUTH QLD" },
                    { 295, "1-9 Hinkler Drive", -28.008013959391, 153.34210664034001, "4211", "QLD", "Nerang", "NERANG QLD" },
                    { 296, "66-70 Alfred Street", -19.300779888777999, 146.76192104815999, "4814", "QLD", "Aitkenvale", "AITKENVALE QLD" },
                    { 297, "285 Walter Road", -31.894415447381999, 115.89976966381001, "6062", "WA", "Morley", "MORLEY WA" },
                    { 298, "69-71 Durham Street", -33.414888836545003, 149.58324283361, "2795", "NSW", "Bathurst", "BATHURST NSW" },
                    { 299, "Homemaker Centre, 19-33 Murray Road", -37.741441693962003, 145.02775490284, "3072", "VIC", "Preston", "NORTHLAND VIC" },
                    { 300, "Homemaker City, 12A Goggs Road", -27.535825946119001, 152.94830739497999, "4074", "QLD", "Jindalee", "JINDALEE QLD" },
                    { 301, "184-190 Main Road", -42.84163913527, 147.29073464870001, "7009", "TAS", "Moonah", "MOONAH TAS" },
                    { 302, "Cnr Fulham & Stud Roads", -37.918036074317001, 145.23566365241999, "3178", "VIC", "Rowville", "ROWVILLE VIC" },
                    { 303, "Howitt St (cnr Forest Street)", -37.540719444445003, 143.83148968219999, "3355", "VIC", "Wendouree", "WENDOUREE VIC" },
                    { 304, "122 George Street (cnr Fitzroy St)", -23.380269274955999, 150.50483107567001, "4700", "QLD", "Rockhampton", "ROCKHAMPTON QLD" },
                    { 305, "1179 The Horsley Drive", -33.849538966270003, 150.90198576450001, "2164", "NSW", "Wetherill Park", "WETHERILL PARK NSW" },
                    { 306, "Cnr Agonis Drive & Sunshine Avenue", -37.702544333851002, 144.80228841305001, "3038", "VIC", "Taylors Lakes", "TAYLORS LAKES VIC" },
                    { 307, "131 Marsh Street", -30.516524939515001, 151.66895538567999, "2350", "NSW", "Armidale", "ARMIDALE NSW" },
                    { 308, "83-89 Maitland Road", -32.276075673831997, 150.89525878429001, "2333", "NSW", "Muswellbrook", "MUSWELLBROOK NSW" },
                    { 309, "Cnr Blackshaws & Millers Roads", -37.831514040343002, 144.84763920307, "3018", "VIC", "Altona", "ALTONA VIC" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 310, "126 Morayfield Road", -27.098927256393999, 152.94827520846999, "4510", "QLD", "Caboolture", "CABOOLTURE QLD" },
                    { 311, "1 Kay Court", -21.129956038117001, 149.16273951529999, "4870", "QLD", "Mackay", "MACKAY NORTH QLD" },
                    { 312, "239 Sth Gippsland Highway", -38.098243389503999, 145.28257280587999, "3977", "VIC", "Cranbourne", "CRANBOURNE VIC" },
                    { 313, "501-503 Elizabeth Street", -37.807336374881999, 144.9595503509, "3000", "VIC", "Melbourne", "VICTORIA MARKETS VIC" },
                    { 314, "Ross Avenue", -42.865313568384998, 147.37114191054999, "7018", "TAS", "Rosny Park", "ROSNY PARK TAS" },
                    { 315, "Cnr Allandale Road & Ferguson Street", -32.830244750652, 151.35610789060999, "2325", "NSW", "Cessnock", "CESSNOCK NSW" },
                    { 316, "211 Wanneroo Road (cnr Morley Drive)", -31.88938257042, 115.83730101585, "6060", "WA", "Tuart Hill", "TUART HILL WA" },
                    { 317, "Cnr Main South Road & Brookside Avenue", -35.024038603363998, 138.56265753508001, "5047", "SA", "Darlington", "DARLINGTON SA" },
                    { 318, "Cnr Parramatta & Bridge Roads", -33.888203281273, 151.17204397917001, "2048", "NSW", "Stanmore", "STANMORE NSW" },
                    { 319, "Cnr Alfred Street & Loftus St", -33.861796476534003, 151.2104344368, "2000", "NSW", "Circular Quay", "SYDNEY GATEWAY NSW" },
                    { 320, "164 Campbell Parade", -33.890086121849997, 151.2751003086, "2026", "NSW", "Bondi", "BONDI BEACH NSW" },
                    { 321, "Cnr Eddystone Avenue & Ocean Reef Road", -31.770054850000999, 115.76732754707, "6025", "WA", "Beldon", "BELDON WA" },
                    { 322, "Cnr Layton Avenue & Great Western Highway", -33.745918118142001, 150.61368584632999, "2774", "NSW", "Blaxland", "BLAXLAND NSW" },
                    { 323, "Camden Valley Way (Cnr Narellan Rd)", -34.039293620514997, 150.74173986912001, "2567", "NSW", "Narellan", "NARELLAN NSW" },
                    { 324, "2 Emu Bank", -35.239989258016003, 149.07432854176, "2617", "NSW", "Belconnen", "BELCONNEN ACT" },
                    { 325, "166-170 High Street", -36.797739040981, 144.24312829971001, "3555", "VIC", "Kangaroo Flat", "KANGAROO FLAT VIC" },
                    { 326, "Cnr Hay & William Streets", -31.953195359618, 115.85730684299, "6000", "WA", "Perth", "WILLIAM STREET WA" },
                    { 327, "400 Plenty Road Cnr University Drive", -37.658689789897998, 145.07701635360999, "3082", "VIC", "Mill Park", "MILL PARK VIC" },
                    { 328, "441 Great Western Highway Cnr Berith Street ", -33.814026142026002, 150.95902293921, "2145", "NSW", "Wentworthville", "WENTWORTHVILLE NSW" },
                    { 329, "18 Manchester Road", -37.788068665902003, 145.31103104352999, "3138", "VIC", "Mooroolbark", "MOOROOLBARK VIC" },
                    { 330, "2/161 Dawson Parade", -27.403473182281001, 152.96206980944001, "4054", "QLD", "Keperra", "ARANA HILLS QLD" },
                    { 331, "Cnr Great Western Highway & Main Street", -33.480994880354999, 150.13740867376001, "2790", "NSW", "Lithgow", "LITHGOW NSW" },
                    { 332, "Cnr Bogan & Grenfell Streets", -33.141252483104999, 148.17224800586999, "2870", "NSW", "Parkes", "PARKES NSW" },
                    { 333, "Niecon Plaza", -28.029079988904002, 153.43181342939999, "4218", "QLD", "Broadbeach", "BROADBEACH/NEICON PLAZA QLD" },
                    { 334, "Kenmore Tavern Plaza, 841 Moggill Road", -27.506851159839002, 152.94916570186999, "4069", "QLD", "Kenmore", "KENMORE QLD" },
                    { 335, "Cnr Bolton & Bridge Streets", -37.718658219783997, 145.13806879520001, "3095", "VIC", "Eltham", "ELTHAM VIC" },
                    { 336, "Cnr Hobart & Opossum Roads", -41.468614122532998, 147.16147899628001, "7249", "TAS", "Kings Meadows", "KINGS MEADOWS TAS" },
                    { 337, "618 Liverpool Road", -33.887506360639001, 151.07216656208001, "2136", "NSW", "Enfield", "ENFIELD NSW" },
                    { 338, "Cnr Adelaide Street & William Bailey Street", -32.759514658032998, 151.75001174211999, "2324", "NSW", "Raymond Terrace", "RAYMOND TERRACE NSW" },
                    { 339, "232 Main Street", -37.826387799999999, 147.62798340000001, "3875", "VIC", "Bairnsdale", "BAIRNSDALE VIC" },
                    { 340, "Cnr Frankston, Dandenong & Ballarto Roads", -38.112409537566997, 145.15886127949, "3199", "VIC", "North Frankston", "FRANKSTON NORTH VIC" },
                    { 341, "45 Penola Road (cnr Jubilee Highway)", -37.823620249695999, 140.78251272439999, "5290", "VIC", "Mount Gambier", "MOUNT GAMBIER SA" },
                    { 342, "BP Service Centre, Southbound Carriageway, Hume Highway", -36.439746679928, 146.24961376190001, "3675", "VIC", "Glenrowan", "GLENROWAN SOUTH VIC" },
                    { 343, "768 Albany Creek Road", -27.345467842343002, 152.96500682831001, "4035", "QLD", "Albany Creek", "ALBANY CREEK QLD" },
                    { 344, "Tea Tree Plaza, 976 North East Road", -34.831841149829003, 138.69153499602999, "5092", "SA", "Modbury", "TEA TREE WESTFIELD FOOD COURT, SA" },
                    { 345, "115 Boat Harbour Drive", -25.288589703258001, 152.83678114413999, "4655", "QLD", "Hervey Bay", "HERVEY BAY QLD" },
                    { 346, "32-36 Dimboola Road", -36.709521438925997, 142.19489693642001, "3400", "VIC", "Horsham", "HORSHAM VIC" },
                    { 347, "Cnr Nepean Highway & Fourth Avenue", -38.357865684307001, 144.89850997925001, "3939", "VIC", "Rosebud", "ROSEBUD VIC" },
                    { 348, "Kin Kora Shopping Centre,91 Dawson Highway", -23.870452323551, 151.23993068933001, "4680", "QLD", "Gladstone", "GLADSTONE KIN KORA QLD" },
                    { 349, "Cnr Wells & Edithvale Roads", -38.028875768272002, 145.13068199157999, "3172", "VIC", "Chelsea Heights", "CHELSEA HEIGHTS VIC" },
                    { 350, "2 William Street (cnr Smith Street)", -27.607947834901999, 152.89649248123001, "4300", "QLD", "Goodna", "GOODNA QLD" },
                    { 351, "2 O'Hanlon Place", -35.189927900000001, 149.08298780000001, "2913", "ACT", "Nicholls", "GOLD CREEK" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 352, "7-11 Horne Street", -37.576644834028002, 144.72866177559001, "3429", "VIC", "Sunbury", "SUNBURY VIC" },
                    { 353, "Cnr Mamre Road & Hall Street", -33.780741349562, 150.77112078667, "2760", "NSW", "St Marys Sth", "ST MARYS SOUTH NSW" },
                    { 354, "18 Robinson Road East", -27.370859787425999, 153.06125789881, "4014", "QLD", "Virginia", "VIRGINIA QLD" },
                    { 355, "Shell Service Centre, Hume Highway", -34.607634356452003, 150.2256372571, "2577", "NSW", "Sutton Forest", "SUTTON FOREST NSW" },
                    { 356, "1st Floor,Terminal 3, Melbourne Airport", -37.669945127444997, 144.84907150269001, "3043", "VIC", "Tullamarine", "MELBOURNE AIRPORT VIRGIN TERMINAL VIC" },
                    { 357, "Westfield Garden City Cnr of Logan and Kessles road", -27.563839707143, 153.08339781548, "4122", "QLD", "Mt Gravatt", "GARDEN CITY QLD" },
                    { 358, "186 Arden Street", -33.920309296904001, 151.25678024727, "2034", "NSW", "Coogee", "COOGEE NSW" },
                    { 359, "91 Queen Street, (cnr Albert & Elizabeth Streets)", -27.470582083812001, 153.02557647227999, "4000", "QLD", "Brisbane", "MYER II QLD" },
                    { 360, "127 Canterbury Road", -37.831575475552, 145.14813244343, "3130", "VIC", "Blackburn South", "BLACKBURN VIC" },
                    { 361, "Cnr Pacific Highway & Wood Street", -33.092471865036998, 151.63684129715, "2281", "NSW", "Swansea", "SWANSEA NSW" },
                    { 362, "Cnr Princes Highway & Bishop Street", -33.914330355513997, 151.17798507213999, "2044", "NSW", "St Peters", "ST PETERS NSW" },
                    { 363, "598 Pascoe Vale Road", -37.720871112155002, 144.92144554852999, "3046", "VIC", "Oak Park", "OAK PARK VIC" },
                    { 364, "Goobarabah Avenue", -33.243088937331002, 151.50541305542001, "2263", "NSW", "Gorokan", "LAKEHAVEN NSW" },
                    { 365, "Australia Fair Shopping Centre, Marine Parade", -27.969208452549999, 153.41557502747, "4215", "QLD", "Southport", "AUSTRALIA FAIR QLD" },
                    { 366, "38 George Street (Cnr Zander Street)", -27.716039306917999, 153.19809615611999, "4207", "QLD", "Beenleigh", "BEENLEIGH QLD" },
                    { 367, "26-48 Browns Plains Road", -27.660534030000001, 153.04065585000001, "4118", "QLD", "Browns Plains", "BROWNS PLAINS QLD" },
                    { 368, "90-106 Sydney Rd ", -37.775540158238002, 144.96086597442999, "3065", "VIC", "Brunswick", "BRUNSWICK VIC" },
                    { 369, "14-20 Siganto Drive", -27.905674113193999, 153.31814378499999, "4212", "QLD", "Helensvale", "HELENSVALE QLD" },
                    { 370, "114-116 Wilson Street", -41.055003569660002, 145.90483188629, "7320", "TAS", "Burnie", "BURNIE TAS" },
                    { 371, "Cnr Blackburn & Doncaster Roads", -37.788696095382001, 145.16155958176, "3109", "VIC", "Doncaster", "EAST DONCASTER VIC" },
                    { 372, "Woden Westfield, Keltie Street", -35.346355461511997, 149.08694028854001, "2606", "NSW", "Woden", "WODEN ACT" },
                    { 373, "Westfield Shoppingtown, The Kingsway", -34.035643995180997, 151.10381126403999, "2228", "NSW", "Miranda", "MIRANDA F/C LVL 1 NSW" },
                    { 374, "70 Hale Road", -31.988836711428, 116.0092574358, "6058", "WA", "Forrestfield", "FORRESTFIELD WA" },
                    { 375, "Birallee Shopping Centre Melrose Drive", -36.127831792305997, 146.86554819345, "3690", "VIC", "West Wodonga", "WODONGA VIC" },
                    { 376, "Pacific Fair Shopping Centre, Cnr Hooker Blvd & Gold Coast Highway", -28.035622100927, 153.42969201285001, "4218", "QLD", "Broadbeach", "PACIFIC FAIR QLD" },
                    { 377, "465 Tapleys Hill Road", -34.914104012994002, 138.51351946592001, "5024", "SA", "Fulham Gardens", "FULHAM GARDENS SA" },
                    { 378, "Stafford City Shopping Centre, 360 Stafford Rd", -27.410497592243999, 153.01389947534, "4053", "QLD", "Stafford", "STAFFORD QLD" },
                    { 379, "Cnr Burelli, Stewart & Corrimal Streets", -34.427323787200997, 150.89982658624999, "2500", "NSW", "Wollongong", "WOLLONGONG NSW" },
                    { 380, "Cnr Hervey Range Road & Thuringowa Drive", -19.317271514986999, 146.72754585742999, "4817", "QLD", "Thuringowa Central", "TOWNSVILLE WILLOWS QLD" },
                    { 381, "140 High Street", -38.307542573835001, 145.18402308226001, "3915", "VIC", "Hastings", "HASTINGS VIC" },
                    { 382, "41-43 Synnot Street", -37.903028086550997, 144.66171920299999, "3030", "VIC", "Werribee", "WERRIBEE VIC" },
                    { 383, "Cnr March & Eastmarket Streets", -33.599330561915998, 150.75281739235001, "2753", "NSW", "Richmond", "RICHMOND NSW" },
                    { 384, "Cnr Princes Highway & Lloyd Street", -38.185341086274001, 146.23514592647999, "3825", "VIC", "Moe", "MOE VIC" },
                    { 385, "M4 Fwy, Eastern Creek", -33.802454942402001, 150.88171362877, "2766", "NSW", "Eastern Creek", "M4 WEST NSW" },
                    { 386, "213 Parramatta Road", -33.869495779051, 151.11460715531999, "2046", "NSW", "Five Dock", "FIVE DOCK NSW" },
                    { 387, "757 Anzac Parade", -33.941812352043002, 151.23905628919999, "2035", "NSW", "Maroubra", "MAROUBRA NSW" },
                    { 388, "95-101 Smith Street", -31.076770929215002, 152.84339547157001, "2440", "NSW", "Kempsey", "KEMPSEY NSW" },
                    { 389, "M4 Fwy, Eastern Creek", -33.801586816464003, 150.88720679283, "2766", "NSW", "Eastern Creek", "M4 EAST (CITY BOUND)" },
                    { 390, "14-28 Rundle Mall", -34.923039855040997, 138.60117673874001, "5000", "SA", "Adelaide", "ADELAIDE MYER CENTRE SA" },
                    { 391, "75 Albion Street", -28.219244317402001, 152.03388601541999, "4370", "QLD", "Warwick", "WARWICK QLD" },
                    { 392, "16-20 Simpson Street", -20.727217495468999, 139.49466884136001, "4825", "QLD", "Mount Isa", "MOUNT ISA QLD" },
                    { 393, "390 South Street", -32.065042108146002, 115.80120384692999, "6163", "WA", "O'Connor", "O'CONNOR WA" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 394, "Suncorp Bldg, The Esplanade", -16.920468581316999, 145.77759526669999, "4870", "QLD", "Cairns", "CAIRNS ESPLANADE QLD" },
                    { 395, "Endeavour Hills Shopping Centre, Matthew Flinders Road (cnr Heatherton Rd)", -37.975529870054999, 145.25833904743001, "3802", "VIC", "Endeavour Hills", "ENDEAVOUR HILLS VIC" },
                    { 396, "Cnr Hassall Street & James Ruse Drive", -33.819222866444001, 151.01985812186999, "2142", "NSW", "Rosehill", "ROSEHILL NSW" },
                    { 397, "The Pines Shopping Centre; Cnr Guineas Creek Rd & K.P. McGrath Drive", -28.133588238792001, 153.4692594409, "4221", "QLD", "Elanora", "ELANORA QLD" },
                    { 398, "7-13 Charlton Street", -33.488878227634999, 151.32263660430999, "2256", "NSW", "Woy Woy", "WOY WOY NSW" },
                    { 399, "Treetops Centre, 1 Executive Dr", -28.100703054286999, 153.42329978942999, "4220", "QLD", "Burleigh Waters", "BURLEIGH WATERS QLD" },
                    { 400, "82 Duffield Road", -27.249445704991999, 153.00160288811, "4503", "QLD", "Kallangur", "KALLANGUR QLD" },
                    { 401, "Cnr Dorchester & Beach Roads", -31.844534558366998, 115.80838143826, "6000", "WA", "Warwick", "WARWICK ENTERTAINMENT CENTRE WA" },
                    { 402, "Cnr Princes Highway & Moombara Road", -34.495835953861999, 150.79340457916001, "2530", "NSW", "Dapto", "DAPTO NSW" },
                    { 403, "61 North East Road", -34.888918751943002, 138.61313939095001, "5081", "SA", "Collinswood", "COLLINSWOOD SA" },
                    { 404, "296 Canterbury Road", -37.831185678875002, 145.27069866657001, "3153", "VIC", "Bayswater North", "BAYSWATER NORTH VIC" },
                    { 405, "652-656 North Road", -37.905112712368997, 145.04431754351, "3204", "VIC", "Ormond", "ORMOND VIC" },
                    { 406, "303-306 Magill Road", -34.914227181592999, 138.64586234092999, "5068", "SA", "Trinity Gardens", "TRINITY GARDENS SA" },
                    { 407, "Cnr Koonya Circuit & Taren Point Road", -34.028015282166002, 151.12062335013999, "2229", "NSW", "Taren Point", "TAREN POINT NSW" },
                    { 408, "625-631 Bridge Road", -37.819628542985001, 145.01183062792001, "3121", "VIC", "Richmond", "BURNLEY VIC" },
                    { 409, "407 St Kilda Road", -37.836191443729, 144.97612774372001, "3004", "VIC", "St Kilda", "ST KILDA ROAD VIC" },
                    { 410, "Cnr New Line & Old Northern Roads", -33.695847076824002, 151.03148818016001, "2158", "NSW", "Dural", "DURAL NSW" },
                    { 411, "Cnr Capital Road & Alexander Drive", -31.848804350835, 115.87854802608, "6066", "WA", "Ballajura", "BALLAJURA WA" },
                    { 412, "Cnr Richmond Road & Woodcroft Drive", -33.748126068349997, 150.87983608246, "2767", "NSW", "Doonside", "DOONSIDE NSW" },
                    { 413, "98 Princes Highway", -38.070907965152003, 145.47823190688999, "3180", "VIC", "Pakenham", "PAKENHAM VIC" },
                    { 414, "1-3 Best Street", -41.178718573647998, 146.36239528656, "7310", "TAS", "Devonport", "DEVONPORT TAS" },
                    { 415, "183 Botany Road", -33.901721969568001, 151.20182454586001, "2017", "NSW", "Waterloo", "WATERLOO NSW" },
                    { 416, "Shellharbour Road", -34.551475584686003, 150.85954785346999, "2528", "NSW", "Warilla", "WARILLA NSW" },
                    { 417, "1171-1173 Pascoe Vale Road", -37.677396788663998, 144.92185592651001, "3047", "VIC", "Broadmeadows", "BROADMEADOWS VIC" },
                    { 418, "Cnr Great Eastern Highway & Lyall Street", -31.934887078262999, 115.93617796898, "6104", "WA", "Ascot", "ASCOT WA" },
                    { 419, "Cnr Godrick & Forster Streets", -41.425724262648998, 147.13163673878, "7248", "TAS", "Launceston", "INVERMAY TAS" },
                    { 420, "Whitfords Ave (cnr Dampier Ave)", -31.796026421948, 115.74894905089999, "6025", "WA", "Hillarys", "WHITFORD CITY WA" },
                    { 421, "Cnr Cunninghame & York Streets", -38.106943485880002, 147.06784307957, "3850", "VIC", "Sale", "SALE VIC" },
                    { 422, "Rosemeadow Marketplace, Copperfield Drive (Cnr Fitzgibbon Lane)", -34.100549192693002, 150.79815477132999, "2560", "NSW", "Rosemeadow", "ROSEMEADOW NSW" },
                    { 423, "872 Hume Highway", -33.900555421537, 150.99892079829999, "2197", "NSW", "Bass Hill", "BASS HILL NSW" },
                    { 424, "Cnr Victoria Road & Mons Avenue", -33.807491904987003, 151.08560979366001, "2114", "NSW", "West Ryde", "WEST RYDE NSW" },
                    { 425, "190-200 Ballarat Road", -37.791108257757998, 144.89041239023001, "3011", "VIC", "Footscray", "FOOTSCRAY VIC" },
                    { 426, "Casuarina Shopping Centre, 247 Trower Rd", -12.375865233316, 130.88053464890001, "0810", "NT", "Darwin", "CASUARINA NT" },
                    { 427, "375 Lower Plenty Road", -37.730757244708997, 145.08633702993001, "3085", "VIC", "Yallambie", "YALLAMBIE VIC" },
                    { 428, "356 Bridge Street (cnr McGregor St)", -27.544763510519999, 151.92472815514, "4350", "QLD", "Toowoomba West", "TOOWOOMBA WEST QLD" },
                    { 429, "Glenmore Shopping Centre, 512-516 Yaamba Rd", -23.333951411587002, 150.51903069018999, "4701", "QLD", "North Rockhampton", "GLENMORE QLD" },
                    { 430, "692 Glenferrie Road", -37.820550214180003, 145.03583103418001, "3122", "VIC", "Hawthorn", "HAWTHORN VIC" },
                    { 431, "61 Condamine Street", -27.181818648690999, 151.26272678375, "4405", "QLD", "Dalby", "DALBY QLD" },
                    { 432, "1991 Wynnum Road", -27.457575796705999, 153.15324693918001, "4178", "QLD", "Wynnum West", "WYNNUM WEST QLD" },
                    { 433, "Cnr City Road & Clarendon Street", -37.828103246757003, 144.95796382427, "3205", "VIC", "South Melbourne", "SOUTH MELBOURNE VIC" },
                    { 434, "Cnr Berwick Street & Canning Highway", -31.974608263932002, 115.88310778141, "6151", "WA", "South Perth", "SOUTH PERTH WA" },
                    { 435, "20 West Terrace", -34.923389527330997, 138.58783811331, "5000", "SA", "Adelaide", "WEST TERRACE SA" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 436, "Cnr Luxford Road & Zoe Place", -33.765212342184, 150.82646548747999, "2770", "NSW", "Mt Druitt", "MOUNT DRUITT NSW" },
                    { 437, "Southlands Shopping Centre, Burrendah Boulevard", -32.057336221142002, 115.88126242161, "6155", "WA", "Willetton", "WILLETTON WA" },
                    { 438, "2A Maitland Road", -32.568502336172998, 151.18039369582999, "2330", "NSW", "Singleton", "SINGLETON NSW" },
                    { 439, "Cnr Ringers Road & New England Highway", -31.126570050828001, 150.92328477057001, "2340", "NSW", "South Tamworth", "TAMWORTH SOUTH NSW" },
                    { 440, "208 Princes Highway", -38.082997091711, 144.36054249681999, "3200", "VIC", "Corio", "CORIO VIC" },
                    { 441, "Cnr Jersey & Hyatts Roads", -33.744388131423001, 150.83658277987999, "2761", "NSW", "Plumpton", "PLUMPTON NSW" },
                    { 442, "Box Hill Central S/C", -37.819225970345002, 145.12239933014001, "3128", "VIC", "Box Hill", "BOX HILL CENTRAL VIC" },
                    { 443, "349 Charles Street", -31.926637556202, 115.85186004639, "6006", "WA", "North Perth", "NORTH PERTH WA" },
                    { 444, "Cnr Princes Highway & Cambewarra Road", -34.843275688273003, 150.59491574763999, "2541", "NSW", "Bomaderry", "BOMADERRY NSW" },
                    { 445, "260A Queen Street", -19.581739335260998, 147.40088760853001, "4807", "QLD", "Ayr", "AYR QLD" },
                    { 446, "35-41 Springwood Road", -27.610719161277, 153.12302917241999, "4127", "QLD", "Springwood", "SPRINGWOOD QLD" },
                    { 447, "Cnr Pacific Highway & Spring Street", -29.706505671633, 152.94131219387, "2460", "NSW", "Grafton", "GRAFTON NSW" },
                    { 448, "5 Westside Circle", -42.976251849684999, 147.30327665806001, "7050", "TAS", "Kingston", "KINGSTON TAS" },
                    { 449, "230-236 Autumn Street", -38.141493025290004, 144.33651208878001, "3218", "VIC", "Geelong West", "GEELONG WEST VIC" },
                    { 450, "Cnr Bagot Road & Fitzer Drive", -12.409908372984001, 130.85570544004, "0820", "NT", "Darwin", "LUDMILLA NT" },
                    { 451, "Cnr High Street & Childs Road", -37.659435102700002, 145.01847445965001, "3076", "VIC", "Epping", "EPPING VIC" },
                    { 452, "Kwinana Hub S/C, Gilmore Avenue", -32.245328614046002, 115.81286609173, "6167", "WA", "Kwinana", "KWINANA WA" },
                    { 453, "Bay Village Shopping Centre, The Entrance Road", -33.375158029491999, 151.47249698639001, "2261", "NSW", "Bateau Bay", "BATEAU BAY NSW" },
                    { 454, "261 Murray Street", -38.338864495812999, 143.58136564493, "3250", "VIC", "Colac", "COLAC VIC" },
                    { 455, "329 Frome Street", -29.472924915090999, 149.84250783920001, "2400", "NSW", "Moree", "MOREE NSW" },
                    { 456, "103 Laurel Avenue", -28.808293456476001, 153.28590899706001, "2480", "QLD", "Lismore", "LISMORE NSW" },
                    { 457, "209-211 Haly Street (cnr Youngman St)", -26.539294586783999, 151.83615191782999, "4610", "QLD", "Kingaroy", "KINGAROY QLD" },
                    { 458, "Cnr Bowral Road & Bessemer Street", -34.451590334921001, 150.44276475906, "2575", "NSW", "Mittagong", "MITTAGONG NSW" },
                    { 459, "Cnr Ricardo Street & McBryde Crescent", -35.404967135287002, 149.09792661667001, "2903", "ACT", "Erindale", "ERINDALE ACT" },
                    { 460, "Cnr Cooyong & Mort Streets", -35.275660912367002, 149.13067638874, "2601", "NSW", "Braddon", "BRADDON ACT" },
                    { 461, "40-42 Adelaide Road", -34.607049334872002, 138.74459177256, "5118", "SA", "Gawler", "GAWLER SA" },
                    { 462, "Morley Galleria Shopping Centre, Collier Rd", -31.897449481978001, 115.89922394988, "6062", "WA", "Morley", "MORLEY FOOD COURT WA" },
                    { 463, "Sunshine Plaza, Horton Parade (cnr Maroochydore Rd)", -26.654113449444001, 153.08906435966, "4558", "QLD", "Maroochydore", "SUNSHINE PLAZA QLD" },
                    { 464, "363 High Road", -32.038916749172003, 115.90850830078, "6155", "WA", "Riverton", "RIVERTON WA" },
                    { 465, "Cnr Cumberland Highway & Victoria Street", -33.852089510848003, 150.94218671322, "2164", "NSW", "Smithfield", "SMITHFIELD NSW" },
                    { 466, "1603 Hume Highway", -37.673983129058001, 144.95538219810001, "3061", "VIC", "Campbellfield", "CAMPBELLFIELD VIC" },
                    { 467, "64 Harold Street", -33.986036205925998, 150.89322566985999, "2564", "NSW", "Macquarie Fields", "GLENQUARIE NSW" },
                    { 468, "Cnr Banna & Crossing Streets", -34.288482170001998, 146.05519115925, "2680", "NSW", "Griffith", "GRIFFITH NSW" },
                    { 469, "52B Princes Highway", -38.001045210721998, 145.23845851421001, "3177", "VIC", "Eumemmerring", "DOVETON VIC" },
                    { 470, "Cnr New England Highway & Denton Park Drive", -32.709843749971, 151.51613116263999, "2320", "NSW", "Rutherford", "RUTHERFORD NSW" },
                    { 471, " 452 Nepean Highway Cnr Wells Street ", -38.142484495353997, 145.12077391148, "3199", "VIC", "Frankston", "FRANKSTON II VIC" },
                    { 472, "237 Victoria Road", -33.850398809021002, 151.15337044001001, "2047", "NSW", "Drummoyne", "DRUMMOYNE NSW" },
                    { 473, "Westside Plaza, Galena Street", -31.962530326025, 141.44991338253001, "2880", "SA", "Broken Hill", "BROKEN HILL NSW" },
                    { 474, "Cnr Blacktown Road & St Martins Crescent", -33.7816373, 150.920129, "2148", "NSW", "Blacktown", "BLACKTOWN MEGA CENTRE ST MARTINS VILLAGE NSW" },
                    { 475, "559-563 Princes Highway", -34.031940865267998, 151.07371151447001, "2232", "NSW", "Kirrawee", "KIRRAWEE NSW" },
                    { 476, "Cnr Boomerang Place & Star Court", -33.740072351259997, 150.71739882231, "2747", "NSW", "Cambridge Gardens", "CAMBRIDGE GARDENS NSW" },
                    { 477, "Wanneroo Road", -31.750914075727, 115.80208361149, "6065", "WA", "Wanneroo", "WANNEROO WA" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 478, "Western Ring Road", -37.803888436720001, 144.80456292629, "3022", "VIC", "Sunshine", "WESTERN RING RD WEST VIC" },
                    { 479, "Western Ring Road", -37.805409336871001, 144.80930242087999, "3022", "VIC", "Sunshine", "WESTERN RING RD EAST VIC" },
                    { 480, "Cnr Main North & Montague Roads", -34.823809165309001, 138.61747384071001, "5095", "SA", "Pooraka", "POORAKA SA" },
                    { 481, "Cnr Allison Crescent & McMahon Place", -34.015201413154998, 151.0137963295, "2234", "NSW", "Menai", "MENAI NSW" },
                    { 482, "2 Golf Links Road", -38.164934520259003, 145.1376503706, "3199", "VIC", "Frankston", "TOWERHILL VIC" },
                    { 483, "Mt Milman Drive", -16.839650705952, 145.69377154111999, "4878", "QLD", "Smithfield", "SMITHFIELD II QLD" },
                    { 484, "Cnr Alice & Ferry Streets", -25.537005877853002, 152.69497811794, "4650", "QLD", "Maryborough", "MARYBOROUGH QLD" },
                    { 485, "1-9 Lunn Court", -37.869814258116001, 144.76108431815999, "3028", "VIC", "Laverton", "LAVERTON VIC" },
                    { 486, "535 South Gippsland Highway", -38.041211234693002, 145.25229334830999, "3976", "VIC", "Hampton Park", "HAMPTON PARK VIC" },
                    { 487, "678 Compton Road", -27.612135695538999, 153.05456042290001, "4109", "QLD", "Calamvale", "CALAMVALE QLD" },
                    { 488, "Cnr Mark & Macintosh Streets", -32.194422034896, 152.51346230506999, "2428", "NSW", "Forster", "FORSTER NSW" },
                    { 489, "9-15 Vaughan Street", -33.864807683594002, 151.04216873646001, "2141", "NSW", "Lidcombe", "LIDCOMBE NSW" },
                    { 490, "658 Windsor Road", -33.699997720406998, 150.92798173428, "2153", "NSW", "Kellyville", "KELLYVILLE NSW" },
                    { 491, "Cnr Renmark Avenue & 21st Street", -34.180765332877002, 140.73745429516001, "5341", "VIC", "Renmark", "RENMARK SA" },
                    { 492, "Cnr Forrester & Boronia Roads", -33.748210816822002, 150.77770829201, "2760", "NSW", "St Marys", "ST MARYS NORTH NSW" },
                    { 493, "Cnr Feldspar & Gould Road", -34.032158700913001, 150.81616044044, "2558", "NSW", "Eagle Vale", "EAGLE VALE NSW" },
                    { 494, "349 Pine Mountain Road", -27.517784502108999, 153.09680789709, "4122", "QLD", "Mt Gravatt East", "CARINA HEIGHTS QLD" },
                    { 495, "Cnr Horatio & Church Streets", -32.599785715598003, 149.58735466003, "2850", "NSW", "Mudgee", "MUDGEE NSW" },
                    { 496, "Runaway Bay Shopping Centre, Lae Dr (Cnr Moralla Ave)", -27.914254330702001, 153.40110182762001, "4216", "QLD", "Runaway Bay", "RUNAWAY BAY S/C QLD" },
                    { 497, "362-376 Deception Bay Road", -27.189854372060001, 153.01803410053, "4508", "QLD", "Deception Bay", "DECEPTION BAY QLD" },
                    { 498, "BP Service Centre, Northbound Side, Hume Highway", -36.439004397059001, 146.24803662299999, "3675", "VIC", "Glenrowan", "GLENROWAN NORTH VIC" },
                    { 499, "Cnr Macquarie & Hillsborough Roads", -32.966250087467003, 151.65314912796001, "2282", "NSW", "Warners Bay", "WARNERS BAY NSW" },
                    { 500, "1 Cambridge St, TownCentre", -12.477811064402999, 130.98327666521001, "0830", "NT", "Palmerston", "PALMERSTON NT" },
                    { 501, "1009 South Road", -34.983036308602003, 138.57439756393001, "5483", "SA", "Melrose Park", "MELROSE PARK SA" },
                    { 502, "Carindale Shopping Centre, Creek Road", -27.503903538936001, 153.10226082802001, "4152", "QLD", "Carindale", "Carindale" },
                    { 503, "606 Warrigal Road", -37.875865413615998, 145.09100675582999, "3148", "VIC", "Holmesglen", "HOLMESGLEN VIC" },
                    { 504, "Burwood Highway", -37.855834146508997, 145.18093585968001, "3133", "VIC", "Vermont", "VERMONT SOUTH VIC" },
                    { 505, "Cnr Hill & Vesper Streets", -35.709382997077, 150.17482280730999, "2536", "NSW", "Batemans Bay", "BATEMANS BAY NSW" },
                    { 506, "Cnr Old Bathurst Road & Russell Street", -33.748210899999997, 150.65411280000001, "2750", "NSW", "Emu Plains", "EMU PLAINS NSW" },
                    { 507, "6 Curt Street", -23.516924501424999, 148.15585702658001, "4720", "QLD", "Emerald", "EMERALD QLD" },
                    { 508, "99-105 Howick Street", -41.449911976338001, 147.13981211185001, "7250", "TAS", "Launceston", "SOUTH LAUNCESTON TAS" },
                    { 509, "90 Elizabeth Street ", -42.882815799873001, 147.32650995255, "7000", "TAS", "Hobart", "HOBART CBD TAS" },
                    { 510, "Manuka Plaza, Flinders Way", -35.321292549521999, 149.13376092911, "2603", "NSW", "Manuka", "MANUKA ACT" },
                    { 511, "Cnr Cary & Bay Streets", -33.009329275641001, 151.59433901310001, "2283", "NSW", "Toronto", "TORONTO NSW" },
                    { 512, "St Ives Shopping Village, Mona Vale Rd", -33.729508198342998, 151.15892316815999, "2075", "NSW", "St Ives", "ST IVES NSW" },
                    { 513, "Pennant Rd", -33.337847129539, 115.65851837397, "6230", "WA", "Bunbury", "BUNBURY WA" },
                    { 514, "164 Warringah Road", -33.753976861472999, 151.26077011228, "2100", "NSW", "Beacon Hill", "BEACON HILL NSW" },
                    { 515, "Cnr Ranford & Nicholson Roads", -32.085915207900001, 115.91713160275999, "6155", "WA", "Canning Vale", "CANNING VALE WA" },
                    { 516, "Midland Highway Cnr Boyer Road", -42.737523395437002, 147.22772955894001, "7030", "TAS", "Bridgewater", "BRIDGEWATER TAS" },
                    { 517, "99 Lear Jet Drive", -27.084893513480999, 152.97842055558999, "4510", "QLD", "Caboolture", "BRIBIE INTERCHANGE QLD" },
                    { 518, "Noosa Homemaker Centre, Gibson Terrace", -26.401380191284002, 153.06228250264999, "4566", "QLD", "Noosaville", "NOOSAVILLE QLD" },
                    { 519, "261-267 High Street", -37.805005272669, 145.03493517637, "3101", "VIC", "Kew", "KEW VIC" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 520, "123 River Road", -26.199990886782999, 152.66719847918, "4570", "QLD", "Gympie", "GYMPIE QLD" },
                    { 521, "Lakeside Shopping Centre, Joondalup Drive", -31.743546799013998, 115.76547682285, "6027", "WA", "Joondalup", "JOONDALUP WA" },
                    { 522, "268 Sandy Bay Road", -42.896463858769998, 147.32868120073999, "7005", "TAS", "Sandy Bay", "SANDY BAY TAS" },
                    { 523, "Yass Service Centre, Hume Highway", -34.806804666780998, 148.88267934321999, "2582", "NSW", "Yass", "YASS NSW" },
                    { 524, "Roselands Shopping Centre, Roselands Drive", -33.934930722958001, 151.06941461563, "2196", "NSW", "Roselands", "ROSELANDS SHOPPING CENTRE NSW" },
                    { 525, "191 Wilson Road", -33.907387514958003, 150.86615413427, "2168", "NSW", "Green Valley", "HINCHINBROOK NSW" },
                    { 526, "Cnr Canning Highway & Foss Street", -32.035588026553, 115.78568726778001, "6157", "WA", "Bicton", "BICTON WA" },
                    { 527, "815-819 Sturt Street", -37.561176246449001, 143.84801745415001, "3350", "VIC", "Ballarat", "BALLARAT STURT STREET VIC" },
                    { 528, "Cnr Great Western Highway & Reserve Road", -33.768602654951003, 150.75718671083001, "2760", "NSW", "Werrington", "WERRINGTON NSW" },
                    { 529, "Cnr Hunter & Haig Street", -27.594166219112999, 152.74532318115001, "4305", "QLD", "Brassall", "BRASSALL QLD" },
                    { 530, "479-489 High Street", -36.124707738323004, 144.74682033062001, "3564", "VIC", "Echuca", "ECHUCA VIC" },
                    { 531, "2098 Ipswich Road", -27.56650268137, 152.98406124114999, "4075", "QLD", "Oxley", "OXLEY QLD" },
                    { 532, "388 Scarborough Beach Road", -31.902481140649002, 115.79871475697, "6018", "WA", "Innaloo", "INNALOO WA" },
                    { 533, "39 Short Street", -27.557719071686002, 153.01767736673, "4106", "QLD", "Rocklea", "ROCKLEA QLD" },
                    { 534, "Westfield Shoppingtown, Church Street", -33.817030119003, 151.00214481354001, "2150", "NSW", "Parramatta", "PARRAMATTA W/F L5 NSW" },
                    { 535, "513 Bridge Road", -34.798999303510001, 138.65660190582, "5096", "SA", "Para Hills", "PARA HILLS SA" },
                    { 536, "227-235 Church Street", -37.818020358098003, 144.99966681004, "3121", "VIC", "Richmond", "RICHMOND VIC" },
                    { 537, "Cnr Carrak Road & Avoca Drive", -33.468300378324003, 151.38284683227999, "2250", "NSW", "Kincumber", "KINCUMBER NSW" },
                    { 538, "458 Quakers Hill Parkway", -33.729996891732, 150.90310156345001, "2763", "NSW", "Quakers Hill", "QUAKERS HILL NSW" },
                    { 539, "87 Osborne Rd", -27.410552357076, 152.97786533832999, "4053", "QLD", "Mitchelton", "BROOKSIDE QLD" },
                    { 540, "5 St Albans Road", -37.746756829256, 144.80232596396999, "3021", "VIC", "St Albans", "ST ALBANS VIC" },
                    { 541, "28 Abbott Road", -33.767303849895001, 150.95251321793, "2147", "NSW", "Seven Hills", "SEVEN HILLS NORTH NSW" },
                    { 542, "804 Canterbury Road", -33.925846343505, 151.08665049076001, "2196", "NSW", "Roselands", "LAKEMBA NSW" },
                    { 543, "Cnr Boundary & Centre Dandenong Roads", -37.972882700427, 145.11237323284001, "3195", "VIC", "Braeside", "BRAESIDE VIC" },
                    { 544, "Marrickville Metro, 34 Victoria Road", -33.906543828916, 151.17154240607999, "2204", "NSW", "Marrickville", "MARRICKVILLE METRO NSW" },
                    { 545, "Cnr Elizabeth Drive & Smithfield Road", -33.888091952480003, 150.88179945946001, "2177", "NSW", "Bonnyrigg", "BONNYRIGG NSW" },
                    { 546, "424-426 Campbell St (Cnr Gray Street)", -35.348035672058998, 143.56157898903001, "3585", "VIC", "Swan Hill", "SWAN HILL VIC" },
                    { 547, "Cnr Ennis Avenue & Elanora Drive", -32.294469935720002, 115.76378703117, "6168", "WA", "Rockingham", "WOODBRIDGE WA" },
                    { 548, "1 Town Centre Circuit", -32.736064594482997, 152.10871160030001, "2301", "NSW", "Salamander Bay", "SALAMANDER BAY NSW" },
                    { 549, "28 Anderson Street", -38.473187636704999, 145.94373464584001, "3953", "VIC", "Leongatha", "LEONGATHA VIC" },
                    { 550, "9A-11 Walker Street", -35.066254144104001, 138.85763347149, "5251", "SA", "Mount Barker", "MOUNT BARKER SA" },
                    { 551, "67 Military Road", -37.766588712474999, 144.8633569479, "3034", "VIC", "Avondale Heights", "AVONDALE HEIGHTS VIC" },
                    { 552, "256 Telegraph Road", -27.330957588192, 153.02691221237001, "4017", "QLD", "Bracken Ridge", "BRACKEN RIDGE QLD" },
                    { 553, "18 Ernest Street", -17.526968917691001, 146.02833151817001, "4860", "QLD", "Innisfail", "INNISFAIL QLD" },
                    { 554, "519 Waverley Road", -37.886230408772001, 145.14508008957, "3149", "VIC", "Mount Waverley", "MOUNT WAVERLEY VIC" },
                    { 555, "Cnr Ryrie & Yarra Streets", -38.150190078902, 144.36175704002, "3220", "VIC", "Geelong", "GEELONG CENTRAL VIC" },
                    { 556, "Dandenong Plaza Shopping Centre,Cnr McCrae & Walker Streets", -37.987181053699999, 145.21856083027001, "3175", "VIC", "Dandenong", "DANDENONG PLAZA VIC" },
                    { 557, "Food Terrace, 171 Dandenong Road", -27.548494309473, 152.93964277555, "4074", "QLD", "Mt Ommaney", "MOUNT OMMANEY FOOD COURT QLD" },
                    { 558, "796 Main Street (cnr Princess St)", -27.483515450955, 153.03617924452001, "4169", "QLD", "Kangaroo Point", "KANGAROO POINT QLD" },
                    { 559, "118 Brown Street", -37.741239242092, 142.02443769081, "3300", "VIC", "Hamilton", "HAMILTON VIC" },
                    { 560, "1 Habour Street", -33.874479361869, 151.20170970282999, "2000", "NSW", "Haymarket", "DARLING QUARTER NSW" },
                    { 561, "72 Park Avenue", -32.940329006794997, 151.71142145991001, "2289", "NSW", "Kotara", "KOTARA NSW" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 562, "4 Kings Parade", -41.157806627023, 146.16933256388, "7315", "TAS", "Ulverstone", "ULVERSTONE TAS" },
                    { 563, "Cnr Cole Street & Weston Hill Road", -42.781409368158997, 147.56480813025999, "7172", "TAS", "Sorell", "SORELL TAS" },
                    { 564, "27 Adelaide Road", -35.120689600109003, 139.27089750767001, "5253", "SA", "Murray Bridge", "MURRAY BRIDGE SA" },
                    { 565, "Hollywood Plaza Shopping Centre, Winzor Street", -34.768475530935, 138.6243134737, "5108", "SA", "Salisbury Downs", "HOLLYWOOD PLAZA SA" },
                    { 566, "172 Lutwyche Road", -27.439052576731999, 153.03048223256999, "4030", "QLD", "Windsor", "WINDSOR WEST QLD" },
                    { 567, "7 Sowerby Street", -34.774512746225, 149.692476833, "2580", "NSW", "Goulburn", "GOULBURN SOUTH NSW" },
                    { 568, "46 Targo Street", -24.867037904888001, 152.35197991133001, "4670", "QLD", "Bundaberg", "BUNDABERG CITY QLD" },
                    { 569, "2901 Albany Highway", -32.118031467340998, 116.01635187863999, "6111", "WA", "Kelmscott", "KELMSCOTT WA" },
                    { 570, "Cnr Marmion Avenue & Burragah Way", -31.841353730723, 115.76394259929999, "6023", "WA", "Duncraig", "DUNCRAIG WA" },
                    { 571, "Westfield Shoppingtown, Cobbs Road", -33.308850358333999, 151.41151428223, "2259", "NSW", "Tuggerah", "TUGGERAH FOOD COURT NSW" },
                    { 572, "Cnr Davies & Arab Roads", -33.945860960083003, 151.03575289249, "2211", "NSW", "Padstow", "PADSTOW NSW" },
                    { 573, "453 Hume Highway", -33.94021, 150.91208900000001, "2170", "NSW", "Casula", "CASULA NSW" },
                    { 574, "Greensborough Plaza Shopping Centre, The Circuit", -37.701844019706002, 145.10355412960001, "3088", "VIC", "Greensborough", "GREENSBOROUGH PLAZA F/C VIC" },
                    { 575, "Westfield Mt Druitt, Cnr Carlisle Ave & Luxford Rd", -33.766467624363003, 150.81961908925001, "2770", "NSW", "Mt Druitt", "MOUNT DRUITT F/C NSW" },
                    { 576, "68 Chambers Flat Road", -27.681164764954001, 153.11553508042999, "4206", "QLD", "Waterford West", "MARSDEN QLD" },
                    { 577, "244 Loganlea Road", -27.668026630309999, 153.13908487558001, "4131", "QLD", "Meadowbrook", "MEADOWBROOK QLD" },
                    { 578, "Nathan Plaza Shopping Centre, 310-330 Ross River Rd", -19.298334480767, 146.76401853561001, "4810", "QLD", "Aitkenvale", "TOWNSVILLE STOCKLAND QLD" },
                    { 579, "Cnr Melton Highway & Calder Park Drive", -37.693898174057999, 144.75496888161001, "3038", "VIC", "Sydenham", "SYDENHAM VIC" },
                    { 580, "Cnr Woodville & Merrylands Roads", -33.838649846183998, 150.99939823151001, "2142", "NSW", "Merrylands", "GRANVILLE NSW" },
                    { 581, "561-583 Polding Street", -33.856807645845002, 150.89748102066, "2176", "NSW", "Prairiewood", "PRAIRIEWOOD NSW" },
                    { 582, "1233 Victoria Road", -33.806598200076003, 151.07123583555, "2114", "NSW", "West Ryde", "WEST RYDE BP NSW" },
                    { 583, "33 Main Hursbridge Road", -37.673609485137, 145.15727877616999, "3089", "VIC", "Diamond Creek", "DIAMOND CREEK VIC" },
                    { 584, "Cnr Marmion & Delamere Avenues", -31.736890656250001, 115.73747456074, "6028", "WA", "Currambine", "CURRAMBINE WA" },
                    { 585, "Cnr Plenty Road & Dunne Street", -37.716926898360001, 145.0422334671, "3083", "VIC", "Kingsbury", "KINGSBURY VIC" },
                    { 586, "121 Boulder Road (cnr Roberts Road)", -30.751074929264998, 121.47990167141, "6340", "WA", "Kalgoorlie", "KALGOORLIE WA" },
                    { 587, "143 Mount Street", -35.084438451522999, 148.09204459189999, "2772", "NSW", "Gundagai", "GUNDAGAI NSW" },
                    { 588, "24 Railway Terrace", -23.697362020162, 133.87889564036999, "0870", "NT", "Alice Springs", "ALICE SPRINGS NT" },
                    { 589, "24-26 Bowen Street", -26.574202116662001, 148.78854453564, "4455", "QLD", "Roma", "ROMA QLD" },
                    { 590, "345 Samsonvale Road", -27.291596410796, 152.95313000678999, "4500", "QLD", "Warner", "WARNER QLD" },
                    { 591, "BP Complex, Cunningham Highway", -28.546731521592001, 150.32354593277, "4390", "QLD", "Goondiwindi", "GOONDIWINDI QLD" },
                    { 592, "349 Colburn Avenue", -27.586594863153, 153.28269034624, "4165", "QLD", "Victoria Point", "VICTORIA POINT QLD" },
                    { 593, "The Gap Shopping Village, 992 Waterworks Rd", -27.445424896315998, 152.95155823230999, "4061", "QLD", "The Gap", "THE GAP QLD" },
                    { 594, " 2-4 Kangan Drive Cnr Clyde Road", -38.039827585706, 145.34290909767, "3806", "VIC", "Berwick", "BERWICK VIC" },
                    { 595, "192-204 High Street", -37.773835608329001, 145.11523783206999, "3108", "VIC", "Doncaster", "LOWER TEMPLESTOWE VIC" },
                    { 596, "Village Shopping Centre, Charles Hackett Drive", -33.766688443545, 150.76991915702999, "2760", "NSW", "St Marys", "ST MARYS VILLAGE NSW" },
                    { 597, "Cnr Robina Town Centre Drive & Christine Avenue", -28.077811608958001, 153.38542699813999, "4226", "QLD", "Robina", "ROBINA CENTRAL QLD" },
                    { 598, "664 Toohey Road", -27.545738560040999, 153.03946495055999, "4107", "QLD", "Salisbury", "SALISBURY QLD" },
                    { 599, "51-53 Victoria Street", -38.160995087281997, 145.92967987060999, "3820", "VIC", "Warragul", "WARRAGUL VIC" },
                    { 600, "Glendale Shopping Centre, 389 Lake Road", -32.931921085035, 151.64001703261999, "2285", "NSW", "Glendale", "GLENDALE NSW" },
                    { 601, "Darwin Central, Cnr Smith & Knuckey Streets", -12.463082207494001, 130.84136366844001, "0800", "NT", "Darwin", "DARWIN CENTRAL NT" },
                    { 602, "Cnr Atlantis Drive & The Grove Way", -34.789027890062002, 138.69763165712001, "5125", "SA", "Golden Grove", "GOLDEN GROVE SA" },
                    { 603, "569 Raglan Parade", -38.38078542329, 142.4851629138, "3280", "VIC", "Warrnambool", "WARRNAMBOOL CENTRAL VIC" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 604, "Waterworth Drive", -34.049092598808997, 150.76050192118001, "2567", "NSW", "Mt Annan", "MOUNT ANNAN NSW" },
                    { 605, "Cnr High & Collings Streets", -37.282598310353997, 142.92933940886999, "3377", "VIC", "Ararat", "ARARAT VIC" },
                    { 606, "182 Wanneroo Road", -31.817592031872, 115.82124531269, "6065", "WA", "Landsdale", "LANDSDALE WA" },
                    { 607, "Cnr Chapman Rd & Durlacher Street", -28.773071351012, 114.61185336113, "6530", "WA", "Geraldton", "GERALDTON WA" },
                    { 608, "Cnr Pacific & Oxley Highways", -31.463641691623, 152.82252520322999, "2444", "NSW", "Port Macquarie", "PORT MACQUARIE HIGHWAY NSW" },
                    { 609, "Citi Centre Arcade, Rundle Mall", -34.922811400000001, 138.60510650000001, "5000", "SA", "Adelaide", "RUNDLE MALL EAST SA" },
                    { 610, "173 Newcastle Street", -35.325098218774997, 149.17135745287001, "2609", "NSW", "Fyshwick", "FYSHWICK ACT" },
                    { 611, "Cnr Charnwood Place & Lhotsky Street", -35.205930277198, 149.03422951697999, "2615", "NSW", "Charnwood", "CHARNWOOD ACT" },
                    { 612, "Cnr Maughan & Arthur Streets", -32.555542369295999, 148.94537597895001, "2820", "NSW", "Wellington", "WELLINGTON NSW" },
                    { 613, "Indiana Place, Main Rd (cnr Maroochydore Rd)", -26.661299948465999, 153.05120229721001, "4558", "QLD", "Kuluin", "KULUIN QLD" },
                    { 614, "Cnr Poath & North Roads", -37.907952787734999, 145.07525682449, "3166", "VIC", "Oakleigh", "OAKLEIGH VIC" },
                    { 615, "Cnr Solomontown Road & Mary-Ellie Street", -33.181018028592, 138.01219046116, "5540", "SA", "Port Pirie", "PORT PIRIE SA" },
                    { 616, "Cnr Hindmarsh & Seaview Roads", -35.551135358373003, 138.62263977527999, "5211", "SA", "Victor Harbor", "VICTOR HARBOR SA" },
                    { 617, "104-106 Herbert Street", -18.646992318986999, 146.16194307804, "4840", "QLD", "Ingham", "INGHAM QLD" },
                    { 618, "386-388 Charlotte Street", -35.526306387045999, 144.96341943741001, "2710", "VIC", "Deniliquin", "DENILIQUIN NSW" },
                    { 619, "373 Pacific Highway", -32.791905966808002, 151.72486066818001, "2324", "NSW", "Heatherbrae", "HEATHERBRAE NSW" },
                    { 620, "370-372 Princes Highway", -34.340362117102003, 150.90657770633999, "2517", "NSW", "Woonona", "WOONONA NSW" },
                    { 621, "275 Newbridge Road", -33.928630512795003, 150.94764232635001, "2170", "NSW", "Moorebank", "MOOREBANK NSW" },
                    { 622, "15-17 Dowling Street", -33.380408141369998, 148.01078975201, "2871", "NSW", "Forbes", "FORBES NSW" },
                    { 623, "199 Maitland Streets Cnr Killarney ", -30.320678666696001, 149.78011965752, "2390", "NSW", "Narrabri", "NARRABRI NSW" },
                    { 624, "267 Dorset Road", -37.859307187620999, 145.28525769711001, "3155", "VIC", "Boronia", "BORONIA VIC" },
                    { 625, "The Hills Shopping Centre, Federal Rd (cnr Prospect Hwy)", -33.775187795299999, 150.93231081963, "2147", "NSW", "Seven Hills", "SEVEN HILLS CENTRE NSW" },
                    { 626, "Anchorage Drive Cnr Bergen Way", -31.677374725436, 115.71028232574, "6030", "WA", "Mindarie", "MINDARIE WA" },
                    { 627, "18 Albert Street", -33.652784600170001, 115.34363508224, "6280", "WA", "Busselton", "BUSSELTON WA" },
                    { 628, "Peninsula Fair Shopping Centre, 272 Anzac Avenue", -27.225841008336999, 153.08729410172, "4021", "QLD", "Kippa-Ring", "PENINSULA FAIR QLD" },
                    { 629, "Westfield Shoppingtown, Church Street", -33.817208393252002, 151.00223064423, "2150", "NSW", "Parramatta", "PARRAMATTA W/F L1 NSW" },
                    { 630, "Cnr Wyong Road & Mingara Drive", -33.362461483379001, 151.44372224808001, "2261", "NSW", "Tumbi Umbi", "MINGARA NSW" },
                    { 631, "Redbank Plaza Shopping Centre", -27.606184227071001, 152.8672349453, "4301", "QLD", "Redbank", "REDBANK PLAZA EXP QLD" },
                    { 632, "Cnr Conadilly & Elgin Streets", -30.978666922597, 150.25472044944999, "2380", "NSW", "Gunnedah", "GUNNEDAH NSW" },
                    { 633, "359-371 Esplanade", -37.880078485886003, 147.98711657524001, "3909", "VIC", "Lakes Entrance", "LAKES ENTRANCE VIC" },
                    { 634, "Cnr Holmes & Albion Streets", -37.761635481002997, 144.97358500957, "3057", "VIC", "Brunswick East", "BRUNSWICK EAST VIC" },
                    { 635, "276 Derrimut Road", -37.861257821022001, 144.68680139021001, "3029", "VIC", "Hoppers Crossing", "HOGANS CORNER VIC" },
                    { 636, "Cnr Kenihans & Regency Roads", -35.082730826850003, 138.56259584426999, "5159", "SA", "Happy Valley", "HAPPY VALLEY SA" },
                    { 637, "63 Victoria Parade", -32.499374460978999, 137.77826428412999, "5700", "SA", "Port Augusta", "PORT AUGUSTA SA" },
                    { 638, "Westland Shopping Centre, Nicolson Ave (Cnr Ekblom St)", -33.027321454800997, 137.53470897675001, "5608", "SA", "Whyalla", "WHYALLA SA" },
                    { 639, "84 Liverpool Street", -34.724132512993997, 135.86302220821, "5606", "SA", "Port Lincoln", "PORT LINCOLN SA" },
                    { 640, "575 North East Road", -34.856768777719999, 138.65566849709001, "5086", "SA", "Gilles Plains", "GILLES PLAINS SA" },
                    { 641, "Gold Coast Super Centre, Markeri St (cnr Bermuda St)", -28.047662422399998, 153.40810239314999, "4218", "QLD", "Mermaid Waters", "MERMAID WATERS QLD" },
                    { 642, "64 Ferry Road", -27.976997201309, 153.41154634953, "4215", "QLD", "Southport", "SOUTHPORT II QLD" },
                    { 643, "335 Wagga Highway", -36.050296758130003, 146.93558493969999, "2641", "NSW", "Lavington", "LAVINGTON NSW" },
                    { 644, "Cnr Cowpasture & Nth Liverpool Roads", -33.894312782614001, 150.85797071457, "2177", "NSW", "Bonnyrigg", "BONNYRIGG HEIGHTS NSW" },
                    { 645, "467 Pacific Highway", -33.408660124969998, 151.35098755359999, "2250", "NSW", "Wyoming", "WYOMING NSW" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 646, "582-586 Parramatta Road", -33.874384041444003, 151.12691581249001, "2132", "NSW", "Croydon", "CROYDON NSW" },
                    { 647, "151 Popendetta Rd (Cnr Jersey Road)", -33.743179288794998, 150.8102273941, "2770", "NSW", "Emerton", "EMERTON II NSW" },
                    { 648, "1 Princes Highway", -34.403014784241002, 150.8919864893, "2519", "NSW", "Fairy Meadow", "FAIRYMEADOW II NSW" },
                    { 649, "188-200 Byron Street", -29.770957094928999, 151.11506044865001, "2360", "NSW", "Inverell", "INVERELL NSW" },
                    { 650, "145-157 Pease Street", -16.912650168195, 145.74003160000001, "4870", "QLD", "Cairns", "MANOORA QLD" },
                    { 651, "Caltex Service Station Northbound", -28.093242692514, 153.39102208614, "4228", "QLD", "Reedy Creek", "REEDY CREEK QLD" },
                    { 652, "Cnr Margaret & Dent Streets", -27.560933322436, 151.94910443849, "4350", "QLD", "Toowoomba", "GRAND CENTRAL QLD" },
                    { 653, "Morayfield Shopping Centre, Morayfield Rd", -27.103416154617001, 152.95062482357, "4506", "QLD", "Morayfield", "Morayfield Shopping Centre" },
                    { 654, "Canterbury Street", -28.862833185010999, 153.04517805576, "2470", "QLD", "Casino", "CASINO NSW" },
                    { 655, "Cnr Gold Coast Highway & Australia Avenue", -28.025517338770001, 153.42955470084999, "4218", "QLD", "Broadbeach", "BROADBEACH II QLD" },
                    { 656, "42-46 Currie Street", -26.625255029441, 152.95880824327, "4560", "QLD", "Nambour", "NAMBOUR QLD" },
                    { 657, "78-80 Coonan Street", -27.499587832096999, 152.97614872456001, "4068", "QLD", "Indooroopilly ", "INDOOROOPILLY II" },
                    { 658, "114-120 Brisbane Street", -27.982577844525999, 152.99468278885001, "4285", "QLD", "Beaudesert", "BEAUDESERT QLD" },
                    { 659, "Cnr Springfield Lakes Boulevard & Centenary Hwy", -27.668867556256, 152.91629791259999, "4300", "QLD", "Springfield", "SPRINGFIELD LAKES QLD" },
                    { 660, "15 Gisborne Road", -37.673855750660003, 144.43577528, "3340", "VIC", "Bacchus Marsh", "BACCHUS MARSH VIC" },
                    { 661, "144-146 Condon Street", -36.774137612187999, 144.30604755877999, "3550", "VIC", "Bendigo", "STRATH VILLAGE VIC" },
                    { 662, "Cnr Princes Highway & South Valley Road", -38.197032539826999, 144.31722700596001, "3221", "VIC", "Waurn Ponds", "WAURN PONDS VIC" },
                    { 663, "Westfield Shopping Centre, Dromana Ave", -37.715568970893003, 144.88307118416, "3042", "VIC", "Airport West", "AIRPORT WEST VIC" },
                    { 664, "Karratha City Shopping Centre, Welcome Rd", -20.735723938583, 116.84727877378, "6714", "WA", "Karratha", "KARRATHA WA" },
                    { 665, "113-119 Gill Street", -20.076346999999998, 146.2600693, "4820", "QLD", "Charters Towers", "CHARTERS TOWERS QLD" },
                    { 666, "24 Sharp Street", -36.232145280494002, 149.13305282593001, "2630", "NSW", "Cooma", "COOMA NSW" },
                    { 667, "506-510 Middleborough Road", -37.809609128692003, 145.14100983738999, "3130", "VIC", "Box Hill North", "BOX HILL NORTH VIC" },
                    { 668, "Whitsunday Village Shopping Centre, Shute Harbour Rd", -20.269091434650999, 148.71889024973001, "4802", "QLD", "Airlie Beach", "AIRLIE BEACH QLD" },
                    { 669, "Lanyon Marketplace, Box Hill Ave", -35.457689970080999, 149.09170925616999, "2906", "ACT", "Conder", "CONDER ACT" },
                    { 670, "Altone Park Shopping Centre, Altone Road", -31.870906593697999, 115.94517946243, "6063", "WA", "Beechboro", "BEECHBORO WA" },
                    { 671, "Cnr Sydney & Shakespeare Streets", -21.147745776518001, 149.18582797049999, "4740", "QLD", "Mackay", "MACKAY EAST QLD" },
                    { 672, "Rockdale Plaza, 616 Princes Highway", -33.957528418408998, 151.13926470280001, "2216", "NSW", "Rockdale", "ROCKDALE PLAZA NSW" },
                    { 673, "Cairns Central Shopping Centre, McLeod Street", -16.925378099164, 145.77223420143, "4870", "QLD", "Cairns", "CAIRNS CENTRAL QLD" },
                    { 674, "90-106 Albany Highway", -35.018750379438004, 117.88084924221, "6330", "WA", "Albany", "ALBANY WA" },
                    { 675, "208 Warnbro Sound Avenue", -32.347264668842001, 115.76175928116, "6169", "WA", "Warnbro", "WARNBRO WA" },
                    { 676, "Cnr Bell & Sussex Streets", -37.739040637786999, 144.9481523037, "3044", "VIC", "Pascoe Vale", "PASCOE VALE SOUTH VIC" },
                    { 677, "Epping Plaza Shopping Centre, High St (cnr Cooper St)", -37.653536097501998, 145.01941323279999, "3076", "VIC", "Epping", "PACIFIC PLAZA VIC" },
                    { 678, "Carousel Shopping Centre, Albany Hwy (cnr Cecil Ave)", -32.018374053561999, 115.93778729439001, "6107", "WA", "Cannington", "CAROUSEL FOODCOURT WA" },
                    { 679, "Yamanto Shopping Village, Warwick Road", -27.662177977646, 152.73908436298001, "4305", "QLD", "Yamanto", "YAMANTO QLD" },
                    { 680, "1802 David Low Way", -26.529354057157999, 153.09073805809001, "4573", "QLD", "Coolum Beach", "COOLUM BEACH QLD" },
                    { 681, "Blacktown Railway Concourse", -33.768552486880999, 150.90708732605, "2148", "NSW", "Blacktown", "BLACKTOWN RWAY CONC NSW" },
                    { 682, "127-129  Bridge & Cnr Smyth Streets", -36.550379497469997, 145.98792672157001, "3672", "VIC", "Benalla", "BENALLA VIC" },
                    { 683, "794-796 Woodville Road", -33.877470517600003, 150.97998440265999, "2163", "NSW", "Villawood", "VILLAWOOD II NSW" },
                    { 684, "201 Manning River Drive", -31.935860000000002, 152.46838, "2430", "NSW", "Glenthorne", "TAREE SOUTH SERVICE CENTRE NSW" },
                    { 685, "Cnr Main Street & Silo Road", -17.267567938100999, 145.47456264496, "4883", "QLD", "Atherton", "ATHERTON QLD" },
                    { 686, "South Hedland Shopping Centre, Throssell Street", -20.409829260395998, 118.59872102737, "6721", "WA", "South Hedland", "PORT HEDLAND WA" },
                    { 687, "237 Forest Lake Boulevard", -27.623196391760001, 152.96911597252, "4077", "QLD", "Forest Lake", "FOREST LAKE QLD" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 688, "Cnr Olympic Park Way & Mid Western Highway", -33.835684503757001, 148.68057489394999, "2794", "NSW", "Cowra", "COWRA NSW" },
                    { 689, "162 Somerville Road", -37.812610751809999, 144.88413333893001, "3013", "VIC", "Yarraville", "YARRAVILLE II VIC" },
                    { 690, "1736-1740 Dandenong Road", -37.913710905126997, 145.12499034404999, "3168", "VIC", "Clayton", "CLAYTON II VIC" },
                    { 691, "Arndale Shopping Centre, Cnr Hanson & Torrens Rd", -34.874753187449997, 138.54969978333, "5009", "SA", "Kilkenny", "ARNDALE SA" },
                    { 692, "Hampshire Road", -37.782159760052998, 144.83112692933, "3020", "VIC", "Sunshine", "SUNSHINE MARKET PLACE VIC" },
                    { 693, "Indooroopilly Shoppingtown, 322 Moggill Road", -27.498345904947001, 152.97286033629999, "4068", "QLD", "Indooroopilly", "INDOOROOPILLY F/C QLD" },
                    { 694, "Westfield Shoppingtown, Dickson St", -27.307402550382001, 152.99085609535001, "4500", "QLD", "Strathpine", "STRATHPINE II QLD" },
                    { 695, "Cnr Sunnyholt Road & Third Avenue", -33.766389657707997, 150.91196358203999, "2148", "NSW", "Blacktown", "BLACKTOWN II NSW" },
                    { 696, "114 Lambton Road", -32.923208419384999, 151.72723174095, "2292", "NSW", "Broadmeadow", "BROADMEADOW II NSW" },
                    { 697, "Cnr Melbourne Drive & Centre Road", -37.669817742116003, 144.84909296036, "3043", "VIC", "Tullamarine", "MELB AIRPORT II VIC" },
                    { 698, "Cnr Somerton Road & David Munroe Drive", -37.640156487405001, 144.92956995963999, "3064", "VIC", "Roxburgh Park", "ROXBURGH PARK VIC" },
                    { 699, "St Johns Road", -33.255116532233998, 151.40274345875, "2259", "NSW", "Jilliby", "F3 NORTH (WYONG NTH) NSW" },
                    { 700, "St Johns Road", -33.254508000000001, 151.40495799999999, "2259", "NSW", "Warnervale", "F3 SOUTH (WYONG STH) NSW" },
                    { 701, "513-517 Pacific Highway", -33.678532714192997, 151.11110150814, "2079", "NSW", "Mount Colah", "MT COLAH NSW" },
                    { 702, "St Clair Shopping Centre, Cnr Bennett Rd & Endeavour Rd", -33.794854362484003, 150.78994989394999, "2759", "NSW", "St Clair", "ST CLAIR NSW" },
                    { 703, "290 Enoggera Road", -27.432448970513999, 153.00475716591001, "4000", "QLD", "Newmarket", "NEWMARKET II QLD" },
                    { 704, "41 Emily Street", -37.020106767531999, 145.12845575809001, "3660", "VIC", "Seymour", "SEYMOUR VIC" },
                    { 705, "63-69 Geelong Road", -38.325426239831998, 144.31699097156999, "3228", "VIC", "Torquay", "TORQUAY VIC" },
                    { 706, "BP Travel Centre,Pacific Highway", -28.244076185118001, 153.55760067700999, "2487", "NSW", "Chinderah", "BP CHINDERAH " },
                    { 707, "48 Park Street", -23.132299512427, 150.73769509792001, "4703", "QLD", "Yeppoon", "YEPPOON QLD" },
                    { 708, "Cnr Aerodrome Rd & Wirraway Street", -26.661561223593999, 153.10235202312001, "4558", "QLD", "Maroochydore", "MAROOCHYDORE II QLD" },
                    { 709, "Gateways Shopping Centre, Cnr Beeliar Drive & Kwinana Freeway", -32.129945805273998, 115.85402190684999, "6164", "WA", "Success", "THOMSONS LAKE WA" },
                    { 710, "Warringah Mall, Pittwater Road", -33.767678442901001, 151.26553773879999, "2100", "NSW", "Brookvale", "WARRINGAH MALL F/C NSW" },
                    { 711, "1239 Nepean Highway", -37.958857999999999, 145.05497500000001, "3192", "VIC", "Cheltenham", "SOUTHLAND VIC" },
                    { 712, "1239 Nepean Highway ", -37.957929999999998, 145.053045, "3192", "VIC ", "Cheltenham", "SOUTHLAND FOODCOURT VIC  " },
                    { 713, "Commercial Road", -35.185836359648, 138.47784474491999, "5169", "SA", "Seaford", "SEAFORD SA" },
                    { 714, "Cnr Camden Valley Way & Ash Road", -33.955501634949997, 150.87202548981, "2170", "NSW", "Prestons", "PRESTONS NSW" },
                    { 715, "Watergardens Shopping Centre, 399 Melton Hwy", -37.699104887095999, 144.77631902754001, "3038", "VIC", "Taylors Lakes", "WATERGARDENS VIC" },
                    { 716, "Imperial Shopping Centre, 171 Mann St", -33.425343649269998, 151.34367585182, "2250", "NSW", "Gosford", "GOSFORD IMPERIAL NSW" },
                    { 717, "600 Main North Road", -34.686472963541, 138.69088321923999, "5114", "SA", "Smithfield", "SMITHFIELD SA" },
                    { 718, "Grand Plaza Shopping Centre, Browns Plains Rd", -27.662550000336001, 153.04065666235999, "4118", "QLD", "Browns Plains", "GRAND PLAZA QLD" },
                    { 719, "Ibis Hotel", -33.848382842816001, 151.06757730245999, "2140", "NSW", "Homebush Bay", "OLYMPIC BOULEVARD NSW" },
                    { 720, "Arrivals Terminal, Sydney International Airport", -33.935669537274002, 151.16672515869001, "2020", "NSW", "Mascot", "INTERNATIONAL ARRIVALS NSW" },
                    { 721, "201 Pacific Highway", -33.822567589370003, 151.19448065757999, "2065", "NSW", "St Leonards", "ST LEONARDS NSW" },
                    { 722, "Cnr Market & Monaro Streets", -36.889961186297, 149.91056084632999, "2548", "NSW", "Merimbula", "MERIMBULA NSW" },
                    { 723, "Westfield Burwood, 100 Burwood Road", -33.874183617055003, 151.10468029975999, "2134", "NSW", "Burwood", "BURWOOD WESTFIELD NSW" },
                    { 724, "1268 Heathcote Road (cnr Princes Highway)", -34.078791540208996, 151.0112670064, "2233", "NSW", "Heathcote", "HEATHCOTE NSW" },
                    { 725, "256 Craigieburn Road West", -37.596301205671999, 144.92144286633001, "3064", "VIC", "Craigieburn", "CRAIGIEBURN VIC" },
                    { 726, "Karingal Hub Shopping Centre, 330 Cranbourne Rd", -38.152305649675, 145.16567409039001, "3199", "VIC", "Karingal", "KARINGAL HUB VIC" },
                    { 727, "Harbourtown S/C, Cnr Gold Coast Hwy & Oxley Drive", -27.933005311641999, 153.39013586025999, "4217", "QLD", "Biggera Waters", "HARBOUR TOWN QLD" },
                    { 728, "BP Travel Centre, Exit 54, Pacific Motorway", -27.860571754502999, 153.30852270125999, "4209", "QLD", "Coomera", "BP COOMERA QLD" },
                    { 729, "BP Service Centre, Pacific Motorway", -27.732436106055999, 153.22838902473001, "4207", "QLD", "Stapylton", "BP STAPYLTON QLD" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 730, "Westfield Shoppingtown, Gympie Rd", -27.382971258478999, 153.03179383278001, "4032", "QLD", "Chermside", "CHERMSIDE F/C QLD" },
                    { 731, "Cnr King Street & Northcliffe Drive", -34.486864900758, 150.88711559772, "2502", "NSW", "Warrawong", "WARRAWONG II NSW" },
                    { 732, "Coffs Harbour Service Centre Pacific Hwy", -30.317960444745001, 153.08960080147, "2450", "NSW", "Coffs Harbour", "COFFS SERVICE CENTRE NSW" },
                    { 733, "240 McCullough Cnr Canna Streets", -27.571319814746001, 153.06183993816001, "4109", "QLD", "Sunnybank", "SUNNYBANK QLD" },
                    { 734, "15 Park Beach Road", -30.283121632429001, 153.12827289104001, "2450", "NSW", "Coffs Harbour", "COFFS NORTH NSW" },
                    { 735, "Cnr Milton Road & Granzella Street", -27.467369328533, 153.00799190998001, "4064", "QLD", "Milton", "MILTON QLD" },
                    { 736, "13-17 Ryley Street", -36.358463421640003, 146.31726443768, "3677", "VIC", "Wangaratta", "WANGARATTA VIC" },
                    { 737, "Cnr Taylors & Kings Roads", -37.726932358950997, 144.78141278027999, "3037", "VIC", "Delahey", "DELAHEY VIC" },
                    { 738, "2-10 Orange Grove Road", -33.907545566031999, 150.91902315617, "2170", "NSW", "Liverpool", "LIVERPOOL MEGA CENTRE NSW" },
                    { 739, "603 Princes Highway", -33.956896583301003, 151.13737106323001, "2216", "NSW", "Rockdale", "ROCKDALE NSW" },
                    { 740, "39 Boorowa Road", -34.313489037121002, 148.29969584942, "2594", "NSW", "Young", "YOUNG NSW" },
                    { 741, "Cnr 19th Avenue & Gold Coast Highway", -28.109007509173999, 153.46543729305, "4221", "QLD", "Palm Beach", "PALM BEACH QLD" },
                    { 742, "Cnr Coach Road West & Gympie Highway", -27.123948181117001, 152.97827839851001, "4505", "QLD", "Burpengary", "BP CABOOLTURE NORTHBOUND QLD" },
                    { 743, "176 Old Coach Rd East", -27.123938632213001, 152.97616481781, "4505", "QLD", "Burpengary", "BP CABOOLTURE SOUTHBOUND QLD" },
                    { 744, "Cnr Bacchus Marsh & Purnell Roads", -38.074835369266999, 144.35648918152, "3214", "VIC", "Corio", "CORIO VILLAGE VIC" },
                    { 745, "BP Service Centre, Western Highway", -37.591867922962003, 144.24216270446999, "3342", "VIC", "Ballan", "BALLAN WESTBOUND VIC" },
                    { 746, "Hornsby Westfield Shopping Centre", -33.705027317606003, 151.09920859337001, "2077", "NSW", "Hornsby", "HORNSBY WESTFIELD NSW" },
                    { 747, "The Marketplace Shopping Centre Cnr Nicklin Way &Bellara Drive", -26.773229033538001, 153.12365949154, "4551", "QLD", "Currimundi", "CURRIMUNDI II QLD" },
                    { 748, "1006 Wynnum Road", -27.468851967237001, 153.09392988682001, "4170", "QLD", "Cannon Hill", "CANNON HILL QLD" },
                    { 749, "Cnr Springvale & Heatherton Roads", -37.961853209235002, 145.15116870403, "3171", "VIC", "Springvale", "SPRINGVALE" },
                    { 750, "317 Cheltenham Road", -37.992510080384001, 145.17321109772001, "3173", "VIC", "Keysborough", "PARKMORE SHOPPING CENTRE VIC" },
                    { 751, "Cnr Horsley Drive & Court Road", -33.868885561722998, 150.95757991075999, "2165", "NSW", "Fairfield", "FAIRFIELD II NSW" },
                    { 752, "Harbourside Shopping Centre", -33.871573603149997, 151.19913697243001, "2000", "NSW", "Darling Harbour", "HARBOURSIDE NSW" },
                    { 753, "Tiffany Plaza, 422 Oxford Street", -33.891389449729999, 151.24841183423999, "2022", "NSW", "Bondi Junction", "BONDI JUNCTION INTERCHANGE NSW" },
                    { 754, "Ann Street Shop 3 The Concourse", -27.465965206076, 153.02592515945, "4000", "QLD", "Brisbane", "CENTRAL STATION QLD" },
                    { 755, "92-94 Fay Avenue", -35.140710786501003, 147.37598329782, "2650", "NSW", "Kooringal", "WAGGA KOORINGAL NSW" },
                    { 756, "North Ward Shopping Centre, Eyre Street", -19.251892643392999, 146.81388348341, "4810", "QLD", "Townsville", "NORTH WARD QLD" },
                    { 757, "Cnr Mayfair Lane & New England Highway", -28.630849297164001, 151.95383548736999, "4380", "QLD", "Stanthorpe", "STANTHORPE QLD" },
                    { 758, "Cnr Guildford & Caledonian Roads", -31.928973174814999, 115.89696407318, "6062", "WA", "Maylands", "MAYLANDS WA" },
                    { 759, "BP Service Centre, Calder Hwy", -37.665669107044003, 144.75369751452999, "3036", "VIC", "Keilor North", "Calder Highway Southbound" },
                    { 760, "184-188 Georges River Road", -33.895915786288001, 151.10762000084, "2133", "NSW", "Croydon Park", "CROYDON PARK NSW" },
                    { 761, "Cnr Luttrell Street & Glenmore Parkway", -33.789883530269996, 150.66888570786, "2745", "NSW", "Glenmore Park", "GLENMORE PARK NSW" },
                    { 762, "Cnr Ernest Cavanaugh & Gozzard Streets", -35.183991399999996, 149.06257400000001, "2912", "ACT", "Gungahlin", "GUNGAHLIN ACT" },
                    { 763, "608 Hay Street", -31.954610996509, 115.86048603058001, "6001", "WA", "Perth", "HAY STREET EAST WA" },
                    { 764, "Nudgee Service Centre, 1097 Nudgee Road", -27.377474220197001, 153.09395670891001, "4014", "QLD", "Nudgee", "NUDGEE SERVICE CENTRE QLD" },
                    { 765, "1410-1424 Sydney Road", -37.690166898236001, 144.95888113976, "3060", "VIC ", "Fawkner", "FAWKNER II VIC" },
                    { 766, "275 Swanston Street", -37.811787516103003, 144.96463045478001, "3000", "VIC", "Melbourne", "SWANSTON & LONSDALE VIC" },
                    { 767, "Carlingford Shopping Centre, Cnr Pennant Hills Rd & Carlingford Rd", -33.776284712111, 151.05233430862, "2118", "NSW", "Carlingford", "CARLINGFORD FOOD COURT NSW" },
                    { 768, "120 Marine Parade", -28.167860792635999, 153.54271709919001, "4226", "QLD", "Coolangatta", "COOLANGATTA II QLD" },
                    { 769, "Bryants Road", -27.663555836267999, 153.1790471077, "4129", "QLD", "Loganholme", "LOGANHOLME II QLD" },
                    { 770, "50-52 Shore Street", -27.523519552347, 153.25630545615999, "4160", "QLD", "Ormiston", "CLEVELAND QLD" },
                    { 771, "Cnr Stuart & Fairfield Waters Drives", -19.309196774579998, 146.80635720491, "4810", "QLD", "Townsville", "FAIRFIELD WATERS QLD" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 772, "1 Resolution Place", -33.684800032405001, 150.91802537441001, "2155", "NSW", "Rouse Hill", "ROUSE HILL NSW" },
                    { 773, "Cnr Princes Highway & Parsons Street", -35.364682744371002, 150.47216176987001, "2541", "NSW", "Ulladulla", "ULLADULLA NSW" },
                    { 774, "Cnr Thornton Road & New England Highway", -32.793051387955003, 151.63424223660999, "2322", "NSW", "Thornton", "THORNTON NSW" },
                    { 775, "BP Service Centre, Calder Hwy", -37.664860159882998, 144.74764913320999, "3036", "VIC", "Keilor North", "CALDER NORTHBOUND VIC" },
                    { 776, "Cnr Westernport Highway & Hall Road", -38.108281545605998, 145.23228406906, "3977", "VIC", "Skye", "SKYE VIC" },
                    { 777, "Cnr Billson & Graham Streets", -38.606718133869002, 145.58813810349, "3995", "VIC", "Wonthaggi", "WONTHAGGI VIC" },
                    { 778, "30 Dalton Roads (cnr Settlement Rd)", -37.688429604794997, 145.02916976809999, "3074", "VIC", "Thomastown", "THOMASTOWN II VIC" },
                    { 779, "10691 - 10699 Princess Highway", -38.385598087712999, 142.53398716449999, "3280", "VIC", "Warrnambool", "WARRNAMBOOL EAST VIC" },
                    { 780, "Paralowie Shopping Centre Boliver Road", -34.758687733400997, 138.59668135643, "5108", "SA", "Paralowie", "PARALOWIE SA" },
                    { 781, "The Promenade Regional Shopping Centre, Cnr Main St & The Promenade", -31.781047659224001, 115.96964120865, "6069", "WA", "Ellenbrook", "ELLENBROOK WA" },
                    { 782, "530 Kalamunda Road", -31.935137466088001, 116.00426852703001, "6057", "WA", "High Wycombe", "HIGH WYCOMBE WA" },
                    { 783, "Bussell Highway", -33.360030828802003, 115.64343094826, "6230", "WA", "Carey Park", "BUNBURY SOUTH WA" },
                    { 784, "Sir Reginald Ansett Drive", -34.947464948573, 138.5188087821, "5950", "SA", "West Beach", "WEST BEACH SA" },
                    { 785, "1A Butler Road", -33.944959802653997, 151.18467986584, "2020", "NSW", "Mascot", "GENERAL HOLMES DRIVE NSW" },
                    { 786, "66-84 High Street", -37.689360340672998, 144.60411608218999, "3337", "VIC", "Melton East", "MELTON EAST VIC" },
                    { 787, "5 Police Close", -37.729486547504997, 144.74120378494001, "3023", "VIC", "Caroline Springs", "CAROLINE SPRINGS VIC" },
                    { 788, "Old Coast Road", -32.584902498422998, 115.65978169441, "6210", "WA", "Falcon", "FALCON WA" },
                    { 789, "Cnr Clyde & Homestead Roads", -38.055907986511002, 145.33836275338999, "3806", "VIC", "Berwick", "BERWICK SOUTH VIC" },
                    { 790, "1 Discovery Drive", -27.241392816346998, 153.02380353212001, "4509", "QLD", "Mango Hill", "NORTH LAKES QLD" },
                    { 791, "BP Service Centre 1015 Hume Freeway", -37.402457276382002, 145.01503586768999, "3756", "VIC", "Wallan", "WALLAN NTH VIC" },
                    { 792, "Manor Lakes Boulevarde (Cnr Ballan Rd)", -37.876055959775996, 144.61559057235999, "3024", "VIC", "Wyndham Vale", "MANOR LAKES VIC" },
                    { 793, "32 Albert Street", -37.58493906156, 143.84037852287, "3356", "VIC", "Sebastopol", "SEBASTOPOL VIC" },
                    { 794, "1050 Hume Freeway", -37.403411831154003, 145.01703411341001, "3756", "VIC", "Wallan", "WALLAN STH VIC" },
                    { 795, "53-55 Telford Street", -36.018303143235002, 146.00452959538001, "3730", "VIC", "Yarrawonga", "YARRAWONGA VIC" },
                    { 796, "36 Hoddle Street", -37.808014499891001, 144.99192327260999, "3067", "VIC ", "Abbotsford", "HODDLE ST VIC" },
                    { 797, "Cnr Minjungbal Drive & Parry Street", -28.193695117642999, 153.54112386703, "2486", "QLD", "Tweed Heads South", "TWEED HEADS SOUTH NSW" },
                    { 798, "1789-1913 Western Highway", -37.706764, 144.62924100000001, "3335", "VIC", "Rockbank", "ROCKBANK INBOUND VIC" },
                    { 799, "Glenfield Street", -35.129596312543001, 147.34207749366999, "2650", "NSW", "Wagga Wagga", "WAGGA GLENFIELD NSW" },
                    { 800, "Cnr Reservoir & Holbeche Roads", -33.793173673932003, 150.89742064475999, "2148", "NSW", "Blacktown", "ARNDELL PARK NSW" },
                    { 801, "Cnr Palm & Pine Avenues", -34.551223745434001, 146.39948487282001, "2705", "NSW", "Leeton", "LEETON NSW" },
                    { 802, "Cnr Meade Street & New England Highway", -29.737546458935, 151.73750996589999, "2370", "NSW", "Glen Innes", "GLEN INNES NSW" },
                    { 803, "25 Fitzroy Street", -35.299632496324001, 148.22382688522001, "2720", "NSW", "Tumut", "TUMUT NSW" },
                    { 804, "Cnr Main & High Streets", -35.92124741248, 145.64888477324999, "3644", "VIC", "Cobram", "COBRAM VIC" },
                    { 805, "206-218 Sanger Street", -35.995377412461004, 146.39080524445001, "2646", "VIC", "Corowa", "COROWA VIC" },
                    { 806, "9 Ross Smith Avenue", -33.932743171897002, 151.18861198425, "2020", "NSW", "Mascot", "SYDNEY AIRPORT - GATEWAY NSW" },
                    { 807, "57 Seaby Street", -37.063999948464001, 142.76544034481, "3380", "VIC", "Stawell", "STAWELL VIC" },
                    { 808, "18 Nicklin Way", -26.701481344449999, 153.1256121397, "4575", "QLD", "Minyama", "MINYAMA QLD" },
                    { 809, "15 Argyle Street", -34.053023873299999, 150.69878697395001, "2570", "NSW", "Camden", "CAMDEN II NSW" },
                    { 810, "Cnr Ramrod Road & Lonsdale Highway", -35.077862363889999, 138.51792097091999, "5158", "SA", "Hallett Cove", "HALLETT COVE SA" },
                    { 811, "Cnr Dora & Ourimbah Streets", -33.111300790248002, 151.48227632045999, "2264", "NSW", "Morisset", "MORISSET" },
                    { 812, "90 Days Road", -27.853367483635001, 153.29996109008999, "4209", "QLD", "Upper Coomera", "UPPER COOMERA QLD" },
                    { 813, "97 Limestone Street", -27.615199244740001, 152.7550059557, "4305", "QLD", "Ipswich", "IPSWICH CBD QLD" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 814, "49 Eramosa Road West", -38.223406251823, 145.16965985298, "3912", "VIC", "Somerville", "SOMERVILLE VIC" },
                    { 815, "1-9 Jamieson Way", -37.897021494371003, 144.75358486176, "3030", "VIC", "Point Cook", "POINT COOK VIC" },
                    { 816, "101 Whylandra Street", -32.251476137106003, 148.59023809433, "2830", "NSW", "Dubbo West", "DUBBO WEST NSW" },
                    { 817, "Cnr Redlynch Connection & Larsen Roads", -16.894860417865001, 145.69969117641, "4870", "QLD", "Redlynch", "REDLYNCH QLD" },
                    { 818, "18 Beerburrum Road", -27.082464831275999, 152.95203030108999, "4510", "QLD", "Caboolture", "CABOOLTURE CITY QLD" },
                    { 819, "Throssell Street", -33.360216770674, 116.15419328213, "6225", "WA", "Collie", "COLLIE WA" },
                    { 820, "Peel Terrace", -31.650011336475998, 116.67779266834, "6401", "WA", "Northam", "NORTHAM WA" },
                    { 821, "169-175 Numurkah Road", -36.354771814260999, 145.40271162987, "3630", "VIC", "Shepparton", "SHEPPARTON NORTH VIC" },
                    { 822, "570 Fifteenth Street", -34.219895588065, 142.15107768774001, "3500", "VIC", "Mildura", "IRYMPLE VIC" },
                    { 823, "236-240 Bridge Street (Cnr Phillip St)", -31.095395197609999, 150.91328322887, "2340", "NSW", "Tamworth", "TAMWORTH WEST NSW" },
                    { 824, "411-423 Bell Street (Cnr St Georges Road)", -37.744835280102002, 144.99697387218001, "3072", "VIC", "Preston", "PRESTON II VIC" },
                    { 825, "65 Princes Freeway", -38.073481775170997, 145.38963566576001, "3809", "VIC", "Officer", "PAKENHAM BYPASS OUTBOUND" },
                    { 826, "Cnr Common Street & Sydney Road", -34.747651382251, 149.74733233452, "2580", "NSW", "Goulburn", "GOULBURN NSW" },
                    { 827, "57-67 Roberts Road", -33.901461400000002, 151.0664104, "2190", "NSW", "Greenacre", "GREENACRE II" },
                    { 828, "208-210 North West Coastal Highway", -28.757268199999999, 114.6252703, "6530", "WA", "Webberton", "GERALDTON HOMEMAKER CENTRE WA" },
                    { 829, "Cnr North East & Reservoir Roads", -34.831645203389002, 138.68837803602, "5029", "SA", "Modbury", "TEA TREE PLAZA II SA" },
                    { 830, "Royal Childrens Hospital, Flemington Rd", -37.794948902119998, 144.94967579842, "3052", "VIC", "Parkville", "ROYAL CHILDRENS HOSPITAL VIC" },
                    { 831, "Cnr Beeliar & Durnin Avenue", -32.127822975675997, 115.79679142153, "6164", "WA", "Beeliar", "BEELIAR VILLAGE WA" },
                    { 832, "264 Dohles Rocks Road", -27.265827000000002, 153.00701900000001, "4503", "QLD", "Murrumba Downs", "MURRUMBA DOWNS QLD" },
                    { 833, "Cnr Hamilton Road & Charlotte Street", -27.386766999999999, 153.03295299999999, "4032", "QLD", "Chermside", "CHERMSIDE QLD" },
                    { 834, "Canberra Centre, Bunda Street", -35.279020199999998, 149.13324900000001, "2601", "ACT", "Canberra", "CANBERRA CENTRE II ACT" },
                    { 835, "1906 Dawson Highway (cnr Bruce Hwy)", -23.983243000000002, 151.21204, "4680", "QLD", "Calliope", "CALLIOPE TRAVEL CENTRE QLD" },
                    { 836, "386-388 Churchill Road", -34.860157361340001, 138.58350526692999, "5084", "SA", "Kilburn", "PROSPECT SA" },
                    { 837, "230 Tweed Valley Way", -28.326938299999998, 153.39585719999999, "2484", "NSW", "Murwillumbah", "MURWILLUMBAH NSW" },
                    { 838, "550 Kirkwood Road", -23.888139299999999, 151.21449920000001, "4032", "QLD", "Kirkwood", "GLADSTONE KIRKWOOD QLD" },
                    { 839, "Cnr Bridge Inn Rd & Yan Yean Rd", -37.606641000000003, 145.13721899999999, "3754", "VIC", "Doreen", "DOREEN VIC" },
                    { 840, "112-114 High Street", -32.676845, 151.38748100000001, "2334", "NSW", "Greta", "GRETA NSW" },
                    { 841, "55-95 Kulina Drive", -38.064146999999998, 144.33685, "3221", "VIC", "Lovely Banks", "GEELONG BYPASS NORTHBOUND VIC" },
                    { 842, "4288 Bruce Highway", -26.917862899999999, 152.99587249999999, "4519", "QLD", "Coochin Creek", "GLASS HOUSE MOUNTAINS QLD" },
                    { 843, "1529 Burwood Highway", -37.905968999999999, 145.343403, "3160", "VIC", "Tecoma", "TECOMA VIC" },
                    { 844, "Cnr Moreton Drive and Nancy Bird Way", -27.396638496697999, 153.10716685998, "4008", "QLD", "Brisbane Airport", "BRISBANE AIRPORT DRIVE" },
                    { 845, "97-99 Cheltenham Road", -37.990480400000003, 145.1990964, "3175", "VIC", "Dandenong", "DANDENONG VIC" },
                    { 846, "343 Milperra Road", -33.930435099999997, 150.99418549999999, "2200", "NSW", "Bankstown", "MILPERRA NSW" },
                    { 847, "110 Harvest Home Road", -37.6223727, 145.02975850000001, "3750", "VIC", "Wollert", "WOLLERT VIC" },
                    { 848, "1410 Thompsons Road", -38.084927720612001, 145.29406347528999, "3977", "VIC", "Cranbourne North", "CRANBOURNE NORTH VIC" },
                    { 849, "89 Keilor Park Drive", -37.718758299999998, 144.85298929999999, "3042", "VIC ", "Keilor Park", "KEILOR PARK VIC" },
                    { 850, "2 Forster Street", -33.964686999999998, 137.71619899999999, "5554", "SA", "Kadina", "KADINA SA" },
                    { 851, "Cnr Global Plaza & Tamborine-Oxenford Rd", -27.890183756894, 153.31180510422999, "4210", "QLD", "Oxenford", "OXENFORD QLD" },
                    { 852, "445 Stuart Highway", -12.521654, 131.04172399999999, "0835", "NT", "Coolalinga", "COOLALINGA NT" },
                    { 853, "74 Roberts Road", -33.892253500000002, 151.06658440000001, "2190", "NSW", "Greenacre", "GREENACRE NORTH NSW" },
                    { 854, "1-7 Swan Street", -36.674033000000001, 149.83744999999999, "2550", "NSW", "Bega", "BEGA NSW" },
                    { 855, "34 East Row", -35.278937999999997, 149.13085599999999, "2600", "ACT", "Canberra", "CANBERRA CITY ACT" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 856, "284-310  Lonsdale St", -37.810184999999997, 144.96858789999999, "3000", "VIC", "Melbourne", "MELBOURNE CENTRAL II VIC" },
                    { 857, "310-312 Plantation Road", -38.063191000000003, 144.33980700000001, "3214", "VIC", "Corio", "GEELONG BYPASS SOUTHBOUND VIC" },
                    { 858, "120-122 Spencer Street", -27.558900000000001, 152.27838199999999, "4343", "QLD", "Gatton", "GATTON CENTRAL QLD" },
                    { 859, "2150 Albany Highway", -32.068252299999997, 115.9993142, "6110", "WA", "Gosnells", "GOSNELLS WA" },
                    { 860, "160 Percy Street (cnr Fern Street)", -38.340392000000001, 141.60446999999999, "3305", "VIC", "Portland", "PORTLAND" },
                    { 861, "Cnr Hambledon Drive and Walker Road", -17.021636999999998, 145.72864569999999, "4869", "QLD", "Edmonton", "EDMONTON" },
                    { 862, "2 Chesterfield Road ", -31.870421, 115.85724500000001, "6061", "WA", "Mirrabooka ", "MIRRABOOKA II WA " },
                    { 863, "Cnr Farrell Road & Northern Distributor", -33.279201700000002, 149.0582632, "2800", "NSW", "ORANGE NORTH NSW", "ORANGE NORTH NSW" },
                    { 864, "2 Peony Boulevard", -31.550171800000001, 115.63938539999999, "6035", "WA", "YANCHEP", "YANCHEP" },
                    { 865, "61-69 Rainbow Street", -27.321664999999999, 153.06814, "4017", "QLD", "Sandgate", "SANDGATE" },
                    { 866, "Cnr Dalrymple Road and Thuringowa Drive", -19.302416300000001, 146.7351568, "4817", "QLD", "KIRWAN", "TOWNSVILLE THURINGOWA" },
                    { 867, "1952-1982 Camden Valley Way", -33.953229399999998, 150.85678899999999, "2174", "NSW", "Edmondson Park", "EDMONDSON PARK" },
                    { 868, "Shop 022, 174 - 200 Crown Street", -34.424587899999999, 150.8942418, "2500", "NSW", "Wollongong Central West", "Wollongong Central" },
                    { 869, "2 Butler Boulevard", -31.635713899999999, 115.70389659999999, "6036", "WA", "Butler", "BRIGHTON" },
                    { 870, "Cnr Pacific Hwy & London Drive", -33.265435099999998, 151.4551835, "2259", "NSW", "Wadalba", "WADALBA" },
                    { 871, "Corner Joondalup Drive & Pinjar Road", -31.730212999999999, 115.80601900000001, "6031", "WA", "Banksia Grove", "BANKSIA GROVE" },
                    { 872, "Lara Village Shopping Centre, Pt 120 Station Lake Road", -38.023748599999998, 144.40483259999999, "3212", "VIC", "LARA", "LARA" },
                    { 873, "1-3 Standing Drive", -38.191254000000001, 146.56259700000001, "3844", "VIC", "Traralgon East", "TRARALGON EAST" },
                    { 874, "90 Hall Road", -38.100881899999997, 145.18232019999999, "3201", "VIC", "CARRUM DOWNS", "CARRUM DOWNS" },
                    { 875, "Cnr Cowper Street & Kokera Street", -32.904037000000002, 151.666946, "2287", "NSW", "Wallsend", "WALLSEND" },
                    { 876, "230-240 Cranbourne Frankston Road", -38.150131999999999, 145.19635299999999, "3910", "VIC", "Langwarrin", "LANGWARRIN" },
                    { 877, "84-94 Osborne Avenue ", -37.945851400000002, 145.13959869999999, "3171", "VIC ", "Springvale", "CLAYTON SOUTH" },
                    { 878, "4 Cardinia Road", -38.072955299999997, 145.43538000000001, "3809", "VIC", "Officer", "OFFICER" },
                    { 879, "1 Chiswick Glade", -33.712897235962998, 150.84079107871, "2765", "NSW", "Marsden Park", "MARSDEN PARK" },
                    { 880, "8 Aitken Boulevard ", -37.5831917, 144.9129653, "3064", "VIC", "Craigieburn North", "CRAIGIEBURN NORTH" },
                    { 881, "Cnr Lakes Road & Minilya Parkway", -32.529789000000001, 115.7637265, "6210", "WA", "Greenfields", "MANDURAH GREENFIELDS" },
                    { 882, "Shop 20-21, 436 Victoria Avenue", -33.796855700000002, 151.18143409999999, "2067", "NSW", "Chatswood", "CHATSWOOD INTERCHANGE" },
                    { 883, "511 Pacific Highway South Kempsey", -31.122973999999999, 152.83154999999999, "2440", "NSW", "South Kempsey", "KEMPSEY SOUTH SERVICE CENTRE" },
                    { 884, "Cnr. Hammond Avenue & Kooringal Road", -35.1373994, 147.3885209, "2650", "NSW", "Wagga Wagga", "WAGGA EAST" },
                    { 885, "314 Victoria Road", -33.811194200000003, 151.03451939999999, "2116", "NSW", "Rydalmere", "RYDALMERE" },
                    { 886, "1 Coltman Plaza", -37.5437729, 143.7837293, "3350", "VIC", "Ballarat", "LUCAS" },
                    { 887, "1-3/1400 Peninsula Link", -38.202250999999997, 145.137902, "3911", "VIC", "BAXTER", "PENINSULA LINK SOUTHBOUND" },
                    { 888, "1789-1913 Western Highway", -37.739006700038999, 144.67994213104001, "3335", "VIC", "Rockbank", "ROCKBANK OUTBOUND VIC" },
                    { 889, "53 Darlington Drive", -28.213901, 153.54176000000001, "2886", "NSW", "Banora Point", "BANORA POINT NSW" },
                    { 890, "92 Radius Drive", -27.639475000000001, 153.01135500000001, "4110", "QLD", "LARAPINTA", "BP LOGAN MOTORWAY" },
                    { 891, "210 Ogden Street", -19.262181000000002, 146.815901, "4810", "QLD", "TOWNSVILLE", "TOWNSVILLE CBD" },
                    { 892, "Terminal 4 Airside", -37.673349999999999, 144.848727, "3043", "VIC", "TULLAMARINE", "MELBOURNE AIRPORT T4 VIC" },
                    { 893, "280 Berwick Cranbourne Road", -38.118634, 145.320379, "3978", "VIC", "Clyde", "CLYDE" },
                    { 894, "565 Derrimut Road", -37.8343931, 144.69096469999999, "3029", "VIC", "Tarneit", "TARNEIT VIC" },
                    { 895, "12-18 Kingston Road", -27.610091000000001, 153.11265, "4119", "Qld", "Underwood", "UNDERWOOD QLD" },
                    { 896, "Cnr Riverina Highway & Drome Street", -36.075961200000002, 146.94758089999999, "2640", "NSW", "Albury East", "ALBURY EAST NSW" },
                    { 897, "9 Herries Street", -27.567496999999999, 151.975132, "4350", "Qld", "Toowoomba East", "TOOWOOMBA EAST QLD" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 898, "BP Service Centre", -38.196465400000001, 145.1502438, "3911", "Vic", "Peninsula Link Northbound", "PENINSULA LINK NORTHBOUND" },
                    { 899, "Cnr Boat Harbour Drive & Margaret Street", -25.292529200000001, 152.8943304, "4655", "Qld", "Urangan", "URANGAN QLD" },
                    { 900, "Cnr Norton Promenade & Tiffany Centre", -33.394286899999997, 115.63525250000001, "6230", "WA", "Dalyellup", "DALYELLUP WA" },
                    { 901, "561 - 583 Polding Street, Shop F01, Stockland Mall", -33.858691999999998, 150.898743, "2164", "NSW", "Wetherill Park", "PRAIRIEWOOD FOODCOURT NSW" },
                    { 902, "77 Young Street", -38.134138, 145.857077, "3818", "VIC", "Drouin", "DROUIN VIC" },
                    { 903, "BP Service Centre, Leary Road", -32.310141399999999, 115.8319055, "6171", "WA", "Baldivis", "KWINANA FREEWAY SOUTHBOUND WA" },
                    { 904, "295 Woodville", -33.850523000000003, 150.997015, "2161", "NSW", "Guildford", "GUILDFORD NSW" },
                    { 905, "Shop 3028/9, Westfield Bondi Junction", -33.891669299999997, 151.2502695, "2022", "NSW", "Bondi", "BONDI WESTFIELD II NSW" },
                    { 906, "1 Robertson Road", -34.546461999999998, 150.37966549999999, "2577", "NSW", "Moss Vale", "MOSS VALE NSW" },
                    { 907, "Cnr George Street & Blacktown Road", -33.633621900000001, 150.7789415, "2756", "NSW", "South Windsor", "Bligh Park" },
                    { 908, "Cnr Nicholson Rd & Yellowwood Avenue", -32.127819199999998, 115.9253296, "6112", "WA", "Harrisdale", "Harrisdale" },
                    { 909, "1 Ross Street (Benowa Shopping Centre)", -28.002143, 153.383082, "4217", "QLD", "Benowa", "BENOWA QLD" },
                    { 910, "97C Sydney Road", -37.288074999999999, 144.94841199999999, "3764", "VIC", "Kilmore", "KILMORE, VIC" },
                    { 911, "182 Gainsborough Drive", -27.824253899999999, 153.31729809999999, "4209", "QLD", "Pimpama", "PIMPAMA, QLD" },
                    { 912, "BP Service Centre, Lot 191, Paparone Road", -32.310429200000002, 115.82839439999999, "6171", "WA", "Baldivis", "KWINANA FREEWAY NORTHBOUND WA" },
                    { 913, "7 Albatross Cresent", -33.320659999999997, 115.71509, "6232", "WA", "Eaton", "EATON" },
                    { 914, "67-69 Boundary Road ", -21.174956000000002, 149.1509623, "4740", "QLD", "Ooralea", "MACKAY SOUTH OORALEA" },
                    { 915, "Cnr. Secret Harbour Boulevard and Oneida Road", -32.410092800000001, 115.76040810000001, "6173", "WA", "Secret Harbour", "SECRET HARBOUR" },
                    { 916, "1341 Dandenong Rd", -37.886286699999999, 145.07612169999999, "3148", "VIC", "Chadstone", "Chadstone Shopping Centre" },
                    { 917, "C2-400 Terminal 1 Pier C, Sydney International Airport", -33.929099999999998, 151.18792999999999, "2020", "NSW", "Mascot", "International Airside II" },
                    { 918, "2 Stafford Street", -36.732473300000002, 144.2576316, "3556", "VIC", "California Gully", "California Gully" },
                    { 919, "585 - 595 Salisbury Highway (cnr. Greenfields Drive)", -34.799868400000001, 138.6080025, "5107", "SA", "Green Fields", "Green Fields" },
                    { 920, "6 Birak Lane", -33.689999999999998, 115.3, "6280", "WA", "Vasse", "Vasse, WA" },
                    { 921, "844-846 Canning Highway", -32.015329999999999, 115.84267, "6153", "WA", "Applecross", "Applecross II" },
                    { 922, "9402 Tweed Valley Way, ", -28.258111799999998, 153.5244179, "2487", "NSW", "Chinderah", "Chinderah Northbound" },
                    { 923, "133 Samantha Riley Drive", -33.699249999999999, 150.957381, "2155", "NSW", "Kellyville North", "KELLYVILLE NORTH NSW" },
                    { 924, "84-86 High Street", -37.412871899999999, 144.9798596, "3756", "VIC", "Wallan", "Wallan, Victoria" },
                    { 925, "827 Port Road", -34.878028200000003, 138.5321926, "5011", "SA", "Woodville", "Woodville, SA" },
                    { 926, "49 Banksiadale Gate", -32.469225700000003, 115.7635051, "6180", "WA", "Lakelands", "Lakelands" },
                    { 927, "1439 Beaudesert Road", -27.589057400000002, 153.0270749, "4110", "QLD", "Acacia Ridge", "Acacia Ridge, QLD" },
                    { 928, "1 Gateway Drive", -27.6697986, 152.89230649999999, "4300", "QLD", "Augustine Heights", "Augustine Heights" },
                    { 929, "5 Boggy Creek Road", -30.6265888, 152.9727742, "2448", "NSW", "Valla", "Nambucca Highway Service Centre" },
                    { 930, "332 Ripley Road", -27.655948800000001, 152.78030670000001, "4306", "QLD", "Ripley", "Ripley QLD" },
                    { 931, "64 Laidley Plainland Road", -27.566210699999999, 152.4234993, "4341", "QLD", "Plainland", "Plainland" },
                    { 932, "144 Flinders Parade", -27.220844499999998, 152.99936500000001, "4509", "QLD", "North Lakes", "North Lakes Business Park" },
                    { 933, "224 manning road", -32.011797000000001, 115.884512, "6152", "WA", "karawara", "KARAWARA, WA" },
                    { 934, "130 Queen Street", -27.469627899999999, 153.02488439999999, "4000", "QLD", "Brisbane City", "QUEEN STREET" },
                    { 935, " Pinjarra Road", -32.535691800000002, 115.7418267, "6210", "WA", "Mandurah", "MANDURAH FORUM II" },
                    { 936, "103 Plunkett St", -34.878624700000003, 150.60412840000001, "2541", "NSW", "Nowra", "NOWRA CENTRAL" },
                    { 937, "1/17 River Hills Rd", -27.70073, 153.1983736, "4207", "QLD", "Eagleby", "EAGLEBY" },
                    { 938, "43/35 Yarrabilba Dr", -27.8019076, 153.10313780000001, "4207", "QLD", "Yarrabilba", "Yarrabilba" },
                    { 939, "101 Raby Rd", -34.005978399999996, 150.7949017, "2557", "NSW", "Leppington", "Emerald Hills" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 940, "722-770 Barwon Heads Rd", -38.230694999999997, 144.37287000000001, "3217", "VIC", "Armstrong Creek", "WARRALILY" },
                    { 941, " 800 Berwick-Cranbourne Rd", -38.078144000000002, 145.335094, "3978", "VIC", "Clyde North", "Clyde North" },
                    { 942, "Stockland Green Hills Shopping Centre 1 Molly Morgan Dr", -32.762504999999997, 151.591542, "2323", "NSW", "East Maitland", "MAITLAND FOOD COURT II" },
                    { 943, "168 Bourke St", -37.812514999999998, 144.96823699999999, "3000", "VIC", "Melbourne", "Bourke & Russell" },
                    { 944, "Tenancy BF-20 T1 Terminal – Departures Lounge Sydney International Airport", -33.939923, 151.175276, "2020", "NSW", "Sydney", "International Airside lll NSW" },
                    { 945, "501 Cowpasture Rd", -33.917796000000003, 150.85504779999999, "2171", "NSW", "Hoxton Park (Len Waters Estate)", "Hoxton Park M7" },
                    { 946, "185 Hutton Rd ", -38.012847499999999, 145.15879190000001, "3173", "VIC", "Keysborough South", "Keysborough South" },
                    { 947, "71 Bald Hill Road", -38.084285999999999, 145.492379, "3810", "VIC", "Pakenham South", "Pakenham South" },
                    { 948, "Lot 906 Thomas Road", -32.207700000000003, 115.9786, "6122", "WA", "Byford", "BYFORD " },
                    { 949, "3 Tarakan Court,", -12.500544, 131.005471, "0832", "NT", "Johnston", "JOHNSTON" },
                    { 950, "Cnr. Richardson Rd, Springs Rd & Brookner Rd,", -34.070267999999999, 150.72976299999999, "2570", "NSW", "Spring Farm", "SPRING FARM" },
                    { 951, "Wynyard Rail, George street", -33.865692000000003, 151.206175, "2000", "NSW", "Sydney", "Wynyard Railway " },
                    { 952, "Crn of Jubilee Hwy E & Attamurra Rd", -37.838158999999997, 140.81198000000001, "5290", "SA", "Mount Gambier", "Mount Gambier East SA" },
                    { 953, "3-13 Maud Street ", -28.143529000000001, 153.49295000000001, "4224", "QLD", "Tugun", "TUGUN QLD" },
                    { 954, "4 Nev Smith Drive", -27.651519, 152.92130700000001, "4300", "QLD", "Springfield", "Camira QLD" },
                    { 955, "1 Silver Banksia Boulevarde", -38.110678, 145.25960599999999, "3977", "VIC", "Cranbourne", "Amstel VIC" },
                    { 956, "7 Mann Street,", -31.901206999999999, 116.163462, "6073", "WA", "Mundaring", "Mundaring WA" },
                    { 957, "Cnr. Ranford Road & Tesla Way", -32.144198000000003, 115.97397100000001, "6112", "WA", "Forrestdale", "Forrestdale WA" },
                    { 958, "Cnr Princess Hwy & Smith Rd", -37.941896999999997, 145.16785899999999, "3171 ", "VIC", "Springvale", "SANDOWN VIC" },
                    { 959, "Cnr Main Rd & Saints Rd", -34.766427200000003, 138.6685937, "5109", "SA", "Salisbury Heights", "Salisbury Plains" },
                    { 960, "701 Grand Junction Road", -34.846913899999997, 138.61800460000001, "5085", "SA", "Northfield", "Northfield SA" },
                    { 961, "Pad Site 3, Stockland Point Cook Shopping Centre", -37.884661000000001, 144.73699099999999, "3030", "VIC", "Dunnings Road", "POINT COOK NORTH VIC" },
                    { 962, "211 & 227-237 Sippy Downs Drive", -26.713131000000001, 153.07099400000001, "4556", "QLD", "Sippy Downs", "SIPPY DOWNS" },
                    { 963, "14A Kirkpatrick St and Cotter Road", -35.321261499999999, 149.05547680000001, "2611", "ACT", "Weston Creek, Canberra", "Molonglo Valley ACT" },
                    { 964, "2 Lexington Drive", -33.738453300000003, 150.94656040000001, "2153", "NSW", "Bella Vista", "Norwest II" },
                    { 965, "Shop 4/5, Level 1, Royal Randwick shopping centre, 73 Belmore Road", -33.915187000000003, 151.24047100000001, "2031", "NSW", "Randwick", "Randwick II" },
                    { 966, "1066 Blunder Road", -27.612833200000001, 152.98488330000001, "4077", "QLD", "DOOLANDELLA", "DOOLANDELLA" },
                    { 967, "1405 Plenty Road", -37.603476999999998, 145.093999, "3754", "VIC", "Mernda", "MERNDA " },
                    { 968, "Rochedale Village – Cnr Miles Platting Rd and Gardner Rd - 448 Miles Platting Rd", -27.5786245, 153.065181, "4123", "QLD", "Rochedale", "Rochedale QLD" },
                    { 969, "Karalee Shopping Centre – Cnr Junction Road and Village Place 2 Centre Court", -27.570855000000002, 152.795659, "4306", "QLD", "Chuwar", "Karalee QLD" },
                    { 970, "R127, 305a Botany Road", -33.905791999999998, 151.20346499999999, "2017", "NSW", "Zetland", "GREEN SQUARE" },
                    { 971, "SHOP 328 LOGAN HYPERDOME, Cnr Pacific Hwy & Bryants Road", -27.658332999999999, 153.17064099999999, "4129", "QLD", "Loganholme", "LOGAN HYPERDOME II" },
                    { 972, "NE11, 9 Little Pier Street", -33.878261999999999, 151.20285000000001, "2000", "NSW", "Haymarket", "DARLING SQUARE" },
                    { 973, "Cnr Davis Rd & Hummingbird Boulevard", -37.833848000000003, 144.65281400000001, " 3029", "VIC", "Tarneit", "RIVERDALE VILLAGE" },
                    { 974, "Belmont Forum Shopping Centre, Abernethy Rd", -31.964108, 115.937049, "6104", "WA", "Belmont", "Belmont WA" },
                    { 975, "Shop 1222, Level 1, Castle Towers Shopping Centre 6-14 Castle Street", -33.730410300000003, 151.005492, "2154", "NSW", "Castle Hill", "Castle Towers II" },
                    { 976, "Anne Aquilina Reserve (Part)", -33.772874899999998, 150.85733769999999, "2766", "NSW", "Rooty Hill", "Blacktown Sports Park" },
                    { 977, "92-120 Grubb Rd", -38.246831999999998, 144.53819899999999, "3226", "VIC", "Ocean Grove", "Ocean Grove" },
                    { 978, "1 Homestead Drive", -27.808123999999999, 152.949354, "4280", "QLD", "Flagstone", "Flagstone" },
                    { 979, "36 CALOUNDRA RD", -31.693601000000001, 115.72495000000001, "6030", "WA", "CLARKSON", "Clarkson" },
                    { 980, "Westfield Shopping Centre (Shop Number 306) Albany Hwy", -32.018259, 115.93607900000001, "6107", "WA", "Cannington", "Cannington II" },
                    { 981, "601-605 Great Western Highway", -33.808603099999999, 150.93592430000001, "2145", "NSW", "Greystanes", "Greystanes" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 982, "930 Thompsons Road", -38.078634000000001, 145.24318199999999, "3977", "VIC", "Cranbourne West", "Lyndhurst II" },
                    { 983, "6 Ferdinand Lane", -35.380555000000001, 149.19663800000001, "2619", "NSW", "Jerrabomberra", "Jerrabomberra" },
                    { 984, "316 Glenelg Highway", -37.590079000000003, 143.79798500000001, "3356", "VIC", "Delacombe", "DELACOMBE VIC" },
                    { 985, "1 Maltby Bypass", -37.926153999999997, 144.631122, "3030", "VIC", "Werribee", "Maltby Bypass VIC" },
                    { 986, "2R Wellington Road", -32.260672999999997, 148.64856499999999, "2830", "NSW", "Dubbo", "Dubbo East" },
                    { 987, "195 Graham Road", -27.108837000000001, 152.967636, "4506", "QLD", "Morayfield", "Morayfield East" },
                    { 988, "1-21 Cranebrook Road", -33.689469000000003, 150.727351, "2749", "NSW", "Cranebrook", "Cranebrook NSW" },
                    { 989, "2/200-230 James Mirams Drive", -37.615777000000001, 144.914129, "3064", "Victoria", "Roxburgh Park", "Greenvale Lakes" },
                    { 990, "81 – 83 Main Street ", -27.607219000000001, 151.87221, "4350", "QLD", "Westbrook ", "Westbrook" },
                    { 991, "41 Bruxner Highway", -28.861167999999999, 153.517088, "2478", "NSW", "West Ballina", "BP Ballina Travel Centre" },
                    { 992, "190 Portland Drive ", -32.917591000000002, 151.597881, "2285", "NSW", "Cameron Park", "Cameron Park NSW" },
                    { 993, "2710 Remembrance Driveway", -34.229458000000001, 150.587997, "2573", "NSW", "Tahmoor", "Tahmoor NSW" },
                    { 994, "20 Pacific Highway", -32.994886000000001, 151.68653599999999, "2290", "NSW", "Bennetts Green", "Bennetts Green NSW" },
                    { 995, "7005 Mount Juillerat Drive", -27.668555000000001, 152.84249700000001, "4301", "QLD", "Redbank Plains", "Edens Crossing QLD" },
                    { 996, "Southern River Road", -32.101035000000003, 115.96404800000001, "6110", "WA", "Southern River", "Southern River" },
                    { 997, "58 Bradshaw Terrace", -12.3708253, 130.88283430000001, "0810", "NT", "Casuarina", "Casuarina North" },
                    { 998, "Lot 147 Sturt Hwy", -34.458545000000001, 138.982282, "5355", "SA", "Nuriootpa", "Nuriootpa" },
                    { 999, "213 Holdsworth Avenue", -31.765377999999998, 115.986358, "6069", "WA", "Aveley", "Malvern Springs  " },
                    { 1000, "859-885 Port Wakefield Rd", -34.769438000000001, 138.593954, "5110", "SA", "Bolivar", "Bolivar" },
                    { 1001, "114-122 Peel Street", -31.078768, 150.91931500000001, "2340", "NSW", "North Tamworth", "Tamworth North" },
                    { 1002, "Cnr Hume highways & Avon street", -33.9086, 151.03048699999999, "2199", "NSW", "Yagoona", "Yagoona NSW" },
                    { 1003, "500-540 Torquay Rd", -38.22663, 144.33686, "3217", "VIC", "Armstrong Creek", "Armstrong Creek VIC" },
                    { 1004, "LOT 1, 2 Youle Dean Road, 2 Marvel Entrance", -31.832395999999999, 115.96898400000001, "6055", "WA", "Brabham", "Brabham WA" },
                    { 1005, "Cnr Albert & Logan Street", -27.770157999999999, 153.10494499999999, "4207", "QLD", "Logan Village", "Logan Village QLD" },
                    { 1006, "244 Rockingham Rd", -32.096181999999999, 115.78312200000001, "6163", "WA", "Spearwood", "Spearwood II" },
                    { 1007, "478 Wanneroo Road", -31.862735000000001, 115.82801000000001, "6061", "WA", "Westminster", "Westminster WA" },
                    { 1008, "9 Symphony Lane", -37.603281000000003, 144.98419200000001, "3750", "VIC", "Wollert North", "Wollert North VIC" },
                    { 1009, "Cnr Warrego Highway & Villis Road", -27.544273604323294, 152.34511613845825, "4343", "QLD", "Gatton", "GATTON Highway" },
                    { 1010, "7 Muir Street", -32.739677, 151.86660800000001, "2318", "NSW", "Medowie", "Medowie" },
                    { 1011, "12-14 Walker St", -33.830748999999997, 151.08664099999999, "2138", "NSW", "Rhodes", "Rhodes" },
                    { 1012, "227 Railway Terrace", -33.705672, 150.87483700000001, "2762", "NSW", "Schofields", "Schofields" },
                    { 1013, "45-49 Princes Highway", -34.450718000000002, 150.848862, "2526", "NSW", "Unanderra", "Unanderra" },
                    { 1014, "Shop G2, 620 Collins St", -37.818759719611997, 144.9542303067, "300", "VIC", "Melbourne", "Spencer Street" },
                    { 1015, "Pad Site No 1, 201 Exford Road", -37.724773999999996, 144.57297800000001, "3338", "VIC", "Melton South", "Melton South" },
                    { 1016, "18 Innovation Dr", -33.732860000000002, 150.93747999999999, "2768", "NSW", "Glenwood", "Glenwood High school" },
                    { 1017, "134-140 Marion Rd", -34.937257000000002, 138.55251799999999, "5033", "SA", "West Richmond", "West Richmond" },
                    { 1018, "475 Albany Highway", -34.992671999999999, 117.85606900000001, "6330", "WA", "Orana", "Albany Orana" },
                    { 1019, "353 CESSNOCK RD", -32.763976999999997, 151.528503, "2321", "NSW", "Gillieston Heights", "Gillieston Heights" },
                    { 1020, "LOT 1001 MURDOCH DRIVE (CNR. FARRINGTON RD)", -32.079039000000002, 115.84333100000001, "6150", "WA", "Murdoch", "Murdoch" },
                    { 1021, "Corner Airport Drive & Links Road", -37.692731000000002, 144.866996, "3045", "VIC", "Melbourne Airport", "Melbourne Airport Drive" },
                    { 1022, "500 Lytton Road", -27.456903000000001, 153.087255, "4170", "QLD", "Morningside", "Colmslie Business Park" },
                    { 1023, "Tenancy 1 2028 Old Bruce Highway", -26.203099999999999, 152.4349, "4570", "QLD", "Coles Creek", "Traveston Service Centre" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "Latitude", "Longitude", "Postcode", "State", "Suburb", "Title" },
                values: new object[,]
                {
                    { 1024, "Cnr Gympie Rd and Mecklem St Strathpine ", -27.183703000000001, 152.592861, "4550", "QLD", "Strathpine", "Strathpine Town Centre" },
                    { 1025, "LOT 101 Clarkson Ave", -31.719632000000001, 115.785068, "6065", "WA", "Tapping ", "Tapping" },
                    { 1026, "450 The Northern Road", -33.995463000000001, 150.72621319999999, "2570", "NSW", "Oran Park", "Oran Park" },
                    { 1027, "2/12 Mary Pleasant Drive", -27.4912396, 153.21844419999999, "4159", "QLD", "Birkdale", "Birkdale" },
                    { 1028, "23-39 Oak Street", -21.097909999999999, 149.18602000000001, "4740", "QLD", "Andergrove", "Andergrove" },
                    { 1029, "4 Lancaster Street", -33.989319000000002, 150.866837, "2565", "NSW", "Ingleburn", "Ingleburn" },
                    { 1030, "1500 Eastlink Northbound", -37.898567, 145.23036200000001, "3179", "VIC", "Scoresby", "EASTLINK NORTHBOUND" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AttributesId", "Category", "Description", "Name", "PurchasePrice", "SalePrice" },
                values: new object[,]
                {
                    { 1, 1, 2, "\n<h2><strong>Everything you need for your personal Island paradise</strong></h2>\n<p>Escape to a deserted island and create your own paradise as you explore, create, and customize in <em>Animal Crossing: New Horizons</em>. Your island getaway has a wealth of natural resources that can be used to craft everything from tools to creature comforts.</p>\n<p>This Animal Crossing Collector's box contains everything you could need to tend to your real-life everyday chores. There's a Nook Inc. drawstring bag, a bell bag blanket, turnip sticky notes, Isabelle fluffy bed socks and more!</p>\n<p>Grab yours today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Nook Inc. Drawstring Bag</li>\n<li>Bell Bag Blanket</li>\n<li>Timmy and Tommy Desk Calendar</li>\n<li>Animal Crossing New Horizons Notebook</li>\n<li>Isabelle Fluffy Bed Socks</li>\n<li>Peach Stress ball</li>\n<li>Turnip Sticky Notes</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Blanket Size:</strong>&nbsp;160cm x 101cm approx</li>\n</ul>\n<p>Official Animal Crossing licensed merchandise</p> ", "Animal Crossing - Animal Crossing New Horizons Collector's Box", 48.33m, 68m },
                    { 2, 2, 2, "\n<h2><strong>I think that pretty much sums it up</strong></h2>\n<p>The Office depicts the everyday lives of office employees in the Scranton, Pennsylvania branch of the fictional Dunder Mifflin Paper Company. To simulate the look of an actual documentary, it was filmed in a single-camera setup, without a studio audience or a laugh track.</p>\n<p>Funko's new The Office 2021 Collector Box features a range of exclusive collectables that no fan can do without. Grab yours today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1x Stanley in Sumo Suit Pop! Vinyl Figure</li>\n<li>1x Jim in Sumo Suit Pop! Vinyl Figure</li>\n<li>1x Sumo Andy Pen Topper</li>\n<li>1x Dundler Mifflin Notebook</li>\n<li>1x 3 pack of The Office pins</li>\n</ul>\n<p>Official Universal&nbsp;licensed merchandise</p> ", "The Office - Funko 2021 Collector's Box", 49.92m, 59m },
                    { 3, 3, 2, "\n<div id=\"StrictOne\" class=\"alert-panel alert-panel-warning\">\n<div class=\"alert-panel-sidebar icon-notification\">­</div>\n<div class=\"alert-panel-title\">Strictly 1 per Customer!</div>\n</div>\n<div id=\"StrictOne\" class=\"alert-panel alert-panel-warning\">\n<div class=\"alert-panel-sidebar icon-notification\">­</div>\n<div class=\"alert-panel-title\">Please note: This listing does not include the Tiny Tina's Wonderlands game</div>\n</div>\n<h2><strong>Tiny Tina's Wonderlands: Treasure Trove</strong></h2>\n<p>Gather round, because Tina’s got the one and only collectible box guaranteed to NOT be a mimic that comes to life and eats your whole family. Chockablock full of hand-picked, awe-inspiring, premium loot, Tiny Tina’s Treasure Trove is an instant heirloom that will impress your friends and make your enemies jelly. This collectible box contains limited-edition items.</p>\n<h2>Includes:</h2>\n<ul>\n<li><strong>Butt Stallion Plush:</strong> Our senior scientists and designers used their collective brainpower to bring you this plush rendition of the most beautiful, iconic, and majestic ruler in all the land – Queen Butt Stallion. Kneel before her supreme cuddliness!</li>\n<li><strong>Illustrated Tarot Cards:</strong> Foresee your glorious fate with this deck of elegantly crafted, golden-trimmed tarot cards. This 78-card deck features regal stained-glass designs straight out of Tina’s imagination.</li>\n<li><strong>Standalone Bunkers &amp; Badasses Module:</strong> Delve into the dungeon of your mind with this official Bunkers &amp; Badasses One-shot! Use the power of IMAGINATION to transport you and your friends to a fantastical world as you chomp down a full bag of nutritious cheese curls.</li>\n<li><strong>Enamel Companion Pins:</strong> All the perks of friendship with none of the mess! Bring your loyal minions with you wherever you go with these shiny, oh-so-adorable enamel pins (just watch out for those pointy ends).</li>\n<li><strong>Butt Stallion’s Castle Papercraft Booklet:</strong> The beauty of Butt Stallion’s splendiferous castle is said to reduce even the most hard-hearted ogre to tears. Now you can recreate that magical experience in your own home with this papercraft rendition – just remember it’s made of paper, so tears of joy will damage the materials.</li>\n<li><strong>Cloth Wonderlands Map:</strong> Whether you’re an enterprising pirate or an adventurous explorer, everybody loves a good map. Get ready to bask in this beautifully illustrated, 18'x30' piece of chaotic cartography depicting the many SPOILERS you may encounter during your ventures ‘cross the Wonderlands.</li>\n</ul>\n<p><strong><em>*Please note that the Treasure Trove does not include a copy of the game.</em></strong></p> ", "Tiny Tina's Wonderlands: Treasure Trove", 106.58m, 149.95m },
                    { 4, 4, 2, "\n<h2><strong>This is the way</strong></h2>\n<p>After the stories of Jango and Boba Fett, another warrior emerges in the Star Wars universe. <em>The Mandalorian</em> is set after the fall of the Empire and before the emergence of the First Order. We follow the travails of a lone gunfighter in the outer reaches of the galaxy far from the authority of the New Republic.</p>\n<p>This Mandalorian Collector's box contains everything you could need to enjoy The Mandalorian in your everyday life. There's The Child planter, a mug shaped like the Mandalorian's helmet, a notepad bearing the Imperial sigil, a Mandalorian helmet pin, and The Child in Carrier keychain.</p>\n<p>Grab yours today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>The Child Planter</li>\n<li>Mandalorian Helmet moulded mug</li>\n<li>Imperial Sigil notepad</li>\n<li>Mandalorian Helmet pin</li>\n<li>The Child in Carrier keychain</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Mandalorian Collector Box", 30.46m, 36m },
                    { 5, 5, 2, "\n<div id=\"StrictOne\" class=\"alert-panel alert-panel-warning\">\n<div class=\"alert-panel-sidebar icon-notification\">­</div>\n<div class=\"alert-panel-title\">This product listing is assorted and is for 1 (one) item only, as specified. Variants are chosen at random at time of shipping. We cannot take requests or make exchanges for specific variants.</div>\n</div>\n<h2><strong>Robots in disguise!</strong></h2>\n<p>Many millions of years ago, on the planet Cybertron, life existed. But not life as we know it today. Intelligent robots that could think and feel inhabited the cities. Eons of war with the Decepticons, their bitter enemies, have drained the planet's once plentiful resources. As the Energon supply runs low on the planet Cybertron, the Autobots leave to find a new energy source. Their enemies, the Decepticons, follow. After a vicious battle in space, both of their ships crash land on Earth. The Decepticons try to gather every bit of energy that they can, from Earth, in order to get back to Cybertron. The Autobots, along with their new human allies, try to stop them</p>\n<p>This Funko Pop! box might feature Transformers, or it might feature G.I.Joe. Which one will you find?</p>\n<h2>Includes:</h2>\n<ul>\n<li>1x Lunch box</li>\n<li>2 x Pop! Vinyl Figure</li>\n<li>1x Keychain</li>\n<li>1x Decal</li>\n<li>1x Pin Set</li>\n</ul>\n<p>Official Transformers &amp; G.I.Joe licensed merchandise</p> ", "Funko Box - Transformers or G.I.Joe (Assorted)", 42.65m, 60m },
                    { 6, 6, 2, "\n<h2><strong>Night City, California. Year 2077.&nbsp;</strong></h2>\n<p>The world is broken. MegaCorps manage every aspect of life from the top floors of their sky-scraping fortresses. Down below, the streets are run by drug pushing gangs, tech hustlers, and illegal braindance slingers. The in-between is where decadence and pop culture mix with violent crime, extreme poverty and the unattainable promise of the American Dream.</p>\n<p>Now you can break free from the MegaCorps with this awesome Cyberpunk 2077 Gift box. Perfect for the Cyberpunk fan in your life.</p>\n<p>Grab one today.</p>\n<h2>Includes:</h2>\n<ul>\n<li>Night City PVC Keychain</li>\n<li>Netrunner Socks</li>\n<li>Monos 3 Pack</li>\n<li>Classic Samurai Cap</li>\n<li>Gadget Sicker Pack</li>\n</ul>\n<p>Official Cyberpunk licensed merchandise</p> ", "Cyberpunk 2077 - Gift Box", 16.08m, 19m },
                    { 7, 7, 2, "\n<div id=\"StrictOne\" class=\"alert-panel alert-panel-warning\">\n<div class=\"alert-panel-sidebar icon-notification\">­</div>\n<div class=\"alert-panel-title\">This product listing is assorted and is for 1 (one) item from each of the below only - comes in 4 possible variants. Variants are chosen at random at time of shipping. We cannot take requests or make exchanges for specific variants.</div>\n</div>\n<h2><strong>I can say 'Chimichanga' in seven languages</strong></h2>\n<p>Wade Wilson is a former Special Forces operative who now works as a mercenary. His world comes crashing down when evil scientist Ajax tortures, disfigures and transforms him into Deadpool. The rogue experiment leaves Deadpool with accelerated healing powers and a twisted sense of humour. With help from mutant allies Colossus and Negasonic Teenage Warhead, Deadpool uses his new skills to hunt down the man who nearly destroyed his life.</p>\n<p>Even after all the harrowing fights and dangerous escapades, Deadpool still has a bucket list of to-dos. Have Deadpool join your Marvel collection and help him accomplish more bucket list adventures with the Deadpool Bucket List 5-piece Mystery Box. Get yours today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Licensed Box</li>\n<li>1x Pop! Vinyl. Random chance of&nbsp;<strong>either</strong>:\n<ul>\n<li>Deadpool – Lazy River</li>\n<li>Deadpool – Paintball</li>\n<li>Deadpool – Safari</li>\n<li>Deadpool – Artist (Black Light)</li>\n</ul>\n</li>\n<li>1x Pop! Keychain. Random chance of&nbsp;<strong>either:</strong>\n<ul>\n<li>Deadpool – Lazy River</li>\n<li>Deadpool – Paintball</li>\n<li>Deadpool – Safari</li>\n<li>Deadpool – Artist</li>\n</ul>\n</li>\n<li>1x Pop! Pen Topper. Random chance of&nbsp;<strong>either:</strong>\n<ul>\n<li>Deadpool – Lazy River</li>\n<li>Deadpool – Paintball</li>\n<li>Deadpool – Safari</li>\n<li>Deadpool – Artist</li>\n</ul>\n</li>\n<li>1x Button Badge. Random chance of&nbsp;<strong>either:</strong>\n<ul>\n<li>Deadpool – Safari</li>\n<li>Deadpool – Artist</li>\n</ul>\n</li>\n<li>1x Lanyard. Random chance of&nbsp;<strong>either:</strong>\n<ul>\n<li>Deadpool – Lazy River</li>\n<li>Deadpool – Paintball</li>\n</ul>\n</li>\n</ul>\n<p>Officially licensed Marvel merchandise</p> ", "Deadpool - Bucket List 5-Piece Mystery Collector Box", 33.84m, 40m },
                    { 8, 8, 2, "\n<h2><strong>What happens to the World's Greatest Heroes if the world ends?</strong></h2>\n<p>When the Anti-Life Equation uses Cyborg's body as a carrier for a terrible techno-virus, it infects 600 million people and turns them into violent, monstrous engines of destruction. What happens to the World’s Finest if the world ends? With death spreading across the planet, who will live and who will turn in this apocalyptic tale of heroism, sacrifice and annihilation? Fighting time, each other and all of humanity, Earth’s greatest heroes must rally together to save the world from the most terrible plague humanity has ever seen.</p>\n<p>This DCeased Gift box features a range of exclusive items that no fan can do without. Get yours today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>DCeased - Licensed Box</li>\n<li>1x DCeased Pop! Vinyl&nbsp;</li>\n<li>1x DCeased Pop! Keychain&nbsp;</li>\n<li>1x DCeased 4\" Enamel Pop! Pin&nbsp;</li>\n<li>1x DCeased Decal</li>\n</ul>\n<p><em>Random chance of either DCeased Batman, DCeased Batman (Bloody), DCeased Joker, DCeased Joker (Bloody) or&nbsp;DCeased logo</em></p>\n<p>Officially licensed DC merchandise</p> ", "DC Comics - DCeased Funko Mystery Collector Box", 41.46m, 49m },
                    { 9, 9, 2, "\n<h2><strong>By the power of Greyskull!</strong></h2>\n<p>Masters of the Universe was a successful line of action figures, released in the 80s that spawned a television series, film and more.</p>\n<p>When the evil Skeletor finds a mysterious power called the Cosmic Key, he becomes nearly invincible. However, courageous warrior He-Man locates inventor Gwildor, who created the Key and has another version of it. During a battle, one of the Keys is transported to Earth, where it is found by teenagers Julie and Kevin. Now both He-Man and Skeletor's forces arrive on Earth searching for the potent weapon.</p>\n<p>Complete your Masters of the Universe collection with this Masters of the Universe Funko Collector's Box. Grab yours today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1x He-Man with Lightning Sword (Flocked) Pop! Vinyl Figure</li>\n<li>1x Glow-in-the-Dark Scareglow Pop! Pen Topper</li>\n<li>1x Orko pin</li>\n<li>Collector's Box</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Masters of the Universe licensed merchandise</p> ", "Masters of the Universe Funko Collector's Box", 30.46m, 36m },
                    { 10, 10, 1, "\n<h2><strong>I am what you made me.</strong></h2>\n<p>Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader.</p>\n<p>Kids and collectors can imagine the biggest battles and missions in the Star Wars saga with figures from Star Wars The Black Series! With exquisite features and decoration, this series embodies the quality and realism that Star Wars devotees love. Star Wars The Black Series includes figures, vehicles, and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies, and animated series. (Additional products each sold separately. Subject to availability.)</p>\n<h2>Includes:</h2>\n<ul>\n<li>Figure</li>\n<li>1 Accessory</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>DARTH VADER:</strong> Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</li>\n<li><strong>STAR WARS: OBI-WAN KENOBI:</strong> Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Darth Vader toy, inspired by the Star Wars: Obi-Wan Kenobi series</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORY:</strong> This Star Wars The Black Series action figure comes with 1 entertainment-inspired accessory that makes a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>FIND OTHER FIGURES FROM A GALAXY FAR, FAR AWAY:</strong> Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy (Each sold separately. Subject to availability)</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING:</strong> Star Wars fans and collectors can display this fully articulated figure featuring poseable head, arms, and legs, as well as premium deco, in their collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>15cm tall approx.</li>\n<li><strong>Material:&nbsp;</strong>Plastic</li>\n<li><strong>WARNING: CHOKING HAZARD</strong> – Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Obi-Wan Kenobi - Black Series - Darth Vader Action Figure", 31.07m, 45m },
                    { 11, 11, 1, "\n<h2><strong>Hello There.</strong></h2>\n<p><em>Obi-Wan Kenobi</em> is set years after the dramatic events of <em>Star Wars: Revenge of the Sith</em> where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</p>\n<p>Kids and collectors alike can imagine the biggest battles and missions in the Star Wars saga with figures from <em>Star Wars The Black Series</em>! With exquisite features and decoration, this series embodies the quality and realism that Star Wars devotees love. Star Wars The Black Series includes figures, vehicles, and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies, and animated series. <em>(Additional products each sold separately. Subject to availability.)</em></p>\n<p>The 6-inch-scale Black Series figure is detailed to look like the Obi-Wan Kenobi (Wandering Jedi) character, featuring premium detail and multiple points of articulation.</p>\n<p>Add him to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>3 accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>OBI-WAN KENOBI (WANDERING JEDI)</strong> - Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</li>\n<li><strong>STAR WARS: OBI-WAN KENOBI</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Obi-Wan Kenobi (Wandering Jedi) toy, inspired by the Star Wars: Obi-Wan Kenobi series</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Black Series action figure comes with 3 entertainment-inspired accessories that make a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>FIND OTHER FIGURES FROM A GALAXY FAR, FAR AWAY</strong> - Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy (Each sold separately. Subject to availability)</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING</strong> - Star Wars fans and collectors can display this fully articulated figure featuring poseable head, arms, and legs, as well as premium deco, in their collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Black Series Obi-Wan Kenobi (Wandering Jedi) Action Figure", 31.07m, 45m },
                    { 12, 12, 1, "\n<h2><strong>Every galaxy has an underworld. </strong></h2>\n<p><em>The Book of Boba Fett</em>, a spin-off from the hit series The Mandalorian, finds legendary bounty hunter Boba Fett and mercenary Fennec Shand navigating the galaxy’s underworld when they return to the sands of Tatooine to stake their claim on the territory once ruled by Jabba the Hutt and his crime syndicate.</p>\n<p>Once regarded as one of the most fearsome bounty hunters in the galaxy, Boba Fett seemingly met his demise in the Sarlacc pit. A survivor, Fett lived to fight another day.</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love.</p>\n<p>Add Boba Fett to your collection today!</p>\n<h2>Features:</h2>\n<ul>\n<li><strong>Boba Fett (Tatooine)</strong> - Once regarded as one of the most fearsome bounty hunters in the galaxy, Boba Fett seemingly met his demise in the Sarlacc pit. A survivor to his core, Fett lived to fight another day</li>\n<li><strong>Special Packaging, Deluxe Figure</strong> - This Star Wars The Vintage Collection 3.75-inch scale classic Star Wars Boba Fett (Tatooine) deluxe action figure features special package artwork, as well as original Kenner branding</li>\n<li><strong>Classic Star Wars Figure</strong> - This Boba Fett (Tatooine) action figure is inspired by the character in <em>Star Wars: The Book of Boba Fett</em>, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Series-Based Character-Inspired Accessories</strong> - This Star Wars The Vintage Collection action figure comes with 9 entertainment-inspired accessories, including removable jetpack and blast effects pieces.</li>\n<li><strong>Premium Design and Articulation</strong> - Highly articulated with fully poseable limbs. Deluxe deco and design with more detail than the standard The Vintage Collection figure.</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size: </strong> 9.5cm tall approx.</li>\n<li><strong>For Ages: </strong> 4+</li>\n<li><strong>WARNING: CHOKING HAZARD</strong> - Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Book of Boba Fett - Vintage Collection Boba Fett Deluxe Action Figure", 37.97m, 55m },
                    { 13, 13, 1, "\n<h2><strong>Your lack of faith disturbs me</strong></h2>\n<p>From junkyard slave, to podracing starlet, to the prophesied Chosen One, to fledgling Jedi, to the most powerful Sith the galaxy has ever known, Darth Vader's meteoric rise - or tragic fall, depending on whether you align with the dark side or the light - is one for the ages.</p>\n<p>Obi-Wan Kenobi is set years after the dramatic events of <em>Star Wars: Revenge of the Sith</em> where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader.</p>\n<p>Celebrate the legacy of Star Wars, the action-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across products and packaging inspired by the original line, as well as the entertainment-inspired collector-grade deco that fans have come to know and love.&nbsp;(Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by <em>Star Wars: Obi-Wan Kenobi</em>, this Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans.</p>\n<p>Add Darth Vader (The Dark Times) to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Darth Vader (The Dark Times) 3.75\" Action Figure</li>\n<li>Lightsaber</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Darth Vader (The Dark Times)</strong> - Obi-Wan Kenobi is set years after the dramatic events of <em>Star Wars: Revenge of the Sith</em> where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure</strong> - This Darth Vader (The Dark Times) action figure is inspired by the character in <em>Star Wars: Obi-Wan Kenobi</em> and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Series-Based Character-Inspired Accessories</strong> - This Star Wars The Vintage Collection action figure comes with 3 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium articulation and detailing</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Darth Vader (The Dark Times) figure can be displayed in action figure and vehicle collections.</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Obi-Wan Kenobi - Vintage Collection Darth Vader (The Dark Times) Action Figure", 29.48m, 35m },
                    { 14, 14, 1, "\n<h2>The Jedi will hunt himself</h2>\n<p>Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</p>\n<p>Kids and collectors can imagine the biggest battles and missions in the Star Wars saga with figures from Star Wars The Black Series! With exquisite features and deco, this series embodies the quality and realism that Star Wars fans love. Star Wars The Black Series includes figures, vehicles and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies and animated series. (Additional products each sold separately. Subject to availability.)</p>\n<h2>Includes:</h2>\n<ul>\n<li>Figure</li>\n<li>1 accessory</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>FIFTH BROTHER (INQUISITOR): </strong>Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</li>\n<li><strong>STAR WARS: OBI-WAN KENOBI:</strong> Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Fifth Brother (Inquisitor) toy, inspired by the Star Wars: Obi-Wan Kenobi series</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORY:</strong> This Star Wars The Black Series action figure comes with 1 entertainment-inspired accessory that makes a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>FIND OTHER FIGURES FROM A GALAXY FAR, FAR AWAY:</strong> Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy (Each sold separately. Subject to availability)</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING:</strong> Star Wars fans and collectors can display this fully articulated figure featuring poseable head, arms, and legs, as well as premium deco, in their collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>15cm tall approx.&nbsp;</li>\n<li><strong>Material:&nbsp;</strong>Plastic</li>\n<li><strong>WARNING: CHOKING HAZARD</strong> – Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Obi-Wan Kenobi - Black Series - Fifth Brother Action Figure", 31.07m, 45m },
                    { 15, 15, 1, "\n<h2><strong>Ahsoka Tano. I fought by her side from the Battle of Christophsis to the Siege of Mandalore.</strong></h2>\n<p>Republic clone troopers represented the future of galactic warfare. They formed the backbone of the Republic's new military. The galaxy-wide conflict that saw their debut even took its name from their ranks</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. <em>(Additional products each sold separately.&nbsp; Subject to availability.)</em></p>\n<p>Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add them to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>3 accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>332ND AHSOKA’S CLONE TROOPER</strong> - Clone troopers represented the future of galactic warfare. They formed the backbone of the Republic's new military. The galaxy-wide conflict that saw their debut even took its name from their ranks: the Clone Wars</li>\n<li><strong>VINTAGE-INSPIRED PACKAGING </strong>- Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding <em>(Each sold separately. Subject to availability.)</em></li>\n<li><strong>CLASSIC STAR WARS FIGURE</strong> - This 332nd Ahsoka’s Clone Trooper action figure is inspired by the character in Star Wars: The Clone Wars, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Vintage Collection action figure comes with 3 entertainment-inspired accessories that make a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>PREMIUM DESIGN AND ARTICULATION</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars 332nd Ahsoka’s Clone Trooper figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Vintage Collection 332nd Ahsoka’s Clone Trooper Action Figure", 29.48m, 35m },
                    { 16, 16, 1, "\n<h2><strong>Roger Roger.</strong></h2>\n<p>The New Republic used these security droids for protection and combat, including aboard high-security correctional transports like the one The Mandalorian boarded to rescue the prisoner Qin&nbsp;</p>\n<p>Kids and collectors can imagine the biggest battles and missions in the Star Wars saga with figures from Star Wars The Black Series! With exquisite features and deco, this series embodies the quality and realism that Star Wars fans love. Star Wars The Black Series includes figures, vehicles and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies and animated series. <em>(Additional products each sold separately. Subject to availability.)</em></p>\n<p>The 6-inch-scale Black Series figure is detailed to look like the New Republic Security Droid character from Star Wars: The Mandalorian with premium detail and multiple points of articulation.</p>\n<p>Add them to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>1 accessory</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>NEW REPUBLIC SECURITY DROID</strong> - The New Republic used these security droids for protection and combat, including aboard high-security correctional transports like the one The Mandalorian boarded in an effort to rescue the prisoner Qin</li>\n<li><strong>STAR WARS: THE MANDALORIAN</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium New Republic Security Droid toy, inspired by the Star Wars: The Mandalorian series</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORY</strong> - This Star Wars The Black Series action figure comes with 1 entertainment-inspired accessory that makes a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>FIND OTHER FIGURES FROM A GALAXY FAR, FAR AWAY</strong> - Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy <em>(Each sold separately. Subject to availability)</em></li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING</strong> - Star Wars fans and collectors can display this fully articulated figure featuring poseable head, arms, and legs, as well as premium deco, in their collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Black Series New Republic Security Droid Action Figure", 31.07m, 45m },
                    { 17, 17, 1, "\n<h2><strong>Hello there.</strong></h2>\n<p>Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</p>\n<p>Celebrate the legacy of Star Wars, the action-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. (Additional products each sold separately. Subject to availability.)</p>\n<h2>Includes:</h2>\n<ul>\n<li>Figure</li>\n<li>6 accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>OBI-WAN KENOBI (WANDERING JEDI):</strong> Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader</li>\n<li><strong>VINTAGE-INSPIRED PACKAGING:</strong> Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>CLASSIC STAR WARS FIGURE:</strong> This Obi-Wan Kenobi (Wandering Jedi) action figure is inspired by the character in Star Wars: Obi-Wan Kenobi and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORIES:</strong> This Star Wars The Vintage Collection action figure comes with 6 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>PREMIUM DESIGN AND ARTICULATION:</strong> Highly articulated with fully poseable head, arms, and legs, the Star Wars Obi-Wan Kenobi (Wandering Jedi) figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size: </strong>9cm tall approx.&nbsp;</li>\n<li><strong>Material:&nbsp;</strong>Plastic</li>\n<li><strong>WARNING: CHOKING HAZARD</strong> – Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Obi-Wan Kenobi - The Vintage Collection Obi-Wan Kenobi Action Figure", 25.27m, 30m },
                    { 18, 18, 1, "\n<h2><strong>Never give up hope, no matter how dark things seem</strong></h2>\n<p>Set between the events of <em>Star Wars Episode II: Attack of the Clones</em> and <em>Star Wars Episode III: Revenge of the Sith</em>, <em>The Clone Wars</em> follows the wartime days of Yoda, Obi-Wan Kenobi, Anakin Skywalker and his Jedi Padawan, Ahsoka Tano. Delving further into Jedi lore they learn more about the nature of the Force than ever before. Though the war against the separatists is valiantly fought, bit by bit Anakin shifts slowly toward the Dark Side.</p>\n<p>Warrior clans of Mandalore were believed to have been wiped out. But as the Clone Wars swept the galaxy, the Mandalorians were resurrected with their legendary armour that was feared across the galaxy</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. (Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add the Mandalorian Death Watch Airborne Trooper to your Vintage Collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Mandalorian Death Watch Airborne Trooper 3.75\" Action Figure</li>\n<li>4x accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Mandalorian Death Watch Airborne Trooper</strong> - Warrior clans of Mandalore were believed to have been wiped out ages ago. But as the Clone Wars swept the galaxy, the Mandalorians were resurrected with their legendary armour that was feared across the galaxy</li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure</strong> - This Mandalorian Death Watch Airborne Trooper action figure is inspired by the character in <em>Star Wars: The Clone Wars</em>, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Series-based character-inspired accessories</strong> - This Star Wars The Vintage Collection action figure comes with 4 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium design and articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Mandalorian Death Watch Airborne Trooper figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Vintage Collection Mandalorian Death Watch Airborne Trooper Action Figure", 29.48m, 35m },
                    { 19, 19, 1, "\n<h2><strong>Never give up hope, no matter how dark things seem</strong></h2>\n<p>Set between the events of <em>Star Wars Episode II: Attack of the Clones</em> and <em>Star Wars Episode III: Revenge of the Sith</em>, <em>The Clone Wars</em> follows the wartime days of Yoda, Obi-Wan Kenobi, Anakin Skywalker and his jedi padawan Ahsoka Tano. Delving further into Jedi lore they learn more about the nature of the Force than ever before. Though the war against the separatists is valiantly fought, bit-by-bit Anakin shifts slowly toward the Dark Side.</p>\n<p>Maul's Mandalorians modify their armor to reflect allegiance to the Dark Lord. These super commandos wear red and black, and some even fashion horns atop their helmets, to resemble their Nightbrother leader</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. (Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add the Mandalorian Super Commando Captain to your Vintage Collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Mandalorian Super Commando Captain 3.75\" Action Figure</li>\n<li>4x accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Mandalorian Super Commando Captain</strong> - Maul's Mandalorians modify their armour to reflect allegiance to the Dark Lord. These super commandos wear red and black, and some even fashion horns atop their helmets, to better resemble their Nightbrother leader</li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure</strong> - This Mandalorian Super Commando Captain action figure is inspired by the character in Star Wars: The Clone Wars, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Series-based character-inspired accessories</strong> - This Star Wars The Vintage Collection action figure comes with 4 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium design and articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Mandalorian Super Commando Captain figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Vintage Collection Mandalorian Super Commando Captain Action Figure", 29.48m, 35m },
                    { 20, 20, 1, "\n<h2><strong>Never give up hope, no matter how dark things seem</strong></h2>\n<p>Set between the events of <em>Star Wars Episode II: Attack of the Clones</em> and <em>Star Wars Episode III: Revenge of the Sith</em>, <em>The Clone Wars</em> follows the wartime days of Yoda, Obi-Wan Kenobi, Anakin Skywalker and his Jedi Padawan, Ahsoka Tano. Delving further into Jedi lore they learn more about the nature of the Force than ever before. Though the war against the separatists is valiantly fought, bit by bit Anakin shifts slowly toward the Dark Side.</p>\n<p>Jesse is a hard-fighting patriot who proudly wears the cog-shaped symbol of the Galactic Republic on his helmet, and has a large tattoo that covers his face</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. (Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add ARC Trooper Jesse to your Vintage Collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Arc Trooper Jesse 3.75\" Action Figure</li>\n<li>5x Accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>ARC Trooper Jesse</strong> - Jesse is a hard-fighting patriot who proudly wears the cog-shaped symbol of the Galactic Republic on his helmet, and has a large tattoo that covers his face</li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure</strong> - This ARC Trooper Jesse action figure is inspired by the character in Star Wars: The Clone Wars, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Series-based character-inspired accessories</strong> - This Star Wars The Vintage Collection action figure comes with 5 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium design and articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars ARC Trooper Jesse figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Vintage Collection The Clone Wars Arc Trooper Jesse Action Figure", 29.48m, 35m },
                    { 21, 21, 1, "\n<h2><strong>The war you have waited your entire lives to fight is upon us, my brothers!</strong></h2>\n<p>A coup topples the pacifist regime of the New Mandalorians led by Maul. His loyal followers modify their armor to reflect their allegiance. These super commandos wear red and black armor; some even fashion horns atop their helmets</p>\n<p>Celebrate Star Wars, the action-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans know and love. <em>(Additional products each sold separately.&nbsp; Subject to availability.)</em></p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by Star Wars: Attack of the Clones, this Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans.</p>\n<p>Add them to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>4 accessory</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>MANDALORIAN SUPER COMMANDO</strong> - A coup topples the pacifist regime of the New Mandalorians led by Maul. His loyal Mandalorians modify their armor to reflect their allegiance. They wear red and black armor, and some even fashion horns atop their helmets</li>\n<li><strong>VINTAGE-INSPIRED PACKAGING</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding <em>(Each sold separately. Subject to availability.)</em></li>\n<li><strong>CLASSIC STAR WARS FIGURE</strong> - This Mandalorian Super Commando action figure is inspired by the character in Star Wars: The Clone Wars and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Vintage Collection action figure comes with 4 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>PREMIUM DESIGN AND ARTICULATION</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Mandalorian Super Commando figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Vintage Collection Mandalorian Super Commando Action Figure", 29.48m, 35m },
                    { 22, 22, 1, "\n<h2><strong>Wherever I go, he goes</strong></h2>\n<p>After the stories of Jango and Boba Fett, another warrior emerges in the Star Wars universe. <em>The Mandalorian</em> is set after the fall of the Empire and before the emergence of the First Order. <em>The Mandalorian</em> follows Din Djarin, a bounty hunter trying to return \"The Child\" to his people, the Jedi.</p>\n<p>The Mandalorian, known to a few as Din Djarin, is a battle-worn bounty hunter, making his way through a dangerous galaxy in an uncertain age. Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. (Additional products each sold separately.&nbsp; Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add Din Djarin to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Din Djarin (Morak) Vintage Collection 3.75\" Action Figure</li>\n<li>Blaster</li>\n<li>Helmet</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Din Djarin (Morak) - </strong>The Mandalorian, known to a few as Din Djarin, is a battle-worn bounty hunter, making his way through a dangerous galaxy in an uncertain age</li>\n<li><strong>Vintage-Inspired Packaging - </strong>Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure - </strong>This Din Djarin (Morak) action figure is inspired by the character in Star Wars: The Mandalorian, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Series-Based Character-Inspired Accessories - </strong>This Star Wars The Vintage Collection action figure comes with 2 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium Design and Articulation - </strong>Highly articulated with fully poseable head, arms, and legs, the Star Wars Din Djarin (Morak) figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n<li><strong>WARNING:</strong> CHOKING HAZARD - Small parts may be generated. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Mandalorian - Vintage Collection Din Djarin (Morak) Action Figure", 29.48m, 35m },
                    { 23, 23, 1, "\n<h2>Off-the-radar is just how we like it here.</h2>\n<p>The war between the Galactic Republic and the Sith Empire spreads to new worlds! Dangerous fringe groups rise in the dark corners of the galaxy and Darth Malgus pursues an unknown plan... Unravel these mysteries and more as your choices continue to shape the galaxy in Star Wars: The Old Republic.</p>\n<p>Once a bounty hunter allied with the Sith, Shae reluctantly became leader of the Mandalorians and began working with Outlander’s Alliance in <em>Star Wars: The Old Republic</em></p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love.&nbsp;(Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by <em>Star Wars: The Old Republic</em>, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add Shae Vizla to your Vintage Collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Shae Vizla 3.75\" Action Figure</li>\n<li>6x Accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Shae Vizla</strong> - Once a bounty hunter allied with the Sith, Shae reluctantly became leader of the Mandalorians and began working with Outlander’s Alliance in <em>Star Wars: The Old Republic</em></li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Star Wars: The Old Republic</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Shae Vizla toy, inspired by the video game</li>\n<li><strong>Game-based character-inspired accessory</strong> - This Star Wars The Vintage Collection action figure comes with 6 entertainment-inspired accessories including additional helmeted head, that make a great addition to any Star Wars collection</li>\n<li><strong>Premium design and articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Shae Vizla figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n<li><strong>WARNING: Choking hazard</strong> - Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Vintage Collection Shae Vizla Action Figure", 31.07m, 45m },
                    { 24, 24, 1, "\n<h2><strong>Figrin, you've got to start booking us better gigs!</strong></h2>\n<p>The Imperial Forces - under orders from cruel Darth Vader - hold Princess Leia hostage, in their efforts to quell the rebellion against the Galactic Empire. Luke Skywalker and Han Solo captain of the Millennium Falcon, working together with the companionable droid duo R2-D2 and C-3PO to rescue the princess, help the Rebel Alliance, and restore freedom and justice to the Galaxy.</p>\n<p>Figrin D'an was the rocking frontman for the all-Bith band \"The Modal Nodes\". His deft playing of the Kloo Horn for the band earned him the nickname \"Fiery\" Figrin</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. (Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add Figrin D'an to your Vintage Collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Figrin D'an 3.75\" Action Figure</li>\n<li>3x musical instruments</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Figrin D'an</strong> - The rocking frontman for the all-Bith band “The Modal Nodes.” His deft playing of the Kloo Horn for the band earned him the nickname “Fiery” Figrin</li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure</strong> - This Figrin D’an action figure is inspired by the character in <em>Star Wars: A New Hope</em>, and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>Movie-based character-inspired accessories</strong> - This Star Wars The Vintage Collection action figure comes with 3 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium design and articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Shae Vizla figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Vintage Collection Figrin D'an Cantina Action Figure", 29.48m, 35m },
                    { 25, 25, 1, "\n<h2><strong>Save the Rebellion! Save the dream!</strong></h2>\n<p>Former scientist Galen Erso lives on a farm with his wife and young daughter, Jyn. His peaceful existence comes crashing down when the evil Orson Krennic takes him away from his beloved family. Many years later, Galen becomes the Empire's lead engineer for the most powerful weapon in the galaxy, the Death Star. Knowing that her father holds the key to its destruction, Jyn joins forces with a spy and other resistance fighters to steal the space station's plans for the Rebel Alliance.</p>\n<p>Gerrera is bunkered on the ancient world of Jedha coordinating a prolonged insurgency against the Imperial occupation; his ailing health does little to wither his resolve to fight</p>\n<p>Kids and collectors alike can imagine the biggest battles and missions in the Star Wars saga with figures from Star Wars The Black Series! With exquisite features and decoration, this series embodies the quality and realism that Star Wars devotees love. Star Wars The Black Series includes figures, vehicles, and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies, and animated series. (Additional products each sold separately. Subject to availability.)</p>\n<p>This Black Series figure from Hasbro features Saw Gerrera, a known insurgent in hiding from the Empire. The 6-inch-scale Black Series figure is detailed to look like the Saw Gerrera character from <em>Rogue One: A Star Wars Story</em>, featuring premium detail and multiple points of articulation. Add Saw Gerrera to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Saw Gerrera 6\" Action Figure</li>\n<li>2x accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Star wars movie-inspired design</strong> - you can imagine scenes from the Star Wars galaxy with this premium figure.</li>\n<li><strong>Rogue One: A Star Wars Story</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Saw Gerrera toy, inspired by the <em>Rogue One: A Star Wars Story</em> movie</li>\n<li><strong>Movie-Based Character-Inspired Accessories</strong> - This Star Wars The Black Series action figure comes with 2 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Find Other Figures from A Galaxy Far, Far Away</strong> - Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy (Each sold separately. Subject to availability)</li>\n<li><strong>Premium articulation and detailing</strong> - premium decoration and multiple points of articulation for high poseability (4 fully articulated limbs). Advanced articulation allows you to pose your figure in a variety of poses for display in your collection, however you choose.</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Black Series Saw Gerrera Deluxe 6\" Action Figure", 51.78m, 75m },
                    { 26, 26, 1, "\n<h2><strong>Cantina Band.</strong></h2>\n<p>Figrin D’an was the rocking frontman for the all-Bith band “The Modal Nodes.” His deft playing of the Kloo Horn for the band earned him the nickname “Fiery” Figrin.</p>\n<p>Kids and collectors alike can imagine the biggest battles and missions in the Star Wars saga with figures from Star Wars The Black Series! With exquisite features and decoration, this series embodies the quality and realism that Star Wars devotees love. Star Wars The Black Series includes figures, vehicles, and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies, and animated series. <em>(Additional products each sold separately. Subject to availability.)</em></p>\n<p>The 6-inch-scale Black Series figure is detailed to look like the Figrin D’an character from Star Wars: A New Hope, featuring premium detail and multiple points of articulation.</p>\n<p>Add them to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>3 accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>FIGRIN D’AN</strong> - Figrin D’an was the rocking frontman for the all-Bith band “The Modal Nodes.” His deft playing of the Kloo Horn for the band earned him the nickname “Fiery” Figrin</li>\n<li><strong>STAR WARS: A NEW HOPE</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Figrin D’an toy, inspired by the Star Wars: A New Hope, movie</li>\n<li><strong>MOVIE-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Black Series action figure comes with 3 entertainment-inspired accessories that make a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>FIND OTHER FIGURES FROM A GALAXY FAR, FAR AWAY</strong> - Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy (Each sold separately. Subject to availability)</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING</strong> - Star Wars fans and collectors can display this fully articulated figure featuring poseable head, arms, and legs, as well as premium deco, in their collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Black Series Figrin D’an Action Figure", 31.07m, 45m },
                    { 27, 27, 1, "\n<h2><strong>Pokedex Entry #145:</strong></h2>\n<p><em>Zapdos, the Electric Pokémon. A legendary bird Pokémon that is said to appear from clouds when the sky turns dark while dropping enormous lightning bolts. Zapdos has both Electric and Flying elements and the flapping of its wings can create lightning. It is said this lightning causes summer storms. Experts theorise that Zapdos lives inside thunder clouds, and can freely control thunder and lightning bolts from within them.</em></p>\n<p>With more detail, more points of articulation, and more ways to play and display than ever, this 6\" Super Articulated Zapdoz is the perfect addition to any Pokémon trainer's team!</p>\n<p>Grab yours today!</p>\n<h2><strong>Features:</strong></h2>\n<ul>\n<li>Incredible detail that makes this First Partner Pokémon look like it jumped from the Pokémon animated series</li>\n<li>Comes with a Posing Arm accessory for maximum display potential</li>\n</ul>\n<h2><strong>Specifications:</strong></h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx.</li>\n<li><strong>Material:</strong> Plastic</li>\n<li><strong>Articulation:</strong> 15+ points</li>\n<li><strong>For Ages: </strong>8+</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - 25th Anniversary Action Figure - Zapdos", 33.83m, 49m },
                    { 28, 28, 1, "\n<h2><strong>Star Wars Jedi: Fallen Order</strong></h2>\n<p><em>Star Wars Jedi: Fallen Order</em> tells an original story about Cal Kestis, a Padawan who survived the events of Star Wars: Revenge of the Sith.</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. <em>(Additional products each sold separately.&nbsp; Subject to availability.)</em></p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by <em>Star Wars Jedi: Fallen Order</em>, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add them to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>3 accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>HEAVY ASSAULT STORMTROOPER</strong> - Star Wars Jedi: Fallen Order tells an original story about Cal Kestis, a Padawan who survived the events of Star Wars: Revenge of the Sith</li>\n<li><strong>VINTAGE-INSPIRED PACKAGING</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding <em>(Each sold separately. Subject to availability.)</em></li>\n<li><strong>STAR WARS JEDI: FALLEN ORDER</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Heavy Assault Stormtrooper toy, inspired by the Star Wars Jedi: Fallen Order video game</li>\n<li><strong>ENTERTAINMENT-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Vintage Collection action figure comes with 3 detachable entertainment-inspired accessories</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING</strong> - Star Wars fans can display this fully articulated figure featuring poseable head, arms, legs, and premium deco, in their action figure and vehicle collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Vintage Collection Gaming Greats Heavy Assault Stormtrooper Action Figure", 31.07m, 45m },
                    { 29, 29, 1, "\n<h2><strong>Star Wars: The Force Unleashed</strong></h2>\n<p><em>Star Wars: The Force Unleashed</em> follows Darth Vader’s secret apprentice, trained to hunt down Jedi, while Stormtrooper Commanders lead Imperial troops into battle.</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. <em>(Additional products each sold separately.&nbsp; Subject to availability.)</em></p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by <em>Star Wars: The Force Unleashed</em>, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add them to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>2 accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>STORMTROOPER COMMANDER</strong> - Star Wars: The Force Unleashed follows Darth Vader’s secret apprentice, trained to hunt down Jedi, while Stormtrooper Commanders lead Imperial troops into battle&nbsp;</li>\n<li><strong>VINTAGE-INSPIRED PACKAGING</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding <em>(Each sold separately. Subject to availability.)</em></li>\n<li><strong>STAR WARS: THE FORCE UNLEASHED</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Stormtrooper Commander toy, inspired by the Star Wars: The Force Unleashed video game</li>\n<li><strong>ENTERTAINMENT-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Vintage Collection action figure comes with 2 detachable entertainment-inspired accessories</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING</strong> - Star Wars fans can display this fully articulated figure featuring poseable head, arms, legs, and premium deco, in their action figure and vehicle collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Vintage Collection Gaming Greats Stormtrooper Commander Action Figure", 31.07m, 45m },
                    { 30, 30, 1, "\n<h2><strong>This is the way</strong></h2>\n<p>After the stories of Jango and Boba Fett, another warrior emerges in the Star Wars universe. <em>The Mandalorian</em> is set after the fall of the Empire and before the emergence of the First Order. We follow the travails of a lone gunfighter in the outer reaches of the galaxy far from the authority of the New Republic.</p>\n<p>This Retro Collection figure from Hasbro features Boba Fett, as he appeared during the rescue mission on Morak. Add him to your collection today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Mandalorian Retro Collection - Boba Fett (Morak) Action Figure", 21.06m, 25m },
                    { 31, 31, 1, "\n<h2><strong>One day, I will become the greatest Jedi ever.</strong></h2>\n<p>Anakin Skywalker had the potential to become one of the most powerful Jedi ever, and was believed by some to be the prophesied Chosen One who would bring balance to the Force</p>\n<p>Celebrate the legacy of Star Wars, the action-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love. <em>(Additional products each sold separately.&nbsp; Subject to availability.)</em></p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by Star Wars: Attack of the Clones, this Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans.</p>\n<p>Add him to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>1 figure</li>\n<li>4 accessory</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>ANAKIN SKYWALKER (PADAWAN)</strong> - Anakin Skywalker had the potential to become one of the most powerful Jedi ever, and was believed by some to be the prophesied Chosen One who would bring balance to the Force</li>\n<li><strong>VINTAGE-INSPIRED PACKAGING</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding <em>(Each sold separately. Subject to availability.)</em></li>\n<li><strong>CLASSIC STAR WARS FIGURE</strong> - This Anakin Skywalker (Padawan) action figure is inspired by the character in Star Wars: Attack of the Clones and makes a great gift for Star Wars collectors and fans ages 4 and up</li>\n<li><strong>MOVIE-BASED CHARACTER-INSPIRED ACCESSORIES</strong> - This Star Wars The Vintage Collection action figure comes with 4 entertainment-inspired accessories that make a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>PREMIUM DESIGN AND ARTICULATION</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Anakin Skywalker (Padawan) figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Vintage Collection Anakin Skywalker (Padawan) Action Figure", 29.48m, 35m },
                    { 32, 32, 1, "\n<h2><strong>A faithful companion</strong></h2>\n<p>Obi-Wan Kenobi is set years after the dramatic events of Star Wars: Revenge of the Sith where Kenobi faced the corruption of his friend and Jedi apprentice, Anakin Skywalker turned Sith Lord Darth Vader.</p>\n<p>The Star Wars L0-LA59 (Lola) Interactive Electronic Figure let kids and fans alike bring home a beloved droid companion. This Star Wars toy features design and deco inspired by the Obi-Wan Kenobi live-action series on Disney+. Press the button on L0-LA59's head to activate droid sounds and lights in her eye and mouth. Plus, pose the panels on her head, open and close her mouth, and tilt her head from side to side. Kids ages 4 and up will love recreating their favourite Star Wars moments or imagining they're blasting off to a galaxy far, far away.</p>\n<h2>Features:</h2>\n<ul>\n<li><strong>L0-LA59:</strong> Kids can bring home this loveable droid companion, L0-LA59 (Lola), and reimagine iconic Star Wars scenes or create their own</li>\n<li><strong>LIGHTS AND SOUNDS:</strong> Press the button on L0-LA59's head to activate adorable droid sounds, a blue light in her primary eye, and a purple light in her mouth that can be opened and closed&nbsp;</li>\n<li><strong>POSEABLE PANELS AND HEAD:</strong> Adjust the panels on top of L0-LA59's head, tilt her head from side to side, and open and close her mouth to unlock a variety of poses</li>\n<li><strong>SERIES-INSPIRED DESIGN AND DECO:</strong> Standing around 5 inches tall, this Star Wars toy is inspired by the fan-loved character from the Obi-Wan Kenobi live-action series on Disney+</li>\n<li><strong>TOY FOR KIDS AGES 4 AND UP:</strong> This electronic toy makes a great gift for kids 4 years old and up and is the perfect addition to any fan's Star Wars collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size: </strong>12cm tall approx.&nbsp;</li>\n<li><strong>Material:&nbsp;</strong>Plastic</li>\n<li><strong>WARNING: CHOKING HAZARD</strong> – Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Obi-Wan Kenobi - L0-LA59 (Lola) Electronic Action Figure", 58.68m, 85m },
                    { 33, 33, 1, "\n<h2><strong>Master your own Star Wars™ hero's journey.</strong></h2>\n<p>Experience rich and living Star Wars multiplayer battlegrounds across all three eras: prequel, classic, and new trilogy in <em>Star Wars Battlefront II</em>. Customize and upgrade your heroes, starfighters, or troopers, each with unique abilities to exploit in battle. Ride tauntauns or take control of tanks and speeders. Down Star Destroyers the size of cities, use the Force to prove your worth against iconic characters such as Kylo Ren, Darth Maul, or Han Solo, as you play a part in a gaming experience inspired by 40 years of timeless Star Wars films.</p>\n<p>A sportsman seeking fortune at the sabacc tables, Lando had a reputation as a bit of a rogue, but he usually fights on the side of good in this battle across all three eras of the Star Wars Galaxy, Star Wars Battlefront II</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed space saga from a galaxy far, far away, with premium 3.75-inch scale figures and vehicles from Star Wars The Vintage Collection. Figures feature premium detail and design across product and packaging inspired by the original line, as well as the entertainment-inspired collector grade deco that fans have come to know and love.&nbsp;(Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation, inspired by <em>Star Wars Battlefront II</em>, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add Lando Calrissian to your Vintage Collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Lando Calrissian 3.75\" Action Figure</li>\n<li>Hand Blaster</li>\n<li>Cape and scarf</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Lando Calrissian (Star Wars Battlefront II)</strong> - A sportsman seeking fortune at the sabacc tables, Lando had a reputation as a bit of a rogue, but he usually fights on the side of good in this battle across all three eras of the Star Wars Galaxy.</li>\n<li><strong>Vintage-Inspired Packaging</strong> - Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Star Wars Battlefront II</strong> - Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Lando Calrissian (Star Wars Battlefront II) action figure, inspired by the video game</li>\n<li><strong>Game-based character-inspired accessories</strong>&nbsp;- This Star Wars The Vintage Collection action figure comes with 3 entertainment-inspired accessories that make a great addition to any Star Wars collection</li>\n<li><strong>Premium design and articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars Lando Calrissian (Star Wars Battlefront II) figure can be displayed in action figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n<li><strong>WARNING: Choking hazard</strong> - Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Vintage Collection Gaming Greats Lando Calrissian Action Figure", 31.07m, 45m },
                    { 34, 34, 1, "\n<h2><strong>More than meets the eye</strong></h2><p>Worlds collide in this Transformers-G.I. Joe mash-up pack! The Decepticons and Cobra team up to conquer the world! Baroness and Megatron, disguised as a H.I.S.S. Tank, plan the next Cobra attack. The Megatron H.I.S.S. Tank toy converts from robot to tank mode in 28 steps and comes with G.I. Joe Retro Baroness figure. Both figures feature deco and details based on the worlds of Transformers and G.I. Joe. Includes fusion cannon, backpack, and weapon accessories. Accurate scale to the 1983 H.I.S.S. Tank toy. Display Baroness figure at the turret and in the H.I.S.S. tank vehicle mode. Packaging is inspired by a mash-up of the classic ’80s toys with retro artwork. Baroness toy comes on a card back with file card.</p><h2><strong>Includes:</strong></h2><ul><li>2x Figures (1x Megatron, 1x Baroness)</li><li>3x Accessories</li><li>Instructions</li></ul><h2>Features:</h2><ul><li><strong>More Than Meets The Eye -&nbsp;</strong>Transformers robots have always More Than Meets the Eye, but now fans can experience Transformers characters as they mash-up with iconic characters who share this same quality</li><li><strong>Transformers-G.I. Joe Mash-Up -&nbsp;</strong>The Decepticons and Cobra team up to conquer the world! Baroness and Megatron, disguised as a H.I.S.S. Tank, plan the next Cobra attack</li><li><strong>Inspired By G.I. Joe -&nbsp;</strong>Megatron H.I.S.S. Tank toy converts from robot to H.I.S.S. tank mode in 28 steps and comes with G.I. Joe Retro Baroness figure. Deco and details are based on the world of G.I. Joe</li><li><strong>Detail and Accessories -&nbsp;</strong>Includes fusion cannon, backpack, and weapon accessories. Accurate scale to the 1983 H.I.S.S. Tank toy. Display Baroness figure at the turret and in the H.I.S.S. tank vehicle mode</li><li><strong>Special Retro G.I. Joe-Inspired Packaging -&nbsp;</strong>Packaging is inspired by the classic ’80s Transformers and G.I. Joe toy packaging with retro artwork. Baroness figure comes on a card back with file card</li></ul><h2><strong>Specifications:</strong></h2><ul><li><strong>Size:&nbsp;</strong>26cm tall approx.</li><li><strong>For Ages:&nbsp;</strong>8+</li><li><strong>WARNING:</strong>&nbsp;CHOKING HAZARD - Small parts. Not for children under 3 years.</li></ul><p>Official Transformers licensed merchandise</p> ", "Transformers - G.I. Joe Mash-Up - Megatron H.I.S.S. Tank and Baroness Figure", 81.46m, 118m },
                    { 35, 35, 1, "\n<h2><strong>Be Careful What You Wish For</strong></h2>\n<p>For the first time in the cinematic history of Spider-Man, our friendly neighbourhood hero is unmasked and no longer able to separate his normal life from the high-stakes of being a Super Hero. When he asks for help from Doctor Strange, the stakes become even more dangerous, forcing him to discover what it truly means to be Spider-Man.</p>\n<p>Spider-Man gears up in his Integrated Suit to bravely confront a new threat.</p>\n<p>With over 80 years of comic book history, Marvel has become a cornerstone of fan collections around the world. With the Marvel Legends Series, fan favourite Marvel Comic Universe and Marvel Cinematic Universe characters are designed with premium detail and articulation for top-of-the-line poseable and displayable collectibles.</p>\n<p>This figure features Spiderman, in his integrated suit. Add him to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Spider-Man 6\" action figure</li>\n<li>2x slinging interchangeable hands</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>6-Inch-Scale Collectible Figure</strong> - Fans, collectors, and kids alike can enjoy this 6-inch-scale figure, inspired by the character from Marvel Studios’ Spider-Man: No Way Home.</li>\n<li><strong>Marvel Entertainment-Inspired Design</strong> - This 6-inch scale Integrated Suit Spider-Man figure features premium design, detail, and articulation for posing and display in a Marvel collection</li>\n<li><strong>Premium Articulation and Detailing</strong> - This 6-inch Legends Series Integrated Suit Spider-Man figure features multiple points of articulation and is a great addition to any action figure collection</li>\n<li><strong>Marvel Universe in 6-Inch Scale</strong> - Look for other Marvel Legends Series figures (each sold separately) with comic- and movie-inspired characters, including Spider-Man, Captain America, and Black Panther. (Additional figures each sold separately. Subject to availability.)</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n<li><strong>WARNING:</strong> CHOKING HAZARD - Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Marvel licensed merchandise</p> ", "Marvel Legends Spider-Man: No Way Home Spider-Man Action Figure", 31.07m, 45m },
                    { 36, 36, 1, "\n<h2><strong>The One and Only</strong></h2>\n<p>Following the events of <em>Avengers: Endgame</em>, Thor attempts to find inner peace but must return to action and recruit Valkyrie, Korg, and others to stop Gorr the God Butcher from eliminating all gods.</p>\n<p>This figure features Thor from the film, a continuation of the character from <em>Avengers: Endgame</em>.</p>\n<p>Add him to your collection today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Marvel licensed merchandise</p> ", "Marvel - Legends Series - Thor: Love And Thunder Thor Figure", 31.07m, 45m },
                    { 37, 37, 1, "\n<h2><strong>Pokedex Entry #384:</strong></h2>\n<p><em>Rayquaza, the sky-high pokemon. Rayquaza lived for hundreds of millions of years in the earth's ozone layer, never descending to the ground, though it is said it would descend to the ground if Kyogre and Groudon were to fight. This Pokémon appears to feed on water and particles in the atmosphere. Its flying form looks like a meteor. Due to its habitation in the Ozone layer, no one had ever seen it until recently as it cannot be seen from the ground.</em></p>\n<p>With more detail, more points of articulation, and more ways to play and display than ever, this 6\" Super Articulated Rayquaza is the perfect addition to any Pokémon trainer's team!</p>\n<p>Grab yours today!</p>\n<h2><strong>Features:</strong></h2>\n<ul>\n<li>Incredible detail that makes this First Partner Pokémon look like it jumped from the Pokémon animated series</li>\n<li>Comes with a Posing Arm accessory for maximum display potential</li>\n</ul>\n<h2><strong>Specifications:</strong></h2>\n<ul>\n<li><strong>Size:</strong> 15cm tall approx.</li>\n<li><strong>Material:</strong> Plastic</li>\n<li><strong>Articulation:</strong> 15+ points</li>\n<li><strong>For Ages:</strong> 8+</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - 25th Anniversary Rayquaza Select Articulated Figure", 33.83m, 49m },
                    { 38, 38, 1, "\n<h2><strong>This is the way</strong></h2><p>After the stories of Jango and Boba Fett, another warrior emerges in the Star Wars universe. <em>The Mandalorian</em> is set after the fall of the Empire and before the emergence of the First Order. We follow the travails of a lone gunfighter in the outer reaches of the galaxy far from the authority of the New Republic.</p><p>This Retro Collection figure from Hasbro features the Mandalorian Din Djarin, wearing his shiny new Beskar armour. Add him to your collection today!</p><h2>Specifications:</h2><ul><li><strong>Size:</strong> 9.5cm tall approx</li><li><strong>Material:</strong> Plastic</li></ul><p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Mandalorian - Retro Collection Din Djarin (Beskar) Action Figure", 21.06m, 25m },
                    { 39, 39, 1, "\n<h2><strong>This is the way</strong></h2>\n<p>After the stories of Jango and Boba Fett, another warrior emerges in the Star Wars universe. <em>The Mandalorian</em> is set after the fall of the Empire and before the emergence of the First Order. We follow the travails of a lone gunfighter in the outer reaches of the galaxy far from the authority of the New Republic.</p>\n<p>When The Mandalorian embarks on a mission to save Grogu from Moff Gideon, he receives unexpected help in the form of Luke Skywalker.</p>\n<p>Kids and collectors alike can imagine the biggest battles and missions in the Star Wars saga with figures from Star Wars The Black Series! With exquisite features and decoration, this series embodies the quality and realism that Star Wars devotees love. Star Wars The Black Series includes figures, vehicles, and roleplay items from the 40-plus-year legacy of the Star Wars Galaxy, including comics, movies, and animated series. (Additional products each sold separately. Subject to availability.)</p>\n<p>The 6-inch-scale Black Series figure is detailed to look like the Luke Skywalker (Imperial Light Cruiser) character from The Mandalorian, featuring premium detail and multiple points of articulation.</p>\n<h2>Includes:</h2>\n<ul>\n<li>Figure</li>\n<li>Accessory</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>LUKE SKYWALKER (IMPERIAL LIGHT CRUISER): </strong>When The Mandalorian embarks on a mission to save Grogu from Moff Gideon, he receives unexpected help in the form of Luke Skywalker</li>\n<li><strong>THE MANDALORIAN: </strong>Fans and collectors can imagine scenes from the Star Wars Galaxy with this premium Luke Skywalker (Imperial Light Cruiser) toy, inspired by The Mandalorian live-action series on Disney+</li>\n<li><strong>SERIES-BASED CHARACTER-INSPIRED ACCESSORY: </strong>This Star Wars The Black Series action figure comes with 1 entertainment-inspired accessory that makes a great addition to any Star Wars collection</li>\n<li><strong>FIND OTHER FIGURES FROM A GALAXY FAR, FAR AWAY: </strong>Find movie- and entertainment-inspired Star Wars The Black Series figures to build a Star Wars galaxy (Each sold separately. Subject to availability)</li>\n<li><strong>PREMIUM ARTICULATION AND DETAILING: </strong>Star Wars fans and collectors can display this fully articulated figure featuring poseable head, arms, and legs, as well as premium deco, in their collection</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>15cm tall approx.&nbsp;</li>\n<li><strong>Material:&nbsp;</strong>Plastic</li>\n<li><strong>WARNING: CHOKING HAZARD</strong> – Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - The Mandalorian - The Black Series Luke Skywalker Action Figure", 31.07m, 45m },
                    { 40, 40, 1, "\n<h2><strong>Mankind's finest achievement. Our nation's proudest moment. A secret hidden for forty years.</strong></h2>\n<p>Sam Witwicky and his new girlfriend, Carly, join the fray when the evil Decepticons renew their longstanding war against the Autobots. Optimus Prime believes that resurrecting ancient Transformer Sentinel Prime, once the leader of the Autobots, may lead to victory. That decision, however, has devastating consequences; the war appears to tip in favour of the Decepticons, leading to a climactic battle in Chicago.</p>\n<p>Studio Series has always allowed fans to reach past the big screen and build the ultimate Transformers collection inspired by iconic movie scenes from the Transformers movie universe. Now, the Studio Series line is expanding to include the epic moments and characters from the classic 1986 The Transformers: The Movie, bringing fans a whole new series of screen-inspired figures to collect! (Each sold separately. Subject to availability.)</p>\n<p>This Studio Series 87 Deluxe Class <em>Transformers: Dark of the Moon</em>-inspired Bumblebee figure converts from robot to licensed Camaro mode in 39 steps. Remove backdrop to showcase Bumblebee in the Battle of Chicago scene. In the Battle of Chicago scene from Transformers: Dark of the Moon, a well-timed distraction allows Bumblebee to escape execution at the hands of Soundwave. Pose the figure out with the included blaster accessory and imagine re-creating this classic movie moment!</p>\n<p>Add Bumblebee to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>Figure</li>\n<li>Accessory</li>\n<li>Removable backdrop</li>\n<li>Instructions</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>Studio Series Deluxe Class</strong> - Deluxe Class figures are 4.5-inch collectible action figures inspired by iconic movie scenes and designed with specs and details to reflect the Transformers movie universe, now including The Transformers: The Movie!</li>\n<li><strong>4.5-Inch Scale Bumblebee</strong> - Figure features vivid, movie-inspired deco, is highly articulated for posability and comes with a blaster accessory inspired by the film</li>\n<li><strong>Big Screen Inspired</strong> - Figure scale reflects the character’s size in the world of <em>Transformers: Dark of the Moon</em>. Figure and packaging are inspired by the iconic Battle of Chicago scene</li>\n<li><strong>2 Iconic Modes</strong> - Figure features classic conversion between robot and licensed Camaro modes in 39 steps. Perfect for fans looking for a more advanced converting figure. For kids and adults ages 8 and up</li>\n<li><strong>Removable Backdrop</strong> - Removable backdrop displays Bumblebee figure in the Battle of Chicago scene. Fans can use the backdrop and pose their figures in the scene with their own style</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 11cm tall approx</li>\n<li><strong>Material:</strong> Plastic</li>\n<li><strong>For Ages:</strong> 8+</li>\n<li><strong>WARNING:</strong> Choking Hazard - Small parts. Not for children under 3 years.</li>\n</ul>\n<p>Official Transformers licensed merchandise</p> ", "Transformers: Dark of the Moon - Studio Series 87 Deluxe Bumblebee Action Figure", 31.07m, 45m },
                    { 41, 41, 1, "\n<h2><strong>You showed valour out there. Real courage.</strong></h2>\n<p>Before the rise of the Galactic Empire, there was the Old Republic and the Clone Wars. Taking place after <em>Star Wars: Episode II - Attack of the Clones</em> (2002) and detailing the events that lead into <em>Star Wars: Episode III - Revenge of the Sith</em> (2005), <em>Star Wars: Clone Wars</em> (2003) shows the Jedi Council's finest hour and how this war changes the galaxy forever.</p>\n<p>A prestigious promotion from clone trooper, the rank of ARC Trooper can be earned through proving oneself in battle.</p>\n<p>Celebrate the legacy of Star Wars, the action-and-adventure-packed Star Wars saga with premium 3.75-inch scale figures, vehicles, and playsets from Star Wars The Vintage Collection. Toys feature premium detail and design across product and packaging inspired by the original line, as well as the movie-inspired collector grade deco that fans have come to know and love.&nbsp;Experience the excitement and action of a galaxy far, far away with figures from the Star Wars The Vintage Collection! (Additional products each sold separately. Subject to availability.)</p>\n<p>Featuring premium detail and design across multiple points of articulation inspired by Star Wars: Clone Wars, this collectible Star Wars The Vintage Collection 3.75-inch-scale figure makes a great gift for Star Wars fans and collectors.</p>\n<p>Add this ARC Trooper Captain to your collection today!</p>\n<h2>Includes:</h2>\n<ul>\n<li>ARC Trooper Captain Vintage Collection 3.75\" Action Figure</li>\n<li>2x Blaster Accessories</li>\n</ul>\n<h2>Features:</h2>\n<ul>\n<li><strong>ARC Trooper Captain&nbsp;</strong>- A prestigious promotion from clone trooper, the rank of ARC Trooper can be earned through proving oneself in battle</li>\n<li><strong>Vintage-Inspired Packaging</strong>&nbsp;- Star Wars The Vintage Collection 3.75-inch scale classic Star Wars figures and vehicles feature original Kenner branding (Each sold separately. Subject to availability.)</li>\n<li><strong>Classic Star Wars Figure</strong>&nbsp;- ARC Trooper Captain action figure is inspired by the character in Star Wars: Clone Wars series animated in the iconic Genndy Tartakovsky style; great gift for Star Wars fans</li>\n<li><strong>Star Wars: Clone Wars ARC Trooper Captain Accessories</strong> - Star Wars The Vintage Collection action figure with 2 entertainment-inspired accessories; a great addition to any Star Wars collection&nbsp;</li>\n<li><strong>Premium Design and Articulation</strong> - Highly articulated with fully poseable head, arms, and legs, the Star Wars ARC Trooper Captain figure can be displayed in action-figure and vehicle collections</li>\n</ul>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> ABS Plastic</li>\n<li><strong>For Ages:</strong> 4+</li>\n</ul>\n<p>Official Star Wars licensed merchandise</p> ", "Star Wars - Clone Wars - Vintage Collection ARC Trooper Captain Action Figure", 24.42m, 29m },
                    { 42, 42, 0, "\n<h2>San Diego Comic-Con is Back and Better Than Ever</h2>\n<p>For the first time since 2019, Comic-Con returns to the San Diego Convention Center on July 21 - 24, 2022! Since 1970, The San Diego Comic-Con has been dedicated to generating public awareness of and appreciation for comics and popular culture. Many Comic, Sci-fi and Pop Culture announcements occur over the event, and unique new collectibles are also announced. Since we can't all be in San Diego, we're bringing Comic-Con to you with a bunch of exciting freshly-announced collectibles.</p>\n<p>Get in fast as they are expected to sell out quickly!</p>\n<h2><strong>Pokedex Entry #004:</strong></h2>\n<p><em>Charmander, the Lizard Pokémon. A flame burns on the tip of its tail from birth. Charmander's health can be gauged by the fire on the tip of its tail, which burns intensely when it's in good health. It is said that a Charmander dies if its flame ever goes out. Charmander's special attack is Rage. It gains more power the more it is attacked. It will continue to fight until its opponent falls.</em></p>\n<p>This Pop! features Charmander, rendered in a shiny metallic finish. Add him to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Charmander Metallic Pop! Vinyl Figure", 17.67m, 25m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AttributesId", "Category", "Description", "Name", "PurchasePrice", "SalePrice" },
                values: new object[,]
                {
                    { 43, 43, 0, "\n<h2>Funko Fair 2022</h2>\n<p>Funko Fair is back! A virtual event to celebrate all things Funko and provide an exclusive glimpse at what's to come in 2022. Funko is always discovering new ways to surprise and delight fans by bringing the best of pop culture directly to them.</p>\n<p>Keep checking back daily for more exciting announcements!</p>\n<h2><strong>Pokedex Entry #393:</strong></h2>\n<p><em>Piplup, the penguin pokemon. Its thick down protects it from the cold. Although not the most sure-footed, it is proud nonetheless, getting right back up after a fall with head held high. Because it is very proud, it hates accepting food from people. It doesn't like to be taken care of. It's difficult to bond with since it won't listen to its Trainer, making it a tricky starter pokemon for new trainers. It lives along shores in northern countries. A skilled swimmer, it dives for over 10 minutes to hunt.</em></p>\n<p>This Pop! features the water Sinnoh starter, Piplup. Add Piplup to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Piplup Pop! Vinyl Figure", 19.44m, 23m },
                    { 44, 44, 0, "\n<h2><strong>Pokedex Entry #025:</strong></h2>\n<p><em>Pikachu - The mouse pokémon. This pokémon has electricity-storing pouches on its cheeks. These appear to become electrically charged during the night while Pikachu sleeps. It occasionally discharges electricity when it is dozy after waking up. Pikachu can help other Pikachu who are feeling weak by sharing its electric current. Pikachu's tail is sometimes struck by lightning as it raises it to check its surroundings. When several of these Pokémon gather, their electricity could build up and cause lightning storms. Forest dwellers, they are few in number and exceptionally rare. The pouches in their cheeks discharge electricity at their opponents. Pikachu are believed to be highly intelligent.</em></p>\n<p>The face of the Pokemon franchise since 1995, Pikachu is universally recognised and adored by fans the world over. Whether you've played Pokemon Yellow with Pikachu following behind you, or followed Ash Ketchum's journey to be a Pokemon master with Pikachu at his side, there's no denying the equal portions of gumption and adorability present in this little guy!</p>\n<p>This Pop! features Pikachu waving with a fuzzy flocked finish.&nbsp;</p>\n<p>Add Pikachu to your party today!</p>\n<h2><strong>Specifications:</strong></h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>9.5cm tall approx.</li>\n<li><strong>Material:&nbsp;</strong>Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Pikachu Waving Flocked Pop! Vinyl Figure", 17.67m, 25m },
                    { 45, 45, 0, "\n <h2><strong>Pokedex Entry #150</strong></h2>\n<p><em>Mewtwo was created by a scientist after years of horrific gene splicing and DNA engineering experiments. Its DNA is almost the same as Mew's. However, its size and disposition are vastly different. A vicious psychic Pokémon created by genetic engineering. Its cold, glowing eyes strike fear into its enemy. It usually remains motionless to conserve energy, so that it may unleash its full power in battle. Rumoured to rest quietly in an undiscovered cave, this Pokémon was created solely for battling. Because its battle abilities were raised to the ultimate level, it thinks only of defeating its foes. It's said to have the most savage heart among Pokémon.</em></p>\n<p>Grow your collection with the latest additions to the Pokémon Pop! vinyl figures line up featuring Vulpix, MewTwo, Mr. Mime, and Pichu.</p>\n<p>This Pop! Vinyl figure features the formidable Mewtwo.</p>\n<p>Grab yours today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong>&nbsp;9.5cm tall approx</li>\n<li><strong>Material:</strong>&nbsp;Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Mewtwo Pop! Vinyl Figure", 19.44m, 23m },
                    { 46, 46, 0, "\n<h2><strong>Pokedex Entry #700:</strong></h2>\n<p><em>Sylveon, the Intertwining Pokémon. It evolves from Eevee when leveled up knowing a Fairy-type move and having at least two levels of Affection. Sylveon affectionately wraps its ribbon-like feelers around its Trainer's arm as they walk together. When this Pokémon sights its prey, it swirls its ribbon-like feelers as a distraction. A moment later, it pounces. It sends a soothing aura from its feelers to calm fights, and to weaken the hostility in its foes.</em></p>\n<p>This Pop! Vinyl figure features Sylveon, the most recent member of the Eeveelution family.</p>\n<p>Add them to your collection today!</p>\n<h2><strong>Specifications:</strong></h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>9.5cm tall approx.&nbsp;</li>\n<li><strong>Material:&nbsp;</strong>Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Sylveon Pop! Vinyl Figure", 19.44m, 23m },
                    { 47, 47, 0, "\n<h2>New York Toy Fair</h2>\n<p>The New York Toy Fair is the largest dedicated toy, game and hobby trade show in the Western Hemisphere, annually held in mid-February. Beginning in 1903, the toy industry's showcase attracts more than 30,000 attendees each year, where some of the biggest toys and collectibles of the year are announced.</p>\n<p>Get in fast as they are expected to sell out quickly!</p>\n<h2><strong>Pokedex Entry #025:</strong></h2>\n<p><em>Pikachu - The mouse pokémon. This pokémon has electricity-storing pouches on its cheeks. These appear to become electrically charged during the night while Pikachu sleeps. It occasionally discharges electricity when it is dozy after waking up. Pikachu can help other Pikachu who are feeling weak by sharing its electric current. Pikachu's tail is sometimes struck by lightning as it raises it to check its surroundings. When several of these Pokémon gather, their electricity could build up and cause lightning storms. Forest dwellers, they are few in number and exceptionally rare. The pouches in their cheeks discharge electricity at their opponents. Pikachu are believed to be highly intelligent.</em></p>\n<p>This Pop! features Pikachu, grumpy and ready to battle! Add one to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Pikachu Grumpy Pop! Vinyl Figure", 19.44m, 23m },
                    { 48, 48, 0, "\n<h2><strong>Pokedex Entry #006:</strong></h2>\n<p><em>Charizard, the Flame Pokémon. Charizard is a Flying and Fire-type. When competing in intense battles, Charizard's flame becomes more intense as well. If Charizard becomes furious, the flame at the tip of its tail flares up in a whitish-blue colour. Charizard's powerful flame can melt absolutely anything - it spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally. Dragon Rage is one of Charizard's most powerful attacks; it usually has a devastating effect on its opponents.</em></p>\n<p>This supersized 10\" Pop! features Charizard, the final evolution of Charmander's evolutionary chain. Add Charizard to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 25.4cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Charizard 10\" Pop! Vinyl Figure", 60.07m, 85m },
                    { 49, 49, 0, "\n<h2><strong>Pokedex Entry #007:</strong></h2>\n<p><em>Squirtle. This Tiny Turtle Pokémon draws its long neck into its shell to launch incredible water attacks with amazing range and accuracy. The blasts can be quite powerful. It takes time for the shell to form and harden after hatching. Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in water, enabling this Pokémon to swim at high speeds.</em></p>\n<p>When Professor Oak first asked the question, 'Which pokemon will you choose?' many trainers opted for the water-type, Squirtle. With a shell offering superior defence and a super-strong water-projectile attack style, Squirtle is strong and only gets stronger as it evolves, making it ideal for new trainers and pokemon masters alike. As an added bonus, Squirtle is super adorable!</p>\n<p>This version is rendered in a metallic silver finish to celebrate Pokemon's 25th Silver Anniversary. Add Squirtle to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Squirtle Silver Metallic 25th Anniversary Pop! Vinyl Figure", 17.67m, 25m },
                    { 50, 50, 0, "\n<h2>Funko Fair 2022</h2><p>Funko Fair is back! A virtual event to celebrate all things Funko and provide an exclusive glimpse at what's to come in 2022. Funko is always discovering new ways to surprise and delight fans by bringing the best of pop culture directly to them.</p><p>Keep checking back daily for more exciting announcements!</p><h2><strong>Pokedex Entry #131:</strong></h2><p>Lapras, the Transport Pokémon. A smart and kindhearted Pokémon, it glides across the surface of the sea while its beautiful song echoes around it. This intellectually advanced Pokémon is able to understand human speech. With its mild temperament, Lapras prefers to carry humans on its back, rather than engage in Pokémon battles. These Pokémon were once near extinction due to poaching. Following protective regulations, there is now an overabundance of them.</p><p>This Pop! features Lapras, the gentle giant of the sea. Add Lapras to your party today!</p><h2>Specifications:</h2><ul><li><strong>Size:</strong> 9.5cm tall approx</li><li><strong>Material:</strong> Plastic/Vinyl</li></ul><p>Official Pokemon licensed merchandise</p> ", "Pokemon - Lapras Pop! Vinyl Figure", 19.44m, 23m },
                    { 51, 51, 0, "\n<h2><strong>Pokedex Entry #116:</strong></h2>\n<p><em>Horsea, the little horse pokemon of the sea. In this unique Pokémon species, thousands of Eggs hatch every spring, and then the male raises them himself. If it senses any danger, it will vigorously spray water or a special type of ink from its mouth. Known to shoot down flying bugs with precision blasts of ink from the surface of the water. It uses its tail to keep its balance while spraying ink from its mouth. Its big, developed fins move rapidly, allowing it to swim backward while still facing forward. If attacked by a larger enemy, it quickly swims to safety by adeptly controlling its dorsal fin. When they're in a safe location, they can be seen playfully tangling their tails together. Horsea eats small insects and moss off of rocks. If the ocean current turns fast, this Pokémon anchors itself by wrapping its tail around rocks or coral to prevent being washed away. It makes its nest in the shade of corals. If it senses danger, it spits murky ink and flees. They swim with dance-like motions and cause whirlpools to form. Horsea compete to see which of them can generate the biggest whirlpool.</em></p>\n<p>This Pop! features Horsea, upright on its coiled tail and ready to spirt ink at any perceived threat. Add Horsea to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Horsea Pop! Vinyl Figure", 12.68m, 15m },
                    { 52, 52, 0, "\n<h2>Celebrate the festive season early with Funko!</h2>\n<p>Tis the season for collecting and gifting your favourite figures ahead of the festive season!</p>\n<p>Join us in celebrating Funko's Festival of Fun where you can capture Pop! vinyl figures, advent calendars and more featuring some of your favourite characters, filled with holiday cheer! Preorder yours now to avoid disappointment, these will not last!</p>\n<h2><strong>Gotta Catch 'Em All!</strong></h2>\n<p>Welcome to the world of Pokemon! For 25 years Pokemon trainers across the globe have been catching, training and battling their favourite Pokemon to see who is truly the very best, like no one ever was. There are so many ways to enjoy Pokemon too - including video games, the Pokémon Trading Card Game, the animated TV series, movies, toys, and much more.</p>\n<p>Count down this festive season with this Pokemon Pocket Pop Advent Calendar! Featuring all your favourite Pokemon from the original generation, now in miniature Pocket Pop form!</p>\n<p>Grab yours today.</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> each gift stands 3.8cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon Pocket Pop! 2021 Advent Calendar", 55.83m, 79m },
                    { 53, 53, 0, "\n<h2><strong>Pokedex Entry #010:</strong></h2>\n<p><em>Caterpie, the Worm Pokémon. It is covered with green skin and has large, eye-like patterns on its head as protection, used to frighten off enemies. Also to repel enemies, Caterpie releases an unpleasant odour from its red antenna. If you touch the feeler on top of its head, it will release a horrible stink to protect itself. Its short feet are tipped with suction pads that Caterpie uses to tirelessly climb slopes and walls, as well as trees to feed on its favourite leaves. Perhaps because it would like to grow up quickly, Caterpie has a voracious appetite. It can devour leaves bigger than its body without hesitation right before your eyes. It moults several times while growing. When it grows, it sheds the skin, covers itself with silk, and becomes a cocoon.</em></p>\n<p>This Pop! features Caterpie, the humble bug pokemon. It won't stay that way for long though - new trainers will find it easy to train this pokemon to evolve into Metapod and then Butterfree very quickly! Add Caterpie to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Caterpie Pop! Vinyl Figure", 19.44m, 23m },
                    { 54, 54, 0, "\n<h2>Funko Fair 2022</h2><p>Funko Fair is back! A virtual event to celebrate all things Funko and provide an exclusive glimpse at what's to come in 2022. Funko is always discovering new ways to surprise and delight fans by bringing the best of pop culture directly to them.</p><p>Keep checking back daily for more exciting announcements!</p><h2><strong>Pokedex Entry #131:</strong></h2><p>Lapras, the Transport Pokémon. A smart and kindhearted Pokémon, it glides across the surface of the sea while its beautiful song echoes around it. This intellectually advanced Pokémon is able to understand human speech. With its mild temperament, Lapras prefers to carry humans on its back, rather than engage in Pokémon battles. These Pokémon were once near extinction due to poaching. Following protective regulations, there is now an overabundance of them.</p><p>This 10\" supersized Pop! features Lapras, the gentle giant of the sea. Add Lapras to your party today!</p><h2>Specifications:</h2><ul><li><strong>Size:</strong> 25.4cm tall approx</li><li><strong>Material:</strong> Plastic/Vinyl</li></ul><p>Official Pokemon licensed merchandise</p> ", "Pokemon - Lapras 10\" Pop! Vinyl Figure", 60.07m, 85m },
                    { 55, 55, 0, "\n<h2><strong>Pokedex Entry #017:</strong></h2>\n<p><em>Pidgeotto, the bird pokemon, and evolved form of Pidgey. A Normal and Flying type. Pidgeotto maintains a wide territory, giving any intruders a thorough pecking. It is armed with sharp claws and dives from the sky to capture its prey. Unlike the more gentle Pidgey, Pidgeotto can be dangerous. Approach with extreme caution. This Pokémon is full of vitality. It constantly flies in a circular pattern around its large territory, all the while keeping a sharp lookout for prey. It builds its nest in the centre of its large territory. It has outstanding vision. However high it flies, it is able to distinguish the movements of its prey. It swiftly snatches and immobilizes its prey using well-developed talons, then carries the prey more than 60 miles to its nest.</em></p>\n<p>This Pop! features Pidgeotto, just like the one Ash caught. Add Pidgeotto to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Pidgeotto Pop! Vinyl Figure", 19.44m, 23m },
                    { 56, 56, 0, "\n<h2>Funko Fair 2022</h2><p>Funko Fair is back! A virtual event to celebrate all things Funko and provide an exclusive glimpse at what's to come in 2022. Funko is always discovering new ways to surprise and delight fans by bringing the best of pop culture directly to them.</p><p>Keep checking back daily for more exciting announcements!</p><h2><strong>Pokedex Entry #470:</strong></h2><p><em>Leafeon, the Verdant Pokémon. It evolves from Eevee when it is levelled up near a Moss Rock. Its cellular composition is closer to that of a plant than an animal. Leafeon is always surrounded by fresh clean air because it uses photosynthesis just like a plant to produce its energy supply without eating food. When you see Leafeon asleep in a patch of sunshine, you'll know it is using photosynthesis to produce clean air. It basically does not fight. The younger they are, the more they smell like fresh grass. With age, their fragrance takes on the odour of fallen leaves.</em></p><p>This Pop! features Leafeon. Add Leafeon to your collection today!</p><h2>Specifications:</h2><ul><li><strong>Size:</strong> 9.5cm tall approx</li><li><strong>Material:</strong> Plastic/Vinyl</li></ul><p>Official Pokemon licensed merchandise</p> ", "Pokemon - Leafeon Pop! Vinyl Figure", 19.44m, 23m },
                    { 57, 57, 0, "\n<h2><strong>Pokedex Entry #077:</strong></h2>\n<p><em>Ponyta, the fire horse pokemon. Its hooves are 10 times harder than diamonds. It can trample anything completely flat in little time. Capable of jumping over the Eiffel Tower in a single giant leap. Its hooves and sturdy legs absorb the impact of a hard landing. It is a weak runner immediately after birth. It gradually becomes faster by chasing after its parents.</em></p>\n<p>This Pop! features Ponyta, with its resplendent fiery mane and tail. Add Ponyta to your collection today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Ponyta Pop! Vinyl Figure", 19.44m, 23m },
                    { 58, 58, 0, "\n<h2>Funko Fair 2021</h2>\n<p>Welcome to the inaugural Funko Fair - a two-week virtual event to celebrate all things Funko and provide an exclusive glimpse at what's to come in 2021. Funko is always discovering new ways to surprise and delight fans by bringing the best of pop culture directly to them.</p>\n<p>Keep checking back daily for more exciting announcements!</p>\n<h2><strong>Pokedex Entry #052:</strong></h2>\n<p>Meowth is a Normal type Pokémon introduced in Generation 1. It is known as the Scratch Cat Pokémon. Meowth has a new Alolan form introduced in Pokémon Sun/Moon.</p>\n<p>This Pop! features Meowth. Show your support for Team Rocket with this Meowth Pop! Add this to your collection today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li>Size: 9.5cm tall approx</li>\n<li>Material: Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Meowth Pop! Vinyl Figure", 19.44m, 23m },
                    { 59, 59, 0, "\n<h2><strong>Pokedex Entry #065:</strong></h2>\n<p><em>Alakazam, the Psi Pokémon. It has an incredibly high level of intelligence. Some say that Alakazam remembers everything that ever happens to it, from birth till death. Alakazam wields potent psychic powers. It’s said that this Pokémon used these powers to create the spoons it holds.</em></p>\n<p>This Pop! Vinyl figure features the original psychic powerhouse Pokemon, Alakazam.</p>\n<p>Add them to your collection today!</p>\n<h2><strong>Specifications:</strong></h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>9.5cm tall approx.&nbsp;</li>\n<li><strong>Material:&nbsp;</strong>Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Alakazam Pop! Vinyl Figure", 19.44m, 23m },
                    { 60, 60, 0, "\n<h2><strong>Pokedex Entry #004:</strong></h2>\n<p><em>Charmander, the Lizard Pokémon. A flame burns on the tip of its tail from birth. Charmander's health can be gauged by the fire on the tip of its tail, which burns intensely when it's in good health. It is said that a Charmander dies if its flame ever goes out. Charmander's special attack is Rage. It gains more power the more it is attacked. It will continue to fight until its opponent falls.</em></p>\n<p>When Professor Oak first asked the question, 'Which Pokemon will you choose?' many trainers chose the fire pokemon Charmander. Although fire pokemon are considered to be difficult for trainers just starting out on their journey, who could resist Charmander? Despite the challenge, Charmander is loyal to any trainer who cares for it and invests in its training.</p>\n<p>This version is rendered in a metallic silver finish to celebrate Pokemon's 25th Silver Anniversary. Add Charmander to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Charmander Silver Metallic 25th Anniversary Pop! Vinyl Figure", 17.67m, 25m },
                    { 61, 61, 0, "\n<h2><strong>Pokedex Entry #025:</strong></h2>\n<p><em>Pikachu - The mouse pokémon. This pokémon has electricity-storing pouches on its cheeks. These appear to become electrically charged during the night while Pikachu sleeps. It occasionally discharges electricity when it is dozy after waking up. Pikachu can help other Pikachu who are feeling weak by sharing its electric current. Pikachu's tail is sometimes struck by lightning as it raises it to check its surroundings. When several of these Pokémon gather, their electricity could build up and cause lightning storms. Forest dwellers, they are few in number and exceptionally rare. The pouches in their cheeks discharge electricity at their opponents. Pikachu are believed to be highly intelligent.</em></p>\n<p>The face of the Pokemon franchise since 1995, Pikachu is universally recognised and adored by fans the world over. Whether you've played Pokemon Yellow with Pikachu following behind you, or followed Ash Ketchum's journey to be a Pokemon master with Pikachu at his side, there's no denying the equal portions of gumption and adorability present in this little guy! This version features a limited Silver metallic finish.</p>\n<p>Grab yours today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Pikachu Silver Metallic Pop! Vinyl Figure", 17.67m, 25m },
                    { 62, 62, 0, "\n<h2><strong>Pokedex Entry #448:</strong></h2>\n<p><em>Lucario, the Aura Pokémon. It controls waves known as auras, which are powerful enough to pulverize huge rocks. It uses these waves to take down its prey. It can tell what people are thinking. Only Trainers who have justice in their hearts can earn this Pokémon’s trust.</em></p>\n<p>This 10\" supersized Pop! features one of the most popular Pokemon, Lucario.&nbsp;</p>\n<p>Add them to your collection today!</p>\n<h2><strong>Specifications:</strong></h2>\n<ul>\n<li><strong>Size:&nbsp;</strong>25.4cm tall approx</li>\n<li><strong>Material:&nbsp;</strong>Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Lucario 10\" Pop! Vinyl Figure", 60.07m, 85m },
                    { 63, 63, 0, "\n<h2><strong>Pokedex Entry #037:</strong></h2>\n<p><em>Vulpix, The fox Pokémon. A fire type Pokémon with a quadruped build grows to an average height of two feet and weighing approximately 28 lbs.&nbsp;</em><em>Vulpix are native to all known regions with the exception of Kalos.</em><em>&nbsp;Inside Vulpix's body burns a flame that never goes out. During the daytime, when the temperatures rise, this Pokémon releases flames from its mouth to prevent its body from growing too hot.&nbsp; It can freely control fire, making fiery orbs fly like will-o'-the-wisps. Both its fur and its tails are beautiful. Born with a singular white tail, it grows its additional tails over time. As each tail grows, its fur becomes more lustrous.&nbsp;</em><em>It is quite warm and cuddly.&nbsp;</em><em>Exposure to a fire stone causes this Pokemon to evolve into Ninetails. Before evolving, Vulpix's six-part tail can become as hot as a fiery blaze.</em></p>\n<p>Grow your collection with the latest additions to the Pokémon Pop! vinyl figures line up featuring Vulpix, MewTwo, Mr Mime, and Pichu.</p>\n<p>This Pop! Vinyl figure features the adorable Vulpix.</p>\n<p>Grab yours today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Vulpix Pop! Vinyl Figure", 19.44m, 23m },
                    { 64, 64, 0, "\n<h2><strong>Pokedex Entry #136:</strong></h2>\n<p><em>Flareon, the Flame Pokémon. It evolves from Eevee when exposed to a Fire Stone. It stores some of the air it breathes in its internal flame sac, which heats its flame to over three thousand degrees. Flareon's fluffy fur has a functional purpose - it fluffs out its fur collar and releases heat into the air to cool down its body temperature, which can exceed 1,650 degrees when storing fire. When it catches prey or finds berries, it breathes fire on them until they're well done, and then it gobbles them up.</em></p>\n<p>This Pop! features Flareon, the eeveelution that can leave trainers feeling hot under the collar. Add Flareon to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Flareon Pop! Vinyl Figure", 19.44m, 23m },
                    { 65, 65, 0, "\n<h2><strong>Pokedex Entry #025:</strong></h2>\n<p><em>Pikachu - The mouse pokémon. This pokémon has electricity-storing pouches on its cheeks. These appear to become electrically charged during the night while Pikachu sleeps. It occasionally discharges electricity when it is dozy after waking up. Pikachu can help other Pikachu who are feeling weak by sharing its electric current. Pikachu's tail is sometimes struck by lightning as it raises it to check its surroundings. When several of these Pokémon gather, their electricity could build up and cause lightning storms. Forest dwellers, they are few in number and exceptionally rare. The pouches in their cheeks discharge electricity at their opponents. Pikachu are believed to be highly intelligent.</em></p>\n<p>This Pop! features Pikachu, relaxing in a seated pose. This version features Funko's Diamond Glitter finish. Add Pikachu to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n<li><strong>Convention:</strong> Funko Festival of Fun 2021</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Pikachu (Seated) Diamond Glitter Pop! Vinyl Figure", 17.67m, 25m },
                    { 66, 66, 0, "\n<h2>Funko Fair 2021</h2>\n<p>Welcome to the inaugural Funko Fair - a two-week virtual event to celebrate all things Funko and provide an exclusive glimpse at what's to come in 2021. Funko is always discovering new ways to surprise and delight fans by bringing the best of pop culture directly to them.</p>\n<p>Keep checking back daily for more exciting announcements!</p>\n<h2><strong>Pokedex Entry #054:</strong></h2>\n<p>Psyduck is constantly beset by headaches. If the Pokémon lets its strange power erupt, apparently the pain subsides for a while.</p>\n<p>This Pop! features Psyduck. The perfect addition for any Pokemon lover! Add this to your collection today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li>Size: 9.5cm tall approx</li>\n<li>Material: Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Psyduck Pop! Vinyl Figure", 19.44m, 23m },
                    { 67, 67, 0, "\n<h2>New York Toy Fair</h2><p>The New York Toy Fair is the largest dedicated toy, game and hobby trade show in the Western Hemisphere, annually held in mid-February. Beginning in 1903, the toy industry's showcase attracts more than 30,000 attendees each year, where some of the biggest toys and collectibles of the year are announced.</p><p>Get in fast as they are expected to sell out quickly!</p><h2><strong>Pokedex Entry #019:</strong></h2><p><em>A Forest Pokémon, Rattata. It likes cheese, nuts, fruits, and berries. It also comes out into open fields to steal food from stupid travellers. It bites anything when it attacks, and will chew on anything with its fangs. Small and very quick, it is a common sight in many places. If you see one, it is certain that 40 more live in the area. Scurries around quickly, searching for hard objects to gnaw. It appears to be jittery and unable to remain still. Its sharp incisors can easily cut right through hardwood, and grow continuously throughout its life.</em></p><p>This Pop! features Rattata. Though easy to capture, even for a beginner, these pokemon grow strong and mighty with the right amount of training and nurturing. Add one to your party today!</p><h2>Specifications:</h2><ul><li><strong>Size:</strong> 9.5cm tall approx</li><li><strong>Material:</strong> Plastic/Vinyl</li></ul><p>Official Pokemon licensed merchandise</p> ", "Pokemon - Rattata Pop! Vinyl Figure", 19.44m, 23m },
                    { 68, 68, 0, "\n<h2><strong>Pokedex Entry #007:</strong></h2><p><em>Squirtle. This Tiny Turtle Pokémon draws its long neck into its shell to launch incredible water attacks with amazing range and accuracy. The blasts can be quite powerful. It takes time for the shell to form and harden after hatching. Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in the water, enabling this Pokémon to swim at high speeds.</em></p><p>When Professor Oak first asked the question, 'Which pokemon will you choose?' many trainers opted for the water-type, Squirtle. With a shell offering superior defence and a super-strong water-projectile attack style, Squirtle is strong and only gets stronger as it evolves, making it ideal for new trainers and pokemon masters alike. As an added bonus, Squirtle is super adorable! Add Squirtle to your party today!</p><h2>Specifications:</h2><ul><li><strong>Size:</strong>&nbsp;9.5cm tall approx</li><li><strong>Material:</strong>&nbsp;Plastic/Vinyl</li></ul><p>Official Pokemon licensed merchandise</p> ", "Pokemon - Squirtle Pop! Vinyl Figure", 19.44m, 23m },
                    { 69, 69, 0, "\n<h2><strong>Pokedex Entry #149:</strong></h2>\n<p><em>Dragonite, the Dragon Pokémon. It is said to live in the sea. Has intelligence on par with people. With its small wings and large body, this \"sea guardian\" is said to be capable of flying around the globe in about 16 hours, faster than the speed of sound. Its impressive build lets it freely fly over raging seas without trouble. It is a kindhearted Pokémon that leads lost and foundering ships in a storm to the safety of land. Incur the wrath of this normally calm Pokémon at your peril, because it will smash everything to smithereens before it's satisfied. Very few people ever see this Pokémon. It is rumoured that somewhere in the ocean lies an island where these gather. Only they live there.</em></p>\n<p>This Pop! features Dragonite. Don't let their gentle demeanour and appearance fool you - Dragonite are a force to be reckoned with. Add Dragonite to your party today!</p>\n<h2>Specifications:</h2>\n<ul>\n<li><strong>Size:</strong> 9.5cm tall approx</li>\n<li><strong>Material:</strong> Plastic/Vinyl</li>\n</ul>\n<p>Official Pokemon licensed merchandise</p> ", "Pokemon - Dragonite Pop! Vinyl Figure", 19.44m, 23m }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_ProductId",
                table: "ProductOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AttributesId",
                table: "Products",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStockSet_ProductId",
                table: "ProductStockSet",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStockSet_StoreId",
                table: "ProductStockSet",
                column: "StoreId");
        }

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
                name: "Images");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "ProductStockSet");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "AttributesSet");
        }
    }
}
