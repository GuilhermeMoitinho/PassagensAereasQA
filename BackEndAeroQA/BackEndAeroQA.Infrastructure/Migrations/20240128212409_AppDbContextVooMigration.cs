using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndAeroQA.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AppDbContextVooMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Voos",
                columns: new[] { "Id", "DataHoraDeChegada", "DataHoraDePartida", "Destino", "Origem", "QuantidadeDosAssentos", "Tipo", "ValorDoAssento" },
                values: new object[,]
                {
                    { new Guid("002b40f6-d5a8-480a-a5ed-085590c62c9f"), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8007), "Destino 7", "Origem 7", 33, 0, 2654.0 },
                    { new Guid("009329cc-78bf-4236-84d7-badeded7130c"), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8027), "Destino 10", "Origem 10", 42, 0, 1860.0 },
                    { new Guid("050e6d75-aace-48ca-90a1-45a0d60179a2"), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8429), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8428), "Destino 79", "Origem 79", 38, 0, 1002.0 },
                    { new Guid("053127f5-329c-42b6-b812-ceb2e6931f09"), new DateTime(2024, 2, 16, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8328), "Destino 64", "Origem 64", 44, 0, 4475.0 },
                    { new Guid("06b86653-a3d4-4c38-8dd8-de4545113ea1"), new DateTime(2024, 2, 19, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8514), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8514), "Destino 96", "Origem 96", 32, 0, 3743.0 },
                    { new Guid("0a01e5ac-d496-49b3-bfec-f62f91c017bf"), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 1, 31, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8463), "Destino 86", "Origem 86", 23, 0, 1761.0 },
                    { new Guid("0eb6a14a-e47e-4024-bb28-34f6dca27a6d"), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 2, 7, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8440), "Destino 81", "Origem 81", 39, 0, 4499.0 },
                    { new Guid("0f32ad46-0110-410f-b06e-8e9c167a30b9"), new DateTime(2024, 1, 29, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8282), "Destino 55", "Origem 55", 34, 0, 3522.0 },
                    { new Guid("172d31b4-3713-4fe9-ab9a-ac4826d9b636"), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8113), "Destino 20", "Origem 20", 39, 0, 2722.0 },
                    { new Guid("193d7ceb-86ac-464d-b3b0-466001f7df42"), new DateTime(2024, 2, 19, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8416), "Destino 76", "Origem 76", 22, 0, 2728.0 },
                    { new Guid("1b2f9fa8-8940-4876-b1de-1b5461711501"), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8436), "Destino 80", "Origem 80", 45, 0, 3946.0 },
                    { new Guid("29a0259e-efa3-4deb-a8cb-7aacb045bca9"), new DateTime(2024, 2, 19, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8302), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8301), "Destino 59", "Origem 59", 44, 0, 1056.0 },
                    { new Guid("2a34cd90-f09a-4629-bdc2-b85f08323d2f"), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 2, 3, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8444), "Destino 82", "Origem 82", 45, 0, 2875.0 },
                    { new Guid("2bbe29cf-a288-4fac-9175-d8d52073cc15"), new DateTime(2024, 2, 26, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8199), "Destino 38", "Origem 38", 33, 0, 3378.0 },
                    { new Guid("2c103dbf-4014-44a5-a479-df0a7e3ae34c"), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7974), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7953), "Destino 1", "Origem 1", 39, 0, 3103.0 },
                    { new Guid("2c4b8d00-bd9c-4b78-bd60-031b5de78fae"), new DateTime(2024, 2, 19, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8409), "Destino 75", "Origem 75", 31, 0, 2138.0 },
                    { new Guid("3028e1e2-b9c5-4549-bd38-716afe3a81af"), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8039), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8038), "Destino 12", "Origem 12", 28, 0, 3668.0 },
                    { new Guid("331f593a-51cf-4313-a8e4-1d86b88669f1"), new DateTime(2024, 2, 3, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8191), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8191), "Destino 36", "Origem 36", 27, 0, 3416.0 },
                    { new Guid("35247efe-bc4f-453d-a0a3-2ab8d4a2e1b8"), new DateTime(2024, 2, 3, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8483), "Destino 90", "Origem 90", 22, 0, 1700.0 },
                    { new Guid("38d1aa1c-8cdb-499f-8512-884c17a3567c"), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8015), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8014), "Destino 8", "Origem 8", 23, 0, 4566.0 },
                    { new Guid("40e53762-c470-4b4a-9d0b-056532ae603d"), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8106), "Destino 19", "Origem 19", 46, 0, 4445.0 },
                    { new Guid("412f91da-4b7b-44c3-a758-31590c1b7a0b"), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8273), "Destino 53", "Origem 53", 23, 0, 1113.0 },
                    { new Guid("4370d7d4-e415-4aeb-90ae-231d47485e88"), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7999), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7999), "Destino 5", "Origem 5", 22, 0, 4373.0 },
                    { new Guid("43fc09bc-6d01-4d00-b5a7-f3e58da10629"), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 2, 21, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8171), "Destino 32", "Origem 32", 24, 0, 691.0 },
                    { new Guid("44684391-164f-4b9e-8975-d4e0c7d804ec"), new DateTime(2024, 2, 17, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8534), "Destino 100", "Origem 100", 33, 0, 868.0 },
                    { new Guid("4656ab10-7de6-4f95-befa-bccf279f4a36"), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8487), "Destino 91", "Origem 91", 23, 0, 4331.0 },
                    { new Guid("4686cc97-1380-44fd-b487-86bf02f2569c"), new DateTime(2024, 1, 29, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8117), "Destino 21", "Origem 21", 31, 0, 2008.0 },
                    { new Guid("46e124cc-7b3c-4444-aae8-e66dac1fbfba"), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8153), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8152), "Destino 28", "Origem 28", 45, 0, 4153.0 },
                    { new Guid("476f736e-03d0-4815-9363-8182542e96a3"), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8219), "Destino 42", "Origem 42", 24, 0, 1571.0 },
                    { new Guid("49f3892d-72ee-44d3-bf2f-903c80c47fcf"), new DateTime(2024, 2, 8, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8455), "Destino 84", "Origem 84", 41, 0, 1510.0 },
                    { new Guid("4a149484-9c56-4969-8795-8244fc2af9ac"), new DateTime(2024, 2, 3, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8215), "Destino 41", "Origem 41", 36, 0, 2073.0 },
                    { new Guid("4b706f6b-1c28-462d-b3e2-2c830f672778"), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8122), "Destino 22", "Origem 22", 22, 0, 543.0 },
                    { new Guid("4e447074-174d-4142-a87e-1b931d98ed14"), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8051), "Destino 15", "Origem 15", 29, 0, 2005.0 },
                    { new Guid("55900ddc-cda6-49fc-8413-643df01e5c35"), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7995), new DateTime(2024, 2, 10, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7994), "Destino 4", "Origem 4", 29, 0, 4580.0 },
                    { new Guid("5bf69656-ae1b-450b-8476-682982a95c76"), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8518), "Destino 97", "Origem 97", 24, 0, 3027.0 },
                    { new Guid("5c9dd07f-93d6-41e8-b2cd-0c69fb7b0265"), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8309), new DateTime(2024, 2, 8, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8308), "Destino 60", "Origem 60", 39, 0, 2667.0 },
                    { new Guid("62992bad-a256-437e-8494-db43a4d3a0d6"), new DateTime(2024, 2, 26, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8405), "Destino 74", "Origem 74", 24, 0, 1090.0 },
                    { new Guid("62ce3269-2623-4bbd-9d30-c37b597ae2f8"), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8161), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8160), "Destino 30", "Origem 30", 38, 0, 1658.0 },
                    { new Guid("66ffb846-24f6-4568-a898-52aee504e3a0"), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8243), "Destino 47", "Origem 47", 24, 0, 2964.0 },
                    { new Guid("68c70e1e-c78d-499b-8666-020dcbb01ebe"), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8003), "Destino 6", "Origem 6", 37, 0, 1503.0 },
                    { new Guid("69a6095b-ac2b-4b77-af7d-d81b5ae1de3f"), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8093), "Destino 16", "Origem 16", 25, 0, 4172.0 },
                    { new Guid("6e67747a-1d66-4336-9d76-3000b7293b5d"), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8377), "Destino 68", "Origem 68", 27, 0, 840.0 },
                    { new Guid("71d8074e-1152-40e4-8fa8-ba39e1da35c6"), new DateTime(2024, 1, 29, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8224), "Destino 43", "Origem 43", 42, 0, 2191.0 },
                    { new Guid("732e4177-6f05-459d-8860-82e2e8bdc366"), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8459), "Destino 85", "Origem 85", 43, 0, 1306.0 },
                    { new Guid("73ba9b54-6683-4664-b7f5-b672e5428c3a"), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8313), "Destino 61", "Origem 61", 29, 0, 2938.0 },
                    { new Guid("76272b88-2810-4974-9be9-e87fddbf1cce"), new DateTime(2024, 2, 17, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8019), new DateTime(2024, 2, 7, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8018), "Destino 9", "Origem 9", 27, 0, 2656.0 },
                    { new Guid("7659c3d7-5adc-43ff-9627-a90f8f8264e2"), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8263), "Destino 51", "Origem 51", 44, 0, 3950.0 },
                    { new Guid("767c4f26-d504-42a7-a9d9-c7356685daa5"), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8385), "Destino 70", "Origem 70", 45, 0, 2987.0 },
                    { new Guid("76ee94ca-7538-45a0-91bd-f98eb6d1a1df"), new DateTime(2024, 2, 19, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8270), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8269), "Destino 52", "Origem 52", 43, 0, 2105.0 },
                    { new Guid("798fa6c1-4fc4-4c0f-9a1c-fe87dfcbce1d"), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8204), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8203), "Destino 39", "Origem 39", 37, 0, 1521.0 },
                    { new Guid("7d5ec02e-5a50-47e0-8ad4-40de32ddf297"), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 2, 10, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8366), "Destino 66", "Origem 66", 43, 0, 1476.0 },
                    { new Guid("82067006-0dee-4686-ae27-448efb948099"), new DateTime(2024, 2, 7, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8397), "Destino 72", "Origem 72", 36, 0, 4453.0 },
                    { new Guid("82cb1be0-16a5-4050-8f76-0d48c6014dd1"), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7982), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7981), "Destino 2", "Origem 2", 30, 0, 2305.0 },
                    { new Guid("862e9ead-b00b-407b-9b15-c9db193cd9e3"), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 1, 29, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8448), "Destino 83", "Origem 83", 27, 0, 3852.0 },
                    { new Guid("8911519e-04e8-4715-8999-675bb94771b3"), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8103), new DateTime(2024, 2, 16, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8102), "Destino 18", "Origem 18", 45, 0, 3089.0 },
                    { new Guid("8ad1d695-8cb6-4c97-86ac-68fdf822261f"), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8239), "Destino 46", "Origem 46", 45, 0, 3863.0 },
                    { new Guid("8b23f91d-f4d1-4d57-9588-31c40dbea69d"), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8317), "Destino 62", "Origem 62", 46, 0, 2114.0 },
                    { new Guid("8c2db102-8bf9-4675-b486-c8e04244b257"), new DateTime(2024, 2, 21, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8297), "Destino 58", "Origem 58", 24, 0, 4343.0 },
                    { new Guid("8c5c316b-857e-4845-a6f2-9da7cd51276c"), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8032), new DateTime(2024, 1, 29, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8031), "Destino 11", "Origem 11", 32, 0, 918.0 },
                    { new Guid("8c627783-ac87-42e6-a6de-294ff024fd7f"), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8494), "Destino 92", "Origem 92", 42, 0, 3695.0 },
                    { new Guid("8ca0ddd5-6280-45cd-9623-f3f76d58e891"), new DateTime(2024, 2, 26, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8211), "Destino 40", "Origem 40", 39, 0, 4364.0 },
                    { new Guid("8dd2d61d-63c4-4ec0-83f2-92b0a9dbdb0b"), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8141), "Destino 26", "Origem 26", 39, 0, 503.0 },
                    { new Guid("8fb5b56b-5d75-4736-a0ba-c92b8b983ef1"), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8235), "Destino 45", "Origem 45", 30, 0, 1086.0 },
                    { new Guid("94f828cd-5b23-47c0-9445-2666b564e548"), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 2, 16, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8503), "Destino 94", "Origem 94", 25, 0, 4887.0 },
                    { new Guid("9679ddfc-b6be-4a48-bb37-82d5a23a77e3"), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 2, 8, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8361), "Destino 65", "Origem 65", 46, 0, 3132.0 },
                    { new Guid("9cb02df6-ccc7-40e7-945a-10b64ebe9b9e"), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8390), "Destino 71", "Origem 71", 43, 0, 520.0 },
                    { new Guid("9fa4467c-9430-4460-aebe-e24bb6abfc68"), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8401), "Destino 73", "Origem 73", 49, 0, 2947.0 },
                    { new Guid("a18a9bc4-1156-4dad-b79b-7ea5f24f4df6"), new DateTime(2024, 1, 31, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8133), "Destino 24", "Origem 24", 24, 0, 1017.0 },
                    { new Guid("a3376918-4121-40cf-9dcd-f67e3947af9d"), new DateTime(2024, 2, 3, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8522), "Destino 98", "Origem 98", 38, 0, 1686.0 },
                    { new Guid("a454d8ed-f387-4728-9bf3-9666b917237e"), new DateTime(2024, 1, 30, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 2, 26, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8145), "Destino 27", "Origem 27", 47, 0, 2367.0 },
                    { new Guid("a6960b1f-9bfa-4636-9491-83f5b21fca16"), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8250), "Destino 48", "Origem 48", 47, 0, 4239.0 },
                    { new Guid("ab13d557-3b2a-4cbc-bd7a-e47a30a3b54a"), new DateTime(2024, 2, 17, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8179), "Destino 34", "Origem 34", 38, 0, 2048.0 },
                    { new Guid("acab75be-3f95-42ee-ac8b-5cee67eac529"), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 1, 31, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8254), "Destino 49", "Origem 49", 27, 0, 3252.0 },
                    { new Guid("acee92c3-233b-48fa-927b-df6404b8f750"), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 2, 21, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8156), "Destino 29", "Origem 29", 37, 0, 1485.0 },
                    { new Guid("b1452650-e5d8-455f-a0bf-e96952b87581"), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8499), "Destino 93", "Origem 93", 22, 0, 1709.0 },
                    { new Guid("b381fe78-2e3f-42d1-b45f-02e2dbf6d8d8"), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 2, 6, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8126), "Destino 23", "Origem 23", 22, 0, 2172.0 },
                    { new Guid("b38c88df-8625-47dc-aaac-9c324d0f907a"), new DateTime(2024, 2, 21, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8195), "Destino 37", "Origem 37", 39, 0, 1992.0 },
                    { new Guid("b5f6b564-0161-413b-b94d-f12975cf1891"), new DateTime(2024, 2, 11, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8289), "Destino 56", "Origem 56", 45, 0, 4846.0 },
                    { new Guid("b8c2d062-5c86-430b-ad0e-77d6b6d88ef6"), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8046), "Destino 14", "Origem 14", 39, 0, 1271.0 },
                    { new Guid("ba3c2329-a76a-4049-bb2c-7dfaebb4de81"), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 2, 8, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8042), "Destino 13", "Origem 13", 40, 0, 1928.0 },
                    { new Guid("bb0e0dfc-62d8-4d66-8740-cafa7717bfe5"), new DateTime(2024, 2, 17, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8381), "Destino 69", "Origem 69", 30, 0, 4101.0 },
                    { new Guid("be7edd56-2678-4086-a97b-b8cf0aaf893c"), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8098), "Destino 17", "Origem 17", 46, 0, 4846.0 },
                    { new Guid("c06e953f-50f0-4d3f-9f4a-3e83292c1922"), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8184), new DateTime(2024, 2, 18, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8184), "Destino 35", "Origem 35", 35, 0, 4546.0 },
                    { new Guid("c0cf4f7b-3850-4f94-9dec-415e2d5f9848"), new DateTime(2024, 2, 23, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8137), new DateTime(2024, 2, 7, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8137), "Destino 25", "Origem 25", 34, 0, 2634.0 },
                    { new Guid("ccb93018-3fa7-4e1a-9f3f-d02a32d099d8"), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8231), new DateTime(2024, 1, 29, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8231), "Destino 44", "Origem 44", 27, 0, 4536.0 },
                    { new Guid("cfddcb24-9b11-4095-9ff0-383ccddde2ad"), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8165), new DateTime(2024, 2, 9, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8164), "Destino 31", "Origem 31", 22, 0, 2461.0 },
                    { new Guid("d11d2a89-4157-4de9-b044-282d500f2a90"), new DateTime(2024, 2, 26, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8526), "Destino 99", "Origem 99", 39, 0, 3155.0 },
                    { new Guid("d276c8fe-5916-46c0-ae6b-a7f89f0630a3"), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8175), "Destino 33", "Origem 33", 42, 0, 3166.0 },
                    { new Guid("d4a77f69-9f07-4487-8d32-4d7c06f034cd"), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8259), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8258), "Destino 50", "Origem 50", 41, 0, 1088.0 },
                    { new Guid("d54e58d2-837b-4c31-9d2b-2a923e81173a"), new DateTime(2024, 2, 7, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 2, 21, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8424), "Destino 78", "Origem 78", 45, 0, 1006.0 },
                    { new Guid("d6465714-3924-4247-bb6c-f823b80f4958"), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8321), "Destino 63", "Origem 63", 27, 0, 3012.0 },
                    { new Guid("dfb8ff14-b864-4373-a217-92b644d80f5c"), new DateTime(2024, 2, 14, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 2, 5, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8507), "Destino 95", "Origem 95", 39, 0, 547.0 },
                    { new Guid("e20c62e3-1a1f-40cf-949a-ffb05b1cf731"), new DateTime(2024, 2, 12, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 2, 15, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8479), "Destino 89", "Origem 89", 29, 0, 1180.0 },
                    { new Guid("eaf79fe1-8113-4b4f-8563-1c07e034d231"), new DateTime(2024, 2, 22, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 2, 3, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8278), "Destino 54", "Origem 54", 33, 0, 2947.0 },
                    { new Guid("ebcbf9ca-4961-4502-9282-ef038fa7007a"), new DateTime(2024, 2, 20, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8474), "Destino 88", "Origem 88", 33, 0, 4884.0 },
                    { new Guid("eff5296c-55d4-4385-8ad3-6051ccd7a94b"), new DateTime(2024, 2, 25, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 2, 19, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8467), "Destino 87", "Origem 87", 42, 0, 3013.0 },
                    { new Guid("f0d228dc-6685-42d8-8a67-a28be924539c"), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 2, 4, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8370), "Destino 67", "Origem 67", 41, 0, 4947.0 },
                    { new Guid("f6120895-18bd-4db5-a992-2e71a52d26ae"), new DateTime(2024, 2, 24, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 2, 13, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8293), "Destino 57", "Origem 57", 41, 0, 4433.0 },
                    { new Guid("f8b6da2e-45a0-4aff-a08f-62a81d4b76fd"), new DateTime(2024, 2, 21, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 2, 1, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(8420), "Destino 77", "Origem 77", 35, 0, 1803.0 },
                    { new Guid("fe80169c-0188-4e99-b179-26aa5fb198fb"), new DateTime(2024, 2, 16, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7986), new DateTime(2024, 2, 2, 18, 24, 8, 247, DateTimeKind.Local).AddTicks(7986), "Destino 3", "Origem 3", 32, 0, 2411.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("002b40f6-d5a8-480a-a5ed-085590c62c9f"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("009329cc-78bf-4236-84d7-badeded7130c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("050e6d75-aace-48ca-90a1-45a0d60179a2"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("053127f5-329c-42b6-b812-ceb2e6931f09"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("06b86653-a3d4-4c38-8dd8-de4545113ea1"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("0a01e5ac-d496-49b3-bfec-f62f91c017bf"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("0eb6a14a-e47e-4024-bb28-34f6dca27a6d"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("0f32ad46-0110-410f-b06e-8e9c167a30b9"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("172d31b4-3713-4fe9-ab9a-ac4826d9b636"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("193d7ceb-86ac-464d-b3b0-466001f7df42"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("1b2f9fa8-8940-4876-b1de-1b5461711501"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("29a0259e-efa3-4deb-a8cb-7aacb045bca9"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("2a34cd90-f09a-4629-bdc2-b85f08323d2f"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("2bbe29cf-a288-4fac-9175-d8d52073cc15"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("2c103dbf-4014-44a5-a479-df0a7e3ae34c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("2c4b8d00-bd9c-4b78-bd60-031b5de78fae"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("3028e1e2-b9c5-4549-bd38-716afe3a81af"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("331f593a-51cf-4313-a8e4-1d86b88669f1"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("35247efe-bc4f-453d-a0a3-2ab8d4a2e1b8"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("38d1aa1c-8cdb-499f-8512-884c17a3567c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("40e53762-c470-4b4a-9d0b-056532ae603d"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("412f91da-4b7b-44c3-a758-31590c1b7a0b"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("4370d7d4-e415-4aeb-90ae-231d47485e88"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("43fc09bc-6d01-4d00-b5a7-f3e58da10629"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("44684391-164f-4b9e-8975-d4e0c7d804ec"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("4656ab10-7de6-4f95-befa-bccf279f4a36"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("4686cc97-1380-44fd-b487-86bf02f2569c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("46e124cc-7b3c-4444-aae8-e66dac1fbfba"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("476f736e-03d0-4815-9363-8182542e96a3"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("49f3892d-72ee-44d3-bf2f-903c80c47fcf"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("4a149484-9c56-4969-8795-8244fc2af9ac"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("4b706f6b-1c28-462d-b3e2-2c830f672778"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("4e447074-174d-4142-a87e-1b931d98ed14"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("55900ddc-cda6-49fc-8413-643df01e5c35"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("5bf69656-ae1b-450b-8476-682982a95c76"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("5c9dd07f-93d6-41e8-b2cd-0c69fb7b0265"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("62992bad-a256-437e-8494-db43a4d3a0d6"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("62ce3269-2623-4bbd-9d30-c37b597ae2f8"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("66ffb846-24f6-4568-a898-52aee504e3a0"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("68c70e1e-c78d-499b-8666-020dcbb01ebe"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("69a6095b-ac2b-4b77-af7d-d81b5ae1de3f"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("6e67747a-1d66-4336-9d76-3000b7293b5d"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("71d8074e-1152-40e4-8fa8-ba39e1da35c6"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("732e4177-6f05-459d-8860-82e2e8bdc366"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("73ba9b54-6683-4664-b7f5-b672e5428c3a"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("76272b88-2810-4974-9be9-e87fddbf1cce"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("7659c3d7-5adc-43ff-9627-a90f8f8264e2"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("767c4f26-d504-42a7-a9d9-c7356685daa5"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("76ee94ca-7538-45a0-91bd-f98eb6d1a1df"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("798fa6c1-4fc4-4c0f-9a1c-fe87dfcbce1d"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("7d5ec02e-5a50-47e0-8ad4-40de32ddf297"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("82067006-0dee-4686-ae27-448efb948099"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("82cb1be0-16a5-4050-8f76-0d48c6014dd1"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("862e9ead-b00b-407b-9b15-c9db193cd9e3"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8911519e-04e8-4715-8999-675bb94771b3"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8ad1d695-8cb6-4c97-86ac-68fdf822261f"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8b23f91d-f4d1-4d57-9588-31c40dbea69d"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8c2db102-8bf9-4675-b486-c8e04244b257"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8c5c316b-857e-4845-a6f2-9da7cd51276c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8c627783-ac87-42e6-a6de-294ff024fd7f"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8ca0ddd5-6280-45cd-9623-f3f76d58e891"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8dd2d61d-63c4-4ec0-83f2-92b0a9dbdb0b"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("8fb5b56b-5d75-4736-a0ba-c92b8b983ef1"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("94f828cd-5b23-47c0-9445-2666b564e548"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("9679ddfc-b6be-4a48-bb37-82d5a23a77e3"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("9cb02df6-ccc7-40e7-945a-10b64ebe9b9e"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("9fa4467c-9430-4460-aebe-e24bb6abfc68"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("a18a9bc4-1156-4dad-b79b-7ea5f24f4df6"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("a3376918-4121-40cf-9dcd-f67e3947af9d"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("a454d8ed-f387-4728-9bf3-9666b917237e"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("a6960b1f-9bfa-4636-9491-83f5b21fca16"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("ab13d557-3b2a-4cbc-bd7a-e47a30a3b54a"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("acab75be-3f95-42ee-ac8b-5cee67eac529"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("acee92c3-233b-48fa-927b-df6404b8f750"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("b1452650-e5d8-455f-a0bf-e96952b87581"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("b381fe78-2e3f-42d1-b45f-02e2dbf6d8d8"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("b38c88df-8625-47dc-aaac-9c324d0f907a"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("b5f6b564-0161-413b-b94d-f12975cf1891"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("b8c2d062-5c86-430b-ad0e-77d6b6d88ef6"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("ba3c2329-a76a-4049-bb2c-7dfaebb4de81"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("bb0e0dfc-62d8-4d66-8740-cafa7717bfe5"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("be7edd56-2678-4086-a97b-b8cf0aaf893c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("c06e953f-50f0-4d3f-9f4a-3e83292c1922"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("c0cf4f7b-3850-4f94-9dec-415e2d5f9848"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("ccb93018-3fa7-4e1a-9f3f-d02a32d099d8"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("cfddcb24-9b11-4095-9ff0-383ccddde2ad"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("d11d2a89-4157-4de9-b044-282d500f2a90"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("d276c8fe-5916-46c0-ae6b-a7f89f0630a3"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("d4a77f69-9f07-4487-8d32-4d7c06f034cd"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("d54e58d2-837b-4c31-9d2b-2a923e81173a"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("d6465714-3924-4247-bb6c-f823b80f4958"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("dfb8ff14-b864-4373-a217-92b644d80f5c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("e20c62e3-1a1f-40cf-949a-ffb05b1cf731"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("eaf79fe1-8113-4b4f-8563-1c07e034d231"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("ebcbf9ca-4961-4502-9282-ef038fa7007a"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("eff5296c-55d4-4385-8ad3-6051ccd7a94b"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("f0d228dc-6685-42d8-8a67-a28be924539c"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("f6120895-18bd-4db5-a992-2e71a52d26ae"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("f8b6da2e-45a0-4aff-a08f-62a81d4b76fd"));

            migrationBuilder.DeleteData(
                table: "Voos",
                keyColumn: "Id",
                keyValue: new Guid("fe80169c-0188-4e99-b179-26aa5fb198fb"));
        }
    }
}
