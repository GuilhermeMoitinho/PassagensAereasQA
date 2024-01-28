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
                            Id = new Guid("d253f61f-9fec-407e-b5e6-16736f94a1e3"),
                            Cidade = "Rio de Janeiro",
                            Codigo = 1000,
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("87a599dd-e48d-4f4f-a084-9586ecf561dc"),
                            Cidade = "São Paulo",
                            Codigo = 1001,
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("f0a093a8-3f33-49b2-9618-dbbb0e7352a6"),
                            Cidade = "Belo Horizonte",
                            Codigo = 1002,
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("cbc1f3cf-b130-4c41-9bc0-7b1651012aa9"),
                            Cidade = "Brasília",
                            Codigo = 1003,
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("5f8efbaf-ae44-4664-b266-b237f2073e5f"),
                            Cidade = "Salvador",
                            Codigo = 1004,
                            UF = "BA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
