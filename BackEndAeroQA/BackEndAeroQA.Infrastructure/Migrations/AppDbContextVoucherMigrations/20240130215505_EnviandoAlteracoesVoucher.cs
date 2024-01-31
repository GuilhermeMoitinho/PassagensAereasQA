using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndAeroQA.Infrastructure.Migrations.AppDbContextVoucherMigrations
{
    /// <inheritdoc />
    public partial class EnviandoAlteracoesVoucher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroVoo = table.Column<int>(type: "int", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePassageiro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PossuiDespachoBagagem = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vouchers");
        }
    }
}
