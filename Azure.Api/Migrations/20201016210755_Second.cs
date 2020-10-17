using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Azure.Api.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Alumno",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Id_Alumno = table.Column<Guid>(nullable: false),
                    FechaMatricula = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matricula_Alumno_Id_Alumno",
                        column: x => x.Id_Alumno,
                        principalTable: "Alumno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matricula_Detalle",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Id_Matricula = table.Column<Guid>(nullable: false),
                    Id_Curso = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula_Detalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matricula_Detalle_Curso_Id_Curso",
                        column: x => x.Id_Curso,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matricula_Detalle_Matricula_Id_Matricula",
                        column: x => x.Id_Matricula,
                        principalTable: "Matricula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("af4d5521-cfc1-4517-8763-f998269d1139"), "Lenguaje" },
                    { new Guid("a3476a67-e06f-4e40-a15c-78f9f616e363"), "Matematica" },
                    { new Guid("d07eec5b-c559-46a2-bab5-bda9cac1767c"), "Ciencias" },
                    { new Guid("4436f676-07c0-4fac-994f-ed7a8e7dd7d7"), "RR.HH" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_Id_Alumno",
                table: "Matricula",
                column: "Id_Alumno");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_Detalle_Id_Curso",
                table: "Matricula_Detalle",
                column: "Id_Curso");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_Detalle_Id_Matricula",
                table: "Matricula_Detalle",
                column: "Id_Matricula");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matricula_Detalle");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Alumno",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
