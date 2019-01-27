using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaServicios.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Clinica");

            migrationBuilder.CreateTable(
                name: "Especializaciones",
                schema: "Clinica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaTransaccion = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getdate()"),
                    ModificadoPor = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especializaciones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especializaciones",
                schema: "Clinica");
        }
    }
}
