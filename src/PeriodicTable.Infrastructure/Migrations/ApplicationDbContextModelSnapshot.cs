﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeriodicTable.Infrastructure.Database;

#nullable disable

namespace PeriodicTable.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PeriodicTable.Domain.Entities.ChemicalElement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AtomicNumber")
                        .HasColumnType("int");

                    b.Property<float>("BoilingPointInK")
                        .HasColumnType("real");

                    b.Property<float?>("Electronegativity")
                        .HasColumnType("real");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("MeltingPointInK")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StandartState")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<short?>("YearDiscovered")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("ChemicalElements");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4e61fad-36d2-46da-b0a0-7044bbba976c"),
                            AtomicNumber = 1,
                            BoilingPointInK = 20.28f,
                            Electronegativity = 2.2f,
                            Group = "Nonmetal",
                            MeltingPointInK = 13.81f,
                            Name = "Hydrogen",
                            StandartState = "Gas",
                            Symbol = "H",
                            YearDiscovered = (short)1766
                        },
                        new
                        {
                            Id = new Guid("627a2312-3f5a-401d-bc7e-f4ed1cec7828"),
                            AtomicNumber = 2,
                            BoilingPointInK = 4.22f,
                            Electronegativity = 2.4f,
                            Group = "Noble gas",
                            MeltingPointInK = 0.95f,
                            Name = "Helium",
                            StandartState = "Gas",
                            Symbol = "He",
                            YearDiscovered = (short)1868
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
