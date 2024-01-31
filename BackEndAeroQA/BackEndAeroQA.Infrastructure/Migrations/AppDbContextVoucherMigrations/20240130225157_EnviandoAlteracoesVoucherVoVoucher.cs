using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndAeroQA.Infrastructure.Migrations.AppDbContextVoucherMigrations
{
    /// <inheritdoc />
    public partial class EnviandoAlteracoesVoucherVoVoucher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PossuiDespachoBagagem",
                table: "Vouchers",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "CpfPassageiro",
                table: "Vouchers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CpfPassageiro",
                table: "Vouchers");

            migrationBuilder.AlterColumn<bool>(
                name: "PossuiDespachoBagagem",
                table: "Vouchers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
