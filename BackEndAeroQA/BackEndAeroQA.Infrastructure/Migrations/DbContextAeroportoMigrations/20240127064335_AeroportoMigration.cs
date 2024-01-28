using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndAeroQA.Infrastructure.Migrations.DbContextAeroportoMigrations
{
    /// <inheritdoc />
    public partial class AeroportoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeroportos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeroportos", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeroportos");
        }
    }
}
