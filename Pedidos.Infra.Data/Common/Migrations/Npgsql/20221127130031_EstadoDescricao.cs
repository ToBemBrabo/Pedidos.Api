using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pedidos.Infra.Data.Common.Migrations.Npgsql
{
    public partial class EstadoDescricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Estado",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Estado");
        }
    }
}
