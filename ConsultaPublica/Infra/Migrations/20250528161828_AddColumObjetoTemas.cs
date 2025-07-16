using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddColumObjetoTemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Objeto",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Temas",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Objeto",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda");

            migrationBuilder.DropColumn(
                name: "Temas",
                schema: "AgendaConsulta",
                table: "ProcessosAgenda");
        }
    }
}
