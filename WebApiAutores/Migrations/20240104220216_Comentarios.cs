using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAutores.Migrations
{
    /// <inheritdoc />
    public partial class Comentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Libros_LibroId1",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_LibroId1",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "LibroId1",
                table: "Comentarios");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Comentarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_LibroId",
                table: "Comentarios",
                column: "LibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Libros_LibroId",
                table: "Comentarios",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Libros_LibroId",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_LibroId",
                table: "Comentarios");

            migrationBuilder.AlterColumn<string>(
                name: "LibroId",
                table: "Comentarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LibroId1",
                table: "Comentarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_LibroId1",
                table: "Comentarios",
                column: "LibroId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Libros_LibroId1",
                table: "Comentarios",
                column: "LibroId1",
                principalTable: "Libros",
                principalColumn: "Id");
        }
    }
}
