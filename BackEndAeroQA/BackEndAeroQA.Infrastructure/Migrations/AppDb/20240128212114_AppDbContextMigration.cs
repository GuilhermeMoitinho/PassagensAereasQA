using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndAeroQA.Infrastructure.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class AppDbContextMigration : Migration
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
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiros", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Passageiros",
                columns: new[] { "Id", "Cpf", "DataDeNascimento", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("005f8dfc-d4db-47fe-959b-02834d06a386"), "CPF71", new DateTime(1977, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1783), "passageiro71@exemplo.com", "Passageiro 71" },
                    { new Guid("0119f6d9-21b8-4f56-b89e-90ce6941e8ae"), "CPF58", new DateTime(1968, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1557), "passageiro58@exemplo.com", "Passageiro 58" },
                    { new Guid("0120735f-7cf1-4cc1-a204-b8b7f0db9b22"), "CPF13", new DateTime(1990, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(990), "passageiro13@exemplo.com", "Passageiro 13" },
                    { new Guid("0155e81c-f2bc-422d-adb9-13cdd2ce855a"), "CPF30", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1189), "passageiro30@exemplo.com", "Passageiro 30" },
                    { new Guid("065e0ad7-e565-4dce-85c6-94d1e57c7aa1"), "CPF21", new DateTime(2006, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1057), "passageiro21@exemplo.com", "Passageiro 21" },
                    { new Guid("0795d654-3526-498a-9ddc-e0c93cf5f4fc"), "CPF97", new DateTime(1984, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(2072), "passageiro97@exemplo.com", "Passageiro 97" },
                    { new Guid("0fc83a78-f134-4bfa-841b-a6c88bfb6441"), "CPF61", new DateTime(1966, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1701), "passageiro61@exemplo.com", "Passageiro 61" },
                    { new Guid("105ba57b-20ae-497f-a0d1-8b659540ea0c"), "CPF31", new DateTime(1999, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1196), "passageiro31@exemplo.com", "Passageiro 31" },
                    { new Guid("164cacb6-ff14-4f62-862d-eefd6998dded"), "CPF47", new DateTime(1975, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1464), "passageiro47@exemplo.com", "Passageiro 47" },
                    { new Guid("169f7bc7-2787-49fb-9741-efa5199761a9"), "CPF18", new DateTime(1967, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1033), "passageiro18@exemplo.com", "Passageiro 18" },
                    { new Guid("183fbd4c-5e80-4abf-a36e-fad7dbfc18be"), "CPF25", new DateTime(1995, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1147), "passageiro25@exemplo.com", "Passageiro 25" },
                    { new Guid("1ae4d259-3264-49de-8967-50721a74500c"), "CPF100", new DateTime(1979, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(2100), "passageiro100@exemplo.com", "Passageiro 100" },
                    { new Guid("1c422a23-ed1b-443b-b279-a4d49d7ec976"), "CPF38", new DateTime(1987, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1258), "passageiro38@exemplo.com", "Passageiro 38" },
                    { new Guid("1fb16bcf-dbd2-4a68-8429-7d35b77d4a58"), "CPF12", new DateTime(1984, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(982), "passageiro12@exemplo.com", "Passageiro 12" },
                    { new Guid("2924f44f-86ca-4e06-a346-c68517a379ee"), "CPF91", new DateTime(1972, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1950), "passageiro91@exemplo.com", "Passageiro 91" },
                    { new Guid("2be73e48-b0f1-4746-b188-40a80c7964bf"), "CPF98", new DateTime(1967, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(2081), "passageiro98@exemplo.com", "Passageiro 98" },
                    { new Guid("2c283782-6a9b-439a-a7df-985adebda5aa"), "CPF16", new DateTime(1979, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1018), "passageiro16@exemplo.com", "Passageiro 16" },
                    { new Guid("2c6c8565-addf-4b5e-8ee9-32f414dede98"), "CPF87", new DateTime(1996, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1916), "passageiro87@exemplo.com", "Passageiro 87" },
                    { new Guid("31937700-8a33-4b10-a74e-4b7e292dd7af"), "CPF40", new DateTime(2000, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1275), "passageiro40@exemplo.com", "Passageiro 40" },
                    { new Guid("3347652a-32e7-4ac0-9319-0a28f39da501"), "CPF26", new DateTime(1975, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1153), "passageiro26@exemplo.com", "Passageiro 26" },
                    { new Guid("3463713c-9471-4015-8a1f-92efdff0c7db"), "CPF59", new DateTime(2004, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1564), "passageiro59@exemplo.com", "Passageiro 59" },
                    { new Guid("3b4a3863-e526-43d0-aa02-337e8701dcc2"), "CPF55", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1531), "passageiro55@exemplo.com", "Passageiro 55" },
                    { new Guid("3be78a25-1414-4cc2-8c11-2def71523696"), "CPF43", new DateTime(1995, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1427), "passageiro43@exemplo.com", "Passageiro 43" },
                    { new Guid("3fd0aaa3-a7e2-4b10-b9de-0ba22a041562"), "CPF72", new DateTime(1988, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1795), "passageiro72@exemplo.com", "Passageiro 72" },
                    { new Guid("40436bef-87f7-4061-b3da-aa8ce621ac2b"), "CPF4", new DateTime(1975, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(915), "passageiro4@exemplo.com", "Passageiro 4" },
                    { new Guid("41ffb3fd-a6c6-4595-8717-e4f1b46e80ba"), "CPF7", new DateTime(1994, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(935), "passageiro7@exemplo.com", "Passageiro 7" },
                    { new Guid("421a3419-db80-4ef2-a1f5-b9fdc3fee139"), "CPF81", new DateTime(1967, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1869), "passageiro81@exemplo.com", "Passageiro 81" },
                    { new Guid("4383fbf0-ae17-4c57-befa-4cf4a2079f1c"), "CPF11", new DateTime(1977, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(971), "passageiro11@exemplo.com", "Passageiro 11" },
                    { new Guid("463dace5-a3a4-46b0-a272-71df048040ef"), "CPF63", new DateTime(1998, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1716), "passageiro63@exemplo.com", "Passageiro 63" },
                    { new Guid("4788aadb-db25-4259-8591-c22497977b00"), "CPF65", new DateTime(1975, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1735), "passageiro65@exemplo.com", "Passageiro 65" },
                    { new Guid("4981053b-af5d-474d-9164-02dc7611236e"), "CPF19", new DateTime(1968, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1040), "passageiro19@exemplo.com", "Passageiro 19" },
                    { new Guid("50e6ea17-0c9c-4102-8f36-acf0d116775f"), "CPF27", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1160), "passageiro27@exemplo.com", "Passageiro 27" },
                    { new Guid("50ff4b0a-5cea-4f61-8156-57c36b600934"), "CPF77", new DateTime(1966, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1836), "passageiro77@exemplo.com", "Passageiro 77" },
                    { new Guid("530416a0-9b30-4208-8cde-aec72b63073f"), "CPF80", new DateTime(1988, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1861), "passageiro80@exemplo.com", "Passageiro 80" },
                    { new Guid("558e993b-61d6-44e7-9dc3-fe869e810925"), "CPF23", new DateTime(1997, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1129), "passageiro23@exemplo.com", "Passageiro 23" },
                    { new Guid("57339186-a83e-445a-ade3-2794b62b7f12"), "CPF37", new DateTime(1999, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1251), "passageiro37@exemplo.com", "Passageiro 37" },
                    { new Guid("5883ee19-a20a-4ec8-b932-6d4b092c6343"), "CPF64", new DateTime(1976, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1727), "passageiro64@exemplo.com", "Passageiro 64" },
                    { new Guid("59f7e68d-5b83-436f-8e33-b9a190b3fee8"), "CPF42", new DateTime(1998, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1420), "passageiro42@exemplo.com", "Passageiro 42" },
                    { new Guid("606fc6a6-a339-4529-8c21-f6322eb0188d"), "CPF70", new DateTime(1995, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1775), "passageiro70@exemplo.com", "Passageiro 70" },
                    { new Guid("6334941a-5319-45cc-8139-820875216f84"), "CPF79", new DateTime(1997, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1851), "passageiro79@exemplo.com", "Passageiro 79" },
                    { new Guid("6b422ef2-2cb8-47f2-90d5-e1c3ddd4e503"), "CPF51", new DateTime(1971, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1498), "passageiro51@exemplo.com", "Passageiro 51" },
                    { new Guid("6e53a264-c36d-4191-b9bf-7b0fd18257de"), "CPF85", new DateTime(1966, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1902), "passageiro85@exemplo.com", "Passageiro 85" },
                    { new Guid("7319e484-1594-4a3a-b454-c1ea505aa639"), "CPF68", new DateTime(1997, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1759), "passageiro68@exemplo.com", "Passageiro 68" },
                    { new Guid("7bdef3c0-8dec-4f51-847a-e751b1f73c44"), "CPF6", new DateTime(1981, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(928), "passageiro6@exemplo.com", "Passageiro 6" },
                    { new Guid("7df03d65-cfcd-4b86-b9b1-a8b802addab4"), "CPF78", new DateTime(1967, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1844), "passageiro78@exemplo.com", "Passageiro 78" },
                    { new Guid("81a0cd6f-01a0-405f-8536-f242bb84d7b3"), "CPF44", new DateTime(2003, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1440), "passageiro44@exemplo.com", "Passageiro 44" },
                    { new Guid("8451c509-88f6-4191-9010-7d8d771ac57d"), "CPF67", new DateTime(1993, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1750), "passageiro67@exemplo.com", "Passageiro 67" },
                    { new Guid("846a4459-da67-48c2-a6eb-c0cf164797c5"), "CPF50", new DateTime(1990, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1490), "passageiro50@exemplo.com", "Passageiro 50" },
                    { new Guid("84f53e85-971f-455b-87fc-5ba54df5729b"), "CPF89", new DateTime(1997, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1935), "passageiro89@exemplo.com", "Passageiro 89" },
                    { new Guid("85976169-1ea7-4a9a-8575-6959fab80a60"), "CPF69", new DateTime(1993, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1767), "passageiro69@exemplo.com", "Passageiro 69" },
                    { new Guid("875c6338-4c07-4deb-ac81-c930ca163a70"), "CPF53", new DateTime(1988, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1517), "passageiro53@exemplo.com", "Passageiro 53" },
                    { new Guid("89736338-341d-46bd-9c20-147b09034951"), "CPF52", new DateTime(2004, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1510), "passageiro52@exemplo.com", "Passageiro 52" },
                    { new Guid("89da3421-146a-4eb3-a759-ef7fc29a3218"), "CPF66", new DateTime(2003, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1743), "passageiro66@exemplo.com", "Passageiro 66" },
                    { new Guid("8bf3d8c6-95b2-4b29-91d8-da85b7d68d86"), "CPF17", new DateTime(1996, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1026), "passageiro17@exemplo.com", "Passageiro 17" },
                    { new Guid("8daaaeb6-d72a-4a78-b2b6-07c67a10b16d"), "CPF75", new DateTime(1973, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1818), "passageiro75@exemplo.com", "Passageiro 75" },
                    { new Guid("8e5f0d3f-4b1f-4cc2-beba-d2c4c3fe47eb"), "CPF82", new DateTime(1978, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1877), "passageiro82@exemplo.com", "Passageiro 82" },
                    { new Guid("8ea9ad2f-5268-4f5d-bfbf-f4f4db9975ad"), "CPF48", new DateTime(1993, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1476), "passageiro48@exemplo.com", "Passageiro 48" },
                    { new Guid("8f362b45-63ca-4618-bc9e-c6a58232848e"), "CPF28", new DateTime(1996, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1172), "passageiro28@exemplo.com", "Passageiro 28" },
                    { new Guid("905ff45d-6cdf-491b-b4c7-30ffa65878b1"), "CPF49", new DateTime(1991, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1483), "passageiro49@exemplo.com", "Passageiro 49" },
                    { new Guid("9117588b-6221-45be-a28a-c6534069d878"), "CPF93", new DateTime(1994, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1968), "passageiro93@exemplo.com", "Passageiro 93" },
                    { new Guid("9296244e-ca65-4241-8cc3-396adebd2104"), "CPF35", new DateTime(1975, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1231), "passageiro35@exemplo.com", "Passageiro 35" },
                    { new Guid("92e2c7c0-c306-4bc5-9d0a-c0bc6ea3b45e"), "CPF73", new DateTime(1977, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1802), "passageiro73@exemplo.com", "Passageiro 73" },
                    { new Guid("938b5420-96e7-48cb-831c-cf4f16c9646a"), "CPF15", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1007), "passageiro15@exemplo.com", "Passageiro 15" },
                    { new Guid("945c7b16-894a-4124-8cf6-42393b5ababb"), "CPF46", new DateTime(2002, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1457), "passageiro46@exemplo.com", "Passageiro 46" },
                    { new Guid("9af3a1a1-e90c-4b67-a73e-41bea1052c5e"), "CPF33", new DateTime(2001, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1215), "passageiro33@exemplo.com", "Passageiro 33" },
                    { new Guid("a3724f92-53ec-4eb4-9cda-64b975493d06"), "CPF57", new DateTime(1988, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1549), "passageiro57@exemplo.com", "Passageiro 57" },
                    { new Guid("a3e10ce8-2f85-4e77-a166-bd5eb38d07fa"), "CPF36", new DateTime(1970, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1243), "passageiro36@exemplo.com", "Passageiro 36" },
                    { new Guid("aa357910-d696-47b3-8f40-c5f963409fab"), "CPF5", new DateTime(1994, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(921), "passageiro5@exemplo.com", "Passageiro 5" },
                    { new Guid("b25be2a1-d18f-43bb-bf61-e4104b61032c"), "CPF54", new DateTime(1980, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1525), "passageiro54@exemplo.com", "Passageiro 54" },
                    { new Guid("b45e46be-c2f3-4eb5-ba37-1b9be28e9439"), "CPF84", new DateTime(2001, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1895), "passageiro84@exemplo.com", "Passageiro 84" },
                    { new Guid("b4a384fb-6d8a-4e54-9274-e735ceea7b0a"), "CPF99", new DateTime(1998, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(2088), "passageiro99@exemplo.com", "Passageiro 99" },
                    { new Guid("bae570c6-87dc-4444-906d-6c908120a531"), "CPF24", new DateTime(1991, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1140), "passageiro24@exemplo.com", "Passageiro 24" },
                    { new Guid("bcfec78f-023e-44be-aeda-b3bbc8adb764"), "CPF8", new DateTime(1992, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(945), "passageiro8@exemplo.com", "Passageiro 8" },
                    { new Guid("be51acf0-018a-4b58-9aca-919490185460"), "CPF29", new DateTime(1976, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1181), "passageiro29@exemplo.com", "Passageiro 29" },
                    { new Guid("c027435b-bef4-4394-b32a-d42bae16ac06"), "CPF88", new DateTime(2000, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1927), "passageiro88@exemplo.com", "Passageiro 88" },
                    { new Guid("c1c6cb5e-1d0e-4d6a-91b6-e4764ea2fa66"), "CPF62", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1709), "passageiro62@exemplo.com", "Passageiro 62" },
                    { new Guid("c200cd36-d66e-421e-bc4f-809ecd372407"), "CPF86", new DateTime(1970, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1909), "passageiro86@exemplo.com", "Passageiro 86" },
                    { new Guid("c2c572f3-be11-4ff9-9fb1-795f5b95ce81"), "CPF94", new DateTime(2006, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1976), "passageiro94@exemplo.com", "Passageiro 94" },
                    { new Guid("c4d4f186-f91b-494a-b6f5-dbe4889a1f06"), "CPF3", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(902), "passageiro3@exemplo.com", "Passageiro 3" },
                    { new Guid("c5b7a6f9-8552-40cb-89a4-eb37e57cea97"), "CPF10", new DateTime(1993, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(964), "passageiro10@exemplo.com", "Passageiro 10" },
                    { new Guid("c6f84477-d377-4b76-b9dc-f7d9ac0c74e8"), "CPF34", new DateTime(2005, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1223), "passageiro34@exemplo.com", "Passageiro 34" },
                    { new Guid("c728cd76-0fbd-4ea9-8e26-7f3d8fbcafcf"), "CPF60", new DateTime(1967, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1694), "passageiro60@exemplo.com", "Passageiro 60" },
                    { new Guid("c7ca67f7-64c9-4297-a259-0bd10360624c"), "CPF95", new DateTime(1969, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1983), "passageiro95@exemplo.com", "Passageiro 95" },
                    { new Guid("c8d07e5f-34a0-4970-97ac-073ae9c37e6b"), "CPF56", new DateTime(2004, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1542), "passageiro56@exemplo.com", "Passageiro 56" },
                    { new Guid("d6689bf3-22dd-4437-8bcb-ea97b897e6db"), "CPF45", new DateTime(1976, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1448), "passageiro45@exemplo.com", "Passageiro 45" },
                    { new Guid("dc49232a-2254-48b5-819b-339c9d64b678"), "CPF39", new DateTime(2003, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1265), "passageiro39@exemplo.com", "Passageiro 39" },
                    { new Guid("de09e1fc-3e27-470c-847c-60796ddc2c26"), "CPF96", new DateTime(1998, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1996), "passageiro96@exemplo.com", "Passageiro 96" },
                    { new Guid("df4781b1-f3c0-451b-8dac-3a0f59e93d54"), "CPF14", new DateTime(1996, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(998), "passageiro14@exemplo.com", "Passageiro 14" },
                    { new Guid("e4b90979-0702-4847-8bef-8a97f2d9a2f6"), "CPF22", new DateTime(1980, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1122), "passageiro22@exemplo.com", "Passageiro 22" },
                    { new Guid("eb3b11fe-0702-4415-82da-5d177a2e6009"), "CPF83", new DateTime(1982, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1884), "passageiro83@exemplo.com", "Passageiro 83" },
                    { new Guid("eb763957-94ac-4cc8-9b0d-58d1e87056b3"), "CPF1", new DateTime(1990, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(860), "passageiro1@exemplo.com", "Passageiro 1" },
                    { new Guid("ed5e390f-2b38-4567-8511-fc72141e77cf"), "CPF74", new DateTime(2003, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1810), "passageiro74@exemplo.com", "Passageiro 74" },
                    { new Guid("ee4c6d7a-3db4-47c7-b56d-c32986e44f01"), "CPF92", new DateTime(2004, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1961), "passageiro92@exemplo.com", "Passageiro 92" },
                    { new Guid("ef34fa59-c9fc-4cb7-b720-fb4e634ed148"), "CPF32", new DateTime(2002, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1207), "passageiro32@exemplo.com", "Passageiro 32" },
                    { new Guid("f2d878ae-7e31-4baf-a7aa-0bf51812da5a"), "CPF41", new DateTime(1966, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1411), "passageiro41@exemplo.com", "Passageiro 41" },
                    { new Guid("f519b487-f7fb-4a73-8850-8b7e9a05e11c"), "CPF2", new DateTime(1979, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(893), "passageiro2@exemplo.com", "Passageiro 2" },
                    { new Guid("f87163cf-9561-414b-9e19-360c23fb581f"), "CPF9", new DateTime(1985, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(953), "passageiro9@exemplo.com", "Passageiro 9" },
                    { new Guid("fba00750-ee6f-4ff1-b15c-9bf34ab7a5d8"), "CPF20", new DateTime(1986, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1050), "passageiro20@exemplo.com", "Passageiro 20" },
                    { new Guid("fbd30c8f-8ed4-4fbd-b137-7c0a5a24a0d0"), "CPF90", new DateTime(1999, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1943), "passageiro90@exemplo.com", "Passageiro 90" },
                    { new Guid("fcd4b8da-9c26-4cee-b179-a5f654da75d7"), "CPF76", new DateTime(1993, 1, 28, 18, 21, 8, 964, DateTimeKind.Local).AddTicks(1829), "passageiro76@exemplo.com", "Passageiro 76" }
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
