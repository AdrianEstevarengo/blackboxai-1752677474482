using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddAgendaProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AgendaConsulta");

            migrationBuilder.EnsureSchema(
                name: "Aion");


            migrationBuilder.CreateTable(
                name: "ProcessosAgenda",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidadeGestoraId = table.Column<int>(type: "int", nullable: false),
                    Prioridade = table.Column<bool>(type: "bit", nullable: false),
                    IdPrioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotivoPrioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataConclusaoInterna = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataConclusaoExterna = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPrevisao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessosAgenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessosAgenda_UnidadesGestoras_UnidadeGestoraId",
                        column: x => x.UnidadeGestoraId,
                        principalSchema: "Aion",
                        principalTable: "UnidadesGestoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessosAgenda_UnidadeGestoraId",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda",
                column: "UnidadeGestoraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessosAgenda",
                schema: "AgendaConsulta");

            migrationBuilder.DropTable(
                name: "UnidadesGestoras",
                schema: "Aion");
        }
    }
}
