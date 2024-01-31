using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndAeroQA.Infrastructure.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class EnviandoAlteracoesAppPassageiro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passageiros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoosComprados = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiros", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passageiros");
        }
    }
}
