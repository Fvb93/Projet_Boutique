using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Boutique.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FloatDecimalTVA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TVA",
                table: "Produit",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 1,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 2,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 3,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 4,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 5,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 6,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 7,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 8,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 9,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 10,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 11,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 12,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 13,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 14,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 15,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 16,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 17,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 18,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 19,
                column: "TVA",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 20,
                column: "TVA",
                value: 21m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TVA",
                table: "Produit",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 1,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 2,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 3,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 4,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 5,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 6,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 7,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 8,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 9,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 10,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 11,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 12,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 13,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 14,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 15,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 16,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 17,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 18,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 19,
                column: "TVA",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Produit",
                keyColumn: "Id",
                keyValue: 20,
                column: "TVA",
                value: 21f);
        }
    }
}
