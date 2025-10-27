using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMigration_20251027_202509 : Migration
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
                    { "1", "ARevisar", new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perro mestizo de tamaño mediano, pelaje corto marrón con pecho blanco. Muy amistoso con las personas y tranquilo en los paseos.", "Firulais", "Perro", null },
                    { "12", "ARevisar", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gatita joven de color marrón claro con manchas blancas. Un poco tímida al principio, pero muy cariñosa cuando toma confianza.", "Misha", "Gato", null },
                    { "14", "ARevisar", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coneja completamente blanca, de pelaje suave. Tranquila, le gusta estar en brazos y es muy limpia.", "Nieve", "Conejo", null },
                    { "18", "ARevisar", new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polluelo color amarillo claro, encontrado en la vía pública. Está en observación hasta completar su desarrollo.", "Sol", "Pajaro", null },
                    { "3", "ARevisar", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conejo blanco con manchas grises, muy curioso y dócil. Le gusta saltar y explorar los rincones del lugar.", "Bunny", "Conejo", null },
                    { "6", "ARevisar", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conejo marrón oscuro de orejas largas, enérgico y juguetón. Se asusta fácilmente pero es muy curioso.", "Coco", "Conejo", null },
                    { "9", "ARevisar", new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cachorra de tamaño mediano, pelaje dorado y ojos claros. Muy activa y juguetona, ideal para una familia con espacio.", "Luna", "Perro", null }
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
                    { "s5", "Ruta 5", "2000", new DateTime(2025, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "Avistamiento de perro callejero al borde de la ruta, pueden ser más de uno, pareciese tener crías", 0 },
                    { "s6", "Av. San Juan", "987", new DateTime(2025, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Perro negro con collar rojo caminando solo.", 0 },
                    { "s7", "Parque Sur", "45", new DateTime(2025, 10, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), "Gato blanco escondido entre arbustos, parece asustado.", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dni", "Name", "Password", "SurName", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user-1", "12345678", "UTN", "123", "Rosario", "utn", "Admin" },
                    { "user-10", "88990011", "Andrés", "123", "Pérez", "andres", "Adoptante" },
                    { "user-11", "99112233", "Lucía", "123", "Benítez", "lucia", "Voluntario" },
                    { "user-12", "99223344", "Pedro", "123", "Luna", "pedro", "Voluntario" },
                    { "user-13", "99334455", "Marta", "123", "Salas", "marta", "Voluntario" },
                    { "user-14", "22334455", "Julieta", "123", "Rossi", "juli", "Transito" },
                    { "user-15", "33445577", "Federico", "123", "Torres", "fede", "Transito" },
                    { "user-16", "44557788", "Carla", "123", "Mendez", "carla", "Transito" },
                    { "user-2", "87654321", "Camila", "123", "Stella", "cami", "Adoptante" },
                    { "user-3", "44180117", "Ignacio", "123", "Esteves", "nacho", "Voluntario" },
                    { "user-4", "11223344", "Nicolás", "123", "Salerno", "niko", "Transito" },
                    { "user-5", "33445566", "Martín", "123", "González", "martin", "Adoptante" },
                    { "user-6", "44556677", "Laura", "123", "Fernández", "laura", "Adoptante" },
                    { "user-7", "55667788", "Diego", "123", "Rodríguez", "diego", "Adoptante" },
                    { "user-8", "66778899", "Sofía", "123", "López", "sofia", "Adoptante" },
                    { "user-9", "77889900", "Valentina", "123", "Moreno", "valen", "Adoptante" }
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
                    { "adoption-5", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", "Vivo sola y trabajo desde casa. Puedo darle mucho tiempo y atención.", "user-8" },
                    { "adoption-7", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "9", "Cree tener espacio adecuado.", "user-9" },
                    { "adoption-9", new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "14", "Estoy interesada en cuidar a Nieve, somos una familia muy cariñosa.", "user-6" }
                });

            migrationBuilder.InsertData(
                table: "AnimalResponsibleHistories",
                columns: new[] { "Id", "AnimalId", "AssignedDate", "ResponsibleId" },
                values: new object[,]
                {
                    { "arh-11", "1", new DateTime(2023, 8, 10, 16, 15, 0, 0, DateTimeKind.Unspecified), "user-5" },
                    { "arh-12", "1", new DateTime(2024, 1, 15, 14, 20, 0, 0, DateTimeKind.Unspecified), "user-8" },
                    { "arh-13", "3", new DateTime(2024, 5, 8, 17, 10, 0, 0, DateTimeKind.Unspecified), "user-7" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalState", "BirthDate", "Description", "Name", "Species", "UserId" },
                values: new object[,]
                {
                    { "10", "Adoptado", new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perro de pelaje oscuro, fuerte y leal. Se muestra protector y siempre atento a su entorno.", "Rocky", "Perro", "user-7" },
                    { "11", "BajoCuidado", new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gato de pelo blanco y gris, ojos celestes. Muy mimoso y busca compañía humana constantemente.", "Simón", "Gato", "user-12" },
                    { "13", "Adoptado", new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gata atigrada de pelaje dorado. Activa, curiosa y siempre lista para jugar.", "Tigra", "Gato", "user-9" },
                    { "15", "BajoCuidado", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conejo marrón claro de orejas cortas. Muy sociable con otros conejos y disfruta de la compañía humana.", "Choco", "Conejo", "user-15" },
                    { "16", "Adoptado", new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coneja de color gris claro, muy sociable y tranquila. Le encanta recibir caricias y estar al aire libre.", "Lili", "Conejo", "user-6" },
                    { "17", "BajoCuidado", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pájaro pequeño de tonos azules y verdes. Tiene un canto melodioso y disfruta del contacto visual con las personas.", "Azul", "Pajaro", "user-13" },
                    { "19", "Adoptado", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pájaro pequeño de plumaje verde brillante, recuperado tras una lesión en el ala. Ahora vuela y canta normalmente.", "Kiwi", "Pajaro", "user-11" },
                    { "2", "Adoptado", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gato adulto de color gris atigrado, ojos verdes y carácter dulce. Se adaptó muy bien a su nuevo hogar.", "Miau", "Gato", "user-5" },
                    { "4", "BajoCuidado", new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gata de pelo negro brillante, muy observadora y tranquila. Fue rescatada de la calle y actualmente está en recuperación.", "Lola", "Gato", "user-4" },
                    { "5", "Adoptado", new DateTime(2017, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perro grande de color beige con orejas caídas. Protector, paciente con niños y muy fiel a su adoptante.", "Rex", "Perro", "user-2" },
                    { "7", "BajoCuidado", new DateTime(2016, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canario macho de plumaje amarillo intenso. Alegre, canta todos los días y se muestra muy sociable.", "Pepi", "Pajaro", "user-3" },
                    { "8", "BajoCuidado", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perro mestizo color negro con patas blancas. Fue rescatado del abandono, ahora está recuperando peso y confianza.", "Toby", "Perro", "user-14" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AddressNumber", "Capacity", "UserId" },
                values: new object[,]
                {
                    { "house-1", "Zeballos", 1341, 2, "user-4" },
                    { "house-2", "San Martín", 550, 3, "user-14" },
                    { "house-3", "Mitre", 200, 1, "user-15" },
                    { "house-4", "Dorrego", 900, 2, "user-16" }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckUps",
                columns: new[] { "Id", "AnimalId", "CheckUpDate", "Observation" },
                values: new object[] { "mc-4", "1", new DateTime(2024, 9, 10, 17, 45, 0, 0, DateTimeKind.Unspecified), "Control pre-adopción. Animal en condiciones óptimas para ser adoptado." });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "Id", "AdoptionRequestDate", "AdoptionResponseDate", "AnimalId", "Description", "State", "UserId" },
                values: new object[,]
                {
                    { "adoption-10", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "17", "El hogar no cumple las condiciones  necesarias para acoger aves.", "Rechazada", "user-7" },
                    { "adoption-2", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", "Solicitud aprobada. El gato ya se encuentra en su nuevo hogar.", "Aprobada", "user-5" },
                    { "adoption-6", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", "Primera solicitud rechazada por falta de documentación.", "Rechazada", "user-2" },
                    { "adoption-8", new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "10", "Solicitud aprobada tras verificación.", "Aprobada", "user-10" }
                });

            migrationBuilder.InsertData(
                table: "AnimalResponsibleHistories",
                columns: new[] { "Id", "AnimalId", "AssignedDate", "ResponsibleId" },
                values: new object[,]
                {
                    { "arh-1", "2", new DateTime(2023, 12, 15, 14, 35, 0, 0, DateTimeKind.Unspecified), "user-2" },
                    { "arh-10", "7", new DateTime(2024, 9, 10, 15, 35, 0, 0, DateTimeKind.Unspecified), "user-3" },
                    { "arh-14", "8", new DateTime(2024, 2, 12, 13, 45, 0, 0, DateTimeKind.Unspecified), "user-14" },
                    { "arh-15", "15", new DateTime(2024, 8, 25, 16, 10, 0, 0, DateTimeKind.Unspecified), "user-15" },
                    { "arh-16", "10", new DateTime(2024, 9, 18, 18, 15, 0, 0, DateTimeKind.Unspecified), "user-16" },
                    { "arh-17", "17", new DateTime(2024, 10, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), "user-11" },
                    { "arh-18", "11", new DateTime(2025, 2, 10, 15, 45, 0, 0, DateTimeKind.Unspecified), "user-12" },
                    { "arh-19", "16", new DateTime(2025, 3, 5, 17, 45, 0, 0, DateTimeKind.Unspecified), "user-6" },
                    { "arh-2", "2", new DateTime(2024, 3, 20, 10, 45, 0, 0, DateTimeKind.Unspecified), "user-6" },
                    { "arh-3", "2", new DateTime(2024, 10, 8, 17, 45, 0, 0, DateTimeKind.Unspecified), "user-5" },
                    { "arh-4", "5", new DateTime(2024, 2, 10, 15, 45, 0, 0, DateTimeKind.Unspecified), "user-7" },
                    { "arh-5", "5", new DateTime(2024, 7, 20, 17, 46, 0, 0, DateTimeKind.Unspecified), "user-2" },
                    { "arh-6", "4", new DateTime(2024, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), "user-3" },
                    { "arh-7", "4", new DateTime(2024, 6, 12, 13, 15, 0, 0, DateTimeKind.Unspecified), "user-8" },
                    { "arh-8", "4", new DateTime(2024, 8, 15, 12, 45, 0, 0, DateTimeKind.Unspecified), "user-4" },
                    { "arh-9", "7", new DateTime(2024, 1, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), "user-6" }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckUps",
                columns: new[] { "Id", "AnimalId", "CheckUpDate", "Observation" },
                values: new object[,]
                {
                    { "mc-1", "7", new DateTime(2024, 11, 15, 17, 45, 0, 0, DateTimeKind.Unspecified), "Control de rutina. Vacunas al día. Estado general excelente." },
                    { "mc-10", "16", new DateTime(2024, 10, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), "Revisión dental, sin problemas." },
                    { "mc-2", "5", new DateTime(2024, 10, 20, 17, 45, 0, 0, DateTimeKind.Unspecified), "Revisión post-adopción. El animal se ha adaptado bien. Se recomienda seguimiento en 3 meses." },
                    { "mc-3", "4", new DateTime(2024, 12, 5, 17, 45, 0, 0, DateTimeKind.Unspecified), "Desparasitación realizada. Peso adecuado para su edad. Continuar con alimentación actual." },
                    { "mc-5", "2", new DateTime(2024, 8, 25, 17, 45, 0, 0, DateTimeKind.Unspecified), "Revisión dental. Se detectó sarro leve. Se realizó limpieza. Buen estado general." },
                    { "mc-6", "8", new DateTime(2024, 11, 30, 17, 45, 0, 0, DateTimeKind.Unspecified), "Vacunación completa, leve sobrepeso." },
                    { "mc-7", "10", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chequeo general, sin anomalías." },
                    { "mc-8", "11", new DateTime(2024, 9, 5, 17, 45, 0, 0, DateTimeKind.Unspecified), "Tratamiento de pulgas realizado." },
                    { "mc-9", "13", new DateTime(2025, 1, 3, 17, 45, 0, 0, DateTimeKind.Unspecified), "Control rutinario, en excelente estado." }
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
