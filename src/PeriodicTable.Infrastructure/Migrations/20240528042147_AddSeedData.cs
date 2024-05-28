using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeriodicTable.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Id", "AtomicNumber", "BoilingPointInk", "Electronegativity", "Group", "MeltingPointInK", "Name", "StandartState", "Symbol", "YearDiscovered" },
                values: new object[,]
                {
                    { new Guid("7b79313a-9dd4-4502-b967-fbb5b504aa2d"), 2, 4.22f, 2.4f, "Noble gas", 0.95f, "Helium", "Gas", "He", (short)1868 },
                    { new Guid("dc9e7890-d34d-4dd3-91f7-6d5577e13940"), 1, 20.28f, 2.2f, "Nonmetal", 13.81f, "Hydrogen", "Gas", "H", (short)1766 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Id",
                keyValue: new Guid("7b79313a-9dd4-4502-b967-fbb5b504aa2d"));

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Id",
                keyValue: new Guid("dc9e7890-d34d-4dd3-91f7-6d5577e13940"));
        }
    }
}
