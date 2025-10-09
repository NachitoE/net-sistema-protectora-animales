using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalCheckUps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCheckUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCheckUps_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCheckUps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckUps",
                columns: new[] { "Id", "AnimalId", "CheckUpDate", "Observation", "UserId" },
                values: new object[,]
                {
                    { "mc-1", "7", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control de rutina. Vacunas al día. Estado general excelente.", "user-3" },
                    { "mc-2", "5", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revisión post-adopción. El animal se ha adaptado bien. Se recomienda seguimiento en 3 meses.", "user-3" },
                    { "mc-3", "4", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desparasitación realizada. Peso adecuado para su edad. Continuar con alimentación actual.", "user-3" },
                    { "mc-4", "1", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control pre-adopción. Animal en condiciones óptimas para ser adoptado.", "user-3" },
                    { "mc-5", "2", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revisión dental. Se detectó sarro leve. Se realizó limpieza. Buen estado general.", "user-3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCheckUps_AnimalId",
                table: "MedicalCheckUps",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCheckUps_UserId",
                table: "MedicalCheckUps",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalCheckUps");
        }
    }
}
