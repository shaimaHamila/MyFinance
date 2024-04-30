using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinance.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitiamMigrationTest24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateProd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "ProductProvider",
                columns: table => new
                {
                    ProductsProductId = table.Column<int>(type: "int", nullable: false),
                    ProvidersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProvider", x => new { x.ProductsProductId, x.ProvidersId });
                    table.ForeignKey(
                        name: "FK_ProductProvider_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProvider_Providers_ProvidersId",
                        column: x => x.ProvidersId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProvider_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            // Seed data
            SeedData(migrationBuilder);
        }

        /// <inheritdoc />
        private void SeedData(MigrationBuilder migrationBuilder)
        {
            // Seed data for Categories table
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name" },
                values: new object[,]
                {
            { "Medicament" },
            { "Vetement" },
            { "Meuble" }
                });

            // Seed data for Providers table
            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "ConfirmPassword", "DateCreated", "Email", "Password", "IsApproved", "UserName" },
                values: new object[,]
                {
            { "password", DateTime.Now, "provider1@example.com", "password", true, "provider1" },
            { "password", DateTime.Now, "provider2@example.com", "password", true, "provider2" },
            { "password", DateTime.Now, "provider3@example.com", "password", true, "provider3" }
                });

            // Seed data for Products table
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "Description", "Price", "Quantity", "DateProd", "CategoryId" },
                values: new object[,]
                {
            { "Product 1", "Description of Product 1", 10.99, 100, DateTime.Now, 1 },
            { "Product 2", "Description of Product 2", 15.99, 50, DateTime.Now, 2 },
            { "Product 3", "Description of Product 3", 20.99, 75, DateTime.Now, 3 }
                });

            // Seed data for ProductProvider table (Example: linking products with providers)
            migrationBuilder.InsertData(
                table: "ProductProvider",
                columns: new[] { "ProductsProductId", "ProvidersId" },
                values: new object[,]
                {
            { 1, 1 }, // Product 1 linked with Provider 1
            { 2, 2 }, // Product 2 linked with Provider 2
            { 3, 3 }  // Product 3 linked with Provider 3
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProvider");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
