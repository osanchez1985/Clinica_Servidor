using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaServicios.Migrations
{
    public partial class Doctores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctores",
                schema: "Clinica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaTransaccion = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getdate()"),
                    ModificadoPor = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: false),
                    Nombres = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctores_Especializaciones_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalSchema: "Clinica",
                        principalTable: "Especializaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_EspecialidadId",
                schema: "Clinica",
                table: "Doctores",
                column: "EspecialidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctores",
                schema: "Clinica");
        }
    }
}
