using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roomie_API.Migrations
{
    /// <inheritdoc />
    public partial class Terceira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Quarto",
                type: "nvarchar(75)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Admin",
                type: "nvarchar(75)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Quarto",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Admin",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)");
        }
    }
}
