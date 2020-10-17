using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Azure.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Apellido = table.Column<string>(type: "Varchar(40)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Alumno",
                columns: new[] { "Id", "Apellido", "FechaNacimiento", "Nombre" },
                values: new object[] { new Guid("2396bc71-fc3b-4204-ac8d-d1df35cf904c"), "Fuentes", new DateTime(1995, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josep" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");
        }
    }
}
