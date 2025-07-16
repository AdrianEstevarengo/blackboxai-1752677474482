using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class CorridoTipoUnidadeGestora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessosAgenda_UnidadesGestoras_UnidadeGestoraId",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda");

            migrationBuilder.DropIndex(
                name: "IX_ProcessosAgenda_UnidadeGestoraId",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Aion");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessosAgenda_UnidadeGestoraId",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda",
                column: "UnidadeGestoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessosAgenda_UnidadesGestoras_UnidadeGestoraId",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda",
                column: "UnidadeGestoraId",
                principalSchema: "Aion",
                principalTable: "UnidadesGestoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
