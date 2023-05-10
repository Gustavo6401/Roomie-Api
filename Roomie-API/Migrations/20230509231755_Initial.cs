using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roomie_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "date", nullable: false),
                    UltimaAtividade = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(9)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Universidade = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quarto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(9)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    NumeroDeQuartos = table.Column<int>(type: "int", nullable: false),
                    NumeroDeBanheiros = table.Column<int>(type: "int", nullable: false),
                    Disponibilidade = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Decimal = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quarto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quarto_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeArquivo = table.Column<string>(type: "nvarchar(75)", nullable: false),
                    QuartoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foto_Quarto_QuartoId",
                        column: x => x.QuartoId,
                        principalTable: "Quarto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(type: "date", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "date", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    QuartoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Quarto_QuartoId",
                        column: x => x.QuartoId,
                        principalTable: "Quarto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foto_QuartoId",
                table: "Foto",
                column: "QuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_Quarto_UsuarioId",
                table: "Quarto",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_QuartoId",
                table: "Reserva",
                column: "QuartoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioId",
                table: "Reserva",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Quarto");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
