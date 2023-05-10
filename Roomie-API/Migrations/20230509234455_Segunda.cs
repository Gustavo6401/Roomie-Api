using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roomie_API.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Usuario",
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
                table: "Usuario",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)");
        }
    }
}
