﻿// <auto-generated />
using System;
using BackEndAeroQA.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEndAeroQA.Infrastructure.Migrations.DbContextAeroportoMigrations
{
    [DbContext(typeof(DbContextAeroporto))]
    partial class DbContextAeroportoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackEndAeroQA.Domain.Entity.Aeroporto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aeroportos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc5c5e35-2186-42ad-90d6-208eb6546e18"),
                            Cidade = "Rio de Janeiro",
                            Codigo = 1000,
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("229a2ac4-f562-4636-b261-8f4ef3f8d207"),
                            Cidade = "São Paulo",
                            Codigo = 1001,
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("84195e0e-fb05-4eb6-9536-2d0dc97547ef"),
                            Cidade = "Belo Horizonte",
                            Codigo = 1002,
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("fe622eb9-e637-499a-9ce7-c46b012e9c9e"),
                            Cidade = "Brasília",
                            Codigo = 1003,
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("5ceb7485-bca8-425b-a905-9ca834c93645"),
                            Cidade = "Salvador",
                            Codigo = 1004,
                            UF = "BA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
