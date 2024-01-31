using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndAeroQA.Infrastructure.Migrations.AppDbContextBagagemMigrations
{
    /// <inheritdoc />
    public partial class EnviandoBagagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagagens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Extraviada = table.Column<bool>(type: "bit", nullable: false),
                    CpfPassageiro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagagens", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagagens");
        }
    }
}
