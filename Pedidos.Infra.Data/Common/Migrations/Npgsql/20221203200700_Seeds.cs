using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pedidos.Infra.Data.Common.Migrations.Npgsql
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1L, "Brasil" });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Descricao", "PaisId", "Uf" },
                values: new object[,]
                {
                    { 1L, "Acre", 1L, "AC" },
                    { 2L, "Alagoas", 1L, "AL" },
                    { 3L, "Amapá", 1L, "AP" },
                    { 4L, "Amazonas", 1L, "AM" },
                    { 5L, "Bahia", 1L, "BA" },
                    { 6L, "Ceara", 1L, "CE" },
                    { 7L, "Distrito Federal", 1L, "DF" },
                    { 8L, "Espirito Santo", 1L, "ES" },
                    { 9L, "Goiás", 1L, "GO" },
                    { 10L, "Maranhão", 1L, "MA" },
                    { 11L, "Mato Grosso", 1L, "MT" },
                    { 12L, "Mato Grosso do Sul", 1L, "MS" },
                    { 13L, "Minas Gerais", 1L, "MG" },
                    { 14L, "Para", 1L, "PA" },
                    { 15L, "Paraíba", 1L, "PB" },
                    { 16L, "Paraná", 1L, "PR" },
                    { 17L, "Pernambuco", 1L, "PE" },
                    { 18L, "Piauí", 1L, "PI" },
                    { 19L, "Rio de Janeiro", 1L, "RJ" },
                    { 20L, "Rio Grande do Norte", 1L, "RN" },
                    { 21L, "Rio Grande do Sul", 1L, "RS" },
                    { 22L, "Rondônia", 1L, "RO" },
                    { 23L, "Roraima", 1L, "RR" },
                    { 24L, "Santa Catarina", 1L, "SC" },
                    { 25L, "São Paulo", 1L, "SP" },
                    { 26L, "Sergipe", 1L, "SE" },
                    { 27L, "Tocantins", 1L, "TO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Pais",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
