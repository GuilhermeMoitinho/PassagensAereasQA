using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndAeroQA.Infrastructure.Migrations.DbContextAeroportoMigrations
{
    /// <inheritdoc />
    public partial class EnviandoAlteracoesAppAeroporto : Migration
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
                    { new Guid("418029f8-4757-45df-ac43-edd9f655a81c"), "Brasília", 1003, "DF" },
                    { new Guid("59ae45a3-ab8a-4da6-8843-e1815c2b089b"), "São Paulo", 1001, "SP" },
                    { new Guid("6300b85d-66ae-4ee4-8ae0-231ae025903d"), "Belo Horizonte", 1002, "MG" },
                    { new Guid("afc80cc6-af3f-4847-ad2a-23a71881504f"), "Salvador", 1004, "BA" },
                    { new Guid("d886b1e9-51fd-476b-8dae-71a524729e55"), "Rio de Janeiro", 1000, "RJ" }
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
