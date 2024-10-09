using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Boutique.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AjoutListeCatProduit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Categorie",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorie",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categorie",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categorie",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categorie",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categorie",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categorie",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_ProductId",
                table: "Categorie",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorie_Produit_ProductId",
                table: "Categorie",
                column: "ProductId",
                principalTable: "Produit",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorie_Produit_ProductId",
                table: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Categorie_ProductId",
                table: "Categorie");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Categorie");
        }
    }
}
