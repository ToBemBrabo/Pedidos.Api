using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pedidos.Infra.Data.Common.Migrations.Npgsql
{
    public partial class Paises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PaisId",
                table: "Estado",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estado_PaisId",
                table: "Estado",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Pais_PaisId",
                table: "Estado",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_PaisId",
                table: "Estado");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Estado_PaisId",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Estado");
        }
    }
}
