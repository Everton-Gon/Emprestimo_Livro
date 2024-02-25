using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpreatimoLivro.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Empretimos",
                table: "Empretimos");

            migrationBuilder.RenameTable(
                name: "Empretimos",
                newName: "Emprestimos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimos",
                table: "Emprestimos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimos",
                table: "Emprestimos");

            migrationBuilder.RenameTable(
                name: "Emprestimos",
                newName: "Empretimos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empretimos",
                table: "Empretimos",
                column: "Id");
        }
    }
}
