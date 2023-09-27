using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forensic_Bones.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventarioEsqueleto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeDeOssos = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioEsqueleto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FotografiasAchados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventEsqueletoId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografiasAchados", x => x.id);
                    table.ForeignKey(
                        name: "FK_FotografiasAchados_InventarioEsqueleto_InventEsqueletoId",
                        column: x => x.InventEsqueletoId,
                        principalTable: "InventarioEsqueleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FotografiasEsqueleto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventEsqueletoId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografiasEsqueleto", x => x.id);
                    table.ForeignKey(
                        name: "FK_FotografiasEsqueleto_InventarioEsqueleto_InventEsqueletoId",
                        column: x => x.InventEsqueletoId,
                        principalTable: "InventarioEsqueleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventarioCranio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventEsqueletoId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frontal = table.Column<int>(type: "int", nullable: false),
                    Ocipital = table.Column<int>(type: "int", nullable: false),
                    Esfenoide = table.Column<int>(type: "int", nullable: false),
                    Maxilar = table.Column<int>(type: "int", nullable: false),
                    Palatino = table.Column<int>(type: "int", nullable: false),
                    Vomer = table.Column<int>(type: "int", nullable: false),
                    ParietalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    TemporalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalInferiorEsquerda = table.Column<int>(type: "int", nullable: false),
                    EtmoideEsquerdo = table.Column<int>(type: "int", nullable: false),
                    LacrimalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    NasalEsquerdo = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoEsquerdo = table.Column<int>(type: "int", nullable: false),
                    ParietalDireito = table.Column<int>(type: "int", nullable: false),
                    TemporalDireito = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalInferiorDireita = table.Column<int>(type: "int", nullable: false),
                    Etmoide = table.Column<int>(type: "int", nullable: false),
                    LacrimalDireito = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoDireito = table.Column<int>(type: "int", nullable: false),
                    Hioide = table.Column<int>(type: "int", nullable: false),
                    CartilagemDaTireoide = table.Column<int>(type: "int", nullable: false),
                    Mandibula = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioCranio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventarioCranio_InventarioEsqueleto_InventEsqueletoId",
                        column: x => x.InventEsqueletoId,
                        principalTable: "InventarioEsqueleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarcadoresCranio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventCranioId = table.Column<int>(type: "int", nullable: false),
                    CristalNucal = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ProcessoMastoide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EminenciaMentoniana = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SupraOrbital = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AreaGlabela = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcadoresCranio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarcadoresCranio_InventarioCranio_InventCranioId",
                        column: x => x.InventCranioId,
                        principalTable: "InventarioCranio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FotografiasAchados_InventEsqueletoId",
                table: "FotografiasAchados",
                column: "InventEsqueletoId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografiasEsqueleto_InventEsqueletoId",
                table: "FotografiasEsqueleto",
                column: "InventEsqueletoId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioCranio_InventEsqueletoId",
                table: "InventarioCranio",
                column: "InventEsqueletoId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcadoresCranio_InventCranioId",
                table: "MarcadoresCranio",
                column: "InventCranioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotografiasAchados");

            migrationBuilder.DropTable(
                name: "FotografiasEsqueleto");

            migrationBuilder.DropTable(
                name: "MarcadoresCranio");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "InventarioCranio");

            migrationBuilder.DropTable(
                name: "InventarioEsqueleto");
        }
    }
}
