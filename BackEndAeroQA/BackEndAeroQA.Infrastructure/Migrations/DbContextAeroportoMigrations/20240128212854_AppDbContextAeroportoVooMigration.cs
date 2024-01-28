using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndAeroQA.Infrastructure.Migrations.DbContextAeroportoMigrations
{
    /// <inheritdoc />
    public partial class AppDbContextAeroportoVooMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("229a2ac4-f562-4636-b261-8f4ef3f8d207"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("5ceb7485-bca8-425b-a905-9ca834c93645"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("84195e0e-fb05-4eb6-9536-2d0dc97547ef"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("dc5c5e35-2186-42ad-90d6-208eb6546e18"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("fe622eb9-e637-499a-9ce7-c46b012e9c9e"));

            migrationBuilder.InsertData(
                table: "Aeroportos",
                columns: new[] { "Id", "Cidade", "Codigo", "UF" },
                values: new object[,]
                {
                    { new Guid("5f8efbaf-ae44-4664-b266-b237f2073e5f"), "Salvador", 1004, "BA" },
                    { new Guid("87a599dd-e48d-4f4f-a084-9586ecf561dc"), "São Paulo", 1001, "SP" },
                    { new Guid("cbc1f3cf-b130-4c41-9bc0-7b1651012aa9"), "Brasília", 1003, "DF" },
                    { new Guid("d253f61f-9fec-407e-b5e6-16736f94a1e3"), "Rio de Janeiro", 1000, "RJ" },
                    { new Guid("f0a093a8-3f33-49b2-9618-dbbb0e7352a6"), "Belo Horizonte", 1002, "MG" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("5f8efbaf-ae44-4664-b266-b237f2073e5f"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("87a599dd-e48d-4f4f-a084-9586ecf561dc"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("cbc1f3cf-b130-4c41-9bc0-7b1651012aa9"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("d253f61f-9fec-407e-b5e6-16736f94a1e3"));

            migrationBuilder.DeleteData(
                table: "Aeroportos",
                keyColumn: "Id",
                keyValue: new Guid("f0a093a8-3f33-49b2-9618-dbbb0e7352a6"));

            migrationBuilder.InsertData(
                table: "Aeroportos",
                columns: new[] { "Id", "Cidade", "Codigo", "UF" },
                values: new object[,]
                {
                    { new Guid("229a2ac4-f562-4636-b261-8f4ef3f8d207"), "São Paulo", 1001, "SP" },
                    { new Guid("5ceb7485-bca8-425b-a905-9ca834c93645"), "Salvador", 1004, "BA" },
                    { new Guid("84195e0e-fb05-4eb6-9536-2d0dc97547ef"), "Belo Horizonte", 1002, "MG" },
                    { new Guid("dc5c5e35-2186-42ad-90d6-208eb6546e18"), "Rio de Janeiro", 1000, "RJ" },
                    { new Guid("fe622eb9-e637-499a-9ce7-c46b012e9c9e"), "Brasília", 1003, "DF" }
                });
        }
    }
}
