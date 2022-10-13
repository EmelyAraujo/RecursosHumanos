using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecursosHumanos.Migrations
{
    public partial class AgregandoLicenciasalcontexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Licencias",
                columns: table => new
                {
                    LicenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaEmicion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiasReposo = table.Column<string>(type: "TEXT", nullable: false),
                    TipoLicencia = table.Column<string>(type: "TEXT", nullable: false),
                    Caracteristica = table.Column<string>(type: "TEXT", nullable: false),
                    NombreMedico = table.Column<string>(type: "TEXT", nullable: false),
                    LugarEmicion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencias", x => x.LicenciaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Licencias");
        }
    }
}
