using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones100.Migrations
{
    /// <inheritdoc />
    public partial class M13NovaInicializaçaoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    RelatorioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.RelatorioId);
                    table.ForeignKey(
                        name: "FK_Relatorios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventariosEsqueleto",
                columns: table => new
                {
                    InventarioEsqueletoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatorioId = table.Column<int>(type: "int", nullable: false),
                    FotoEsqueleto = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ObservacoesEsq = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosEsqueleto", x => x.InventarioEsqueletoId);
                    table.ForeignKey(
                        name: "FK_InventariosEsqueleto_Relatorios_RelatorioId",
                        column: x => x.RelatorioId,
                        principalTable: "Relatorios",
                        principalColumn: "RelatorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventarioCranio",
                columns: table => new
                {
                    InventarioCranioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatorioCranioId = table.Column<int>(type: "int", nullable: false),
                    Frontal = table.Column<int>(type: "int", nullable: false),
                    FrontalDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Ocipital = table.Column<int>(type: "int", nullable: false),
                    OcipitalDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Esfenoide = table.Column<int>(type: "int", nullable: false),
                    EsfenoideDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Maxilar = table.Column<int>(type: "int", nullable: false),
                    MaxilarDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Vomer = table.Column<int>(type: "int", nullable: false),
                    VomerDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ParietalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    ParietalEsquerdoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    TemporalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    TemporalEsquerdoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ConchaNasalInferiorEsquerda = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalInferiorEsquerdaDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Etmoide = table.Column<int>(type: "int", nullable: false),
                    EtmoideDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    LacrimalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    LacrimalEsquerdoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    NasalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    NasalEsquerdoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ZigomaticoEsquerdo = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoEsquerdoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ParietalDireito = table.Column<int>(type: "int", nullable: false),
                    ParietalDireitoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    TemporalDireito = table.Column<int>(type: "int", nullable: false),
                    TemporalDireitoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ConchaNasalInferiorDireita = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalInferiorDireitaDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    LacrimalDireito = table.Column<int>(type: "int", nullable: false),
                    LacrimalDireitoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    NasalDireito = table.Column<int>(type: "int", nullable: false),
                    NasalDireitoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ZigomaticoDireito = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoDireitoDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Hioide = table.Column<int>(type: "int", nullable: false),
                    HioideDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    CartilagemTireoide = table.Column<int>(type: "int", nullable: false),
                    CartilagemTireoideDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Mandibula = table.Column<int>(type: "int", nullable: false),
                    MandibulaDesc = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    FotosCranio = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    InventarioEsqueletoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioCranio", x => x.InventarioCranioId);
                    table.ForeignKey(
                        name: "FK_InventarioCranio_InventariosEsqueleto_InventarioEsqueletoId",
                        column: x => x.InventarioEsqueletoId,
                        principalTable: "InventariosEsqueleto",
                        principalColumn: "InventarioEsqueletoId");
                    table.ForeignKey(
                        name: "FK_InventarioCranio_Relatorios_RelatorioCranioId",
                        column: x => x.RelatorioCranioId,
                        principalTable: "Relatorios",
                        principalColumn: "RelatorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarcadoresCranio",
                columns: table => new
                {
                    MarcadoresCranioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatorioMarcadoresId = table.Column<int>(type: "int", nullable: false),
                    CristaNucal = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ProcessoMastoide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EminenciaMentoniana = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SupraOrbital = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AreaGlabela = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CalculoEstimativaSexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    InventarioCranioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcadoresCranio", x => x.MarcadoresCranioId);
                    table.ForeignKey(
                        name: "FK_MarcadoresCranio_InventarioCranio_InventarioCranioId",
                        column: x => x.InventarioCranioId,
                        principalTable: "InventarioCranio",
                        principalColumn: "InventarioCranioId");
                    table.ForeignKey(
                        name: "FK_MarcadoresCranio_Relatorios_RelatorioMarcadoresId",
                        column: x => x.RelatorioMarcadoresId,
                        principalTable: "Relatorios",
                        principalColumn: "RelatorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventarioCranio_InventarioEsqueletoId",
                table: "InventarioCranio",
                column: "InventarioEsqueletoId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioCranio_RelatorioCranioId",
                table: "InventarioCranio",
                column: "RelatorioCranioId");

            migrationBuilder.CreateIndex(
                name: "IX_InventariosEsqueleto_RelatorioId",
                table: "InventariosEsqueleto",
                column: "RelatorioId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcadoresCranio_InventarioCranioId",
                table: "MarcadoresCranio",
                column: "InventarioCranioId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcadoresCranio_RelatorioMarcadoresId",
                table: "MarcadoresCranio",
                column: "RelatorioMarcadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatorios_UsuarioId",
                table: "Relatorios",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcadoresCranio");

            migrationBuilder.DropTable(
                name: "InventarioCranio");

            migrationBuilder.DropTable(
                name: "InventariosEsqueleto");

            migrationBuilder.DropTable(
                name: "Relatorios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
