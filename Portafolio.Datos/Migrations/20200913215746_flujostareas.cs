using Microsoft.EntityFrameworkCore.Migrations;

namespace Portafolio.DataAccess.Migrations
{
    public partial class flujostareas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlujoTareas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_flujo = table.Column<string>(nullable: false),
                    Des_flujo = table.Column<string>(nullable: false),
                    Progreso = table.Column<int>(nullable: false),
                    TipoFlujoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlujoTareas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlujoTareas_Tipoflujos_TipoFlujoId",
                        column: x => x.TipoFlujoId,
                        principalTable: "Tipoflujos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlujoTareas_TipoFlujoId",
                table: "FlujoTareas",
                column: "TipoFlujoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlujoTareas");
        }
    }
}
