using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_Boutique.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BoutiqueDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Format",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Format", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    TVA = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorie_Produit_NN",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie_Produit_NN", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_Categorie_Produit_NN_Categorie_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categorie_Produit_NN_Produit_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Format_Produit_NN",
                columns: table => new
                {
                    FormatId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Format_Produit_NN", x => new { x.FormatId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Format_Produit_NN_Format_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Format",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Format_Produit_NN_Produit_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    OrderUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commande_Utilisateur_OrderUserId",
                        column: x => x.OrderUserId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commande_Produit_NN",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AmountTVAC = table.Column<float>(type: "real", nullable: false),
                    AmountHTVA = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande_Produit_NN", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_Commande_Produit_NN_Commande_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Commande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commande_Produit_NN_Produit_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Produit",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock", "TVA" },
                values: new object[,]
                {
                    { 1, "High performance laptop", "Laptop", 1200, 10, 21f },
                    { 2, "Latest model smartphone", "Smartphone", 800, 20, 21f },
                    { 3, "Noise cancelling headphones", "Wireless Headphones", 200, 50, 21f },
                    { 4, "Automatic coffee machine", "Coffee Maker", 150, 30, 21f },
                    { 5, "Fast boiling kettle", "Electric Kettle", 50, 60, 21f },
                    { 6, "High-speed blender", "Blender", 100, 40, 21f },
                    { 7, "Cordless vacuum cleaner", "Vacuum Cleaner", 250, 25, 21f },
                    { 8, "Latest generation console", "Gaming Console", 500, 15, 21f },
                    { 9, "Waterproof fitness smartwatch", "Smartwatch", 150, 35, 21f },
                    { 10, "Ultra HD 4K smart TV", "4K TV", 900, 10, 21f },
                    { 11, "Energy-efficient refrigerator", "Refrigerator", 1200, 8, 21f },
                    { 12, "Front load washing machine", "Washing Machine", 800, 12, 21f },
                    { 13, "Automatic dishwasher", "Dishwasher", 700, 10, 21f },
                    { 14, "Compact microwave oven", "Microwave Oven", 200, 40, 21f },
                    { 15, "Digital camera with 4K video", "Camera", 1100, 15, 21f },
                    { 16, "Bluetooth wireless speakers", "Speakers", 300, 25, 21f },
                    { 17, "WiFi 6 router", "Router", 150, 50, 21f },
                    { 18, "High-resolution tablet", "Tablet", 600, 20, 21f },
                    { 19, "All-in-one wireless printer", "Printer", 200, 30, 21f },
                    { 20, "Portable air conditioner", "Air Conditioner", 700, 10, 21f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_Produit_NN_CategoryId",
                table: "Categorie_Produit_NN",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_OrderUserId",
                table: "Commande",
                column: "OrderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_Produit_NN_OrderId",
                table: "Commande_Produit_NN",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Format_Produit_NN_ProductId",
                table: "Format_Produit_NN",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie_Produit_NN");

            migrationBuilder.DropTable(
                name: "Commande_Produit_NN");

            migrationBuilder.DropTable(
                name: "Format_Produit_NN");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Format");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
