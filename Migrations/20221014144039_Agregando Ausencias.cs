using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecursosHumanos.Migrations
{
    public partial class AgregandoAusencias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LugarEmicion",
                table: "Licencias",
                newName: "LugarEmision");

            migrationBuilder.RenameColumn(
                name: "FechaEmicion",
                table: "Licencias",
                newName: "FechaEmision");

            migrationBuilder.CreateTable(
                name: "Ausencias",
                columns: table => new
                {
                    AusenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadDias = table.Column<int>(type: "INTEGER", nullable: false),
                    MotivoAusencia = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ausencias", x => x.AusenciaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ausencias");

            migrationBuilder.RenameColumn(
                name: "LugarEmision",
                table: "Licencias",
                newName: "LugarEmicion");

            migrationBuilder.RenameColumn(
                name: "FechaEmision",
                table: "Licencias",
                newName: "FechaEmicion");
        }
    }
}
