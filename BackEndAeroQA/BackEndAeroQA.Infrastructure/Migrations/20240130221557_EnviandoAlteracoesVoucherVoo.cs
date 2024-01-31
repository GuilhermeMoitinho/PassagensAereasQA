using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndAeroQA.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EnviandoAlteracoesVoucherVoo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroDoVoo",
                table: "Voos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDoVoo",
                table: "Voos");
        }
    }
}
