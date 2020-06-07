using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.v1.Migrations
{
    public partial class Reserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Atraso_EmprestimoId",
                table: "Atraso");

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    LivroId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    DataReserva = table.Column<DateTime>(nullable: false),
                    DataRetirada = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Livro_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atraso_EmprestimoId",
                table: "Atraso",
                column: "EmprestimoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_LivroId",
                table: "Reserva",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioId",
                table: "Reserva",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Atraso_EmprestimoId",
                table: "Atraso");

            migrationBuilder.CreateIndex(
                name: "IX_Atraso_EmprestimoId",
                table: "Atraso",
                column: "EmprestimoId");
        }
    }
}
