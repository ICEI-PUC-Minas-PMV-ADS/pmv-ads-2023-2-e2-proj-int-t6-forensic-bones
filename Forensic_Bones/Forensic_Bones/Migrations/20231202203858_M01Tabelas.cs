using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forensic_Bones.Migrations
{
    /// <inheritdoc />
    public partial class M01Tabelas : Migration
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
                    Cargo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Perfil = table.Column<int>(type: "int", nullable: false)
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
                name: "InventariosCranio",
                columns: table => new
                {
                    InventarioCranioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatorioId = table.Column<int>(type: "int", nullable: false),
                    InventarioEsqueletoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoCranio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frontal = table.Column<int>(type: "int", nullable: false),
                    Ocipital = table.Column<int>(type: "int", nullable: false),
                    Esfenoide = table.Column<int>(type: "int", nullable: false),
                    Maxilar = table.Column<int>(type: "int", nullable: false),
                    Vomer = table.Column<int>(type: "int", nullable: false),
                    ParietalEsq = table.Column<int>(type: "int", nullable: false),
                    TemporalEsq = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalEsq = table.Column<int>(type: "int", nullable: false),
                    EtmoideEsq = table.Column<int>(type: "int", nullable: false),
                    LacrimalEsq = table.Column<int>(type: "int", nullable: false),
                    NasalEsq = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoEsq = table.Column<int>(type: "int", nullable: false),
                    ParietalDir = table.Column<int>(type: "int", nullable: false),
                    TemporalDir = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalDir = table.Column<int>(type: "int", nullable: false),
                    EtmoideDir = table.Column<int>(type: "int", nullable: false),
                    LacrimalDir = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoDir = table.Column<int>(type: "int", nullable: false),
                    Hioide = table.Column<int>(type: "int", nullable: false),
                    CartilagemTireoide = table.Column<int>(type: "int", nullable: false),
                    Mandibula = table.Column<int>(type: "int", nullable: false),
                    FrontalDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OcipitalDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EsfenoideDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxilarDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VomerDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParietalEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporalEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConchaNasalEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtmoideEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LacrimalEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NasalEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZigomaticoEsqDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParietalDirDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporalDirDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConchaNasalDirDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtmoideDirDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LacrimalDirDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZigomaticoDirDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HioideDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartilagemTireoideDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MandibulaDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventarioEsqueletoId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosCranio", x => x.InventarioCranioId);
                    table.ForeignKey(
                        name: "FK_InventariosCranio_InventariosEsqueleto_InventarioEsqueletoId1",
                        column: x => x.InventarioEsqueletoId1,
                        principalTable: "InventariosEsqueleto",
                        principalColumn: "InventarioEsqueletoId");
                    table.ForeignKey(
                        name: "FK_InventariosCranio_Relatorios_RelatorioId",
                        column: x => x.RelatorioId,
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
                    RelatorioId = table.Column<int>(type: "int", nullable: false),
                    CristaNucal = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ProcessoMastoide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EminenciaMentoniana = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SupraOrbital = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AreaGlabela = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventarioCranioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcadoresCranio", x => x.MarcadoresCranioId);
                    table.ForeignKey(
                        name: "FK_MarcadoresCranio_InventariosCranio_InventarioCranioId",
                        column: x => x.InventarioCranioId,
                        principalTable: "InventariosCranio",
                        principalColumn: "InventarioCranioId");
                    table.ForeignKey(
                        name: "FK_MarcadoresCranio_Relatorios_RelatorioId",
                        column: x => x.RelatorioId,
                        principalTable: "Relatorios",
                        principalColumn: "RelatorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventariosCranio_InventarioEsqueletoId1",
                table: "InventariosCranio",
                column: "InventarioEsqueletoId1");

            migrationBuilder.CreateIndex(
                name: "IX_InventariosCranio_RelatorioId",
                table: "InventariosCranio",
                column: "RelatorioId");

            migrationBuilder.CreateIndex(
                name: "IX_InventariosEsqueleto_RelatorioId",
                table: "InventariosEsqueleto",
                column: "RelatorioId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcadoresCranio_InventarioCranioId",
                table: "MarcadoresCranio",
                column: "InventarioCranioId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcadoresCranio_RelatorioId",
                table: "MarcadoresCranio",
                column: "RelatorioId");

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
                name: "InventariosCranio");

            migrationBuilder.DropTable(
                name: "InventariosEsqueleto");

            migrationBuilder.DropTable(
                name: "Relatorios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
