using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Linguini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sightings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SightingAddressName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SightingAddressNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SightingDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SightingDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Sightingstate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sightings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sightings",
                columns: new[] { "Id", "SightingAddressName", "SightingAddressNumber", "SightingDateTime", "SightingDescription", "Sightingstate" },
                values: new object[,]
                {
                    { "s1", "Calle Falsa", "123", new DateTime(2025, 9, 25, 10, 30, 0, 0, DateTimeKind.Unspecified), "Avisté un perro corriendo solo", 0 },
                    { "s2", "Av. Libertad", "456", new DateTime(2025, 9, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "Gato atrapado en un árbol, unos pibes le estaban tirando piedras, los cagué a trompadas pero no pude bajar al gato del árbol", 0 },
                    { "s3", "Plaza Central", "10", new DateTime(2025, 9, 23, 9, 15, 0, 0, DateTimeKind.Unspecified), "Conejo perdido cerca del parque", 0 },
                    { "s4", "Barrio Norte", "2345", new DateTime(2025, 9, 22, 18, 45, 0, 0, DateTimeKind.Unspecified), "Se ve un pájaro herido", 0 },
                    { "s5", "Ruta 5", "2000", new DateTime(2025, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "Avistamiento de perro callejero al borde de la ruta, pueden ser más de uno, pareciese tener crías", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sightings");
        }
    }
}
