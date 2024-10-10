using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Boutique.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FloatEnDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Produit",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 1200m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 800m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 250m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 900m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 1200m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 800m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 700m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 1100m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 300m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 600m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 700m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Produit",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 1200f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 800f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 200f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 50f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 100f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 250f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 500f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 900f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 1200f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 800f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 700f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 200f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 1100f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 300f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 150f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 600f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 200f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 700f);

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
    }
}
