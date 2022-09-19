using Microsoft.EntityFrameworkCore.Migrations;

namespace HomePetCareCats.App.Persistencia.Migrations
{
    public partial class Inicialos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Veterinarios_VeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Visita_Veterinarios_VeterinarioProfesionalId",
                table: "Visita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "Veterinarios",
                newName: "ProfesionalVeterinarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfesionalVeterinarios",
                table: "ProfesionalVeterinarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_ProfesionalVeterinarios_VeterinarioId",
                table: "Mascotas",
                column: "VeterinarioId",
                principalTable: "ProfesionalVeterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visita_ProfesionalVeterinarios_VeterinarioProfesionalId",
                table: "Visita",
                column: "VeterinarioProfesionalId",
                principalTable: "ProfesionalVeterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_ProfesionalVeterinarios_VeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Visita_ProfesionalVeterinarios_VeterinarioProfesionalId",
                table: "Visita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfesionalVeterinarios",
                table: "ProfesionalVeterinarios");

            migrationBuilder.RenameTable(
                name: "ProfesionalVeterinarios",
                newName: "Veterinarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Veterinarios_VeterinarioId",
                table: "Mascotas",
                column: "VeterinarioId",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visita_Veterinarios_VeterinarioProfesionalId",
                table: "Visita",
                column: "VeterinarioProfesionalId",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
