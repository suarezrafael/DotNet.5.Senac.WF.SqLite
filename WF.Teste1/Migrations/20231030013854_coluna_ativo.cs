using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WF.Teste1.Migrations
{
    /// <inheritdoc />
    public partial class coluna_ativo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Categorias");
        }
    }
}
