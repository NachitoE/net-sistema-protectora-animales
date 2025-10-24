using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMigration_20251024_184927 : Migration
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStatus = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Active"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnimalState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressNumber = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnimalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdoptionRequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdoptionResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Pendiente"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoptions_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adoptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalResponsibleHistories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsibleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnimalId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalResponsibleHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalResponsibleHistories_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalResponsibleHistories_Users_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCheckUps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalState", "BirthDate", "Description", "Name", "Species", "UserId" },
                values: new object[,]
                {
                    { "1", "ARevisar", new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Firulais", "Perro", null },
                    { "3", "ARevisar", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Bunny", "Conejo", null },
                    { "6", "ARevisar", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Coco", "Conejo", null }
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dni", "Name", "Password", "SurName", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user-1", "12345678", "UTN", "123", "Rosario", "utn", "Admin" },
                    { "user-2", "87654321", "Camila", "123", "Stella", "cami", "Adoptante" },
                    { "user-3", "44180117", "Ignacio", "123", "Esteves", "nacho", "Voluntario" },
                    { "user-4", "11223344", "Nicolás", "123", "Salerno", "niko", "Transito" },
                    { "user-5", "33445566", "Martín", "123", "González", "martin", "Adoptante" },
                    { "user-6", "44556677", "Laura", "123", "Fernández", "laura", "Adoptante" },
                    { "user-7", "55667788", "Diego", "123", "Rodríguez", "diego", "Adoptante" },
                    { "user-8", "66778899", "Sofía", "123", "López", "sofia", "Adoptante" }
                });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "Id", "AdoptionRequestDate", "AdoptionResponseDate", "AnimalId", "Description", "UserId" },
                values: new object[] { "adoption-1", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", "Interesada en adoptar a Firulais. Tengo experiencia con perros.", "user-2" });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "Id", "AdoptionRequestDate", "AdoptionResponseDate", "AnimalId", "Description", "State", "UserId" },
                values: new object[] { "adoption-3", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", "No cuenta con espacio adecuado para conejos.", "Rechazada", "user-6" });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "Id", "AdoptionRequestDate", "AdoptionResponseDate", "AnimalId", "Description", "UserId" },
                values: new object[,]
                {
                    { "adoption-4", new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "6", "Familia con niños pequeños, buscan un conejo tranquilo.", "user-7" },
                    { "adoption-5", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", "Vivo sola y trabajo desde casa. Puedo darle mucho tiempo y atención.", "user-8" }
                });

            migrationBuilder.InsertData(
                table: "AnimalResponsibleHistories",
                columns: new[] { "Id", "AnimalId", "AssignedDate", "ResponsibleId" },
                values: new object[,]
                {
                    { "arh-11", "1", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-5" },
                    { "arh-12", "1", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-8" },
                    { "arh-13", "3", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-7" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalState", "BirthDate", "Description", "Name", "Species", "UserId" },
                values: new object[,]
                {
                    { "2", "Adoptado", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Miau", "Gato", "user-5" },
                    { "4", "BajoCuidado", new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Lola", "Gato", "user-4" },
                    { "5", "Adoptado", new DateTime(2017, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Rex", "Perro", "user-2" },
                    { "7", "BajoCuidado", new DateTime(2016, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Pepi", "Pajaro", "user-3" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AddressNumber", "Capacity", "UserId" },
                values: new object[] { "house-1", "Zeballos", 1341, 2, "user-4" });

            migrationBuilder.InsertData(
                table: "MedicalCheckUps",
                columns: new[] { "Id", "AnimalId", "CheckUpDate", "Observation" },
                values: new object[] { "mc-4", "1", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control pre-adopción. Animal en condiciones óptimas para ser adoptado." });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "Id", "AdoptionRequestDate", "AdoptionResponseDate", "AnimalId", "Description", "State", "UserId" },
                values: new object[,]
                {
                    { "adoption-2", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", "Solicitud aprobada. El gato ya se encuentra en su nuevo hogar.", "Aprobada", "user-5" },
                    { "adoption-6", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", "Primera solicitud rechazada por falta de documentación.", "Rechazada", "user-2" }
                });

            migrationBuilder.InsertData(
                table: "AnimalResponsibleHistories",
                columns: new[] { "Id", "AnimalId", "AssignedDate", "ResponsibleId" },
                values: new object[,]
                {
                    { "arh-1", "2", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-2" },
                    { "arh-10", "7", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-3" },
                    { "arh-2", "2", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-6" },
                    { "arh-3", "2", new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-5" },
                    { "arh-4", "5", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-7" },
                    { "arh-5", "5", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-2" },
                    { "arh-6", "4", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-3" },
                    { "arh-7", "4", new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-8" },
                    { "arh-8", "4", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-4" },
                    { "arh-9", "7", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "user-6" }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckUps",
                columns: new[] { "Id", "AnimalId", "CheckUpDate", "Observation" },
                values: new object[,]
                {
                    { "mc-1", "7", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control de rutina. Vacunas al día. Estado general excelente." },
                    { "mc-2", "5", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revisión post-adopción. El animal se ha adaptado bien. Se recomienda seguimiento en 3 meses." },
                    { "mc-3", "4", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desparasitación realizada. Peso adecuado para su edad. Continuar con alimentación actual." },
                    { "mc-5", "2", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revisión dental. Se detectó sarro leve. Se realizó limpieza. Buen estado general." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_AnimalId",
                table: "Adoptions",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalResponsibleHistories_AnimalId",
                table: "AnimalResponsibleHistories",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalResponsibleHistories_ResponsibleId",
                table: "AnimalResponsibleHistories",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_UserId",
                table: "Animals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_UserId",
                table: "Houses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCheckUps_AnimalId",
                table: "MedicalCheckUps",
                column: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.DropTable(
                name: "AnimalResponsibleHistories");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "MedicalCheckUps");

            migrationBuilder.DropTable(
                name: "Sightings");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
