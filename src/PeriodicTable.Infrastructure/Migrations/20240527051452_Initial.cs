using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicTable.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChemicalElements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Group = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StandartState = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false),
                    Electronegativity = table.Column<float>(type: "real", nullable: false),
                    MeltingPointInK = table.Column<float>(type: "real", nullable: false),
                    BoilingPointInk = table.Column<float>(type: "real", nullable: false),
                    YearDiscovered = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalElements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChemicalElements");
        }
    }
}
