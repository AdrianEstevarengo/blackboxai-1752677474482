using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddAtendentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atendentes",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendentes", x => x.Id);
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Atendentes", schema: "AgendaConsulta");

            migrationBuilder.CreateTable(
                name: "ProcessosAgenda",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataConclusaoExterna = table.Column<DateTime>(
                        type: "datetime2",
                        nullable: true
                    ),
                    DataConclusaoInterna = table.Column<DateTime>(
                        type: "datetime2",
                        nullable: true
                    ),
                    DataPrevisao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdPrioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotivoPrioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prioridade = table.Column<bool>(type: "bit", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temas = table.Column<int>(type: "int", nullable: true),
                    UnidadeGestoraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessosAgenda", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "TipoEvento",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEvento", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "UnidadeGestora",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeGestora", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Atividade",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnidadeGestoraId = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPrevisao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPrevisaoAssinatura = table.Column<DateTime>(
                        type: "datetime2",
                        nullable: true
                    ),
                    DataPrevisaoEmissao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ElementoDespesa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnfrentamentoCOVID = table.Column<bool>(type: "bit", nullable: false),
                    EstaNaMesa = table.Column<bool>(type: "bit", nullable: false),
                    FusoHorarioAbertura = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: false
                    ),
                    IRP = table.Column<bool>(type: "bit", nullable: true),
                    IdPNCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPrioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Justificativa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legislacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManifestacaoInteresse = table.Column<bool>(type: "bit", nullable: true),
                    Mesa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotivoPrioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotivoRevogacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaturezaDoObjeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCertame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroItem = table.Column<int>(type: "int", nullable: true),
                    NumeroProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objeto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prioridade = table.Column<bool>(type: "bit", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubObjeto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividade_UnidadeGestora_UnidadeGestoraId",
                        column: x => x.UnidadeGestoraId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "UnidadeGestora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Anexo",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtividadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArquivoByte = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DataUpload = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeArquivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoArquivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anexo_Atividade_AtividadeId",
                        column: x => x.AtividadeId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "Atividade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Evento",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtividadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoEventoId = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessoAgendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Setorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeExterna = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_Atividade_AtividadeId",
                        column: x => x.AtividadeId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "Atividade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Evento_ProcessosAgenda_ProcessoAgendaId",
                        column: x => x.ProcessoAgendaId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "ProcessosAgenda",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_Evento_TipoEvento_TipoEventoId",
                        column: x => x.TipoEventoId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "TipoEvento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "RelatorioEstatistico",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtividadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ano = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCriacaoRelatorio = table.Column<DateTime>(
                        type: "datetime2",
                        nullable: false
                    ),
                    ElaboradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdContratacaoPNCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legislacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDoCertame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Objeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pregoeiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorEstimadoGlobal = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                    ),
                    ValorNegociadoGlobal = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                    ),
                    dataAberturaProposta = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                    ),
                    dataEncerramentoProposta = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                    ),
                    dataPublicacaoPncp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioEstatistico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatorioEstatistico_Atividade_AtividadeId",
                        column: x => x.AtividadeId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "Atividade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Itemsatacollections",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesempateRegional = table.Column<bool>(type: "bit", nullable: true),
                    EmpresaVencedora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeEpp = table.Column<bool>(type: "bit", nullable: true),
                    OrdemDoItem = table.Column<int>(type: "int", nullable: false),
                    PossuiCota = table.Column<bool>(type: "bit", nullable: true),
                    Quantidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RelatorioEstatisticoId = table.Column<Guid>(
                        type: "uniqueidentifier",
                        nullable: false
                    ),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorEstimado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorNegociado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ro = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itemsatacollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itemsatacollections_RelatorioEstatistico_RelatorioEstatisticoId",
                        column: x => x.RelatorioEstatisticoId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "RelatorioEstatistico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Recurso",
                schema: "AgendaConsulta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataJulgamentoRecurso = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                    ),
                    DataRecurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemsatacollectionsId = table.Column<Guid>(
                        type: "uniqueidentifier",
                        nullable: false
                    ),
                    NumItemRecurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoJulgamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_Itemsatacollections_ItemsatacollectionsId",
                        column: x => x.ItemsatacollectionsId,
                        principalSchema: "AgendaConsulta",
                        principalTable: "Itemsatacollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_AtividadeId",
                schema: "AgendaConsulta",
                table: "Anexo",
                column: "AtividadeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_UnidadeGestoraId",
                schema: "AgendaConsulta",
                table: "Atividade",
                column: "UnidadeGestoraId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Evento_AtividadeId",
                schema: "AgendaConsulta",
                table: "Evento",
                column: "AtividadeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Evento_ProcessoAgendaId",
                schema: "AgendaConsulta",
                table: "Evento",
                column: "ProcessoAgendaId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoEventoId",
                schema: "AgendaConsulta",
                table: "Evento",
                column: "TipoEventoId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Itemsatacollections_RelatorioEstatisticoId",
                schema: "AgendaConsulta",
                table: "Itemsatacollections",
                column: "RelatorioEstatisticoId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_ItemsatacollectionsId",
                schema: "AgendaConsulta",
                table: "Recurso",
                column: "ItemsatacollectionsId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioEstatistico_AtividadeId",
                schema: "AgendaConsulta",
                table: "RelatorioEstatistico",
                column: "AtividadeId"
            );
        }
    }
}
