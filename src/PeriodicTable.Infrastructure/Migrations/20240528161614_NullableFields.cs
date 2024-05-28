using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeriodicTable.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Id",
                keyValue: new Guid("7b79313a-9dd4-4502-b967-fbb5b504aa2d"));

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Id",
                keyValue: new Guid("dc9e7890-d34d-4dd3-91f7-6d5577e13940"));

            migrationBuilder.RenameColumn(
                name: "BoilingPointInk",
                table: "ChemicalElements",
                newName: "BoilingPointInK");

            migrationBuilder.AlterColumn<short>(
                name: "YearDiscovered",
                table: "ChemicalElements",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<float>(
                name: "Electronegativity",
                table: "ChemicalElements",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Id", "AtomicNumber", "BoilingPointInK", "Electronegativity", "Group", "MeltingPointInK", "Name", "StandartState", "Symbol", "YearDiscovered" },
                values: new object[,]
                {
                    { new Guid("627a2312-3f5a-401d-bc7e-f4ed1cec7828"), 2, 4.22f, 2.4f, "Noble gas", 0.95f, "Helium", "Gas", "He", (short)1868 },
                    { new Guid("a4e61fad-36d2-46da-b0a0-7044bbba976c"), 1, 20.28f, 2.2f, "Nonmetal", 13.81f, "Hydrogen", "Gas", "H", (short)1766 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Id",
                keyValue: new Guid("627a2312-3f5a-401d-bc7e-f4ed1cec7828"));

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Id",
                keyValue: new Guid("a4e61fad-36d2-46da-b0a0-7044bbba976c"));

            migrationBuilder.RenameColumn(
                name: "BoilingPointInK",
                table: "ChemicalElements",
                newName: "BoilingPointInk");

            migrationBuilder.AlterColumn<short>(
                name: "YearDiscovered",
                table: "ChemicalElements",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Electronegativity",
                table: "ChemicalElements",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Id", "AtomicNumber", "BoilingPointInk", "Electronegativity", "Group", "MeltingPointInK", "Name", "StandartState", "Symbol", "YearDiscovered" },
                values: new object[,]
                {
                    { new Guid("7b79313a-9dd4-4502-b967-fbb5b504aa2d"), 2, 4.22f, 2.4f, "Noble gas", 0.95f, "Helium", "Gas", "He", (short)1868 },
                    { new Guid("dc9e7890-d34d-4dd3-91f7-6d5577e13940"), 1, 20.28f, 2.2f, "Nonmetal", 13.81f, "Hydrogen", "Gas", "H", (short)1766 }
                });
        }
    }
}
