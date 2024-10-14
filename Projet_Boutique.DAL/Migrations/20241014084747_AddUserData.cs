using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Boutique.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Admin",
                table: "Utilisateur",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "Id", "Admin", "Birthdate", "Email", "FirstName", "Name", "Password" },
                values: new object[] { 1, true, new DateTime(1993, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "fabianvanb@proton.me", "Fabian", "Van Buggenhout", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Utilisateur");
        }
    }
}
