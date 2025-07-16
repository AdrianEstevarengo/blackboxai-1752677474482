using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anexo",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "Evento",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "Recurso",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "TipoEvento",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "Itemsatacollections",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "RelatorioEstatistico",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "Atividade",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "UnidadeGestora",
                schema: "AgendaConsulta");
        }
    }
}
