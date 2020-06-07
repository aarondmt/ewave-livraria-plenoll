using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.v1.Migrations
{
    public partial class AtualizacaoAtraso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atraso_Usuario_UsuarioId",
                table: "Atraso");

            migrationBuilder.DropColumn(
                name: "DataDevolucao",
                table: "Atraso");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Atraso",
                newName: "EmprestimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Atraso_UsuarioId",
                table: "Atraso",
                newName: "IX_Atraso_EmprestimoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atraso_Emprestimo_EmprestimoId",
                table: "Atraso",
                column: "EmprestimoId",
                principalTable: "Emprestimo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atraso_Emprestimo_EmprestimoId",
                table: "Atraso");

            migrationBuilder.RenameColumn(
                name: "EmprestimoId",
                table: "Atraso",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Atraso_EmprestimoId",
                table: "Atraso",
                newName: "IX_Atraso_UsuarioId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDevolucao",
                table: "Atraso",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Atraso_Usuario_UsuarioId",
                table: "Atraso",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
